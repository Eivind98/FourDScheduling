using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbim.Ifc4.MeasureResource;

namespace FourDScheduling
{
    public class IfcObjects
    {
        public IfcObjects(string name)
        {
            var firstColonIndex = name.IndexOf(':') + 1;
            var LastColonIndex = name.LastIndexOf(':');
            Name = name.Count(x => x==':') < 2 ? name : name.Substring(firstColonIndex, LastColonIndex - firstColonIndex);
            //Name = name;
            var indexSpace = name.IndexOf(' ');
            TypeId = indexSpace > 0 ? name.Substring(0, indexSpace) : "";
        }

        public string Id { get; set; }
        public string TypeId { get; private set; }
        public string Name { get; private set; }
        public string Unit { get; set; }
        public decimal Length { get; set; }
        public decimal Area { get; set; }
        public decimal Volume { get; set; }
        public string TimeUnit { get; set; }
        public int TimeValue { get; set; }
        public int Count { get; set; } = 1;

        public static void PrintIfcObject(IfcObjects obj)
        {
            Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));
            Console.WriteLine("--------------------------------------------------");


        }

    }






}
