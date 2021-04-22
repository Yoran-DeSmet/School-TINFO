using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPersoon
{
    class Persoon
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public int Geboortjaar { get { return Geboortedatum.Year; } }
        public override string ToString()
        {
            return $()

        }
    }
}
