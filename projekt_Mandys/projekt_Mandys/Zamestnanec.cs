using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_Mandys
{
    internal class Zamestnanec
    {
        public Zamestnanec(string krestniJmeno, string prijmeni)
        {
            KrestniJmeno = krestniJmeno;
            Prijmeni = prijmeni;
        }

        public string KrestniJmeno { get; set; }
        public string Prijmeni { get; set; }
    }
}
