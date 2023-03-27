using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projekt_Mandys
{
    public class Uzivatel
    {
        public string Jmeno { get; set; }
        public int Role { get; set; }
        public string Heslo { get; set; }
        //public byte[] PasswordHash { get; set; }
        //public byte[] PasswordSalt { get; set; }
        public int IdZamestnance { get; set; }
        public int Id { get; set; }

        public Uzivatel(string jmeno, string heslo) 
        {
            Jmeno = jmeno;
            Heslo = heslo;
            
        }

        public Uzivatel(int id, string jmeno, int idZamestnance, int role)
        {
            IdZamestnance= idZamestnance;
            Jmeno = jmeno;
            Id = id;
            Role= role;
        }

        //public bool OverovaniHesla(string text)
        //{
        //    byte[] hash;
        //    using (var hmac = new HMACSHA512(PasswordSalt))
        //    {
        //        hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(text));
        //    }
        //    return hash.SequenceEqual(PasswordHash);
        //}


    }
}
