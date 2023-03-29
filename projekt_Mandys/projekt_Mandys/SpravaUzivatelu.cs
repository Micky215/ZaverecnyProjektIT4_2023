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
    public partial class SpravaUzivatelu : Form
    {
        public SpravaUzivatelu()
        {
            InitializeComponent();
            UpdateUzivatelView();
        }

        public void UpdateUzivatelView()
        {
            listViewUzivatele.Items.Clear();

            foreach (Uzivatel uzivatel in SqlRepository.ShowUzivatele())
            {
                listViewUzivatele.Items.Add(new ListViewItem(new string[] 
                { 
                  uzivatel.Id.ToString(), 
                  uzivatel.IdZamestnance.ToString(),
                  uzivatel.Jmeno, 
                  uzivatel.Heslo,
                  uzivatel.Role.ToString() 
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

        private void btnMazaniUzivatele_Click(object sender, EventArgs e)
        {
            SqlRepository.RemoveUzivateleByID(int.Parse(listViewUzivatele.SelectedItems[0].Text));
            UpdateUzivatelView();
        }

        private void btnPridaniUzivatele_Click(object sender, EventArgs e)
        {
            PridaniUzivateleForm pridaniUzivateleForm = new PridaniUzivateleForm(this);
            pridaniUzivateleForm.ShowDialog();
        }

        private void btnEditaceUzivatele_Click(object sender, EventArgs e)
        {
            UpravaZamestnance upravaZamestnance = new UpravaZamestnance(this);
            upravaZamestnance.ShowDialog();
        }
    }
}
