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
    public partial class SpravaZamestnancu : Form
    {
        public SpravaZamestnancu()
        {
            InitializeComponent();
            UpdateZamestnancuView();
        }

        private void UpdateZamestnancuView()
        {
            listViewZamestnanci.Items.Clear();

            foreach (Zamestnanec zamestnanec in SqlRepository.ShowZamestnance())
            {
                listViewZamestnanci.Items.Add(new ListViewItem(new string[]
                {
                  zamestnanec.Id.ToString(),
                  zamestnanec.KrestniJmeno,
                  zamestnanec.Prijmeni,
                  zamestnanec.DatumNarozeni.ToShortDateString(),
                  zamestnanec.Email,
                  zamestnanec.Telefon.ToString()
                }));
                //ListViewItem item = new ListViewItem();
                //item.Text = uzivatel.Id.ToString();
                //item.SubItems.Add(uzivatel.Name);
                //item.SubItems.Add(book.Author);
                //item.SubItems.Add(book.PageCount.ToString());
                //item.SubItems.Add(book.Genre);
                //listViewBooks.Items.Add(item);
            }
        }
    }
}
