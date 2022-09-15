using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FourDScheduling
{
    public class AttributeHandler
    {
        public static void id(XmlDocument xmlDoc, int idOfTask, int id)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["id"].Value = id.ToString();

        }

        public static void Name(XmlDocument xmlDoc, int idOfTask, string name)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["name"].Value = name;

        }

        public static void Meeting(XmlDocument xmlDoc, int idOfTask, bool meeting)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["meeting"].Value = meeting.ToString().ToLower();

        }

        public static void StartDate(XmlDocument xmlDoc, int idOfTask, DateTime startDate)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["start"].Value = startDate.ToString("yyyy-MM-dd");

        }

        public static void Duration(XmlDocument xmlDoc, int idOfTask, int durationInDays)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["duration"].Value = durationInDays.ToString();

        }

        public static void Complete (XmlDocument xmlDoc, int idOfTask, int procentComplete)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["complete"].Value = procentComplete.ToString();

        }

        public static void EarliestStart (XmlDocument xmlDoc, int idOfTask, DateTime earliestStart)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["thirdDate"].Value = earliestStart.ToString("yyyy-MM-dd");

        }

        public static void EarliestStartActive(XmlDocument xmlDoc, int idOfTask, bool active)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["thirdDate-constraint"].Value = Convert.ToInt32(active).ToString();

        }

        public static void Expand(XmlDocument xmlDoc, int idOfTask, bool expand)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

            node.Attributes["expand"].Value = expand.ToString().ToLower();

        }


        //public void Duration(XmlDocument xmlDoc, int idOfTask, int durationInDays)
        //{
        //    XmlNode node = xmlDoc.SelectSingleNode($"project/tasks/task[@id='{idOfTask}']");

        //    node.Attributes["Duration"].Value = durationInDays.ToString();

        //}



    }
}
