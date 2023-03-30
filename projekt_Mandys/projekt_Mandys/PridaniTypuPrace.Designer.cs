namespace projekt_Mandys
{
    partial class PridaniTypuPrace
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
            this.LabelNazevPrace = new System.Windows.Forms.Label();
            this.LabelPopis = new System.Windows.Forms.Label();
            this.btnPridatTypPrace = new System.Windows.Forms.Button();
            this.txtBoxPridaniNazvuPrace = new System.Windows.Forms.TextBox();
            this.txtBoxPridaniPopisuPrace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelNazevPrace
            // 
            this.LabelNazevPrace.AutoSize = true;
            this.LabelNazevPrace.Location = new System.Drawing.Point(29, 63);
            this.LabelNazevPrace.Name = "LabelNazevPrace";
            this.LabelNazevPrace.Size = new System.Drawing.Size(68, 13);
            this.LabelNazevPrace.TabIndex = 0;
            this.LabelNazevPrace.Text = "Název práce";
            // 
            // LabelPopis
            // 
            this.LabelPopis.AutoSize = true;
            this.LabelPopis.Location = new System.Drawing.Point(29, 117);
            this.LabelPopis.Name = "LabelPopis";
            this.LabelPopis.Size = new System.Drawing.Size(63, 13);
            this.LabelPopis.TabIndex = 1;
            this.LabelPopis.Text = "Popis práce";
            // 
            // btnPridatTypPrace
            // 
            this.btnPridatTypPrace.Location = new System.Drawing.Point(291, 179);
            this.btnPridatTypPrace.Name = "btnPridatTypPrace";
            this.btnPridatTypPrace.Size = new System.Drawing.Size(97, 31);
            this.btnPridatTypPrace.TabIndex = 2;
            this.btnPridatTypPrace.Text = "Přidat";
            this.btnPridatTypPrace.UseVisualStyleBackColor = true;
            this.btnPridatTypPrace.Click += new System.EventHandler(this.btnPridatTypPrace_Click);
            // 
            // txtBoxPridaniNazvuPrace
            // 
            this.txtBoxPridaniNazvuPrace.Location = new System.Drawing.Point(115, 60);
            this.txtBoxPridaniNazvuPrace.Name = "txtBoxPridaniNazvuPrace";
            this.txtBoxPridaniNazvuPrace.Size = new System.Drawing.Size(115, 20);
            this.txtBoxPridaniNazvuPrace.TabIndex = 3;
            // 
            // txtBoxPridaniPopisuPrace
            // 
            this.txtBoxPridaniPopisuPrace.Location = new System.Drawing.Point(115, 114);
            this.txtBoxPridaniPopisuPrace.Name = "txtBoxPridaniPopisuPrace";
            this.txtBoxPridaniPopisuPrace.Size = new System.Drawing.Size(300, 20);
            this.txtBoxPridaniPopisuPrace.TabIndex = 4;
            // 
            // PridaniTypuPrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 227);
            this.Controls.Add(this.txtBoxPridaniPopisuPrace);
            this.Controls.Add(this.txtBoxPridaniNazvuPrace);
            this.Controls.Add(this.btnPridatTypPrace);
            this.Controls.Add(this.LabelPopis);
            this.Controls.Add(this.LabelNazevPrace);
            this.Name = "PridaniTypuPrace";
            this.Text = "PridaniTypuPrace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNazevPrace;
        private System.Windows.Forms.Label LabelPopis;
        private System.Windows.Forms.Button btnPridatTypPrace;
        private System.Windows.Forms.TextBox txtBoxPridaniNazvuPrace;
        private System.Windows.Forms.TextBox txtBoxPridaniPopisuPrace;
    }
}