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
using Xbim.Common.Geometry;
using Xbim.Common.XbimExtensions;
using Xbim.ModelGeometry.Scene;
using System.Runtime.Remoting.Contexts;
using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.ProductExtension;
using Xbim.Ifc4.MeasureResource;
using Xbim.Geometry.Engine.Interop;
using Xbim.Geometry;
using Xbim.Geometry.Engine;
using Microsoft.Extensions.Logging;
using System.Windows.Shapes;

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
            //double volume = 0;
            //var model = product.Model;
            //var context = new Xbim3DModelContext(model);
            //context.CreateContext();


            //using (var model = IfcStore.Open("path/to/file.ifc"))
            //{
            //    double volume = 0;
            //    var context = new Xbim3DModelContext(model);
            //    context.CreateContext();
            //    ILogger logger = new LoggerFactory().CreateLogger<Program>();
            //    IIfcProduct element = model.Instances.OfType<IIfcProduct>().FirstOrDefault();
            //    IIfcGeometricRepresentationItem geomRep = (IIfcGeometricRepresentationItem)element.Representation.Representations.FirstOrDefault();
            //    var geomEngine = new XbimGeometryEngine();
            //    using (IXbimGeometryObject geomStore = geomEngine.Create(geomRep, logger))
            //    {
            //        var solids = model.Instances.OfType<IIfcSolidModel>();
            //        foreach (var solid in solids)
            //        {
            //            var shape = context.ShapeInstancesOf(solid).FirstOrDefault();
            //            if (shape != null)
            //            {
            //                IXbimGeometryObject geomObj = geomStore.Create(shape);
            //                if (geomObj is IXbimSolid)
            //                {
            //                    IXbimSolid xbimSolid = (IXbimSolid)geomObj;
            //                    volume += xbimSolid.Volume;
            //                }
            //            }
            //        }
            //    }
            //    Console.WriteLine("Volume of element: " + volume);
            //}


            //using (var model = IfcStore.Open("path/to/file.ifc"))
            //{
            //    double volume = 0;
            //    var context = new Xbim3DModelContext(model);
            //    context.CreateContext();
            //    var solids = model.Instances.OfType<IIfcSolidModel>();
            //    foreach (var solid in solids)
            //    {
            //        var shape = context.ShapeInstancesOf((XbimShapeGeometry)solid).FirstOrDefault();
            //        if (shape != null)
            //        {
            //            IXbimGeometryObject geomObj = shape.Geometry;
            //            if (geomObj is IXbimSolid)
            //            {
            //                IXbimSolid xbimSolid = (IXbimSolid)geomObj;
            //                volume += xbimSolid.Volume;
            //            }
            //        }
            //    }
            //    Console.WriteLine("Total volume of all elements: " + volume);
            //}

            //using (var model = IfcStore.Open("path/to/file.ifc"))
            //{
            //    double volume = 0;
            //    var context = new Xbim3DModelContext(model);
            //    context.CreateContext();
            //    var elements = context.ShapeInstances;
            //    foreach (var element in elements)
            //    {
            //        var shapeGeometry = context.ShapeGeometry(element);
            //        if (shapeGeometry != null)
            //        {
            //            var geomRep = shapeGeometry.IfcShapeRepresentation;
            //            var solid = geomRep.Items.OfType<IIfcSolidModel>().FirstOrDefault();
            //            if (solid != null)
            //            {
            //                //convert the IIfcSolidModel to a solid representation that can be used to calculate volume
            //                // you can use third party library to calculate the volume of the solid
            //            }
            //        }
            //    }
            //    Console.WriteLine("Total volume of all elements: " + volume);
            //}

            //using (var model = IfcStore.Open("path/to/file.ifc"))
            //{
            //    double volume = 0;
            //    var context = new Xbim3DModelContext(model);
            //    context.CreateContext();
            //    var elements = context.ShapeInstances;
            //    var geomEngine = new XbimGeometryEngine();
            //    //create geometry
            //    foreach (var element in elements)
            //    {
            //        if (element.RepresentationType == XbimGeometryRepresentationType.OpeningsAndAdditionsIncluded)
            //        {
            //            var solid = element.ShapeGeometry.Solid;
            //            if (solid != null)
            //            {
            //                var solidSet = geomEngine.CreateSolidSet();
            //                geomEngine.Triangulate(solid, solidSet);
            //                var faces = solidSet.Faces;
            //                //iterate over faces and calculate the volume
            //            }
            //        }
            //    }
            //    Console.WriteLine("Total volume of all elements: " + volume);
            //}


            //try
            //{

            //    var model = product.Model;

            //    var context = new Xbim3DModelContext(model);
            //    context.CreateContext();

            //    var productshape = context.ShapeInstancesOf(product);
            //    var _productShape = productshape.Where(s => s.RepresentationType != XbimGeometryRepresentationType.OpeningsAndAdditionsExcluded).ToList();
            //    var geometry = new XbimShapeGeometry();

            //    decimal vol = 0;

            //    foreach (var shapeInstance in _productShape)
            //    {
            //        geometry = context.ShapeGeometry(shapeInstance);
            //        var ms = new MemoryStream(((IXbimShapeGeometryData)geometry).ShapeData);
            //        var br = new BinaryReader(ms);
            //        var mesh = br.ReadShapeTriangulation().Transform(shapeInstance.Transformation);


            //        List<int> trs = new List<int>();

            //        vol += VolumeOfMesh(mesh.Vertices, trs);

            //    }
            //    return vol;
            //}
            //catch
            //{
            //    var value = GetProperty<IIfcQuantityVolume>(product, "NetVolume")?.VolumeValue.ToString() ?? "0";
            //    return decimal.Parse(value, CultureInfo.InvariantCulture);
            //}

            var value = GetProperty<IIfcQuantityVolume>(product, "NetVolume")?.VolumeValue.ToString() ?? "0";
            return decimal.Parse(value, CultureInfo.InvariantCulture);
        }

        private static double SignedVolumeOfTriangle(XbimPoint3D p1, XbimPoint3D p2, XbimPoint3D p3)
        {
            var v321 = p3.X * p2.Y * p1.Z;
            var v231 = p2.X * p3.Y * p1.Z;
            var v312 = p3.X * p1.Y * p2.Z;
            var v132 = p1.X * p3.Y * p2.Z;
            var v213 = p2.X * p1.Y * p3.Z;
            var v123 = p1.X * p2.Y * p3.Z;
            return (1 / 6) * (-v321 + v231 + v312 - v132 - v213 + v123);
        }

        public static decimal VolumeOfMesh(IList<XbimPoint3D> vertices, List<int> trs)
        {
            decimal volume = 0;

            for (int i = 0; i < trs.Count; i += 3)
            {
                XbimPoint3D p1 = vertices[trs[i + 0]];
                XbimPoint3D p2 = vertices[trs[i + 1]];
                XbimPoint3D p3 = vertices[trs[i + 2]];

                decimal vol = (decimal)SignedVolumeOfTriangle(p1, p2, p3);
                
                volume += vol;
            }
            return Math.Abs(volume);
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


        public static List<IfcObjects> LoadIfcObjects(string ifcPath)
        {
            using (var model = IfcStore.Open(ifcPath))
            {
                return LoadProducts(model.Instances)
                    .Select(product => new IfcObjects(product)).ToList();
            }
        }

        /// <summary>
        /// This will only load specific product types and not all of them.
        /// The most basic types will be loaded:
        /// Windows, Walls, Doors, Stair flights, Slabs(includes floors), Roofs and footings.
        /// </summary>
        /// <param name="modelInstances"></param>
        /// <returns></returns>
        public static IEnumerable<IIfcProduct> LoadProducts(IEntityCollection modelInstances)
        {
            return new List<IIfcProduct>()
                        .Concat(modelInstances.OfType<IIfcWindow>())
                        .Concat(modelInstances.OfType<IIfcWall>())
                        .Concat(modelInstances.OfType<IIfcDoor>())
                        .Concat(modelInstances.OfType<IIfcStairFlight>())
                        .Concat(modelInstances.OfType<IIfcSlab>())
                        .Concat(modelInstances.OfType<IIfcRoof>())
                        .Concat(modelInstances.OfType<IIfcFooting>());
        }



        public static IEnumerable<IIfcProduct> LoadProducts(EntitySelection ifcSelection)
        {
            return new List<IIfcProduct>()
                        .Concat(ifcSelection.OfType<IIfcWindow>())
                        .Concat(ifcSelection.OfType<IIfcWall>())
                        .Concat(ifcSelection.OfType<IIfcDoor>())
                        .Concat(ifcSelection.OfType<IIfcStairFlight>())
                        .Concat(ifcSelection.OfType<IIfcSlab>())
                        .Concat(ifcSelection.OfType<IIfcRoof>())
                        .Concat(ifcSelection.OfType<IIfcFooting>());
        }




    }
}
