using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_Mandys
{
    public partial class Form1 : Form
    {
        public Uzivatel Uzivatel { get; set; }

        public Form1(Uzivatel uzivatel)
        {               
            InitializeComponent();
            Uzivatel = uzivatel;
        }

        private void btnSpravaUzivatelu_Click(object sender, EventArgs e)
        {
            SpravaUzivatelu spravaUzivatelu = new SpravaUzivatelu();
            spravaUzivatelu.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SpravaZamestnancu spravaZamestnancu = new SpravaZamestnancu();
            spravaZamestnancu.ShowDialog();
            this.Hide();
        }
    }
}
