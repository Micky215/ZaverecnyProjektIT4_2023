namespace projekt_Mandys
{
    partial class UpravaRole
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
            this.LabelNazevRole = new System.Windows.Forms.Label();
            this.btnUpravaRole = new System.Windows.Forms.Button();
            this.txtBoxUpravaNazvuRole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelNazevRole
            // 
            this.LabelNazevRole.AutoSize = true;
            this.LabelNazevRole.Location = new System.Drawing.Point(26, 67);
            this.LabelNazevRole.Name = "LabelNazevRole";
            this.LabelNazevRole.Size = new System.Drawing.Size(58, 13);
            this.LabelNazevRole.TabIndex = 0;
            this.LabelNazevRole.Text = "Název role";
            // 
            // btnUpravaRole
            // 
            this.btnUpravaRole.Location = new System.Drawing.Point(122, 118);
            this.btnUpravaRole.Name = "btnUpravaRole";
            this.btnUpravaRole.Size = new System.Drawing.Size(75, 23);
            this.btnUpravaRole.TabIndex = 1;
            this.btnUpravaRole.Text = "Upravit";
            this.btnUpravaRole.UseVisualStyleBackColor = true;
            this.btnUpravaRole.Click += new System.EventHandler(this.btnUpravaRole_Click);
            // 
            // txtBoxUpravaNazvuRole
            // 
            this.txtBoxUpravaNazvuRole.Location = new System.Drawing.Point(97, 67);
            this.txtBoxUpravaNazvuRole.Name = "txtBoxUpravaNazvuRole";
            this.txtBoxUpravaNazvuRole.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUpravaNazvuRole.TabIndex = 2;
            // 
            // UpravaRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 191);
            this.Controls.Add(this.txtBoxUpravaNazvuRole);
            this.Controls.Add(this.btnUpravaRole);
            this.Controls.Add(this.LabelNazevRole);
            this.Name = "UpravaRole";
            this.Text = "UpravaRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNazevRole;
        private System.Windows.Forms.Button btnUpravaRole;
        private System.Windows.Forms.TextBox txtBoxUpravaNazvuRole;
    }
}