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

namespace FourDScheduling
{
    public class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlDocument ifcDoc = new XmlDocument();
            string xmlPath = "D:\\Gantt Test\\empty.gan";
            string ifcPath = "D:\\Gantt Test\\Revit.ifc";

            xmlDoc.Load(xmlPath);
            //ifcDoc.Load(ifcPath);
            

            List<Task> ganTasks = GanAPI.LoadAllTasks(xmlDoc);

            

            List<Task> ifcTasks = new List<Task>();

            List<Task> allTasks = new List<Task>();


            //XmlNodeList nodeList = ifcDoc.GetElementsByTagName("IfcWall");
            //XmlNodeList nodeList1;
            //XmlNode node1;

            //Console.WriteLine(nodeList.Count);

            //foreach (XmlNode node in nodeList)
            //{
            //    if(!(node.Attributes["id"].Value == null))
            //    {
            //        nodeList1 = node.SelectNodes("GlobalId");
            //        node1 = nodeList1[0];


            //        Console.WriteLine(node1.ChildNodes.ToString());


            //    }
            //}




            //double area = 0;

            //IIfcValue area1;

            //allTasks.AddRange(ganTasks);

            //List<IfcObjects> objects = new List<IfcObjects>();

            //using (IfcStore model = IfcStore.Open(ifcPath))
            //{
            //    var walls = model.Instances.OfType<IIfcWall>().ToList();

            //    foreach (var wall in walls)
            //    {
            //        area1 = IfcAPI.GetProperty(wall, "Area");
            //        //area1 = IfcAPI.GetArea(wall);
            //        if (area1 == null)
            //        {
            //            area = 0;
            //        }
            //        else
            //        {
            //            area = double.Parse(area1.ToString().Replace(".",","));
            //        }

            //        objects.Add(new IfcObjects()
            //        {
            //            id = wall.GlobalId.ToString(),
            //            name = wall.Name.ToString().Substring(0, wall.Name.ToString().LastIndexOf(":")),
            //            unit = "m2",
            //            value = area,
            //        });

            //        //Console.WriteLine(wall.GlobalId);
            //        //Console.WriteLine(wall.Name.ToString().Substring(0, wall.Name.ToString().LastIndexOf(":")));
            //        //Console.WriteLine(IfcAPI.GetProperty(wall, "Area"));
            //        //Console.WriteLine(IfcAPI.GetProperty(wall, "Volume"));
            //        //Console.WriteLine(IfcAPI.GetProperty(wall, "Length"));
            //        //Console.WriteLine(IfcAPI.GetProperty(wall, "Gross Area"));
            //        //Console.WriteLine("------------------------------------------");
            //        //Console.WriteLine(wall);
            //        //Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            //    }

            //    var ab = objects.GroupBy(x => x.name).Select(x => x.First()).ToList();

            //    //foreach (var ob in objects)
            //    //{
            //    //    IfcObjects.printIfcObject(ob);
            //    //}




            //    foreach (var ob1 in ab)
            //    {

            //        ob1.value = 0;
            //        foreach(var ob2 in objects)
            //        {
            //            if(ob1.name == ob2.name)
            //            {

            //                ob1.value = ob1.value + ob2.value;
            //            }

            //        }
            //    }

            //    foreach (var b in ab)
            //    {
            //        IfcObjects.printIfcObject(b);
            //    }

            //    Task ta;

            //    foreach (var obj in ab)
            //    {
            //        ta = new Task(allTasks, obj.name, "false", "2022-09-30", Math.Round(obj.value).ToString(), "0", "true");
            //        ifcTasks.Add(ta);
            //        allTasks.Add(ta);
            //    }

            //    foreach (var t in ifcTasks)
            //    {
            //        GanAPI.AddTask(xmlDoc, t, ganTasks[0]);
            //    }





            //}

            //foreach (var t in ifcTasks)
            //{
            //    GanAPI.AddTask(xmlDoc, t);
            //}


            //0hFm8JzRf0Av5DNSToaTC_




            //allTasks.ForEach(task => Task.printTask(task));




            //Console.WriteLine(test);
            Console.ReadLine();

            xmlDoc.Save(xmlPath);
        }
    }
}
