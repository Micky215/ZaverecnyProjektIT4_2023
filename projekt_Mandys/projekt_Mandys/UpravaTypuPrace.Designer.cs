namespace projekt_Mandys
{
    partial class UpravaTypuPrace
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
            this.LabelUpravitNazevPrace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpravitPraci = new System.Windows.Forms.Button();
            this.txtBoxUpravaNazvuPrace = new System.Windows.Forms.TextBox();
            this.txtBoxUpravaPopisuPrace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelUpravitNazevPrace
            // 
            this.LabelUpravitNazevPrace.AutoSize = true;
            this.LabelUpravitNazevPrace.Location = new System.Drawing.Point(49, 69);
            this.LabelUpravitNazevPrace.Name = "LabelUpravitNazevPrace";
            this.LabelUpravitNazevPrace.Size = new System.Drawing.Size(38, 13);
            this.LabelUpravitNazevPrace.TabIndex = 0;
            this.LabelUpravitNazevPrace.Text = "Název";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Popis";
            // 
            // btnUpravitPraci
            // 
            this.btnUpravitPraci.Location = new System.Drawing.Point(346, 180);
            this.btnUpravitPraci.Name = "btnUpravitPraci";
            this.btnUpravitPraci.Size = new System.Drawing.Size(88, 31);
            this.btnUpravitPraci.TabIndex = 2;
            this.btnUpravitPraci.Text = "Upravit";
            this.btnUpravitPraci.UseVisualStyleBackColor = true;
            this.btnUpravitPraci.Click += new System.EventHandler(this.btnUpravitPraci_Click);
            // 
            // txtBoxUpravaNazvuPrace
            // 
            this.txtBoxUpravaNazvuPrace.Location = new System.Drawing.Point(132, 69);
            this.txtBoxUpravaNazvuPrace.Name = "txtBoxUpravaNazvuPrace";
            this.txtBoxUpravaNazvuPrace.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUpravaNazvuPrace.TabIndex = 3;
            // 
            // txtBoxUpravaPopisuPrace
            // 
            this.txtBoxUpravaPopisuPrace.Location = new System.Drawing.Point(132, 116);
            this.txtBoxUpravaPopisuPrace.Name = "txtBoxUpravaPopisuPrace";
            this.txtBoxUpravaPopisuPrace.Size = new System.Drawing.Size(302, 20);
            this.txtBoxUpravaPopisuPrace.TabIndex = 4;
            // 
            // UpravaTypuPrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 223);
            this.Controls.Add(this.txtBoxUpravaPopisuPrace);
            this.Controls.Add(this.txtBoxUpravaNazvuPrace);
            this.Controls.Add(this.btnUpravitPraci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelUpravitNazevPrace);
            this.Name = "UpravaTypuPrace";
            this.Text = "UpravaTypuPrace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUpravitNazevPrace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpravitPraci;
        private System.Windows.Forms.TextBox txtBoxUpravaNazvuPrace;
        private System.Windows.Forms.TextBox txtBoxUpravaPopisuPrace;
    }
}