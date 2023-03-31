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
        }
    }
}
