using System;

namespace FourDScheduling.Models
{
    public class Depend
    {
        public string Id { get; }
        public string Type { get; set; }
        public string Difference { get; set; }
        public string Hardness { get; set; }


        public Depend(string aId, string aType, string aDifference, string aHardness)
        {

            Id = aId;
            Type = aType;
            Difference = aDifference;
            Hardness = aHardness;

        }


        public static void PrintDepend(Depend depend)
        {
            Console.WriteLine(depend.Id);
            Console.WriteLine(depend.Type);
            Console.WriteLine(depend.Difference);
            Console.WriteLine(depend.Hardness);
            Console.WriteLine("------------");





        }


    }
}
