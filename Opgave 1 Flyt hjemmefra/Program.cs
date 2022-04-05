using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1_Flyt_hjemmefra
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Velkommen til Ungeråd's Flyt Hjemmefra-servicen\n");
                Console.WriteLine("Indtast dit navn: ");
                string navn = Console.ReadLine();
                Console.WriteLine("Indtast din timeløn: ");
                string timeløn = Console.ReadLine();
                Console.WriteLine("Hvor mange timer arbejder du om ugen: ");
                string timer = Console.ReadLine();
                double ugeløn = Convert.ToDouble(timeløn) * Convert.ToDouble(timer);
                Console.WriteLine("Hej " + navn + ". Du tjener kr. " + ugeløn + " om ugen.");
                for (int a = 0; a < ugeløn - ugeløn % 100; a += 100)
                {
                    Console.Write("*");
                }
                if (ugeløn > 2600)
                {
                    Console.WriteLine("\nDu har råd til at flytte hjemmefra.");
                }
                else
                {
                    Console.WriteLine("Du har ikke råd til at flytte hjemmefra.\n");
                }
                Console.WriteLine("Tryk på en tast, hvis du vil genstarte, eller Escape for at lukke programmet.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}