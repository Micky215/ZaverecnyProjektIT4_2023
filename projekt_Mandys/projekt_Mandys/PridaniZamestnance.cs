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
    public partial class PridaniZamestnance : Form
    {
        public SpravaZamestnancu Form { get; set; }
        public PridaniZamestnance(SpravaZamestnancu form)
        {
            InitializeComponent();
            Form = form;
        }

        private void btnVytvoritZamestnance_Click(object sender, EventArgs e)
        {
            SqlRepository.AddZamestnance(txtBoxKrestniJmeno.Text, txtBoxPrijmeni.Text, Convert.ToDateTime(txtBoxDatumNarozeni.Text), txtBoxEmail.Text, txtBoxTelefon.Text);
            Form.UpdateZamestnancuView();
            Close();

        }
    }
}
