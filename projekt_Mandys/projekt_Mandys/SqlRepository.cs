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
        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DEDMS\Desktop\ForkZaverecnyProjekt\projekt_Mandys\Zamestnanci.mdf;Integrated Security=True;Connect Timeout=30";


        public static List<Uzivatel> ShowUzivatele()
        {
            var uzivatele = new List<Uzivatel>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Uzivatele";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                uzivatele.Add(new Uzivatel(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4)));
            }
            reader.Close();
            conn.Close();



            return uzivatele;
        }

        public static List<Zamestnanec> ShowZamestnance()
        {
            var zametnanec = new List<Zamestnanec>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Zamestnanci";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                zametnanec.Add(new Zamestnanec(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4), reader.GetString(5)));
            }
            reader.Close();
            conn.Close();



            return zametnanec;
        }

        public static List<Role> ShowRole()
        {
            var role = new List<Role>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Role";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                role.Add(new Role(reader.GetInt32(0), reader.GetString(1)));
            }
            reader.Close();
            conn.Close();



            return role;
        }

        public Uzivatel GetUzivatel(string uzivatelskeJmeno)
        {
            Uzivatel uzivatel = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
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

        public Uzivatel GetUzivatelById(int id)
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
                            uzivatel = new Uzivatel(Convert.ToInt32(reader["IdUzivatele"]), Convert.ToInt32(reader["IdZamestance"]), Convert.ToString(reader["Jmeno"]), Convert.ToString(reader["Heslo"]), Convert.ToInt32(reader["Role"]));
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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Uzivatele";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            uzivatele.Add(new Uzivatel(Convert.ToInt32(reader["IdUzivatele"]), Convert.ToInt32(reader["IdZamestance"]), Convert.ToString(reader["Jmeno"]), Convert.ToString(reader["Heslo"]), Convert.ToInt32(reader["Role"])));
                        }
                    }
                }
                conn.Close();
            }
            return uzivatele;
        }

        public Role GetRole(string roleJmeno)
        {
            Role role = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
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
            using (SqlConnection conn = new SqlConnection(connectionString))
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

        
    }

}
