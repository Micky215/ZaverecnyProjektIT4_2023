using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_Mandys
{
    public partial class Prihlaseni : Form
    {
        SqlRepository sqlRepository;
        public Prihlaseni()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void btnPrihlasit_Click(object sender, EventArgs e)
        {
            if (txtBoxJmeno.Text != " " && txtBoxHeslo.Text != " ")
            {
                Uzivatel uzivatel = sqlRepository.GetUzivatel(txtBoxJmeno.Text);
                if (uzivatel != null)
                {
                    if(txtBoxHeslo.Text == uzivatel.Heslo.ToString())
                    {
                        Form1 form1 = new Form1(uzivatel);
                        form1.Show();
                        this.Hide();
                    }


                    else
                    {
                        MessageBox.Show("Heslo není správné!");
                    }
                }
                else
                {
                    MessageBox.Show("Tento uživatel neexistuje!");
                }
            }
            else
            {
                MessageBox.Show("Nevyplnil jste heslo nebo uživatelské jméno!");
            }
        }
    }
}
