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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSpravaZamestnancu = new System.Windows.Forms.Button();
            this.btnSpravaRoli = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Správa práce";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Správa kontraktů";
            this.button3.UseVisualStyleBackColor = true;
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
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(171, 147);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 39);
            this.button6.TabIndex = 4;
            this.button6.Text = "Správa odpracovaných hodin";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 221);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnSpravaRoli);
            this.Controls.Add(this.btnSpravaZamestnancu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSpravaUzivatelu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpravaUzivatelu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSpravaZamestnancu;
        private System.Windows.Forms.Button btnSpravaRoli;
        private System.Windows.Forms.Button button6;
    }
}

