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
    public partial class SpravitOdpracovaneHodiny : Form
    {
        public SpravitOdpracovaneHodiny()
        {
            InitializeComponent();
            UpdateOdpracovaneHodiny();
        }

        public void UpdateOdpracovaneHodiny()
        {
            listViewOdpracovaneHodiny.Items.Clear();

            foreach (OdpracovaneHodiny odpracovaneHodiny in SqlRepository.ShowOdpracovaneHodiny())
            {
                listViewOdpracovaneHodiny.Items.Add(new ListViewItem(new string[]
                {
                  odpracovaneHodiny.Id.ToString(),
                  odpracovaneHodiny.PocetHodin.ToString(),
                  odpracovaneHodiny.Datum.ToShortDateString(),
                  odpracovaneHodiny.IdZamestnanci.ToString(),
                  odpracovaneHodiny.IdKontraktu.ToString(),
                  odpracovaneHodiny.IdPrace.ToString()
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

        private void btnPridatOdpracovaneHodiny_Click(object sender, EventArgs e)
        {
            PridaniOdpracovanychHodin pridaniOdpracovanychHodin = new PridaniOdpracovanychHodin(this);
            pridaniOdpracovanychHodin.ShowDialog();
        }

        private void btnUpravitOdpracovaneHodiny_Click(object sender, EventArgs e)
        {
            UpravaOdpracovanychHodin upravaOdpracovanychHodin = new UpravaOdpracovanychHodin(Convert.ToInt32(listViewOdpracovaneHodiny.SelectedItems[0].SubItems[0].Text), this);
            upravaOdpracovanychHodin.ShowDialog();
        }

        private void btnSmazatOdpracovaneHodiny_Click(object sender, EventArgs e)
        {
            SqlRepository.RemoveOdpracovaneHodinyByID(int.Parse(listViewOdpracovaneHodiny.SelectedItems[0].Text));
            UpdateOdpracovaneHodiny();
        }
    }
}
