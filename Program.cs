using System;

namespace oop_6115261020_w08
{
    class Program
    {
        static void Main(string[] args)
        {
            clip a1 = new clip("banama","2.35","25,564","6,589","256");
            clip a2 = new clip("kaka", "3.65", "654,567", "456,564", "425,456");
            channel b1 = new channel("pikiki", "5", "145,123", a1);
            channel b2 = new channel("narumcan", "2", "1,256,001", a2);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }
    }
}
