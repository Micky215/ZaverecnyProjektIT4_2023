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
    public partial class PridaniRole : Form
    {
        public SpravaRoli Form { get; set; }
        public PridaniRole(SpravaRoli form)
        {
            InitializeComponent();
            Form = form;
        }

        private void btnPridatRoli_Click(object sender, EventArgs e)
        {
            SqlRepository.AddRole(txtBoxNazevRoli.Text);
            Form.UpdateSpravaRoli();
            Close();
        }
    }
}
