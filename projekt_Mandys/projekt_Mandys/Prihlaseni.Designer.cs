namespace projekt_Mandys
{
    partial class Prihlaseni
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
            this.btnPrihlasit = new System.Windows.Forms.Button();
            this.lblHeslo = new System.Windows.Forms.Label();
            this.lblJmeno = new System.Windows.Forms.Label();
            this.txtBoxHeslo = new System.Windows.Forms.TextBox();
            this.txtBoxJmeno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPrihlasit
            // 
            this.btnPrihlasit.Location = new System.Drawing.Point(145, 123);
            this.btnPrihlasit.Name = "btnPrihlasit";
            this.btnPrihlasit.Size = new System.Drawing.Size(75, 23);
            this.btnPrihlasit.TabIndex = 4;
            this.btnPrihlasit.Text = "Přihlásit";
            this.btnPrihlasit.UseVisualStyleBackColor = true;
            this.btnPrihlasit.Click += new System.EventHandler(this.btnPrihlasit_Click);
            // 
            // lblHeslo
            // 
            this.lblHeslo.AutoSize = true;
            this.lblHeslo.Location = new System.Drawing.Point(12, 83);
            this.lblHeslo.Name = "lblHeslo";
            this.lblHeslo.Size = new System.Drawing.Size(34, 13);
            this.lblHeslo.TabIndex = 1;
            this.lblHeslo.Text = "Heslo";
            // 
            // lblJmeno
            // 
            this.lblJmeno.AutoSize = true;
            this.lblJmeno.Location = new System.Drawing.Point(12, 42);
            this.lblJmeno.Name = "lblJmeno";
            this.lblJmeno.Size = new System.Drawing.Size(93, 13);
            this.lblJmeno.TabIndex = 0;
            this.lblJmeno.Text = "Uživatelské jméno";
            // 
            // txtBoxHeslo
            // 
            this.txtBoxHeslo.Location = new System.Drawing.Point(128, 76);
            this.txtBoxHeslo.Name = "txtBoxHeslo";
            this.txtBoxHeslo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHeslo.TabIndex = 3;
            // 
            // txtBoxJmeno
            // 
            this.txtBoxJmeno.Location = new System.Drawing.Point(128, 39);
            this.txtBoxJmeno.Name = "txtBoxJmeno";
            this.txtBoxJmeno.Size = new System.Drawing.Size(100, 20);
            this.txtBoxJmeno.TabIndex = 2;
            // 
            // Prihlaseni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 181);
            this.Controls.Add(this.btnPrihlasit);
            this.Controls.Add(this.txtBoxHeslo);
            this.Controls.Add(this.txtBoxJmeno);
            this.Controls.Add(this.lblHeslo);
            this.Controls.Add(this.lblJmeno);
            this.Name = "Prihlaseni";
            this.Text = "Prihlaseni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrihlasit;
        private System.Windows.Forms.Label lblHeslo;
        private System.Windows.Forms.Label lblJmeno;
        private System.Windows.Forms.TextBox txtBoxHeslo;
        private System.Windows.Forms.TextBox txtBoxJmeno;
    }
}