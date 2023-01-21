using SharpCompress.Common;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Xml;


namespace FourDScheduling
{
    public class SigAPI
    {

        public static void AddSigmaComponent(XmlDocument xmlDoc, SigTask sigTask)
        {
            XmlNodeList levelElements = xmlDoc.SelectNodes("//Level[text()='0']");
            XmlElement projectElement = (XmlElement)levelElements.Item(0).ParentNode;
            string taskName = sigTask.Name;

            XmlElement component = xmlDoc.CreateElement("Component");
            component.SetAttribute("Name", taskName);

            XmlElement number = xmlDoc.CreateElement("Number");
            number.InnerText = sigTask.Unit;
            component.AppendChild(number);

            XmlElement name = xmlDoc.CreateElement("Name");
            name.InnerText = taskName;
            component.AppendChild(name);

            XmlElement unit = xmlDoc.CreateElement("Unit");
            unit.InnerText = sigTask.Unit;
            component.AppendChild(unit);

            XmlElement amount = xmlDoc.CreateElement("Amount");
            amount.InnerText = sigTask.Quantity;
            component.AppendChild(amount);

            projectElement.AppendChild(component);

        }

        public static List<SigTask> LoadAllTasks(string path)
        {
            
            List<SigTask> listOfSigTasks = new List<SigTask>();
            

            switch (CheckFileType(path))
            {
                case "ZIP":
                    listOfSigTasks = LoadAllTasksZip(path);
                    break;

                case "XML":
                    listOfSigTasks = LoadAllTasksXml(path);
                    break;

                default: break;
            }


            return listOfSigTasks;
        }


        //Optimized by ChatGBT
        public static List<SigTask> LoadAllTasksZip(string path)
        {
            List<SigTask> listOfSigTasks = new List<SigTask>();
            XmlSerializer serializer = new XmlSerializer(typeof(SigmaFile));
            string fileName = Path.GetFileName(path);

            using (Ionic.Zip.ZipFile zip = Ionic.Zip.ZipFile.Read(path))
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    zip[fileName].Extract(stream);
                    stream.Position = 0;
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        var sigma = (SigmaFile)serializer.Deserialize(reader);
                        Array.ForEach(sigma.ProjectData.ComponentData.Component, comp => listOfSigTasks.AddRange(Tasks(comp)));
                    }
                }
            }
            
            return listOfSigTasks;
        }


        //optimized by ChatGBT
        public static List<SigTask> LoadAllTasksXml(string path)
        {
            List<SigTask> listOfSigTasks = new List<SigTask>();

            XmlSerializer serializer = new XmlSerializer(typeof(SigmaFile));
            using (var file = File.Open(path, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(file))
            {
                var sigma = (SigmaFile)serializer.Deserialize(reader);
                foreach (var comp in sigma.ProjectData.ComponentData.Component)
                {
                    listOfSigTasks.AddRange(Tasks(comp));
                }
            }

            return listOfSigTasks;
        }

        public static string CheckFileType(string path)
        {
            string fileType = "";
            

            if (SigAPI.IsZipFile(path))
            {
                fileType = "ZIP";
            }
            else if (IsXmlFile(path))
            {
                fileType = "XML";
            }
            
            return fileType;
        }


        ////My normal code
        //public static List<SigTask> LoadAllTasks(string path)
        //{

        //    var file = File.Open(path, FileMode.Open);
        //    var sigma = (SigmaFile)new XmlSerializer(typeof(SigmaFile)).Deserialize(file);
        //    List<SigTask> listOfSigTasks= new List<SigTask>();

        //    foreach (var comp in sigma.ProjectData.ComponentData.Component)
        //    {
        //        listOfSigTasks.AddRange(Tasks(comp));
        //    }

        //    return listOfSigTasks;

        //}


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

        public static bool IsZipFile(string filePath)
        {
            bool result = false;
            try
            {
                using (var stream = File.OpenRead(filePath))
                using (var reader = ReaderFactory.Open(stream))
                {
                    result = true;
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        static bool IsXmlFile(string filePath)
        {
            try
            {
                using (var reader = XmlReader.Create(filePath))
                {
                    while (reader.Read()) { }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
