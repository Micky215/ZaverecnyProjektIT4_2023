namespace projekt_Mandys
{
    partial class PridaniZamestnance
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
            this.LabelKrestniJmeno = new System.Windows.Forms.Label();
            this.txtBoxKrestniJmeno = new System.Windows.Forms.TextBox();
            this.txtBoxPrijmeni = new System.Windows.Forms.TextBox();
            this.txtBoxDatumNarozeni = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.LabelPrijmeni = new System.Windows.Forms.Label();
            this.LabelDatumNarozeni = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelTelefon = new System.Windows.Forms.Label();
            this.txtBoxTelefon = new System.Windows.Forms.TextBox();
            this.btnVytvoritZamestnance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelKrestniJmeno
            // 
            this.LabelKrestniJmeno.AutoSize = true;
            this.LabelKrestniJmeno.Location = new System.Drawing.Point(59, 59);
            this.LabelKrestniJmeno.Name = "LabelKrestniJmeno";
            this.LabelKrestniJmeno.Size = new System.Drawing.Size(73, 13);
            this.LabelKrestniJmeno.TabIndex = 0;
            this.LabelKrestniJmeno.Text = "Křestní jméno";
            // 
            // txtBoxKrestniJmeno
            // 
            this.txtBoxKrestniJmeno.Location = new System.Drawing.Point(182, 56);
            this.txtBoxKrestniJmeno.Name = "txtBoxKrestniJmeno";
            this.txtBoxKrestniJmeno.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKrestniJmeno.TabIndex = 1;
            // 
            // txtBoxPrijmeni
            // 
            this.txtBoxPrijmeni.Location = new System.Drawing.Point(182, 102);
            this.txtBoxPrijmeni.Name = "txtBoxPrijmeni";
            this.txtBoxPrijmeni.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrijmeni.TabIndex = 2;
            // 
            // txtBoxDatumNarozeni
            // 
            this.txtBoxDatumNarozeni.Location = new System.Drawing.Point(182, 143);
            this.txtBoxDatumNarozeni.Name = "txtBoxDatumNarozeni";
            this.txtBoxDatumNarozeni.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDatumNarozeni.TabIndex = 3;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(182, 189);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEmail.TabIndex = 4;
            // 
            // LabelPrijmeni
            // 
            this.LabelPrijmeni.AutoSize = true;
            this.LabelPrijmeni.Location = new System.Drawing.Point(59, 102);
            this.LabelPrijmeni.Name = "LabelPrijmeni";
            this.LabelPrijmeni.Size = new System.Drawing.Size(48, 13);
            this.LabelPrijmeni.TabIndex = 5;
            this.LabelPrijmeni.Text = "Příjmení";
            // 
            // LabelDatumNarozeni
            // 
            this.LabelDatumNarozeni.AutoSize = true;
            this.LabelDatumNarozeni.Location = new System.Drawing.Point(59, 146);
            this.LabelDatumNarozeni.Name = "LabelDatumNarozeni";
            this.LabelDatumNarozeni.Size = new System.Drawing.Size(83, 13);
            this.LabelDatumNarozeni.TabIndex = 6;
            this.LabelDatumNarozeni.Text = "Datum narození";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(59, 189);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(35, 13);
            this.LabelEmail.TabIndex = 7;
            this.LabelEmail.Text = "E-mail";
            // 
            // LabelTelefon
            // 
            this.LabelTelefon.AutoSize = true;
            this.LabelTelefon.Location = new System.Drawing.Point(59, 230);
            this.LabelTelefon.Name = "LabelTelefon";
            this.LabelTelefon.Size = new System.Drawing.Size(43, 13);
            this.LabelTelefon.TabIndex = 8;
            this.LabelTelefon.Text = "Telefon";
            // 
            // txtBoxTelefon
            // 
            this.txtBoxTelefon.Location = new System.Drawing.Point(182, 230);
            this.txtBoxTelefon.Name = "txtBoxTelefon";
            this.txtBoxTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTelefon.TabIndex = 9;
            // 
            // btnVytvoritZamestnance
            // 
            this.btnVytvoritZamestnance.Location = new System.Drawing.Point(207, 300);
            this.btnVytvoritZamestnance.Name = "btnVytvoritZamestnance";
            this.btnVytvoritZamestnance.Size = new System.Drawing.Size(75, 23);
            this.btnVytvoritZamestnance.TabIndex = 10;
            this.btnVytvoritZamestnance.Text = "Přidat";
            this.btnVytvoritZamestnance.UseVisualStyleBackColor = true;
            this.btnVytvoritZamestnance.Click += new System.EventHandler(this.btnVytvoritZamestnance_Click);
            // 
            // PridaniZamestnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 344);
            this.Controls.Add(this.btnVytvoritZamestnance);
            this.Controls.Add(this.txtBoxTelefon);
            this.Controls.Add(this.LabelTelefon);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelDatumNarozeni);
            this.Controls.Add(this.LabelPrijmeni);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxDatumNarozeni);
            this.Controls.Add(this.txtBoxPrijmeni);
            this.Controls.Add(this.txtBoxKrestniJmeno);
            this.Controls.Add(this.LabelKrestniJmeno);
            this.Name = "PridaniZamestnance";
            this.Text = "PridaniZamestnance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelKrestniJmeno;
        private System.Windows.Forms.TextBox txtBoxKrestniJmeno;
        private System.Windows.Forms.TextBox txtBoxPrijmeni;
        private System.Windows.Forms.TextBox txtBoxDatumNarozeni;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label LabelPrijmeni;
        private System.Windows.Forms.Label LabelDatumNarozeni;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelTelefon;
        private System.Windows.Forms.TextBox txtBoxTelefon;
        private System.Windows.Forms.Button btnVytvoritZamestnance;
    }
}