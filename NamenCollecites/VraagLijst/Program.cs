using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VraagLijst
{
    class Program
    {
        static void Main(string[] args)
        {
            versie1();

            
            //Wachten...
            Console.WriteLine();
            Console.WriteLine("Druk een knop om te stoppen...");
            Console.ReadLine();

            byte AantalElementen;
            //DECLARATIONS
            byte lenght;
            List<string> namen = new List<string>();

            //INPUT + PROCESSING
            Console.Write("Hoeveel namen wil je ingeven? ");
            lenght = byte.Parse(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Geef een naam: ");
                namen.Add(Console.ReadLine());
            }

            //OUTPUT
            Console.WriteLine();
            Console.WriteLine($"Er zitten {lenght} namen in de lijst.");
            Console.WriteLine();
            foreach (var item in namen)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item);
                Console.ResetColor();
            }

            //Wachten...
            Console.WriteLine();
            Console.WriteLine("Druk een knop om te stoppen...");
            Console.ReadLine();
        }
    }
}
