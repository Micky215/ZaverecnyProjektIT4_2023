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
    public partial class UpravaUzivatele : Form
    {
        public SpravaUzivatelu Form { get; set; }
        public int IdUzivatele { get; set; }
        public UpravaUzivatele(int idUzivatele, SpravaUzivatelu form)
        {
            InitializeComponent();
            Form = form;
            IdUzivatele = idUzivatele;
        }

        private void btnUpravitUzivatele_Click(object sender, EventArgs e)
        {
            SqlRepository.EditUzivatele(IdUzivatele, Convert.ToInt32(txtBoxUpravaIdZamestnance.Text), txtBoxUpravaJmena.Text, txtBoxUpravaHesla.Text, Convert.ToInt32(txtBoxUpravaRole.Text));
            Form.UpdateUzivatelView();
            Close();
        }
    }
}
