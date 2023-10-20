using System;
namespace Upggift
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, skriv in hur lång din låt är för våran radiostation i minuter");
            int låtM = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många sekunder är din låt");
            int låtS = int.Parse(Console.ReadLine());

            int låtL = (låtM * 60) + låtS;


            if (låtM < 260)
            {
                Console.WriteLine("ja denna kan vi spela");
            }
            else
            {
                Console.WriteLine("Tyvärr denna är för lång");
            }
            

        }

    }
}
