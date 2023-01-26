using FourDScheduling.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MaterialResource;

namespace FourDScheduling.Models
{
    public class IfcObjects
    {

        public string Id { get; set; }
        public string TypeId { get; private set; }
        public string Name { get; private set; }
        public string FamilyName { get; private set; }
        public string IfcType { get; private set; }
        public string Material { get; private set; }

        public decimal Length { get; set; }
        public decimal Thickness { get; set; }
        public decimal AreaOfOpenings { get; set; }
        public decimal NetArea { get; set; }
        public decimal GrossArea { get; set; }
        public decimal Volume { get; set; }
        public bool Chosen { get; set; }
        public int Count { get; set; } = 1;
        public ListViewItem Item { get; set; }
        public IIfcProduct Product { get; set; }

        public readonly string[] validVariables = { "NetArea", "GrossArea", "AreaOfOpenings", "Length", "Thickness", "Volume", "Count" };
        private string _variable;

        public string Variabel
        {
            get { return _variable; }
            set
            {
                if (validVariables.Contains(value))
                    _variable = value;
                else
                    throw new ArgumentException("Invalid variable.");
            }
        }

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
            IfcType = product.ExpressType.Name;
            Material = (product.Material as IIfcMaterial)?.Name;

            Id = product.GlobalId;
            Length = IfcAPI.GetLength(product);
            NetArea = IfcAPI.GetNetArea(product);
            GrossArea = IfcAPI.GetGrossArea(product);
            Volume = IfcAPI.GetVolume(product);
            Thickness = IfcAPI.GetThickness(product);
            AreaOfOpenings = Math.Round(GrossArea - NetArea, 6);

            Chosen = TypeId == "" ? false : true;
            Product = product;


            switch (product)
            {
                case IIfcWindow _:
                    Variabel = validVariables[6];
                    break;
                case IIfcWall _:
                    Variabel = validVariables[0];
                    break;
                case IIfcDoor _:
                    Variabel = validVariables[6];
                    break;
                case IIfcStairFlight _:
                    Variabel = validVariables[6];
                    break;
                case IIfcSlab _:
                    Variabel = validVariables[0];
                    break;
                case IIfcRoof _:
                    Variabel = validVariables[0];
                    break;
                case IIfcFooting _:
                    Variabel = validVariables[5];
                    break;
                default:

                    break;

            }
        }

        /// <summary>
        /// The list input has to be of the same type to ensure the information is correct.
        /// The first element in the list will be the input for ID, Name, FamilyName, TypeId, IfcType, Material, Thickness and Variable
        /// </summary>
        /// <param name="obj"></param>
        public IfcObjects(List<IfcObjects> obj)
        {
            Id = obj.First().Id;
            Name = obj.First().Name;
            FamilyName = obj.First().FamilyName;
            TypeId = obj.First().TypeId;
            IfcType = obj.First().IfcType;
            Material = obj.First().Material;

            Length = obj.Sum(x => x.Length);
            NetArea = obj.Sum(x => x.NetArea);
            GrossArea = obj.Sum(x => x.GrossArea);
            Volume = obj.Sum(x => x.Volume);
            AreaOfOpenings = obj.Sum(x => x.AreaOfOpenings);
            Thickness = obj.First().Thickness;
            Count = obj.Sum(x => x.Count);

            Variabel = obj.First().Variabel;
        }


        public static void PrintIfcObject(IfcObjects obj)
        {
            Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));
            Console.WriteLine("--------------------------------------------------");


        }

    }

}
