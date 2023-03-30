namespace projekt_Mandys
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSpravaUzivatelu = new System.Windows.Forms.Button();
            this.btnSpravaTypuPrace = new System.Windows.Forms.Button();
            this.btnSpravaKontraktu = new System.Windows.Forms.Button();
            this.btnSpravaZamestnancu = new System.Windows.Forms.Button();
            this.btnSpravaRoli = new System.Windows.Forms.Button();
            this.btnSpravaOdpracovanychHodin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpravaUzivatelu
            // 
            this.btnSpravaUzivatelu.Location = new System.Drawing.Point(24, 32);
            this.btnSpravaUzivatelu.Name = "btnSpravaUzivatelu";
            this.btnSpravaUzivatelu.Size = new System.Drawing.Size(119, 39);
            this.btnSpravaUzivatelu.TabIndex = 0;
            this.btnSpravaUzivatelu.Text = "Správa uživatelů";
            this.btnSpravaUzivatelu.UseVisualStyleBackColor = true;
            this.btnSpravaUzivatelu.Click += new System.EventHandler(this.btnSpravaUzivatelu_Click);
            // 
            // btnSpravaTypuPrace
            // 
            this.btnSpravaTypuPrace.Location = new System.Drawing.Point(171, 32);
            this.btnSpravaTypuPrace.Name = "btnSpravaTypuPrace";
            this.btnSpravaTypuPrace.Size = new System.Drawing.Size(116, 39);
            this.btnSpravaTypuPrace.TabIndex = 1;
            this.btnSpravaTypuPrace.Text = "Správa typů práce";
            this.btnSpravaTypuPrace.UseVisualStyleBackColor = true;
            this.btnSpravaTypuPrace.Click += new System.EventHandler(this.btnSpravaTypuPrace_Click);
            // 
            // btnSpravaKontraktu
            // 
            this.btnSpravaKontraktu.Location = new System.Drawing.Point(171, 89);
            this.btnSpravaKontraktu.Name = "btnSpravaKontraktu";
            this.btnSpravaKontraktu.Size = new System.Drawing.Size(119, 39);
            this.btnSpravaKontraktu.TabIndex = 2;
            this.btnSpravaKontraktu.Text = "Správa kontraktů";
            this.btnSpravaKontraktu.UseVisualStyleBackColor = true;
            // 
            // btnSpravaZamestnancu
            // 
            this.btnSpravaZamestnancu.Location = new System.Drawing.Point(24, 89);
            this.btnSpravaZamestnancu.Name = "btnSpravaZamestnancu";
            this.btnSpravaZamestnancu.Size = new System.Drawing.Size(119, 39);
            this.btnSpravaZamestnancu.TabIndex = 2;
            this.btnSpravaZamestnancu.Text = "Správa zaměstannců";
            this.btnSpravaZamestnancu.UseVisualStyleBackColor = true;
            this.btnSpravaZamestnancu.Click += new System.EventHandler(this.btnSpravaZamestnancu_Click);
            // 
            // btnSpravaRoli
            // 
            this.btnSpravaRoli.Location = new System.Drawing.Point(24, 147);
            this.btnSpravaRoli.Name = "btnSpravaRoli";
            this.btnSpravaRoli.Size = new System.Drawing.Size(119, 39);
            this.btnSpravaRoli.TabIndex = 3;
            this.btnSpravaRoli.Text = "Správa rolí";
            this.btnSpravaRoli.UseVisualStyleBackColor = true;
            this.btnSpravaRoli.Click += new System.EventHandler(this.btnSpravaRoli_Click);
            // 
            // btnSpravaOdpracovanychHodin
            // 
            this.btnSpravaOdpracovanychHodin.Location = new System.Drawing.Point(171, 147);
            this.btnSpravaOdpracovanychHodin.Name = "btnSpravaOdpracovanychHodin";
            this.btnSpravaOdpracovanychHodin.Size = new System.Drawing.Size(119, 39);
            this.btnSpravaOdpracovanychHodin.TabIndex = 4;
            this.btnSpravaOdpracovanychHodin.Text = "Správa odpracovaných hodin";
            this.btnSpravaOdpracovanychHodin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 221);
            this.Controls.Add(this.btnSpravaOdpracovanychHodin);
            this.Controls.Add(this.btnSpravaRoli);
            this.Controls.Add(this.btnSpravaZamestnancu);
            this.Controls.Add(this.btnSpravaKontraktu);
            this.Controls.Add(this.btnSpravaTypuPrace);
            this.Controls.Add(this.btnSpravaUzivatelu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpravaUzivatelu;
        private System.Windows.Forms.Button btnSpravaTypuPrace;
        private System.Windows.Forms.Button btnSpravaKontraktu;
        private System.Windows.Forms.Button btnSpravaZamestnancu;
        private System.Windows.Forms.Button btnSpravaRoli;
        private System.Windows.Forms.Button btnSpravaOdpracovanychHodin;
    }
}

