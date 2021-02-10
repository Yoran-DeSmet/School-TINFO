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
            DateTime[] geboortedatum = new DateTime[5];
            int[] leeftijd = new int[5];
            int oudste;

            //INPUNT
            //VRAAG: geboortedatums
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Geef de geboortedatum in DD/MM/YY: ");
                geboortedatum[i] = DateTime.Parse(Console.ReadLine());
            }

            //P
            //BEREKEN:  leeftijden
            for (int i = 0; i < 5; i++)
            {
                leeftijd[i] = CalculateLeeftijd(geboortedatum[i]);
            }
            //BEREKEN:  oudste
            oudste = 0;
            for (int i = 0; i < 5; i++)
            {
                if (leeftijd[i] >= oudste)
                    oudste = leeftijd[i];
            }

            //output
            //TOON:     oudste
            Console.WriteLine($"de oudste persoon uit de reeks geboortedata is: ");

            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten...");
            Console.ReadLine();




            private static int CalculateLeeftijd(DateTime geboortedatum)
            {
                int leeftijd;
                //bereken leeftijd
                if (geboortedatum.Month > DateTime.Now.Month)
                {
                    leeftijd = (DateTime.Now.Year - geboortedatum.Year) - 1;
                }
                else if (geboortedatum.Month == DateTime.Now.Month)
                {
                    if (geboortedatum.Day >= DateTime.Now.Day)
                        leeftijd = (DateTime.Now.Year - geboortedatum.Year) - 1;
                    else
                        leeftijd = (DateTime.Now.Year - geboortedatum.Year);
                }
                else
                {
                    leeftijd = (DateTime.Now.Year - geboortedatum.Year);
                }
                return leeftijd;
            }
        }

    }
    }
}
