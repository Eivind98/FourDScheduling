using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDScheduling
{
    public class Depend
    {
        public string id { get; }
        public string type { get; set; }
        public string difference { get; set; }
        public string hardness { get; set; }


        public Depend(string aId, string aType, string aDifference, string aHardness)
        {

            id = aId;
            type = aType;
            difference = aDifference;
            hardness = aHardness;

        }


        public static void printDepend(Depend depend)
        {
            Console.WriteLine(depend.id);
            Console.WriteLine(depend.type);
            Console.WriteLine(depend.difference);
            Console.WriteLine(depend.hardness);
            Console.WriteLine("------------");





        }


    }
}
