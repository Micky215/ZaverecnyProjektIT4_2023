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
    public partial class PridaniKontraktu : Form
    {
        public SpravaKontraktu Form { get; set; }
        public PridaniKontraktu(SpravaKontraktu form)
        {
            InitializeComponent();
            Form = form;
        }

        private void btnPridatKontrakt_Click(object sender, EventArgs e)
        {
            SqlRepository.AddKontrakt(txtBoxPridaniNazvuKontraktu.Text, txtBoxPridaniPopisuKontraktu.Text);
            Form.UpdateKontraktuView();
            Close();
        }
    }
}
