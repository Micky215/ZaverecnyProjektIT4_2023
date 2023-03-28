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
    public partial class PridaniUzivateleForm : Form
    {
        public SpravaUzivatelu Form { get; set; }
        SqlRepository sqlRepository;
        public PridaniUzivateleForm(SpravaUzivatelu form)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            Form = form;
        }

        private void btnPridatUzivatele_Click(object sender, EventArgs e)
        {
            SqlRepository.AddUzivatele(Convert.ToInt32(txtBoxIdZamestnance.Text), txtBoxJmeno.Text, txtBoxHeslo.Text, Convert.ToInt32(txtBoxRole.Text));
            Form.UpdateUzivatelView();
            Close();
        }
    }
}
