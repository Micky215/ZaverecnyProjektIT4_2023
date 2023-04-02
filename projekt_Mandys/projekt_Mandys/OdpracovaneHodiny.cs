using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_Mandys
{
    public class OdpracovaneHodiny
    {
        public int Id { get; set; }
        public int PocetHodin { get; set; }
        public DateTime Datum { get; set; }
        public int IdZamestnanci { get; set; }
        public int IdKontraktu { get; set; }
        public int IdPrace { get; set; }

        public OdpracovaneHodiny(int id, int pocetHodin, DateTime datum, int idZamestnanci, int idKontraktu, int idPrace)
        {
            Id = id;
            PocetHodin = pocetHodin;
            Datum = datum;
            IdZamestnanci = idZamestnanci;
            IdKontraktu = idKontraktu;
            IdPrace = idPrace;
        }
    }
}
