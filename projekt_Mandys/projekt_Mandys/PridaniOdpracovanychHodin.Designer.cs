namespace projekt_Mandys
{
    partial class PridaniOdpracovanychHodin
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
            this.LabelPocetHodin = new System.Windows.Forms.Label();
            this.LabelDatum = new System.Windows.Forms.Label();
            this.LabelIdZamestnance = new System.Windows.Forms.Label();
            this.LabelIdKontraktu = new System.Windows.Forms.Label();
            this.LabelIdPrace = new System.Windows.Forms.Label();
            this.txtBoxPocetHodin = new System.Windows.Forms.TextBox();
            this.txtBoxIdZamestnance = new System.Windows.Forms.TextBox();
            this.txtBoxIdKontraktu = new System.Windows.Forms.TextBox();
            this.txtBoxIdPrace = new System.Windows.Forms.TextBox();
            this.btnPridatOdpracovaneHodiny = new System.Windows.Forms.Button();
            this.txtBoxDatum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelPocetHodin
            // 
            this.LabelPocetHodin.AutoSize = true;
            this.LabelPocetHodin.Location = new System.Drawing.Point(36, 36);
            this.LabelPocetHodin.Name = "LabelPocetHodin";
            this.LabelPocetHodin.Size = new System.Drawing.Size(64, 13);
            this.LabelPocetHodin.TabIndex = 0;
            this.LabelPocetHodin.Text = "Počet hodin";
            // 
            // LabelDatum
            // 
            this.LabelDatum.AutoSize = true;
            this.LabelDatum.Location = new System.Drawing.Point(36, 79);
            this.LabelDatum.Name = "LabelDatum";
            this.LabelDatum.Size = new System.Drawing.Size(38, 13);
            this.LabelDatum.TabIndex = 1;
            this.LabelDatum.Text = "Datum";
            // 
            // LabelIdZamestnance
            // 
            this.LabelIdZamestnance.AutoSize = true;
            this.LabelIdZamestnance.Location = new System.Drawing.Point(36, 117);
            this.LabelIdZamestnance.Name = "LabelIdZamestnance";
            this.LabelIdZamestnance.Size = new System.Drawing.Size(84, 13);
            this.LabelIdZamestnance.TabIndex = 2;
            this.LabelIdZamestnance.Text = "ID zaměstnance";
            // 
            // LabelIdKontraktu
            // 
            this.LabelIdKontraktu.AutoSize = true;
            this.LabelIdKontraktu.Location = new System.Drawing.Point(36, 155);
            this.LabelIdKontraktu.Name = "LabelIdKontraktu";
            this.LabelIdKontraktu.Size = new System.Drawing.Size(66, 13);
            this.LabelIdKontraktu.TabIndex = 3;
            this.LabelIdKontraktu.Text = "ID kontraktu";
            // 
            // LabelIdPrace
            // 
            this.LabelIdPrace.AutoSize = true;
            this.LabelIdPrace.Location = new System.Drawing.Point(36, 195);
            this.LabelIdPrace.Name = "LabelIdPrace";
            this.LabelIdPrace.Size = new System.Drawing.Size(48, 13);
            this.LabelIdPrace.TabIndex = 4;
            this.LabelIdPrace.Text = "ID prace";
            // 
            // txtBoxPocetHodin
            // 
            this.txtBoxPocetHodin.Location = new System.Drawing.Point(188, 36);
            this.txtBoxPocetHodin.Name = "txtBoxPocetHodin";
            this.txtBoxPocetHodin.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPocetHodin.TabIndex = 5;
            // 
            // txtBoxIdZamestnance
            // 
            this.txtBoxIdZamestnance.Location = new System.Drawing.Point(188, 117);
            this.txtBoxIdZamestnance.Name = "txtBoxIdZamestnance";
            this.txtBoxIdZamestnance.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIdZamestnance.TabIndex = 6;
            // 
            // txtBoxIdKontraktu
            // 
            this.txtBoxIdKontraktu.Location = new System.Drawing.Point(188, 155);
            this.txtBoxIdKontraktu.Name = "txtBoxIdKontraktu";
            this.txtBoxIdKontraktu.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIdKontraktu.TabIndex = 7;
            // 
            // txtBoxIdPrace
            // 
            this.txtBoxIdPrace.Location = new System.Drawing.Point(188, 192);
            this.txtBoxIdPrace.Name = "txtBoxIdPrace";
            this.txtBoxIdPrace.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIdPrace.TabIndex = 8;
            // 
            // btnPridatOdpracovaneHodiny
            // 
            this.btnPridatOdpracovaneHodiny.Location = new System.Drawing.Point(285, 249);
            this.btnPridatOdpracovaneHodiny.Name = "btnPridatOdpracovaneHodiny";
            this.btnPridatOdpracovaneHodiny.Size = new System.Drawing.Size(75, 23);
            this.btnPridatOdpracovaneHodiny.TabIndex = 10;
            this.btnPridatOdpracovaneHodiny.Text = "Přidat";
            this.btnPridatOdpracovaneHodiny.UseVisualStyleBackColor = true;
            this.btnPridatOdpracovaneHodiny.Click += new System.EventHandler(this.btnPridatOdpracovaneHodiny_Click);
            // 
            // txtBoxDatum
            // 
            this.txtBoxDatum.Location = new System.Drawing.Point(188, 79);
            this.txtBoxDatum.Name = "txtBoxDatum";
            this.txtBoxDatum.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDatum.TabIndex = 11;
            // 
            // PridaniOdpracovanychHodin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 295);
            this.Controls.Add(this.txtBoxDatum);
            this.Controls.Add(this.btnPridatOdpracovaneHodiny);
            this.Controls.Add(this.txtBoxIdPrace);
            this.Controls.Add(this.txtBoxIdKontraktu);
            this.Controls.Add(this.txtBoxIdZamestnance);
            this.Controls.Add(this.txtBoxPocetHodin);
            this.Controls.Add(this.LabelIdPrace);
            this.Controls.Add(this.LabelIdKontraktu);
            this.Controls.Add(this.LabelIdZamestnance);
            this.Controls.Add(this.LabelDatum);
            this.Controls.Add(this.LabelPocetHodin);
            this.Name = "PridaniOdpracovanychHodin";
            this.Text = "PridaniOdpracovanychHodin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPocetHodin;
        private System.Windows.Forms.Label LabelDatum;
        private System.Windows.Forms.Label LabelIdZamestnance;
        private System.Windows.Forms.Label LabelIdKontraktu;
        private System.Windows.Forms.Label LabelIdPrace;
        private System.Windows.Forms.TextBox txtBoxPocetHodin;
        private System.Windows.Forms.TextBox txtBoxIdZamestnance;
        private System.Windows.Forms.TextBox txtBoxIdKontraktu;
        private System.Windows.Forms.TextBox txtBoxIdPrace;
        private System.Windows.Forms.Button btnPridatOdpracovaneHodiny;
        private System.Windows.Forms.TextBox txtBoxDatum;
    }
}