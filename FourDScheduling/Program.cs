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



            allTasks.AddRange(ganTasks);

            List<IfcObjects> objects = new List<IfcObjects>();

            using (IfcStore model = IfcStore.Open(ifcPath))
            {
                
                objects = IfcAPI.CreateObjects(model);

                foreach (var b in objects)
                {
                    IfcObjects.printIfcObject(b);
                }

                Task ta;

                foreach (var obj in objects)
                {
                    ta = new Task(allTasks, obj.name, "false", "", Math.Round(obj.value).ToString(), "0", "true");
                    ifcTasks.Add(ta);
                    allTasks.Add(ta);
                }

                foreach (var t in ifcTasks)
                {

                    GanAPI.AddTask(xmlDoc, t, ganTasks[7]);
                    Depend de = new Depend(t.id, "2", "0", "Strong");
                    GanAPI.AddDepend(xmlDoc, de, ganTasks[6]);
                }

                //foreach (var t in ifcTasks)
                //{
                //    GanAPI.AddTask(xmlDoc, t);
                //}

            }

            //0hFm8JzRf0Av5DNSToaTC_

            //allTasks.ForEach(task => Task.printTask(task));

            //Console.WriteLine(test);
            Console.ReadLine();

            xmlDoc.Save(xmlPath);
        }
    }
}
