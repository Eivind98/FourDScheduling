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
        //adding task to xmldocument
        public static void AddTask(XmlDocument xmlDoc, List<Column> existingColumns, Task taskName)
        {
            XmlNodeList nodes = xmlDoc.GetElementsByTagName("tasks");
            XmlNode node = nodes[0];

            XmlElement ele = xmlDoc.CreateElement("task");
            node.AppendChild(ele);

            XmlAttribute aId = xmlDoc.CreateAttribute("id");
            aId.Value = taskName.Id;
            ele.Attributes.Append(aId);

            XmlAttribute aName = xmlDoc.CreateAttribute("name");
            aName.Value = taskName.Name;
            ele.Attributes.Append(aName);

            XmlAttribute aMeeting = xmlDoc.CreateAttribute("meeting");
            aMeeting.Value = taskName.Meeting;
            ele.Attributes.Append(aMeeting);

            XmlAttribute aStart = xmlDoc.CreateAttribute("start");
            aStart.Value = taskName.Start;
            ele.Attributes.Append(aStart);

            XmlAttribute aDuration = xmlDoc.CreateAttribute("duration");
            aDuration.Value = taskName.Duration;
            ele.Attributes.Append(aDuration);

            XmlAttribute aComplete = xmlDoc.CreateAttribute("complete");
            aComplete.Value = taskName.Complete;
            ele.Attributes.Append(aComplete);

            XmlAttribute aExpand = xmlDoc.CreateAttribute("expand");
            aExpand.Value = taskName.Expand;
            ele.Attributes.Append(aExpand);

            if (taskName.Classification != "")
            {
                string id = "";
                foreach(Column c in existingColumns)
                {
                    if (c.Name == "Classification")
                    {
                        id = c.Id;
                    }
                }

                XmlElement customproperty = xmlDoc.CreateElement("customproperty");
                ele.AppendChild(customproperty);

                XmlAttribute taskpropertyId = xmlDoc.CreateAttribute("taskproperty-id");
                taskpropertyId.Value = id;
                customproperty.Attributes.Append(taskpropertyId);

                XmlAttribute value = xmlDoc.CreateAttribute("value");
                value.Value = taskName.Classification;
                customproperty.Attributes.Append(value);

            }



        }

        //add task to xml document to a parent task
        public static void AddTask(XmlDocument xmlDoc, List<Column> existingColumns, Task taskName, Task parentTask)
        {
            XmlNodeList nodes = xmlDoc.GetElementsByTagName("task");
            XmlNode node = null;

            foreach (XmlNode n in nodes)
            {

                if (n.Attributes["id"].Value == parentTask.Id)
                {
                    node = n;
                    break;
                }


            }


            XmlElement ele = xmlDoc.CreateElement("task");
            node.AppendChild(ele);

            XmlAttribute aId = xmlDoc.CreateAttribute("id");
            aId.Value = taskName.Id;
            ele.Attributes.Append(aId);

            XmlAttribute aName = xmlDoc.CreateAttribute("name");
            aName.Value = taskName.Name;
            ele.Attributes.Append(aName);

            XmlAttribute aMeeting = xmlDoc.CreateAttribute("meeting");
            aMeeting.Value = taskName.Meeting;
            ele.Attributes.Append(aMeeting);

            XmlAttribute aStart = xmlDoc.CreateAttribute("start");
            aStart.Value = taskName.Start;
            ele.Attributes.Append(aStart);

            XmlAttribute aDuration = xmlDoc.CreateAttribute("duration");
            aDuration.Value = taskName.Duration;
            ele.Attributes.Append(aDuration);

            XmlAttribute aComplete = xmlDoc.CreateAttribute("complete");
            aComplete.Value = taskName.Complete;
            ele.Attributes.Append(aComplete);

            XmlAttribute aExpand = xmlDoc.CreateAttribute("expand");
            aExpand.Value = taskName.Expand;
            ele.Attributes.Append(aExpand);


            if (taskName.Classification != "")
            {
                string id = "";
                foreach (Column c in existingColumns)
                {
                    if (c.Name == "Classification")
                    {
                        id = c.Id;
                    }
                }

                XmlElement customproperty = xmlDoc.CreateElement("customproperty");
                ele.AppendChild(customproperty);

                XmlAttribute taskpropertyId = xmlDoc.CreateAttribute("taskproperty-id");
                taskpropertyId.Value = id;
                customproperty.Attributes.Append(taskpropertyId);

                XmlAttribute value = xmlDoc.CreateAttribute("value");
                value.Value = taskName.Classification;
                customproperty.Attributes.Append(value);

            }

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
            aId.Value = column.Id;
            ele.Attributes.Append(aId);

            XmlAttribute aName = xmlDoc.CreateAttribute("name");
            aName.Value = column.Name;
            ele.Attributes.Append(aName);

            XmlAttribute aWidth = xmlDoc.CreateAttribute("width");
            aWidth.Value = column.Width;
            ele.Attributes.Append(aWidth);

            XmlAttribute aOrder = xmlDoc.CreateAttribute("order");
            aOrder.Value = column.Order;
            ele.Attributes.Append(aOrder);



            XmlNodeList propertyNodes = xmlDoc.GetElementsByTagName("taskproperties");
            XmlNode propertyNode = propertyNodes[0];

            XmlElement ele1 = xmlDoc.CreateElement("taskproperty");
            propertyNode.AppendChild(ele1);

            XmlAttribute aIdProperty = xmlDoc.CreateAttribute("id");
            aIdProperty.Value = column.Id;
            ele1.Attributes.Append(aIdProperty);

            XmlAttribute aNameProperty = xmlDoc.CreateAttribute("name");
            aNameProperty.Value = column.Name;
            ele1.Attributes.Append(aNameProperty);

            XmlAttribute aTypeProperty = xmlDoc.CreateAttribute("type");
            aTypeProperty.Value = column.Type;
            ele1.Attributes.Append(aTypeProperty);

            XmlAttribute aValuetextProperty = xmlDoc.CreateAttribute("valuetype");
            aValuetextProperty.Value = column.Valuetype;
            ele1.Attributes.Append(aValuetextProperty);

            XmlAttribute aDefaultvalueProperty = xmlDoc.CreateAttribute("defaultvalue");
            aDefaultvalueProperty.Value = column.Defaultvalue;
            ele1.Attributes.Append(aDefaultvalueProperty);

        }

        public static List<Column> LoadAllColumns(XmlDocument xmlDoc)
        {
            
            XmlNodeList nodeListField = xmlDoc.GetElementsByTagName("view")[0].ChildNodes;
            
            XmlNodeList nodeListTaskproperty = xmlDoc.GetElementsByTagName("taskproperty");
            List<Column> columns = new List<Column>();

            foreach (XmlNode node in nodeListField)
            {
                XmlNode taskpropertyNode = null;
                foreach (XmlNode node2 in nodeListTaskproperty)
                {
                    if(node.Attributes["id"].Value == node2.Attributes["id"].Value)
                    {
                        taskpropertyNode = node2;
                        break;
                    }

                }

                
                if(node.Name == "field")
                {
                    if (taskpropertyNode != null)
                    {
                        columns.Add(new Column(
                        node.Attributes["id"].Value,
                        node.Attributes["name"].Value,
                        node.Attributes["width"].Value,
                        node.Attributes["order"].Value,
                        taskpropertyNode.Attributes["valuetype"].Value,
                        ""
                        ));
                    }
                    else
                    {
                        columns.Add(new Column(
                        node.Attributes["id"].Value,
                        node.Attributes["name"].Value,
                        node.Attributes["width"].Value,
                        node.Attributes["order"].Value,
                        "",
                        ""
                        ));
                    }
                }

            }

            return columns;
        }



        public static void AddDepend(XmlDocument xmlDoc, Depend depend, Task parentTask)
        {
            XmlNodeList nodes = xmlDoc.GetElementsByTagName("task");
            XmlNode node = null;

            foreach(XmlNode n in nodes)
            {
                
                if(n.Attributes["id"].Value == parentTask.Id)
                {
                    node = n;
                    break;
                }


            }

            XmlElement ele = xmlDoc.CreateElement("depend");
            node.AppendChild(ele);

            XmlAttribute aId = xmlDoc.CreateAttribute("id");
            aId.Value = depend.Id;
            ele.Attributes.Append(aId);

            XmlAttribute aType = xmlDoc.CreateAttribute("type");
            aType.Value = depend.Type;
            ele.Attributes.Append(aType);

            XmlAttribute aDifference = xmlDoc.CreateAttribute("difference");
            aDifference.Value = depend.Difference;
            ele.Attributes.Append(aDifference);

            XmlAttribute aHardness = xmlDoc.CreateAttribute("hardness");
            aHardness.Value = depend.Hardness;
            ele.Attributes.Append(aHardness);

        }




        //from here and down probably not necessary
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
