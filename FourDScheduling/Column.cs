using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDScheduling
{
    public class Column
    {
        public string id { get; }
        public string name { get; set; }
        public string width { get; set; }
        public string order { get; set; }
        public string type { get; set; }
        public string valuetype { get; set; }
        public string defaultvalue { get; set; }


        public Column(string aId, string aName, string aWidth, string aOrder, string aType, string aValuetype, string aDefaultvalue)
        {

            id = aId;
            name = aName;
            width = aWidth;
            order = aOrder;
            type = aType;
            valuetype = aValuetype;
            defaultvalue = aDefaultvalue;

        }


        public static void printColumn(Column column)
        {
            Console.WriteLine(column.id);
            Console.WriteLine(column.name);
            Console.WriteLine(column.width);
            Console.WriteLine(column.order);
            Console.WriteLine("------------");





        }


    }
}
