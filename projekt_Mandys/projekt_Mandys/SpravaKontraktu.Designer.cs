namespace projekt_Mandys
{
    partial class SpravaKontraktu
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
            this.listViewSpravaKontraktu = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zakaznik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.popis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPridaniKontraktu = new System.Windows.Forms.Button();
            this.btnUpravaKontraktu = new System.Windows.Forms.Button();
            this.btnMazaniKontraktu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSpravaKontraktu
            // 
            this.listViewSpravaKontraktu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.zakaznik,
            this.popis});
            this.listViewSpravaKontraktu.FullRowSelect = true;
            this.listViewSpravaKontraktu.GridLines = true;
            this.listViewSpravaKontraktu.HideSelection = false;
            this.listViewSpravaKontraktu.Location = new System.Drawing.Point(12, 12);
            this.listViewSpravaKontraktu.MultiSelect = false;
            this.listViewSpravaKontraktu.Name = "listViewSpravaKontraktu";
            this.listViewSpravaKontraktu.Size = new System.Drawing.Size(648, 426);
            this.listViewSpravaKontraktu.TabIndex = 0;
            this.listViewSpravaKontraktu.UseCompatibleStateImageBehavior = false;
            this.listViewSpravaKontraktu.View = System.Windows.Forms.View.Details;
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
            this.popis.Width = 400;
            // 
            // btnPridaniKontraktu
            // 
            this.btnPridaniKontraktu.Location = new System.Drawing.Point(673, 54);
            this.btnPridaniKontraktu.Name = "btnPridaniKontraktu";
            this.btnPridaniKontraktu.Size = new System.Drawing.Size(115, 31);
            this.btnPridaniKontraktu.TabIndex = 1;
            this.btnPridaniKontraktu.Text = "Přidání kontraktu";
            this.btnPridaniKontraktu.UseVisualStyleBackColor = true;
            this.btnPridaniKontraktu.Click += new System.EventHandler(this.btnPridaniKontraktu_Click);
            // 
            // btnUpravaKontraktu
            // 
            this.btnUpravaKontraktu.Location = new System.Drawing.Point(673, 132);
            this.btnUpravaKontraktu.Name = "btnUpravaKontraktu";
            this.btnUpravaKontraktu.Size = new System.Drawing.Size(115, 31);
            this.btnUpravaKontraktu.TabIndex = 2;
            this.btnUpravaKontraktu.Text = "Úprava kontraktů";
            this.btnUpravaKontraktu.UseVisualStyleBackColor = true;
            this.btnUpravaKontraktu.Click += new System.EventHandler(this.btnUpravaKontraktu_Click);
            // 
            // btnMazaniKontraktu
            // 
            this.btnMazaniKontraktu.Location = new System.Drawing.Point(673, 211);
            this.btnMazaniKontraktu.Name = "btnMazaniKontraktu";
            this.btnMazaniKontraktu.Size = new System.Drawing.Size(115, 31);
            this.btnMazaniKontraktu.TabIndex = 3;
            this.btnMazaniKontraktu.Text = "Smazání kontraktů";
            this.btnMazaniKontraktu.UseVisualStyleBackColor = true;
            // 
            // SpravaKontraktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMazaniKontraktu);
            this.Controls.Add(this.btnUpravaKontraktu);
            this.Controls.Add(this.btnPridaniKontraktu);
            this.Controls.Add(this.listViewSpravaKontraktu);
            this.Name = "SpravaKontraktu";
            this.Text = "SpravaKontraktu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSpravaKontraktu;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader zakaznik;
        private System.Windows.Forms.ColumnHeader popis;
        private System.Windows.Forms.Button btnPridaniKontraktu;
        private System.Windows.Forms.Button btnUpravaKontraktu;
        private System.Windows.Forms.Button btnMazaniKontraktu;
    }
}