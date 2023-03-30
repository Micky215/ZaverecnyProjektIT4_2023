using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_Mandys
{
    internal class Kontrakt
    {
        public int IdKontraktu { get; set; }
        public string Zakaznik { get; set; }
        public string Popis { get; set; }

        public Kontrakt(int idKontraktu, string zakaznik, string popis)
        {
            IdKontraktu = idKontraktu;
            Zakaznik = zakaznik;
            Popis = popis;
        }

        public Kontrakt(int idKontraktu)
        {
            IdKontraktu = idKontraktu;
        }
    }
}
