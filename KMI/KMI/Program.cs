/* 5AIT3 - Yoran - 2021-1-20
 * 
 * OPGAVE: 
 * -------
 * bouw een lijst met de 10 eerste natuurlijke getallen
 * Toon deb lijst aan de gebruiker
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMI
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] getallenlijst = new byte[10]; // {0,1,2,3,4,5,6,7,8,9 };
            //Array opvullen
            for (int i = 0; i < 10; i++)
            {
                getallenlijst[i] = i;
            }
        }
    }
}
