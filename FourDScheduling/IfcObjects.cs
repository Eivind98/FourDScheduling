using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;

namespace FourDScheduling
{
    public class IfcObjects
    {

        public string Id { get; set; }
        public string TypeId { get; private set; }
        public string Name { get; private set; }
        public string FamilyName { get; private set; }
        public decimal Length { get; set; }
        public decimal Thickness { get; set; }
        public decimal AreaOfOpenings { get; set; }
        public decimal NetArea { get; set; }
        public decimal GrossArea { get; set; }
        public decimal Volume { get; set; }
        public bool Chosen { get; set; }
        public int Count { get; set; } = 1;


        private static Regex bimSevenAARegex = new Regex(@"(.{3,}):(((\d{6})(\.\d+)?\s)?(.+)):(\d{6})");
        

        public IfcObjects(string name)
        {

            Name = bimSevenAARegex.Match(name).Groups[2].Value;
            FamilyName = bimSevenAARegex.Match(name).Groups[1].Value;
            TypeId = bimSevenAARegex.Match(name).Groups[3].Value;

        }

        public IfcObjects(IIfcProduct product)
        {
            string name = product.Name;

            Name = bimSevenAARegex.Match(name).Groups[2].Value;
            FamilyName = bimSevenAARegex.Match(name).Groups[1].Value;
            TypeId = bimSevenAARegex.Match(name).Groups[3].Value;

            Id = product.GlobalId;
            Length = IfcAPI.GetLength(product);
            NetArea = IfcAPI.GetNetArea(product);
            GrossArea = IfcAPI.GetGrossArea(product);
            Volume = IfcAPI.GetVolume(product);
            Chosen = TypeId == "" ? false : true;

        }


        public IfcObjects(List<IfcObjects> obj)
        {
            Id = obj.First().Id;
            Name = obj.First().Name;
            FamilyName = obj.First().FamilyName;
            TypeId = obj.First().TypeId;
            Length = obj.Sum(x => x.Length);
            NetArea = obj.Sum(x => x.NetArea);
            GrossArea = obj.Sum(x => x.GrossArea);
            Volume = obj.Sum(x => x.Volume);
            Count = obj.Sum(x => x.Count);
        }


        public static void PrintIfcObject(IfcObjects obj)
        {
            Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));
            Console.WriteLine("--------------------------------------------------");


        }

    }

}
