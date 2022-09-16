using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDScheduling
{
    public class IfcObjects
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Value { get; set; }
        public string TimeUnit { get; set; }
        public int TimeValue { get; set; }


        public static void PrintIfcObject(IfcObjects obj)
        {
            Console.WriteLine(obj.Id);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Unit);
            Console.WriteLine(obj.Value);
            Console.WriteLine(obj.TimeUnit);
            Console.WriteLine(obj.TimeValue);
            Console.WriteLine("------------");


        }

    }

    




}
