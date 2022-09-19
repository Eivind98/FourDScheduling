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
            string name = "NetSideArea";
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
                .OfType<IIfcQuantityArea>().Where(p =>
                    string.Equals(p.Name, name, System.StringComparison.OrdinalIgnoreCase) ||
                    p.Name.ToString().ToLower().Contains(name.ToLower()))

                //We will take the first one. There might obviously be more than one area properties
                //so you might want to check the name. But we will keep it simple for this example.
                .FirstOrDefault()?
                .AreaValue;

            if (area != null)
                return area;

            //try to get the value from properties
            return GetProperty(product, "Area");
        }

        public static IIfcValue GetLength(IIfcProduct product)
        {
            string name = "Length";
            var length = product.IsDefinedBy
                .SelectMany(r => r.RelatingPropertyDefinition.PropertySetDefinitions)
                .OfType<IIfcElementQuantity>()
                .SelectMany(qset => qset.Quantities)
                .OfType<IIfcQuantityLength>().Where(p =>
                    string.Equals(p.Name, name, System.StringComparison.OrdinalIgnoreCase) ||
                    p.Name.ToString().ToLower().Contains(name.ToLower()))
                .FirstOrDefault()?.LengthValue;
            if (length != null)
                return length;
            return GetProperty(product, "Length");
        }

        //from another project
        public static IIfcValue GetVolume(IIfcProduct product)
        {
            string name = "NetVolume";
            var volume = product.IsDefinedBy
                .SelectMany(r => r.RelatingPropertyDefinition.PropertySetDefinitions)
                .OfType<IIfcElementQuantity>()
                .SelectMany(qset => qset.Quantities)
                .OfType<IIfcQuantityVolume>().Where(p =>
                    string.Equals(p.Name, name, System.StringComparison.OrdinalIgnoreCase) ||
                    p.Name.ToString().ToLower().Contains(name.ToLower()))
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
            //creating variable
            List<IfcObjects> allObjects = new List<IfcObjects>();

            var requiredProducts = new IIfcProduct[0]
                .Concat(model.Instances.OfType<IIfcWindow>())
                .Concat(model.Instances.OfType<IIfcWall>())
                .Concat(model.Instances.OfType<IIfcDoor>())
                .Concat(model.Instances.OfType<IIfcSlab>())
                .Concat(model.Instances.OfType<IIfcRoof>())
                .Concat(model.Instances.OfType<IIfcFooting>());
            
            decimal length;
            decimal area;
            decimal volume;

            IIfcValue lengthTest;
            IIfcValue areaTest;
            IIfcValue volumeTest;


            foreach (var obj in requiredProducts)
            {
                lengthTest = IfcAPI.GetLength(obj);
                if (lengthTest == null) length = 0; else length = decimal.Parse(lengthTest.ToString().Replace(".", ","));

                areaTest = IfcAPI.GetArea(obj);
                //area1 = IfcAPI.GetArea(wall);
                if (areaTest == null) area = 0; else area = decimal.Parse(areaTest.ToString().Replace(".", ","));

                volumeTest = IfcAPI.GetVolume(obj);
                if (volumeTest == null) volume = 0; else volume = decimal.Parse(volumeTest.ToString().Replace(".", ","));

                

                allObjects.Add(new IfcObjects()
                {
                    Id = obj.GlobalId.ToString(),
                    Name = obj.Name.ToString().Substring(0, obj.Name.ToString().LastIndexOf(":")) + " - " + " - " + GetProperty(obj, "Classification"),
                    Length = length,
                    Area = area,
                    Volume = volume
                });
            }

            
            
            

            //var typeObjects = allObjects.GroupBy(x => x.Name).Select(x => x.First()).ToList();

            //foreach (var ob1 in typeObjects)
            //{

            //    ob1.Area = 0;
            //    foreach (var ob2 in allObjects)
            //    {
            //        if (ob1.Name == ob2.Name)
            //        {

            //            ob1.Area = ob1.Area + ob2.Area;
            //        }

            //    }
            //}





            return allObjects;

        }


    }
}
