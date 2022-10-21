using System;
namespace Uppgift_4_25
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            while (b == true)
            {



                Console.WriteLine("Välj ett av följande alternativ");
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta programmet");

                float val = float.Parse(Console.ReadLine());

                switch (val)
                {
                    case 1:
                        Console.WriteLine("1. Subtrahera ett tal med ett annat");
                        Console.WriteLine("skriv in 2 tal");
                        float tal1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv in tal2 här");
                        float tal2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"{tal1}-{tal2}={tal1 - tal2}");
                        break;

                    case 2:
                        Console.WriteLine("2. Dividera ett tal med ett annat");
                        Console.WriteLine("Börja med att skriva in ett tal");
                        float tal3 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv in det andra talet här");
                        float tal4 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"{tal3}/{tal4}={tal3 / tal4}");
                        break;

                    case 3:
                        b = false;
                        Console.WriteLine("Hejdå");
                        break;

                }
            }
        }
    }
}
