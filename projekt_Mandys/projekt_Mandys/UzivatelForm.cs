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
    public partial class UzivatelForm : Form
    {
        public Uzivatel uzivatel { get; set; }
        public UzivatelForm(Uzivatel uzivatel)
        {
            InitializeComponent();
            this.uzivatel = uzivatel;
            UpdateUzivatelForm();
        }

        public void UpdateUzivatelForm()
        {
            listViewPohledZakaznika.Items.Clear();

            foreach (OdpracovaneHodiny odpracovaneHodiny in SqlRepository.ShowUzivatelForm())
            {
                listViewPohledZakaznika.Items.Add(new ListViewItem(new string[]
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

        //private void btnPridatZaznam_Click(object sender, EventArgs e)
        //{
        //    PridaniOdpracovanychHodin pridaniOdpracovanychHodin = new PridaniOdpracovanychHodin(this);
        //    pridaniOdpracovanychHodin.ShowDialog();
        //}
    }
}
