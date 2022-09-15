using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDScheduling
{
    public class IfcObjects
    {
        public string id { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public double value { get; set; }
        public string timeUnit { get; set; }
        public int timeValue { get; set; }


        public static void printIfcObject(IfcObjects obj)
        {
            Console.WriteLine(obj.id);
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.unit);
            Console.WriteLine(obj.value);
            Console.WriteLine(obj.timeUnit);
            Console.WriteLine(obj.timeValue);
            Console.WriteLine("------------");


        }

    }

    




}
