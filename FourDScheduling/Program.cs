﻿using System;
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

        
        public static void PrintNumber(Component comp)
        {
            if (!string.IsNullOrEmpty(comp.Number))
            {
                Console.WriteLine(comp.Number);
            }
            if (comp.Component1 == null) return;
            foreach (var child in comp.Component1)
            {
                PrintNumber(child);
            }
        }


        static void Main(string[] args)
        {
            var file = File.Open("D:\\Gantt Test\\SigmaData.xml", FileMode.Open);
            var sigma = (SigmaFile) new XmlSerializer(typeof(SigmaFile)).Deserialize(file);

            var test = sigma.ProjectData.ComponentData.Component;

            foreach (var comp in sigma.ProjectData.ComponentData.Component)
            {
                PrintNumber(comp);
            }


            Console.WriteLine(test);

            var file1 = File.Open("D:\\Gantt Test\\SigmaData1.xml", FileMode.OpenOrCreate);
            new XmlSerializer(typeof(SigmaFile)).Serialize(file1, sigma);

            file1.Close();






            //Creating necessary variables
            XmlDocument xmlDoc = new XmlDocument();
            List<Column> newColumns = new List<Column>();

            //Establishing the paths to files
            string xmlPath = "D:\\Gantt Test\\empty.gan";
            string ifcPath = "D:\\Gantt Test\\Revit.ifc";

            //Load the necessary files into memory
            xmlDoc.Load(xmlPath);
            //ifcDoc.Load(ifcPath);
            

            //Creating Lists for tasks.
            //ganTasks is tasks loaded from xml file. Used for making sure not to import tasks to xml file that are already there 
            //ifcTasks is tasks loaded from ifc file. Used for making sure not to import tasks to xml file that are already there
            //allTasks are tasks from both ganTasks and ifcTasks. Used for making sure no duplicate id value.
            List<Task> ganTasks = GanAPI.LoadAllTasks(xmlDoc);
            List<Task> ifcTasks = new List<Task>();
            List<Task> allTasks = new List<Task>();

            //adding ganTasks to allTasks
            allTasks.AddRange(ganTasks);

            //Creating a list for columns that exist within the xml file and loading all columns from xml file
            List<Column> loadedColumns = GanAPI.LoadAllColumns(xmlDoc);

            //printing all columns from loadedColumns
            foreach(Column column in loadedColumns)
            {
                Column.PrintColumn(column);
            }


            //Internally creating custom Columns for final document
            Column ClassificationColumn = new Column(loadedColumns, "Classification", "100", "Text", "");
            loadedColumns.Add(ClassificationColumn);
            newColumns.Add(ClassificationColumn);

            Column UnitColumn = new Column(loadedColumns, "Unit", "50", "Text", "");
            loadedColumns.Add(UnitColumn);
            newColumns.Add(UnitColumn);

            Column QuantityColumn = new Column(loadedColumns, "Quantity", "60", "Text", "");
            loadedColumns.Add(QuantityColumn);
            newColumns.Add(QuantityColumn);

            Column HoursColumn = new Column(loadedColumns, "Hours/Quantity", "100", "Text", "");
            loadedColumns.Add(HoursColumn);
            newColumns.Add(HoursColumn);

            Console.WriteLine("-------------------------------------------------------");

            foreach (Column column in newColumns)
            {
                Column.PrintColumn(column);
                GanAPI.AddColumn(xmlDoc, column);
            }




            //List<IfcObjects> objects = new List<IfcObjects>();

            //using (IfcStore model = IfcStore.Open(ifcPath))
            //{

            //    objects = IfcAPI.LoadIfcObjects(model);

            //    foreach (var b in objects)
            //    {
            //        IfcObjects.printIfcObject(b);
            //    }

            //    Task ta;

            //    foreach (var obj in objects)
            //    {
            //        ta = new Task(allTasks, obj.name, "false", "", Math.Round(obj.value).ToString(), "0", "true");
            //        ifcTasks.Add(ta);
            //        allTasks.Add(ta);
            //    }

            //    foreach (var t in ifcTasks)
            //    {

            //        GanAPI.AddTask(xmlDoc, t, ganTasks[7]);
            //        Depend de = new Depend(t.id, "2", "0", "Strong");
            //        GanAPI.AddDepend(xmlDoc, de, ganTasks[6]);
            //    }

            //    //foreach (var t in ifcTasks)
            //    //{
            //    //    GanAPI.AddTask(xmlDoc, t);
            //    //}

            //}

            //0hFm8JzRf0Av5DNSToaTC_

            //allTasks.ForEach(task => Task.printTask(task));

            //Console.WriteLine(test);
            Console.ReadLine();

            xmlDoc.Save(xmlPath);
        }
    }
}
