namespace projekt_Mandys
{
    partial class UpravaUzivatele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_IdZamestnance = new System.Windows.Forms.Label();
            this.LabelJméno = new System.Windows.Forms.Label();
            this.LabelHeslo = new System.Windows.Forms.Label();
            this.LabelRole = new System.Windows.Forms.Label();
            this.txtBoxUpravaIdZamestnance = new System.Windows.Forms.TextBox();
            this.txtBoxUpravaJmena = new System.Windows.Forms.TextBox();
            this.txtBoxUpravaHesla = new System.Windows.Forms.TextBox();
            this.txtBoxUpravaRole = new System.Windows.Forms.TextBox();
            this.btnUpravitUzivatele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_IdZamestnance
            // 
            this.Label_IdZamestnance.AutoSize = true;
            this.Label_IdZamestnance.Location = new System.Drawing.Point(31, 65);
            this.Label_IdZamestnance.Name = "Label_IdZamestnance";
            this.Label_IdZamestnance.Size = new System.Drawing.Size(82, 13);
            this.Label_IdZamestnance.TabIndex = 0;
            this.Label_IdZamestnance.Text = "Id zaměstnance";
            // 
            // LabelJméno
            // 
            this.LabelJméno.AutoSize = true;
            this.LabelJméno.Location = new System.Drawing.Point(31, 114);
            this.LabelJméno.Name = "LabelJméno";
            this.LabelJméno.Size = new System.Drawing.Size(38, 13);
            this.LabelJméno.TabIndex = 1;
            this.LabelJméno.Text = "Jméno";
            // 
            // LabelHeslo
            // 
            this.LabelHeslo.AutoSize = true;
            this.LabelHeslo.Location = new System.Drawing.Point(31, 162);
            this.LabelHeslo.Name = "LabelHeslo";
            this.LabelHeslo.Size = new System.Drawing.Size(34, 13);
            this.LabelHeslo.TabIndex = 2;
            this.LabelHeslo.Text = "Heslo";
            // 
            // LabelRole
            // 
            this.LabelRole.AutoSize = true;
            this.LabelRole.Location = new System.Drawing.Point(31, 209);
            this.LabelRole.Name = "LabelRole";
            this.LabelRole.Size = new System.Drawing.Size(29, 13);
            this.LabelRole.TabIndex = 3;
            this.LabelRole.Text = "Role";
            // 
            // txtBoxUpravaIdZamestnance
            // 
            this.txtBoxUpravaIdZamestnance.Location = new System.Drawing.Point(130, 62);
            this.txtBoxUpravaIdZamestnance.Name = "txtBoxUpravaIdZamestnance";
            this.txtBoxUpravaIdZamestnance.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUpravaIdZamestnance.TabIndex = 4;
            // 
            // txtBoxUpravaJmena
            // 
            this.txtBoxUpravaJmena.Location = new System.Drawing.Point(130, 114);
            this.txtBoxUpravaJmena.Name = "txtBoxUpravaJmena";
            this.txtBoxUpravaJmena.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUpravaJmena.TabIndex = 5;
            // 
            // txtBoxUpravaHesla
            // 
            this.txtBoxUpravaHesla.Location = new System.Drawing.Point(130, 162);
            this.txtBoxUpravaHesla.Name = "txtBoxUpravaHesla";
            this.txtBoxUpravaHesla.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUpravaHesla.TabIndex = 6;
            // 
            // txtBoxUpravaRole
            // 
            this.txtBoxUpravaRole.Location = new System.Drawing.Point(130, 206);
            this.txtBoxUpravaRole.Name = "txtBoxUpravaRole";
            this.txtBoxUpravaRole.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUpravaRole.TabIndex = 7;
            // 
            // btnUpravitUzivatele
            // 
            this.btnUpravitUzivatele.Location = new System.Drawing.Point(155, 266);
            this.btnUpravitUzivatele.Name = "btnUpravitUzivatele";
            this.btnUpravitUzivatele.Size = new System.Drawing.Size(75, 23);
            this.btnUpravitUzivatele.TabIndex = 8;
            this.btnUpravitUzivatele.Text = "Upravit";
            this.btnUpravitUzivatele.UseVisualStyleBackColor = true;
            this.btnUpravitUzivatele.Click += new System.EventHandler(this.btnUpravitUzivatele_Click);
            // 
            // UpravaUzivatele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 316);
            this.Controls.Add(this.btnUpravitUzivatele);
            this.Controls.Add(this.txtBoxUpravaRole);
            this.Controls.Add(this.txtBoxUpravaHesla);
            this.Controls.Add(this.txtBoxUpravaJmena);
            this.Controls.Add(this.txtBoxUpravaIdZamestnance);
            this.Controls.Add(this.LabelRole);
            this.Controls.Add(this.LabelHeslo);
            this.Controls.Add(this.LabelJméno);
            this.Controls.Add(this.Label_IdZamestnance);
            this.Name = "UpravaUzivatele";
            this.Text = "UpravaUzivatele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_IdZamestnance;
        private System.Windows.Forms.Label LabelJméno;
        private System.Windows.Forms.Label LabelHeslo;
        private System.Windows.Forms.Label LabelRole;
        private System.Windows.Forms.TextBox txtBoxUpravaIdZamestnance;
        private System.Windows.Forms.TextBox txtBoxUpravaJmena;
        private System.Windows.Forms.TextBox txtBoxUpravaHesla;
        private System.Windows.Forms.TextBox txtBoxUpravaRole;
        private System.Windows.Forms.Button btnUpravitUzivatele;
    }
}