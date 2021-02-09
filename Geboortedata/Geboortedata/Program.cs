/* 5AIT3 - Yoran - 2021-2-9
 * 
 * OPGAVE: 
 * ======
 * VRAAG    lijst met geboortedata
 * BEREKEN  oudste leeftijd
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geboortedata
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            byte leeftijd;
            DateTime geboortedatum;
            DateTime vandaag = DateTime.Today;
            DateTime[] geboortedata = new DateTime[5];
            const byte maxAantalGeboortedata = 5;
            //INPUT
            Console.WriteLine($"Geef geboortedatum ");
            geboortedatum = DateTime.Parse(Console.ReadLine());
            Console.ReadLine();


            //p
            Console.Write("De ouste leeftijd is: ");
            
        }
    }
}
