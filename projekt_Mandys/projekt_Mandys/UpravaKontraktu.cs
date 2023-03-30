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
    public partial class UpravaKontraktu : Form
    {
        public SpravaKontraktu Form { get; set; }
        public int IdKontrakt { get; set; }
        public UpravaKontraktu(int idKontrakt, SpravaKontraktu form)
        {
            InitializeComponent();
            Form = form;
            IdKontrakt = idKontrakt;
        }

        private void btnUpravitKontrakt_Click(object sender, EventArgs e)
        {
            SqlRepository.EditKontrakt(IdKontrakt, txtBoxUpravitNazevKontraktu.Text, txtBoxUpravaPopisuKontraktu.Text);
            Form.UpdateKontraktuView();
            Close();
        }
    }
}
