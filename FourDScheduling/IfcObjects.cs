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
        private static Regex nameRegex = new Regex(@"([\d\D]{3,}):([\d\D]{1,}):(\d{6})");
        private static Regex bimSevenAARegex = new Regex(@"([\d\D]{3,}):((\d{6}(\.\d+)?)\s[\d\D]{1,}):(\d{6})");
        private static Regex bimSevenAAFromNameRegex = new Regex(@"(\d{6}(\.\d+)?)\s[\d\D]{1,}");

        public IfcObjects(string name)
        {

            //var firstColonIndex = name.IndexOf(':') + 1;
            //var LastColonIndex = name.LastIndexOf(':');
            //var n = name.Substring(firstColonIndex, LastColonIndex - firstColonIndex);
            var n = nameRegex.Match(name).Groups[2].Value;
            Name = n;
            FamilyName = nameRegex.Match(name).Groups[1].Value;
            TypeId = bimSevenAAFromNameRegex.Match(n).Groups[1].Value;
        }

        public IfcObjects(List<IfcObjects> g)
        {
            Id = g.First().Id;
            Name = g.First().Name;
            FamilyName = g.First().FamilyName;
            TypeId = g.First().TypeId;
            Length = g.Sum(x => x.Length);
            NetArea = g.Sum(x => x.NetArea);
            GrossArea = g.Sum(x => x.GrossArea);
            Volume = g.Sum(x => x.Volume);
            Count = g.Sum(x => x.Count);
        }


        public string Id { get; set; }
        public string TypeId { get; private set; }
        public string Name { get; private set; }
        public string FamilyName { get; private set; }
        public decimal Length { get; set; }
        public decimal NetArea { get; set; }
        public decimal GrossArea { get; set; }
        public decimal Volume { get; set; }
        public int Count { get; set; } = 1;

        public static void PrintIfcObject(IfcObjects obj)
        {
            Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));
            Console.WriteLine("--------------------------------------------------");


        }

    }






}
