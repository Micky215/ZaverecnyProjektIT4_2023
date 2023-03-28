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
            this.listViewUzivatele = new System.Windows.Forms.ListView();
            this.idUzivatele = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idZamestnance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jmeno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heslo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPridaniUzivatele = new System.Windows.Forms.Button();
            this.btnEditaceUzivatele = new System.Windows.Forms.Button();
            this.btnMazaniUzivatele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewUzivatele
            // 
            this.listViewUzivatele.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idUzivatele,
            this.idZamestnance,
            this.jmeno,
            this.heslo,
            this.role});
            this.listViewUzivatele.FullRowSelect = true;
            this.listViewUzivatele.GridLines = true;
            this.listViewUzivatele.HideSelection = false;
            this.listViewUzivatele.Location = new System.Drawing.Point(12, 12);
            this.listViewUzivatele.MultiSelect = false;
            this.listViewUzivatele.Name = "listViewUzivatele";
            this.listViewUzivatele.Size = new System.Drawing.Size(665, 426);
            this.listViewUzivatele.TabIndex = 0;
            this.listViewUzivatele.UseCompatibleStateImageBehavior = false;
            this.listViewUzivatele.View = System.Windows.Forms.View.Details;
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
            // btnPridaniUzivatele
            // 
            this.btnPridaniUzivatele.Location = new System.Drawing.Point(683, 40);
            this.btnPridaniUzivatele.Name = "btnPridaniUzivatele";
            this.btnPridaniUzivatele.Size = new System.Drawing.Size(111, 32);
            this.btnPridaniUzivatele.TabIndex = 1;
            this.btnPridaniUzivatele.Text = "Přidání uživatele";
            this.btnPridaniUzivatele.UseVisualStyleBackColor = true;
            this.btnPridaniUzivatele.Click += new System.EventHandler(this.btnPridaniUzivatele_Click);
            // 
            // btnEditaceUzivatele
            // 
            this.btnEditaceUzivatele.Location = new System.Drawing.Point(683, 147);
            this.btnEditaceUzivatele.Name = "btnEditaceUzivatele";
            this.btnEditaceUzivatele.Size = new System.Drawing.Size(111, 32);
            this.btnEditaceUzivatele.TabIndex = 2;
            this.btnEditaceUzivatele.Text = "Upravit uživatele";
            this.btnEditaceUzivatele.UseVisualStyleBackColor = true;
            this.btnEditaceUzivatele.Click += new System.EventHandler(this.btnEditaceUzivatele_Click);
            // 
            // btnMazaniUzivatele
            // 
            this.btnMazaniUzivatele.Location = new System.Drawing.Point(683, 258);
            this.btnMazaniUzivatele.Name = "btnMazaniUzivatele";
            this.btnMazaniUzivatele.Size = new System.Drawing.Size(111, 32);
            this.btnMazaniUzivatele.TabIndex = 3;
            this.btnMazaniUzivatele.Text = "Smazat uživatele";
            this.btnMazaniUzivatele.UseVisualStyleBackColor = true;
            this.btnMazaniUzivatele.Click += new System.EventHandler(this.btnMazaniUzivatele_Click);
            // 
            // SpravaUzivatelu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMazaniUzivatele);
            this.Controls.Add(this.btnEditaceUzivatele);
            this.Controls.Add(this.btnPridaniUzivatele);
            this.Controls.Add(this.listViewUzivatele);
            this.Name = "SpravaUzivatelu";
            this.Text = "SpravaUzivatelu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewUzivatele;
        private System.Windows.Forms.ColumnHeader idUzivatele;
        private System.Windows.Forms.ColumnHeader idZamestnance;
        private System.Windows.Forms.ColumnHeader jmeno;
        private System.Windows.Forms.ColumnHeader heslo;
        private System.Windows.Forms.ColumnHeader role;
        private System.Windows.Forms.Button btnPridaniUzivatele;
        private System.Windows.Forms.Button btnEditaceUzivatele;
        private System.Windows.Forms.Button btnMazaniUzivatele;
    }
}