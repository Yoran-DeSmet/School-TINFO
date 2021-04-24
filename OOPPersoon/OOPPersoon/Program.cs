using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPersoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon persoon = new Persoon();
            persoon.Voornaam = Vraag("Wat is je voornaam? ");
            persoon.Achternaam = Vraag("Wat is de familienaam? ");
            persoon.Geboortedatum = DateTime.Parse(Vraag("Wat is de geboortedatum? "));

            Console.WriteLine();
            Console.WriteLine(persoon);
            Console.WriteLine();
            Console.WriteLine("Druk ENTER om te stoppen...");
            Console.ReadLine();

        }
        static string Vraag(string vraag)
        {
            Console.Write(vraag);
            return Console.ReadLine();

        }
    }
}
