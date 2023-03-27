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

        private void UpdateSpravaRoli()
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
    }
}
