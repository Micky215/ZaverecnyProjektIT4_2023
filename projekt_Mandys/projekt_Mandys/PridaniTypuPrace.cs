﻿using System;
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
    public partial class PridaniTypuPrace : Form
    {
        public SpravaTypuPrace Form { get; set; }

        public PridaniTypuPrace(SpravaTypuPrace form)
        {
            InitializeComponent();
            Form = form;
        }

        private void btnPridatTypPrace_Click(object sender, EventArgs e)
        {
            SqlRepository.AddTypuPrace(txtBoxPridaniNazvuPrace.Text, txtBoxPridaniPopisuPrace.Text);
            Form.UpdateSpravaTypuPrace();
            Close();
        }
    }
}
