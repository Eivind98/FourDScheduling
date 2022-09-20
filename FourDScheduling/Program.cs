using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Xbim.Ifc;
using System.Diagnostics;
using System.IO;
using Xbim.Ifc4.Interfaces;
using System.Xml.Serialization;

namespace FourDScheduling
{
    public class Program
    {

        
        
        static void Main(string[] args)
        {
            
            string ifcPath = "D:\\Gantt Test\\Revit.ifc";
            string xmlPath = "D:\\Gantt Test\\empty.gan";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);

            List<SigTask> sigmaTasks = SigAPI.LoadAllTasks("D:\\Gantt Test\\SigmaData.xml");
            List<IfcObjects> objects = IfcAPI.LoadIfcObjects(ifcPath);

            var summary = objects.GroupBy(x => x.Name).Select(g =>
            {
                var first = g.First();
                return new IfcObjects(first.Name)
                {
                    Length = g.Sum(x => x.Length),
                    Area = g.Sum(x => x.Area),
                    Volume = g.Sum(x => x.Volume),
                    Count = g.Sum(x => x.Count)
                };
            });


            foreach (var b in summary)
            {
                IfcObjects.PrintIfcObject(b);
            }

            Console.ReadLine();

            




            //Creating necessary variables
            
            //List<Column> newColumns = new List<Column>();

            //Establishing the paths to files
            

            //Load the necessary files into memory
            
            //ifcDoc.Load(ifcPath);
            

            //Creating Lists for tasks.
            //ganTasks is tasks loaded from xml file. Used for making sure not to import tasks to xml file that are already there 
            //ifcTasks is tasks loaded from ifc file. Used for making sure not to import tasks to xml file that are already there
            //allTasks are tasks from both ganTasks and ifcTasks. Used for making sure no duplicate id value.
            List<Task> ganTasks = GanAPI.LoadAllTasks(xmlDoc);
            List<Task> ifcTasks = new List<Task>();
            List<Task> allTasks = new List<Task>();

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
            Console.ReadLine();

            xmlDoc.Save(xmlPath);
        }
    }
}
