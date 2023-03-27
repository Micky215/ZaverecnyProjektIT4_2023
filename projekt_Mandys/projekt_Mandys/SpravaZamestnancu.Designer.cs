namespace projekt_Mandys
{
    partial class SpravaZamestnancu
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
            this.listViewZamestnanci = new System.Windows.Forms.ListView();
            this.IdZamestnance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KrestniJmeno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijmeni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumNarozeni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewZamestnanci
            // 
            this.listViewZamestnanci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdZamestnance,
            this.KrestniJmeno,
            this.Prijmeni,
            this.DatumNarozeni,
            this.Email,
            this.Telefon});
            this.listViewZamestnanci.GridLines = true;
            this.listViewZamestnanci.HideSelection = false;
            this.listViewZamestnanci.Location = new System.Drawing.Point(12, 12);
            this.listViewZamestnanci.Name = "listViewZamestnanci";
            this.listViewZamestnanci.Size = new System.Drawing.Size(671, 426);
            this.listViewZamestnanci.TabIndex = 0;
            this.listViewZamestnanci.UseCompatibleStateImageBehavior = false;
            this.listViewZamestnanci.View = System.Windows.Forms.View.Details;
            // 
            // IdZamestnance
            // 
            this.IdZamestnance.Text = "ID zaměstnance";
            this.IdZamestnance.Width = 100;
            // 
            // KrestniJmeno
            // 
            this.KrestniJmeno.Text = "Křestní jméno";
            this.KrestniJmeno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KrestniJmeno.Width = 100;
            // 
            // Prijmeni
            // 
            this.Prijmeni.Text = "Příjmení";
            this.Prijmeni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prijmeni.Width = 100;
            // 
            // DatumNarozeni
            // 
            this.DatumNarozeni.Text = "Datum narození";
            this.DatumNarozeni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DatumNarozeni.Width = 100;
            // 
            // Email
            // 
            this.Email.Text = "E-mail";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 100;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telefon.Width = 100;
            // 
            // SpravaZamestnancu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewZamestnanci);
            this.Name = "SpravaZamestnancu";
            this.Text = "SpravaZamestnancu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewZamestnanci;
        private System.Windows.Forms.ColumnHeader IdZamestnance;
        private System.Windows.Forms.ColumnHeader KrestniJmeno;
        private System.Windows.Forms.ColumnHeader Prijmeni;
        private System.Windows.Forms.ColumnHeader DatumNarozeni;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Telefon;
    }
}