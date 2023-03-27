using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_Mandys
{
    internal class Role
    {
        public Role(string jmeno)
        {
            Jmeno = jmeno;
        }

        public Role(int id)
        {
            Id = id;
        }

        public string Jmeno { get; set; }
        public int Id { get; set; }
    }
}
