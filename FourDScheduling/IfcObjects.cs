using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xbim.Ifc4.MeasureResource;

namespace FourDScheduling
{
    public class IfcObjects
    {
        private static Regex regex = new Regex(@":(\d{6}(\.\d+)?)\s");

        public IfcObjects(string name)
        {

            var firstColonIndex = name.IndexOf(':') + 1;
            var LastColonIndex = name.LastIndexOf(':');
            var n = name.Substring(firstColonIndex, LastColonIndex - firstColonIndex);
            Name = n;
            TypeId = regex.Match(name).Groups[1].Value;
        }

        public IfcObjects(List<IfcObjects> g)
        {
            Name = g.First().Name;
            TypeId = g.First().TypeId;
            Length = g.Sum(x => x.Length);
            Area = g.Sum(x => x.Area);
            Volume = g.Sum(x => x.Volume);
            Count = g.Sum(x => x.Count);
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
