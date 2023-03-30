using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_Mandys
{
    internal class TypPrace
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public string Popis { get; set; }

        public TypPrace(int id, string nazev, string popis)
        {
            Id = id;
            Nazev = nazev;
            Popis = popis;
        }

        public TypPrace(int id) 
        {
            Id=id;
        }   
    }
}
