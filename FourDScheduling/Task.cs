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

        public string Id { get; }
        public string Name { get; set; }
        public string Meeting { get; set; }
        public string Start { get; set; }
        public string Duration { get; set; }
        public string Complete { get; set; }
        public string Expand { get; set; }


        public Task(List<Task> tasks, string aName, string aMeeting, string aStart, string aDuration, string aComplete, string aExpand)
        {

            //making sure there are no duplicate id value
            int tempInt = 0;
            int i = 0;
            while(tasks.Count > i)
            {
                if (tasks[i].Id == tempInt.ToString())
                {
                    tempInt++;
                    i = 0;
                }
                else
                {
                    i++;
                }

            }


            

            Id = tempInt.ToString();
            Name = aName;
            Meeting = aMeeting;
            Start = aStart;
            Duration = aDuration;
            Complete = aComplete;
            Expand = aExpand;

        }

        public Task(string aId, string aName, string aMeeting, string aStart, string aDuration, string aComplete, string aExpand)
        {

            Id = aId;
            Name = aName;
            Meeting = aMeeting;
            Start = aStart;
            Duration = aDuration;
            Complete = aComplete;
            Expand = aExpand;

        }


        public static void PrintTask(Task task)
        {
            Console.WriteLine(task.Id);
            Console.WriteLine(task.Name);
            Console.WriteLine(task.Meeting);
            Console.WriteLine(task.Start);
            Console.WriteLine(task.Duration);
            Console.WriteLine(task.Complete);
            Console.WriteLine(task.Expand);
            Console.WriteLine("------------");





        }


    }
}
