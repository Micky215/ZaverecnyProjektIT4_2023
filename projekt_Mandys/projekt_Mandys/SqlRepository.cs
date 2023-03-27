using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_Mandys
{
    internal class SqlRepository
    {
        public string connection { get; set; }
        

        public SqlRepository(string connection)
        {
            this.connection = connection;
        }
        
        public Uzivatel GetUzivatel(string uzivatelskeJmeno)
        {
            Uzivatel uzivatel = null;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Uzivatele where Jmeno=@uzivatelskeJmeno";
                    cmd.Parameters.AddWithValue("uzivatelskeJmeno", uzivatelskeJmeno);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            uzivatel = new Uzivatel(reader["Jmeno"].ToString(), reader["Heslo"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Uživatel s takovýmto uživatelským jménem neexistuje!");
                        }
                    }

                    
                }
                conn.Close();

                
            }
            return uzivatel;

        }

        public Uzivatel GetUzivatel(int id)
        {
            Uzivatel uzivatel = null;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Uzivatele WHERE IdUzivatele=@id";
                    cmd.Parameters.AddWithValue("id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            uzivatel = new Uzivatel(Convert.ToInt32(reader["IdUzivatele"]), Convert.ToString(reader["Jmeno"]), Convert.ToInt32(reader["IdZamestance"]), Convert.ToInt32(reader["Role"]));
                        }
                        else
                        {
                            MessageBox.Show("Uživatel s takovýmto uživatelským jménem neexistuje!");
                        }
                    }
                }
                conn.Close();
            }

            return uzivatel;
        }

        public List<Uzivatel> GetUsers()
        {
            List<Uzivatel> uzivatele = new List<Uzivatel>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Uzivatele";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            uzivatele.Add(new Uzivatel(Convert.ToInt32(reader["IdUzivatele"]), reader["Jmeno"].ToString(), Convert.ToInt32(reader["IdZamestnance"]), Convert.ToInt32(reader["Role"])));
                        }
                    }
                }
                conn.Close();
            }
            return uzivatele;
        }

        public List<Role> GetRole()
        {
            List<Role> role = new List<Role>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Role";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            role.Add(new Role(reader["NazevRole"].ToString()));
                        }
                    }
                }
                conn.Close();
            }
            return role;
        }

        public Zamestnanec GetZamestance(int idZamestnance)
        {
            Zamestnanec zamestnanec = null;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Zamestnanci where IdZamestnance=@id";
                    cmd.Parameters.AddWithValue("id", idZamestnance);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            zamestnanec = new Zamestnanec(reader["KrestniJmeno"].ToString(), reader["Prijmeni"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Zaměstnanec s takovýmto identifikačním číslem neexistuje!");
                        }
                    }
                }
                conn.Close();
            }
            return zamestnanec;
        }

        public Role GetRole(int idRole)
        {
            Role role = null;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Role where IdRole=@id";
                    cmd.Parameters.AddWithValue("id", idRole);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = new Role(reader["Name"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Role s takovýmto identifikačním číslem neexistuje!");
                        }
                    }
                }
                conn.Close();
            }
            return role;
        }

        public Role GetRole(string roleJmeno)
        {
            Role role = null;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Role where NazevRole=@roleName";
                    cmd.Parameters.AddWithValue("roleName", roleJmeno);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = new Role(Convert.ToInt32(reader["IdRole"]));
                        }
                        else
                        {
                            MessageBox.Show("Role s takovýmto názvem neexistuje!");
                        }
                    }
                }
                conn.Close();
            }
            return role;
        }

        public void UpdateUzivatele(string jmeno, int idRole, int idUzivatele)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update Uzivatele set Jmeno =@jmeno,Role=@idRole where IdUzivatele=@idUzivatele";
                    cmd.Parameters.AddWithValue("userName", jmeno);
                    cmd.Parameters.AddWithValue("idRole", idRole);
                    cmd.Parameters.AddWithValue("idUser", idUzivatele);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void ResetUzivateHeslo(int idZamestnance, byte[] heslo, byte[] passwordSalt)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update Users set Password=@password,PasswordSalt=@passwordSalt where IdUser=@idUser";
                    cmd.Parameters.AddWithValue("password", heslo);
                    cmd.Parameters.AddWithValue("passwordSalt", passwordSalt);
                    cmd.Parameters.AddWithValue("idUser", idZamestnance);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }

}
