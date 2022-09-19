using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FourDScheduling
{
    public class SigAPI
    {

        public static void AddTask()
        {

        }


        public static List<SigTask> LoadAllTasks(string path)
        {
            var file = File.Open(path, FileMode.Open);
            var sigma = (SigmaFile)new XmlSerializer(typeof(SigmaFile)).Deserialize(file);
            List<SigTask> listOfSigTasks= new List<SigTask>();

            foreach (var comp in sigma.ProjectData.ComponentData.Component)
            {
                listOfSigTasks.AddRange(Tasks(comp));
            }

            foreach (var task in listOfSigTasks)
            {

                Console.WriteLine(task.Classification);
                Console.WriteLine(task.Name);
                Console.WriteLine(task.Unit);
                Console.WriteLine(task.Quantity);
                Console.WriteLine("---------------------------------------------------------");

            }


            return listOfSigTasks;

        }





        public static List<SigTask> Tasks(Component comp)
        {
            List<SigTask> tasks = new List<SigTask>();
            if (!string.IsNullOrEmpty(comp.Number))
            {
                tasks.Add(new SigTask
                {
                    Classification = comp.Number,
                    Name = comp.Name,
                    Unit = comp.Unit,
                    Quantity = comp.Amount
                });
            }
            

            
            if (comp.Component1 == null) return tasks;
            foreach (Component child in comp.Component1)
            {


                tasks.AddRange(Tasks(child));
            }

            return tasks;

        }

    }
}
