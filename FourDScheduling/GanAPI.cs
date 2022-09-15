using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FourDScheduling
{
    public class GanAPI
    {
        public static void AddTask(XmlDocument xmlDoc, Task taskName)
        {
            XmlNodeList nodes = xmlDoc.GetElementsByTagName("tasks");
            XmlNode node = nodes[0];

            XmlElement ele = xmlDoc.CreateElement("task");
            node.AppendChild(ele);

            XmlAttribute aId = xmlDoc.CreateAttribute("id");
            aId.Value = taskName.id;
            ele.Attributes.Append(aId);

            XmlAttribute aName = xmlDoc.CreateAttribute("name");
            aName.Value = taskName.name;
            ele.Attributes.Append(aName);

            XmlAttribute aMeeting = xmlDoc.CreateAttribute("meeting");
            aMeeting.Value = taskName.meeting;
            ele.Attributes.Append(aMeeting);

            XmlAttribute aStart = xmlDoc.CreateAttribute("start");
            aStart.Value = taskName.start;
            ele.Attributes.Append(aStart);

            XmlAttribute aDuration = xmlDoc.CreateAttribute("duration");
            aDuration.Value = taskName.duration;
            ele.Attributes.Append(aDuration);

            XmlAttribute aComplete = xmlDoc.CreateAttribute("complete");
            aComplete.Value = taskName.complete;
            ele.Attributes.Append(aComplete);

            XmlAttribute aExpand = xmlDoc.CreateAttribute("expand");
            aExpand.Value = taskName.expand;
            ele.Attributes.Append(aExpand);


        }

        public static void AddTask(XmlDocument xmlDoc, Task taskName, Task parentTask)
        {
            XmlNodeList nodes = xmlDoc.GetElementsByTagName("task");
            XmlNode node = null;

            foreach (XmlNode n in nodes)
            {

                if (n.Attributes["id"].Value == parentTask.id)
                {
                    node = n;
                    break;
                }


            }


            XmlElement ele = xmlDoc.CreateElement("task");
            node.AppendChild(ele);

            XmlAttribute aId = xmlDoc.CreateAttribute("id");
            aId.Value = taskName.id;
            ele.Attributes.Append(aId);

            XmlAttribute aName = xmlDoc.CreateAttribute("name");
            aName.Value = taskName.name;
            ele.Attributes.Append(aName);

            XmlAttribute aMeeting = xmlDoc.CreateAttribute("meeting");
            aMeeting.Value = taskName.meeting;
            ele.Attributes.Append(aMeeting);

            XmlAttribute aStart = xmlDoc.CreateAttribute("start");
            aStart.Value = taskName.start;
            ele.Attributes.Append(aStart);

            XmlAttribute aDuration = xmlDoc.CreateAttribute("duration");
            aDuration.Value = taskName.duration;
            ele.Attributes.Append(aDuration);

            XmlAttribute aComplete = xmlDoc.CreateAttribute("complete");
            aComplete.Value = taskName.complete;
            ele.Attributes.Append(aComplete);

            XmlAttribute aExpand = xmlDoc.CreateAttribute("expand");
            aExpand.Value = taskName.expand;
            ele.Attributes.Append(aExpand);


        }






        public static List<Task> LoadAllTasks(XmlDocument xmlDoc)
        {

            XmlNodeList nodeList = xmlDoc.GetElementsByTagName("task");

            List<Task> tasks = new List<Task>();

            foreach (XmlNode n in nodeList)
            {
                tasks.Add(new Task(
                    n.Attributes["id"].Value,
                    n.Attributes["name"].Value,
                    n.Attributes["meeting"].Value,
                    n.Attributes["start"].Value,
                    n.Attributes["duration"].Value,
                    n.Attributes["complete"].Value,
                    n.Attributes["expand"].Value
                    ));


            }



            return tasks;


        }

        public static void AddColumn(XmlDocument xmlDoc, Column column)
        {
            XmlNodeList nodes = xmlDoc.GetElementsByTagName("view");
            XmlNode node = nodes[0];

            XmlElement ele = xmlDoc.CreateElement("field");
            node.AppendChild(ele);

            XmlAttribute aId = xmlDoc.CreateAttribute("id");
            aId.Value = column.id;
            ele.Attributes.Append(aId);

            XmlAttribute aName = xmlDoc.CreateAttribute("name");
            aName.Value = column.name;
            ele.Attributes.Append(aName);

            XmlAttribute aWidth = xmlDoc.CreateAttribute("width");
            aWidth.Value = column.width;
            ele.Attributes.Append(aWidth);

            XmlAttribute aOrder = xmlDoc.CreateAttribute("order");
            aOrder.Value = column.order;
            ele.Attributes.Append(aOrder);



            XmlNodeList propertyNodes = xmlDoc.GetElementsByTagName("taskproperties");
            XmlNode propertyNode = propertyNodes[0];

            XmlElement ele1 = xmlDoc.CreateElement("taskproperty");
            propertyNode.AppendChild(ele1);

            XmlAttribute aIdProperty = xmlDoc.CreateAttribute("id");
            aIdProperty.Value = column.id;
            ele1.Attributes.Append(aIdProperty);

            XmlAttribute aNameProperty = xmlDoc.CreateAttribute("name");
            aNameProperty.Value = column.name;
            ele1.Attributes.Append(aNameProperty);

            XmlAttribute aTypeProperty = xmlDoc.CreateAttribute("type");
            aTypeProperty.Value = column.type;
            ele1.Attributes.Append(aTypeProperty);

            XmlAttribute aValuetextProperty = xmlDoc.CreateAttribute("valuetype");
            aValuetextProperty.Value = column.valuetype;
            ele1.Attributes.Append(aValuetextProperty);

            XmlAttribute aDefaultvalueProperty = xmlDoc.CreateAttribute("defaultvalue");
            aDefaultvalueProperty.Value = column.defaultvalue;
            ele1.Attributes.Append(aDefaultvalueProperty);

        }

        public static void AddDepend(XmlDocument xmlDoc, Depend depend, Task task)
        {
            XmlNodeList nodes = xmlDoc.GetElementsByTagName("task");
            XmlNode node = null;

            foreach(XmlNode n in nodes)
            {
                
                if(n.Attributes["id"].Value == task.id)
                {
                    node = n;
                    break;
                }


            }

            XmlElement ele = xmlDoc.CreateElement("depend");
            node.AppendChild(ele);

            XmlAttribute aId = xmlDoc.CreateAttribute("id");
            aId.Value = depend.id;
            ele.Attributes.Append(aId);

            XmlAttribute aType = xmlDoc.CreateAttribute("type");
            aType.Value = depend.type;
            ele.Attributes.Append(aType);

            XmlAttribute aDifference = xmlDoc.CreateAttribute("difference");
            aDifference.Value = depend.difference;
            ele.Attributes.Append(aDifference);

            XmlAttribute aHardness = xmlDoc.CreateAttribute("hardness");
            aHardness.Value = depend.hardness;
            ele.Attributes.Append(aHardness);

            


        }




        public static void EditId(XmlDocument xmlDoc, int idOfTask, int id)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["id"].Value = id.ToString();

        }

        public static void EditName(XmlDocument xmlDoc, int idOfTask, string name)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["name"].Value = name;

        }

        public static void EditMeeting(XmlDocument xmlDoc, int idOfTask, bool meeting)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["meeting"].Value = meeting.ToString().ToLower();

        }

        public static void EditStartDate(XmlDocument xmlDoc, int idOfTask, DateTime startDate)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["start"].Value = startDate.ToString("yyyy-MM-dd");

        }

        public static void EditDuration(XmlDocument xmlDoc, int idOfTask, int durationInDays)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["duration"].Value = durationInDays.ToString();

        }

        public static void EditComplete(XmlDocument xmlDoc, int idOfTask, int procentComplete)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["complete"].Value = procentComplete.ToString();

        }

        public static void EditEarliestStart(XmlDocument xmlDoc, int idOfTask, DateTime earliestStart)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["thirdDate"].Value = earliestStart.ToString("yyyy-MM-dd");

        }

        public static void EditEarliestStartActive(XmlDocument xmlDoc, int idOfTask, bool active)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["thirdDate-constraint"].Value = Convert.ToInt32(active).ToString();

        }

        public static void EditExpand(XmlDocument xmlDoc, int idOfTask, bool expand)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["expand"].Value = expand.ToString().ToLower();

        }

    }
}
