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
using Microsoft.Isam.Esent.Interop;
using Xbim.Presentation;
using Xbim.Common;

namespace FourDScheduling
{
    public class IfcAPI
    {
        //from another project
        public static decimal GetNetArea(IIfcProduct product)
        {
            string nameOfProperty;

            switch (product)
            {
                case IIfcProduct p when (p is IIfcSlab) || (p is IIfcRoof):
                    nameOfProperty = "NetArea";
                    break;
                case IIfcProduct p when (p is IIfcWall):
                    nameOfProperty = "NetSideArea";
                    break;
                case IIfcProduct p when (p is IIfcDoor) || (p is IIfcWindow):
                    nameOfProperty = "Area";
                    break;
                default:
                    nameOfProperty = "Area";
                    break;

            }

            var value = GetProperty<IIfcQuantityArea>(product, nameOfProperty)?.AreaValue.ToString() ?? "0";
            return decimal.Parse(value, CultureInfo.InvariantCulture);

        }

        public static decimal GetGrossArea(IIfcProduct product)
        {
            string nameOfProperty;

            switch (product)
            {
                case IIfcProduct p when (p is IIfcSlab) || (p is IIfcRoof):
                    nameOfProperty = "GrossArea";
                    break;
                case IIfcProduct p when (p is IIfcWall):
                    nameOfProperty = "GrossSideArea";
                    break;
                case IIfcProduct p when (p is IIfcDoor) || (p is IIfcWindow):
                    nameOfProperty = "Area";
                    break;
                default:
                    nameOfProperty = "Area";
                    break;

            }

            var value = GetProperty<IIfcQuantityArea>(product, nameOfProperty)?.AreaValue.ToString() ?? "0";
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
        public static IIfcValue GetPropertySingleValue(IIfcProduct product, string name)
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
                
                var requiredProducts = LoadAllProducts(model.Instances);
                

                return requiredProducts.Select(x => new IfcObjects(x.Name)
                {
                    Id = x.GlobalId,
                    Length = GetLength(x),
                    NetArea = GetNetArea(x),
                    GrossArea = GetGrossArea(x),
                    Volume = GetVolume(x),
                }).ToList();

            }

        }
        
        public static IEnumerable<IIfcProduct> LoadAllProducts(EntitySelection test)
        {

            var products = new IIfcProduct[0]
                        .Concat(test.OfType<IIfcWindow>())
                        .Concat(test.OfType<IIfcWall>())
                        .Concat(test.OfType<IIfcDoor>())
                        .Concat(test.OfType<IIfcStairFlight>())
                        .Concat(test.OfType<IIfcSlab>())
                        .Concat(test.OfType<IIfcRoof>())
                        .Concat(test.OfType<IIfcFooting>());

            return products;
        }

        public static IEnumerable<IIfcProduct> LoadAllProducts(IEntityCollection test)
        {

            var products = new IIfcProduct[0]
                        .Concat(test.OfType<IIfcWindow>())
                        .Concat(test.OfType<IIfcWall>())
                        .Concat(test.OfType<IIfcDoor>())
                        .Concat(test.OfType<IIfcStairFlight>())
                        .Concat(test.OfType<IIfcSlab>())
                        .Concat(test.OfType<IIfcRoof>())
                        .Concat(test.OfType<IIfcFooting>());

            return products;

        }


    }
}
