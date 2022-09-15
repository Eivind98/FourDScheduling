using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FourDScheduling
{
    public class Task
    {

        public string id { get; }
        public string name { get; set; }
        public string meeting { get; set; }
        public string start { get; set; }
        public string duration { get; set; }
        public string complete { get; set; }
        public string expand { get; set; }


        public Task(List<Task> tasks, string aName, string aMeeting, string aStart, string aDuration, string aComplete, string aExpand)
        {

            


            int tempInt = 0;
            int i = 0;
            while(tasks.Count > i)
            {
                if (tasks[i].id == tempInt.ToString())
                {
                    tempInt++;
                    i = 0;
                }
                else
                {
                    i++;
                }

            }


            

            id = tempInt.ToString();
            name = aName;
            meeting = aMeeting;
            start = aStart;
            duration = aDuration;
            complete = aComplete;
            expand = aExpand;

        }

        public Task(string aId, string aName, string aMeeting, string aStart, string aDuration, string aComplete, string aExpand)
        {

            id = aId;
            name = aName;
            meeting = aMeeting;
            start = aStart;
            duration = aDuration;
            complete = aComplete;
            expand = aExpand;

        }


        public static void printTask(Task task)
        {
            Console.WriteLine(task.id);
            Console.WriteLine(task.name);
            Console.WriteLine(task.meeting);
            Console.WriteLine(task.start);
            Console.WriteLine(task.duration);
            Console.WriteLine(task.complete);
            Console.WriteLine(task.expand);
            Console.WriteLine("------------");





        }


    }
}
