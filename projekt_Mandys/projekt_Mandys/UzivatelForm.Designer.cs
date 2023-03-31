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
            this.zakaznik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.popis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.odpracovaneHodiny = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewPohledZakaznika
            // 
            this.listViewPohledZakaznika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.zakaznik,
            this.popis,
            this.odpracovaneHodiny});
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
            // zakaznik
            // 
            this.zakaznik.Text = "Zákazník";
            this.zakaznik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zakaznik.Width = 150;
            // 
            // popis
            // 
            this.popis.Text = "Popis";
            this.popis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.popis.Width = 300;
            // 
            // odpracovaneHodiny
            // 
            this.odpracovaneHodiny.Text = "Odpracované hodiny";
            this.odpracovaneHodiny.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.odpracovaneHodiny.Width = 120;
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
        private System.Windows.Forms.ColumnHeader zakaznik;
        private System.Windows.Forms.ColumnHeader popis;
        private System.Windows.Forms.ColumnHeader odpracovaneHodiny;
    }
}