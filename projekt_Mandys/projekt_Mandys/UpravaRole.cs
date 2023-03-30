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
    public partial class UpravaRole : Form
    {

        public SpravaRoli Form { get; set; }
        public int IdRole { get; set; }

        public UpravaRole(int idRole, SpravaRoli form)
        {
            InitializeComponent();
            Form = form;
            IdRole = idRole;
        }

        private void btnUpravaRole_Click(object sender, EventArgs e)
        {
            SqlRepository.EditRole(IdRole, txtBoxUpravaNazvuRole.Text);
            Form.UpdateSpravaRoli();
            Close();
        }
    }
}
