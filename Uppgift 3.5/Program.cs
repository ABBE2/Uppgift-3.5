using System;
using System.Windows.Markup;

namespace uppgift3_5
{
    class uppgift3_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skriv ett till tal");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            string val = Console.ReadLine();
            switch (val)
            {
                case "1":
                    {
                        Console.WriteLine("Svaret blir " + (x+y) );
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("Svaret blir " + (x-y) );
                    }
                    break;
                case "3":
                    {
                        Console.WriteLine("Svaret blir " + (x*y) );
                    }
                    break;
                case "4":
                    {
                        Console.WriteLine("Svaret blir " + (x/y) );
                    }
                    break;
                    default:
                    Console.WriteLine("Du måste välja ett av alternativen");
                    break;
            }
        }
    }
}