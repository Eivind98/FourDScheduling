using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDScheduling
{
    public class Column
    {
        public string Id { get; }
        public string Name { get; set; }
        public string Width { get; set; }
        public string Order { get; set; }
        public string Type { get; set; }
        public string Valuetype { get; set; }
        public string Defaultvalue { get; set; }


        public Column(string aId, string aName, string aWidth, string aOrder, string aValuetype, string aDefaultvalue)
        {

            Id = aId;
            Name = aName;
            Width = aWidth;
            Order = aOrder;
            Type = "custom";
            Valuetype = aValuetype;
            Defaultvalue = aDefaultvalue;

        }


        public static void PrintColumn(Column column)
        {
            Console.WriteLine(column.Id);
            Console.WriteLine(column.Name);
            Console.WriteLine(column.Width);
            Console.WriteLine(column.Order);
            Console.WriteLine(column.Valuetype);
            Console.WriteLine(column.Defaultvalue);
            Console.WriteLine("------------");


        }

    }
}
