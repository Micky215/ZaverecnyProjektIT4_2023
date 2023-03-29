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
    public partial class UpravaZamestnance : Form
    {
        public UpravaZamestnance Form { get; set; }
        public UpravaZamestnance()
        {
            InitializeComponent();
            Form = this;
        }

        private void btnUpravaZamestnance_Click(object sender, EventArgs e)
        {
            SqlRepository.EditZamestnance(txtBoxUpravaJmenaZamestnance.Text, txtBoxUpravaPrijmeniZamestnance.Text, Convert.ToDateTime(txtBoxUpravaDataZamestnance.Text), txtBoxUpravaEmailuZamestnance.Text, txtBoxUpravaTelefonuZamestnance.Text);
            Form.UpdateZamestnancuView();
            Close();
        }

       
    }
}
