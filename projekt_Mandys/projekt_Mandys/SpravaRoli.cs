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
    public partial class SpravaRoli : Form
    {
        public SpravaRoli()
        {
            InitializeComponent();
            UpdateSpravaRoli();
        }

        public void UpdateSpravaRoli()
        {
            listViewRole.Items.Clear();

            foreach (Role role in SqlRepository.ShowRole())
            {
                listViewRole.Items.Add(new ListViewItem(new string[]
                {
                  role.IdRole.ToString(),
                  role.NazevRole
                
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

        private void btnPridaniRole_Click(object sender, EventArgs e)
        {
            PridaniRole pridaniRole = new PridaniRole(this);
            pridaniRole.ShowDialog();
        }

        private void btnSmazaniRole_Click(object sender, EventArgs e)
        {
            SqlRepository.RemoveRoleByID(int.Parse(listViewRole.SelectedItems[0].Text));
            UpdateSpravaRoli();
        }

        private void btnUpravaRole_Click(object sender, EventArgs e)
        {
            UpravaRole upravaRole = new UpravaRole(Convert.ToInt32(listViewRole.SelectedItems[0].SubItems[0].Text), this);
            upravaRole.ShowDialog();
        }
    }
}
