namespace projekt_Mandys
{
    partial class UpravaKontraktu
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
            this.btnUpravitKontrakt = new System.Windows.Forms.Button();
            this.LabelNazevKontraktu = new System.Windows.Forms.Label();
            this.LabelPopisKontraktu = new System.Windows.Forms.Label();
            this.txtBoxUpravitNazevKontraktu = new System.Windows.Forms.TextBox();
            this.txtBoxUpravaPopisuKontraktu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpravitKontrakt
            // 
            this.btnUpravitKontrakt.Location = new System.Drawing.Point(345, 221);
            this.btnUpravitKontrakt.Name = "btnUpravitKontrakt";
            this.btnUpravitKontrakt.Size = new System.Drawing.Size(95, 31);
            this.btnUpravitKontrakt.TabIndex = 0;
            this.btnUpravitKontrakt.Text = "Upravit kontrakt";
            this.btnUpravitKontrakt.UseVisualStyleBackColor = true;
            this.btnUpravitKontrakt.Click += new System.EventHandler(this.btnUpravitKontrakt_Click);
            // 
            // LabelNazevKontraktu
            // 
            this.LabelNazevKontraktu.AutoSize = true;
            this.LabelNazevKontraktu.Location = new System.Drawing.Point(37, 88);
            this.LabelNazevKontraktu.Name = "LabelNazevKontraktu";
            this.LabelNazevKontraktu.Size = new System.Drawing.Size(86, 13);
            this.LabelNazevKontraktu.TabIndex = 1;
            this.LabelNazevKontraktu.Text = "Název kontraktu";
            // 
            // LabelPopisKontraktu
            // 
            this.LabelPopisKontraktu.AutoSize = true;
            this.LabelPopisKontraktu.Location = new System.Drawing.Point(37, 157);
            this.LabelPopisKontraktu.Name = "LabelPopisKontraktu";
            this.LabelPopisKontraktu.Size = new System.Drawing.Size(81, 13);
            this.LabelPopisKontraktu.TabIndex = 2;
            this.LabelPopisKontraktu.Text = "Popis kontraktu";
            // 
            // txtBoxUpravitNazevKontraktu
            // 
            this.txtBoxUpravitNazevKontraktu.Location = new System.Drawing.Point(150, 88);
            this.txtBoxUpravitNazevKontraktu.Name = "txtBoxUpravitNazevKontraktu";
            this.txtBoxUpravitNazevKontraktu.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUpravitNazevKontraktu.TabIndex = 3;
            // 
            // txtBoxUpravaPopisuKontraktu
            // 
            this.txtBoxUpravaPopisuKontraktu.Location = new System.Drawing.Point(150, 157);
            this.txtBoxUpravaPopisuKontraktu.Name = "txtBoxUpravaPopisuKontraktu";
            this.txtBoxUpravaPopisuKontraktu.Size = new System.Drawing.Size(290, 20);
            this.txtBoxUpravaPopisuKontraktu.TabIndex = 4;
            // 
            // UpravaKontraktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 280);
            this.Controls.Add(this.txtBoxUpravaPopisuKontraktu);
            this.Controls.Add(this.txtBoxUpravitNazevKontraktu);
            this.Controls.Add(this.LabelPopisKontraktu);
            this.Controls.Add(this.LabelNazevKontraktu);
            this.Controls.Add(this.btnUpravitKontrakt);
            this.Name = "UpravaKontraktu";
            this.Text = "UpravaKontraktu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpravitKontrakt;
        private System.Windows.Forms.Label LabelNazevKontraktu;
        private System.Windows.Forms.Label LabelPopisKontraktu;
        private System.Windows.Forms.TextBox txtBoxUpravitNazevKontraktu;
        private System.Windows.Forms.TextBox txtBoxUpravaPopisuKontraktu;
    }
}