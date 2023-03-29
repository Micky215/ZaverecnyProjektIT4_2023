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
        public SpravaZamestnancu Form { get; set; }
        public int IdZamestnance { get; set; }
        public UpravaZamestnance(int idZamestnance, SpravaZamestnancu form)
        {
            InitializeComponent();
            Form = form;
            IdZamestnance = idZamestnance;
        }

       

        private void btnUpravaZamestnance_Click_1(object sender, EventArgs e)
        {
            SqlRepository.EditZamestnance(IdZamestnance, txtBoxUpravaJmenaZamestnance.Text, txtBoxUpravaPrijmeniZamestnance.Text, dateTimePickerUpravaDataZamestnance.Value, txtBoxUpravaEmailuZamestnance.Text, txtBoxUpravaTelefonuZamestnance.Text);
            Form.UpdateZamestnancuView();
            Close();
        }

        private void UpravaZamestnance_Load(object sender, EventArgs e)
        {

        }
    }
}
