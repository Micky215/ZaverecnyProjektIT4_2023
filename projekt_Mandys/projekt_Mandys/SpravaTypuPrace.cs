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
    public partial class SpravaTypuPrace : Form
    {
        public SpravaTypuPrace()
        {
            InitializeComponent();
            UpdateSpravaTypuPrace();
        }

        public void UpdateSpravaTypuPrace()
        {
            listViewTypyPraci.Items.Clear();

            foreach (TypPrace prace in SqlRepository.ShowTypyPrace())
            {
                listViewTypyPraci.Items.Add(new ListViewItem(new string[]
                {
                  prace.Id.ToString(),
                  prace.Nazev,
                  prace.Popis

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

        private void btnPridatTypPrace_Click(object sender, EventArgs e)
        {
            PridaniTypuPrace pridaniTypuPrace = new PridaniTypuPrace(this);
            pridaniTypuPrace.ShowDialog();
        }

        private void btnUpravitTypPrace_Click(object sender, EventArgs e)
        {
            UpravaTypuPrace upravaPrace = new UpravaTypuPrace(Convert.ToInt32(listViewTypyPraci.SelectedItems[0].SubItems[0].Text), this);
            upravaPrace.ShowDialog();
        }

        private void btnSmazatTypPrace_Click(object sender, EventArgs e)
        {
            SqlRepository.RemoveTypPraceByID(int.Parse(listViewTypyPraci.SelectedItems[0].Text));
            UpdateSpravaTypuPrace();
        }
    }
}
