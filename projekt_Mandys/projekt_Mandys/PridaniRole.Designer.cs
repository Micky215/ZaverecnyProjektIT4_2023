namespace projekt_Mandys
{
    partial class PridaniRole
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
            this.btnPridatRoli = new System.Windows.Forms.Button();
            this.txtBoxNazevRoli = new System.Windows.Forms.TextBox();
            this.LabelNazevRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPridatRoli
            // 
            this.btnPridatRoli.Location = new System.Drawing.Point(114, 151);
            this.btnPridatRoli.Name = "btnPridatRoli";
            this.btnPridatRoli.Size = new System.Drawing.Size(75, 23);
            this.btnPridatRoli.TabIndex = 0;
            this.btnPridatRoli.Text = "Přidat";
            this.btnPridatRoli.UseVisualStyleBackColor = true;
            this.btnPridatRoli.Click += new System.EventHandler(this.btnPridatRoli_Click);
            // 
            // txtBoxNazevRoli
            // 
            this.txtBoxNazevRoli.Location = new System.Drawing.Point(88, 78);
            this.txtBoxNazevRoli.Name = "txtBoxNazevRoli";
            this.txtBoxNazevRoli.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNazevRoli.TabIndex = 1;
            // 
            // LabelNazevRole
            // 
            this.LabelNazevRole.AutoSize = true;
            this.LabelNazevRole.Location = new System.Drawing.Point(10, 81);
            this.LabelNazevRole.Name = "LabelNazevRole";
            this.LabelNazevRole.Size = new System.Drawing.Size(58, 13);
            this.LabelNazevRole.TabIndex = 2;
            this.LabelNazevRole.Text = "Název role";
            // 
            // PridaniRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 196);
            this.Controls.Add(this.LabelNazevRole);
            this.Controls.Add(this.txtBoxNazevRoli);
            this.Controls.Add(this.btnPridatRoli);
            this.Name = "PridaniRole";
            this.Text = "PridaniRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPridatRoli;
        private System.Windows.Forms.TextBox txtBoxNazevRoli;
        private System.Windows.Forms.Label LabelNazevRole;
    }
}