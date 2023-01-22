using System.Collections.Generic;

namespace FourDScheduling.Models
{
    public class SigTask
    {

        public string Classification { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Quantity { get; set; }
        public SigTask Parent { get; set; }
        

        public SigTask() { }

        public SigTask(List<IfcObjects> objects)
        {
            foreach (IfcObjects obj in objects)
            {
                new SigTask(obj);

            }
        }

        public SigTask(IfcObjects obj)
        {
            Classification = obj.TypeId;
            Name = obj.Name;

            switch (obj.variable)
            {
                case "Length":
                    Quantity = obj.Length.ToString();
                    Unit = Units.Length;
                    break;

                case "Thickness":
                    Quantity = obj.Thickness.ToString();
                    Unit = Units.Thickness;
                    break;

                case "AreaOfOpenings":
                    Quantity = obj.AreaOfOpenings.ToString();
                    Unit = Units.AreaOfOpenings;
                    break;

                case "NetArea":
                    Quantity = obj.NetArea.ToString();
                    Unit = Units.NetArea;
                    break;

                case "GrossArea":
                    Quantity = obj.GrossArea.ToString();
                    Unit = Units.GrossArea;
                    break;

                case "Volume":
                    Quantity = obj.Volume.ToString();
                    Unit = Units.Volume;
                    break;

                case "Count":
                    Quantity = obj.Count.ToString();
                    Unit = Units.Count;
                    break;


                default: break;


            }
            
        }


    }
}
