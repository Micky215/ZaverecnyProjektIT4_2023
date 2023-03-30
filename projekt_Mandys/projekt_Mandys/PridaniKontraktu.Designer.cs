namespace projekt_Mandys
{
    partial class PridaniKontraktu
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
            this.LabelZakaznik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPridaniNazvuKontraktu = new System.Windows.Forms.TextBox();
            this.txtBoxPridaniPopisuKontraktu = new System.Windows.Forms.TextBox();
            this.btnPridatKontrakt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelZakaznik
            // 
            this.LabelZakaznik.AutoSize = true;
            this.LabelZakaznik.Location = new System.Drawing.Point(26, 80);
            this.LabelZakaznik.Name = "LabelZakaznik";
            this.LabelZakaznik.Size = new System.Drawing.Size(53, 13);
            this.LabelZakaznik.TabIndex = 0;
            this.LabelZakaznik.Text = "Zákazník";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Popis kontraktu";
            // 
            // txtBoxPridaniNazvuKontraktu
            // 
            this.txtBoxPridaniNazvuKontraktu.Location = new System.Drawing.Point(139, 80);
            this.txtBoxPridaniNazvuKontraktu.Name = "txtBoxPridaniNazvuKontraktu";
            this.txtBoxPridaniNazvuKontraktu.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPridaniNazvuKontraktu.TabIndex = 2;
            // 
            // txtBoxPridaniPopisuKontraktu
            // 
            this.txtBoxPridaniPopisuKontraktu.Location = new System.Drawing.Point(139, 126);
            this.txtBoxPridaniPopisuKontraktu.Name = "txtBoxPridaniPopisuKontraktu";
            this.txtBoxPridaniPopisuKontraktu.Size = new System.Drawing.Size(282, 20);
            this.txtBoxPridaniPopisuKontraktu.TabIndex = 3;
            // 
            // btnPridatKontrakt
            // 
            this.btnPridatKontrakt.Location = new System.Drawing.Point(335, 177);
            this.btnPridatKontrakt.Name = "btnPridatKontrakt";
            this.btnPridatKontrakt.Size = new System.Drawing.Size(86, 27);
            this.btnPridatKontrakt.TabIndex = 4;
            this.btnPridatKontrakt.Text = "Přidat kontrakt";
            this.btnPridatKontrakt.UseVisualStyleBackColor = true;
            this.btnPridatKontrakt.Click += new System.EventHandler(this.btnPridatKontrakt_Click);
            // 
            // PridaniKontraktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 232);
            this.Controls.Add(this.btnPridatKontrakt);
            this.Controls.Add(this.txtBoxPridaniPopisuKontraktu);
            this.Controls.Add(this.txtBoxPridaniNazvuKontraktu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelZakaznik);
            this.Name = "PridaniKontraktu";
            this.Text = "PridaniKontraktu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelZakaznik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPridaniNazvuKontraktu;
        private System.Windows.Forms.TextBox txtBoxPridaniPopisuKontraktu;
        private System.Windows.Forms.Button btnPridatKontrakt;
    }
}