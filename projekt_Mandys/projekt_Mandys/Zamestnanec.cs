using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_Mandys
{
    internal class Zamestnanec
    {
        public Zamestnanec(int id, string krestniJmeno, string prijmeni, DateTime datumNarozeni, string email, int telefon)
        {
            Id = id;
            KrestniJmeno = krestniJmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            Email = email;
            Telefon = telefon;
        }

        public int Id { get; set; }
        public string KrestniJmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }

    }
}
