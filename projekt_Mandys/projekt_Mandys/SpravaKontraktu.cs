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
    public partial class SpravaKontraktu : Form
    {
        public SpravaKontraktu()
        {
            InitializeComponent();
            UpdateKontraktuView();
        }

        public void UpdateKontraktuView()
        {
            listViewSpravaKontraktu.Items.Clear();

            foreach (Kontrakt kontrakt in SqlRepository.ShowKontrakt())
            {
                listViewSpravaKontraktu.Items.Add(new ListViewItem(new string[]
                {
                  kontrakt.IdKontraktu.ToString(),
                  kontrakt.Zakaznik,
                  kontrakt.Popis,
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


        private void btnPridaniKontraktu_Click(object sender, EventArgs e)
        {
            PridaniKontraktu pridaniKontraktu = new PridaniKontraktu(this);
            pridaniKontraktu.ShowDialog();
        }

        private void btnUpravaKontraktu_Click(object sender, EventArgs e)
        {
            UpravaKontraktu upravaKontraktu = new UpravaKontraktu(Convert.ToInt32(listViewSpravaKontraktu.SelectedItems[0].SubItems[0].Text), this);
            upravaKontraktu.ShowDialog();
        }
    }
}
