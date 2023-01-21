using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Xbim.Ifc;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using Xbim.Ifc4.Interfaces;
using System.Xml.Serialization;
using Xbim.ModelGeometry.Scene;
using Xbim.Common.Geometry;
using Xbim.Common.XbimExtensions;
using System.Windows.Forms;
using SharpCompress.Archives.Zip;
using ICSharpCode.SharpZipLib.Zip;

namespace FourDScheduling
{
    public class Program
    {


        [STAThread]
        static void Main(string[] args)
        {
            //var path = @"C:\\Users\\eev_9\\OneDrive\\01 - Skúli\\05 - BLBI_Feb 2021 -\\Sem. 4\\07 - Prototype\\Gantt Test\\Playing around1.sig";
            //List<SigTask> sigTasks = new List<SigTask>();
            

            //sigTasks = SigAPI.LoadAllTasks(path);

            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(path);





            //foreach (var t in sigTasks)
            //{
            //    SigAPI.AddSigmaComponent(xmlDoc, t);

            //    Console.WriteLine(xmlDoc.LocalName);
            //    Console.WriteLine(t.Name);
            //    Console.WriteLine(t.Quantity);
            //    Console.WriteLine(t.Unit);
            //    Console.WriteLine(t.Classification);
            //    Console.WriteLine("-----------------");

            //}
            //Console.ReadLine();

            //xmlDoc.Save(path);







            
            //The Program
            Application.EnableVisualStyles();
            Application.Run(new MainMenu());
            





            /*

            string ifcPath = "D:\\Gantt Test\\HavL3_K01_N001_ARK.ifc";
            //string ifcPath = "D:\\Gantt Test\\HavL3_K01_N001_ARK.ifc";
            string xmlPath = "D:\\Gantt Test\\empty.gan";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);

            List<SigTask> sigmaTasks = SigAPI.LoadAllTasks("D:\\Gantt Test\\SigmaData.xml");
            List<IfcObjects> allInstances = IfcAPI.LoadIfcObjects(ifcPath);

            var groupedByName = allInstances
                .GroupBy(x => x.Name)
                .Select(g => new IfcObjects(g.ToList()));

            List<IfcObjects> withClassification = new List<IfcObjects>();
            List<IfcObjects> withoutClassification = new List<IfcObjects>();

            foreach (IfcObjects obj in groupedByName)
            {
                if (obj.TypeId == "")
                {
                    withoutClassification.Add(obj);
                }
                else
                {
                    withClassification.Add(obj);
                }
            }


            foreach (var b in withoutClassification)
            {
                IfcObjects.PrintIfcObject(b);
            }

            foreach (var b in withClassification)
            {
                IfcObjects.PrintIfcObject(b);
            }

            Console.WriteLine(groupedByName.Count());

            Console.ReadLine();

            */


            /*

            using (var model = IfcStore.Open("D:\\Gantt Test\\Revit.ifc"))
            {

                var context = new Xbim3DModelContext(model);
                context.CreateContext();
                var item = model.Instances.FirstOrDefault<IIfcWall>();

                Console.WriteLine("Name:{0}", item.Name);
                Console.WriteLine("-----------");

                var some = item.HasOpenings;

                var productshape = context.ShapeInstancesOf((Xbim.Ifc4.Interfaces.IIfcProduct)item);
                var _productShape = productshape.Where(s => s.RepresentationType != XbimGeometryRepresentationType.OpeningsAndAdditionsExcluded).ToList();
                var geometry = new XbimShapeGeometry();

                XbimShapeTriangulation mesh;

                var vol = 0.0;
                var area = 0.0;

                foreach (var shapeInstance in _productShape)
                {
                    geometry = context.ShapeGeometry(shapeInstance);
                    var ms = new MemoryStream(((IXbimShapeGeometryData)geometry).ShapeData);
                    var br = new BinaryReader(ms);
                    mesh = br.ReadShapeTriangulation();
                    mesh = mesh.Transform(((XbimShapeInstance)shapeInstance).Transformation);

                    List<int> trs = new List<int>();
                    foreach (var f in mesh.Faces)
                    {
                        trs = trs.Concat(f.Indices).ToList();
                        area += GetAreaOfMesh(mesh, f);
                    }
                    vol += VolumeOfMesh(mesh.Vertices, trs);
                }
                Console.WriteLine("-----------");
                Console.WriteLine("Area Total:{0}", area);
                Console.WriteLine("Volume Total:{0}", vol);

            }
            Console.ReadKey();
        }

        private static double GetAreaOfMesh(XbimShapeTriangulation mesh, XbimFaceTriangulation f)
        {
            var area = 0.0;
            for (int i = 0; i < f.Indices.Count(); i += 3)
            {
                var p1 = mesh.Vertices[f.Indices[i]];
                var p2 = mesh.Vertices[f.Indices[i + 1]];
                var p3 = mesh.Vertices[f.Indices[i + 2]];
                var t = new XbimPoint3D[] { p1, p2, p3 };

                double[] point1 = new double[3] { p1.X, p1.Y, p1.Z };
                double[] point2 = new double[3] { p2.X, p2.Y, p2.Z };
                double[] point3 = new double[3] { p3.X, p3.Y, p3.Z };
                var distp1p2 = Math.Sqrt(point1.Zip(point2, (a, b) => (a - b) * (a - b)).Sum());
                var distp2p3 = Math.Sqrt(point2.Zip(point3, (a, b) => (a - b) * (a - b)).Sum());
                var distp3p1 = Math.Sqrt(point3.Zip(point1, (a, b) => (a - b) * (a - b)).Sum());
                double s = (distp1p2 + distp2p3 + distp3p1) / 2;
                area += Math.Sqrt(s * (s - distp1p2) * (s - distp2p3) * (s - distp3p1));
            }
            Console.WriteLine("Area Face:{0}", area);
            return area;
        }

        private static double SignedVolumeOfTriangle(XbimPoint3D p1, XbimPoint3D p2, XbimPoint3D p3)
        {
            var v321 = p3.X * p2.Y * p1.Z;
            var v231 = p2.X * p3.Y * p1.Z;
            var v312 = p3.X * p1.Y * p2.Z;
            var v132 = p1.X * p3.Y * p2.Z;
            var v213 = p2.X * p1.Y * p3.Z;
            var v123 = p1.X * p2.Y * p3.Z;
            return (1.0 / 6.0) * (-v321 + v231 + v312 - v132 - v213 + v123);
        }

        public static double VolumeOfMesh(IList<XbimPoint3D> vertices, List<int> trs)
        {
            double volume = 0.0;

            for (int i = 0; i < trs.Count; i += 3)
            {
                XbimPoint3D p1 = vertices[trs[i + 0]];
                XbimPoint3D p2 = vertices[trs[i + 1]];
                XbimPoint3D p3 = vertices[trs[i + 2]];

                var vol = SignedVolumeOfTriangle(p1, p2, p3);
                Console.WriteLine("Volume Trg:{0}", vol);

                volume += vol;
            }
            return Math.Abs(volume);
        }

        */



            //Creating necessary variables

            //List<Column> newColumns = new List<Column>();

            //Establishing the paths to files


            //Load the necessary files into memory

            //ifcDoc.Load(ifcPath);


            //Creating Lists for tasks.
            //ganTasks is tasks loaded from xml file. Used for making sure not to import tasks to xml file that are already there 
            //ifcTasks is tasks loaded from ifc file. Used for making sure not to import tasks to xml file that are already there
            //allTasks are tasks from both ganTasks and ifcTasks. Used for making sure no duplicate id value.
            //List<Task> ganTasks = GanAPI.LoadAllTasks(xmlDoc);
            //List<Task> ifcTasks = new List<Task>();
            //List<Task> allTasks = new List<Task>();

            ////adding ganTasks to allTasks
            //allTasks.AddRange(ganTasks);

            ////Creating a list for columns that exist within the xml file and loading all columns from xml file
            //List<Column> loadedColumns = GanAPI.LoadAllColumns(xmlDoc);

            ////printing all columns from loadedColumns
            //foreach(Column column in loadedColumns)
            //{
            //    Column.PrintColumn(column);
            //}


            ////Internally creating custom Columns for final document
            //Column ClassificationColumn = new Column(loadedColumns, "Classification", "100", "Text", "");
            //loadedColumns.Add(ClassificationColumn);
            //newColumns.Add(ClassificationColumn);

            //Column UnitColumn = new Column(loadedColumns, "Unit", "50", "Text", "");
            //loadedColumns.Add(UnitColumn);
            //newColumns.Add(UnitColumn);

            //Column QuantityColumn = new Column(loadedColumns, "Quantity", "60", "Text", "");
            //loadedColumns.Add(QuantityColumn);
            //newColumns.Add(QuantityColumn);

            //Column HoursColumn = new Column(loadedColumns, "Hours/Quantity", "100", "Text", "");
            //loadedColumns.Add(HoursColumn);
            //newColumns.Add(HoursColumn);

            //Console.WriteLine("-------------------------------------------------------");

            //foreach (Column column in newColumns)
            //{
            //    Column.PrintColumn(column);
            //    GanAPI.AddColumn(xmlDoc, column);
            //}









            //0hFm8JzRf0Av5DNSToaTC_

            //allTasks.ForEach(task => Task.printTask(task));

            //Console.WriteLine(test);
            //Console.ReadLine();

            //xmlDoc.Save(xmlPath);
        }
    }
}
