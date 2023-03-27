using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_Mandys
{
    internal class Role
    {


        public Role(int idRole)
        {
            IdRole = idRole;
        }

        public Role(int idRole, string nazevRole)
        {
            IdRole = idRole;
            NazevRole = nazevRole;
            
        }

        public string NazevRole { get; set; }
        public int IdRole { get; set; }
    }
}
