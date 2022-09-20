using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbim.Ifc;
using System.Diagnostics;
using System.IO;
using Xbim.Ifc4.Interfaces;
using System.Globalization;

namespace FourDScheduling
{
    public class IfcAPI
    {
        //from another project
        public static decimal GetArea(IIfcProduct product)
        {
            var value = GetProperty<IIfcQuantityArea>(product, "NetSideArea")?.AreaValue.ToString() ?? "0";
            return decimal.Parse(value, CultureInfo.InvariantCulture);

        }

        public static decimal GetLength(IIfcProduct product)
        {
            var value = GetProperty<IIfcQuantityLength>(product, "Length")?.LengthValue.ToString() ?? "0";
            return decimal.Parse(value, CultureInfo.InvariantCulture);

        }

        //from another project
        public static decimal GetVolume(IIfcProduct product)
        {
            var value = GetProperty<IIfcQuantityVolume>(product, "NetVolume")?.VolumeValue.ToString()??"0";
            return decimal.Parse(value, CultureInfo.InvariantCulture);
            
        }

        


        //from another project but only usable one
        public static IIfcValue OldGetProperty(IIfcProduct product, string name)
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


        public static T GetProperty<T>(IIfcProduct product, string name) where T : IIfcPhysicalQuantity
        {
            return
                product.IsDefinedBy
                .SelectMany(r => r.RelatingPropertyDefinition.PropertySetDefinitions)
                .OfType<IIfcElementQuantity>()
                .SelectMany(qset => qset.Quantities)
                .OfType<T>()
                //Contains skal nok slettes
                .Where(p =>
                    string.Equals(p.Name, name, System.StringComparison.OrdinalIgnoreCase) ||
                    p.Name.ToString().ToLower().Contains(name.ToLower()))
                .FirstOrDefault();
        }


        //loading all ifc objects
        public static List<IfcObjects> LoadIfcObjects(string ifcPath)
        {
            
            using (IfcStore model = IfcStore.Open(ifcPath))
            {
                var requiredProducts = new IIfcProduct[0]
                .Concat(model.Instances.OfType<IIfcWindow>())
                .Concat(model.Instances.OfType<IIfcWall>())
                .Concat(model.Instances.OfType<IIfcDoor>())
                .Concat(model.Instances.OfType<IIfcSlab>())
                .Concat(model.Instances.OfType<IIfcRoof>())
                .Concat(model.Instances.OfType<IIfcFooting>());

                return requiredProducts.Select(x => new IfcObjects(x.Name)
                {
                    
                    Length = GetLength(x),
                    Area = GetArea(x),
                    Volume = GetVolume(x),
                }).ToList();

            }

        }


    }
}
