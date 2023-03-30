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
    public partial class UpravaTypuPrace : Form
    {
        public SpravaTypuPrace Form { get; set; }
        public int IdTypuPrace { get; set; }
        public UpravaTypuPrace(int idTypuPrace, SpravaTypuPrace form)
        {
            InitializeComponent();
            Form = form;
            IdTypuPrace = idTypuPrace;
        }

        private void btnUpravitPraci_Click(object sender, EventArgs e)
        {
            SqlRepository.EditTypuPrace(IdTypuPrace, txtBoxUpravaNazvuPrace.Text, txtBoxUpravaPopisuPrace.Text);
            Form.UpdateSpravaTypuPrace();
            Close();
        }
    }
}
