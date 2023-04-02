namespace projekt_Mandys
{
    partial class UzivatelForm
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
            this.listViewPohledZakaznika = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PocetHodin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idZamestnance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idKontraktu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idPrace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewPohledZakaznika
            // 
            this.listViewPohledZakaznika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.PocetHodin,
            this.datum,
            this.idZamestnance,
            this.idKontraktu,
            this.idPrace});
            this.listViewPohledZakaznika.FullRowSelect = true;
            this.listViewPohledZakaznika.GridLines = true;
            this.listViewPohledZakaznika.HideSelection = false;
            this.listViewPohledZakaznika.Location = new System.Drawing.Point(12, 12);
            this.listViewPohledZakaznika.MultiSelect = false;
            this.listViewPohledZakaznika.Name = "listViewPohledZakaznika";
            this.listViewPohledZakaznika.Size = new System.Drawing.Size(666, 426);
            this.listViewPohledZakaznika.TabIndex = 0;
            this.listViewPohledZakaznika.UseCompatibleStateImageBehavior = false;
            this.listViewPohledZakaznika.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // PocetHodin
            // 
            this.PocetHodin.Text = "Počet hodin";
            this.PocetHodin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PocetHodin.Width = 100;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datum.Width = 100;
            // 
            // idZamestnance
            // 
            this.idZamestnance.Text = "ID zaměstnance";
            this.idZamestnance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idZamestnance.Width = 100;
            // 
            // idKontraktu
            // 
            this.idKontraktu.Text = "ID kontraktu";
            this.idKontraktu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idKontraktu.Width = 100;
            // 
            // idPrace
            // 
            this.idPrace.Text = "ID práce";
            this.idPrace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idPrace.Width = 100;
            // 
            // UzivatelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewPohledZakaznika);
            this.Name = "UzivatelForm";
            this.Text = "UzivatelForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPohledZakaznika;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader PocetHodin;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader idZamestnance;
        private System.Windows.Forms.ColumnHeader idKontraktu;
        private System.Windows.Forms.ColumnHeader idPrace;
    }
}