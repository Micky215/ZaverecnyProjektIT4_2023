namespace projekt_Mandys
{
    partial class SpravaUzivatelu
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.idUzivatele = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idZamestnance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jmeno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heslo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idUzivatele,
            this.idZamestnance,
            this.jmeno,
            this.heslo,
            this.role});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(665, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idUzivatele
            // 
            this.idUzivatele.Text = "ID uživatele";
            // 
            // idZamestnance
            // 
            this.idZamestnance.Text = "ID zaměstnance";
            this.idZamestnance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // jmeno
            // 
            this.jmeno.Text = "Jméno";
            this.jmeno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // heslo
            // 
            this.heslo.Text = "Heslo";
            this.heslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // role
            // 
            this.role.Text = "Role";
            this.role.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SpravaUzivatelu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "SpravaUzivatelu";
            this.Text = "SpravaUzivatelu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idUzivatele;
        private System.Windows.Forms.ColumnHeader idZamestnance;
        private System.Windows.Forms.ColumnHeader jmeno;
        private System.Windows.Forms.ColumnHeader heslo;
        private System.Windows.Forms.ColumnHeader role;
    }
}