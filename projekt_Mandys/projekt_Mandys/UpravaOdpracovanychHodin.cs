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
    public partial class UpravaOdpracovanychHodin : Form
    {
        public SpravitOdpracovaneHodiny Form { get; set; }
        public int Id { get; set; }
        public UpravaOdpracovanychHodin(int id, SpravitOdpracovaneHodiny form)
        {
            InitializeComponent();
            Id = id;
            Form = form;
        }

        private void btnUpravitPocetHodin_Click(object sender, EventArgs e)
        {
            SqlRepository.EditOdpracovaneHodiny(Id, Convert.ToInt32(txtBoxPocetHodin.Text), Convert.ToDateTime(txtBoxDatum.Text), Convert.ToInt32(txtBoxIdZamestnance.Text), Convert.ToInt32(txtBoxIdKontraktu.Text), Convert.ToInt32(txtBoxIdPrace.Text));
            Form.UpdateOdpracovaneHodiny();
            Close();
        }
    }
}
