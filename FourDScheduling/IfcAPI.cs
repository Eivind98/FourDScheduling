using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbim.Ifc;
using System.Diagnostics;
using System.IO;
using Xbim.Ifc4.Interfaces;

namespace FourDScheduling
{
    public class IfcAPI
    {
        //from another project
        public static IIfcValue GetArea(IIfcProduct product)
        {
            //try to get the value from quantities first
            var area =
                //get all relations which can define property and quantity sets
                product.IsDefinedBy

                //Search across all property and quantity sets. 
                //You might also want to search in a specific quantity set by name
                .SelectMany(r => r.RelatingPropertyDefinition.PropertySetDefinitions)

                //Only consider quantity sets in this case.
                .OfType<IIfcElementQuantity>()

                //Get all quantities from all quantity sets
                .SelectMany(qset => qset.Quantities)

                //We are only interested in areas 
                .OfType<IIfcQuantityArea>()

                //We will take the first one. There might obviously be more than one area properties
                //so you might want to check the name. But we will keep it simple for this example.
                .FirstOrDefault()?
                .AreaValue;

            if (area != null)
                return area;

            //try to get the value from properties
            return GetProperty(product, "Area");
        }

        //from another project
        public static IIfcValue GetVolume(IIfcProduct product)
        {
            var volume = product.IsDefinedBy
                .SelectMany(r => r.RelatingPropertyDefinition.PropertySetDefinitions)
                .OfType<IIfcElementQuantity>()
                .SelectMany(qset => qset.Quantities)
                .OfType<IIfcQuantityVolume>()
                .FirstOrDefault()?.VolumeValue;
            if (volume != null)
                return volume;
            return GetProperty(product, "Volume");
        }

        //from another project but only usable one
        public static IIfcValue GetProperty(IIfcProduct product, string name)
        {
            return
                //get all relations which can define property and quantity sets
                product.IsDefinedBy

                //Search across all property and quantity sets. You might also want to search in a specific property set
                .SelectMany(r => r.RelatingPropertyDefinition.PropertySetDefinitions)

                //Only consider property sets in this case.
                .OfType<IIfcPropertySet>()

                //Get all properties from all property sets
                .SelectMany(pset => pset.HasProperties)

                //lets only consider single value properties. There are also enumerated properties, 
                //table properties, reference properties, complex properties and other
                .OfType<IIfcPropertySingleValue>()

                //lets make the name comparison more fuzzy. This might not be the best practise
                .Where(p =>
                    string.Equals(p.Name, name, System.StringComparison.OrdinalIgnoreCase) ||
                    p.Name.ToString().ToLower().Contains(name.ToLower()))

                //only take the first. In reality you should handle this more carefully.
                .FirstOrDefault()?.NominalValue;
        }

        //loading all ifc objects
        public static List<IfcObjects> LoadIfcObjects(IfcStore model)
        {
            //creating variables
            double area = 0;
            IIfcValue areaTest;
            List<IfcObjects> allObjects = new List<IfcObjects>();

            //
            var wallObjects = model.Instances.OfType<IIfcWall>().ToList();

            foreach (var obj in wallObjects)
            {
                areaTest = IfcAPI.GetProperty(obj, "Area");
                //area1 = IfcAPI.GetArea(wall);
                if (areaTest == null)
                {
                    area = 0;
                }
                else
                {
                    area = double.Parse(areaTest.ToString().Replace(".", ","));
                }

                allObjects.Add(new IfcObjects()
                {
                    Id = obj.GlobalId.ToString(),
                    Name = obj.Name.ToString().Substring(0, obj.Name.ToString().LastIndexOf(":")),
                    Unit = "m2",
                    Value = area,
                });
            }

            var typeObjects = allObjects.GroupBy(x => x.Name).Select(x => x.First()).ToList();

            foreach (var ob1 in typeObjects)
            {

                ob1.Value = 0;
                foreach (var ob2 in allObjects)
                {
                    if (ob1.Name == ob2.Name)
                    {

                        ob1.Value = ob1.Value + ob2.Value;
                    }

                }
            }





            return typeObjects;

        }


    }
}
