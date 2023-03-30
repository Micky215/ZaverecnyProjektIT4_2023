namespace projekt_Mandys
{
    partial class SpravaTypuPrace
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
            this.listViewTypyPraci = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jmeno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.popis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPridatTypPrace = new System.Windows.Forms.Button();
            this.btnUpravitTypPrace = new System.Windows.Forms.Button();
            this.btnSmazatTypPrace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewTypyPraci
            // 
            this.listViewTypyPraci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.jmeno,
            this.popis});
            this.listViewTypyPraci.FullRowSelect = true;
            this.listViewTypyPraci.GridLines = true;
            this.listViewTypyPraci.HideSelection = false;
            this.listViewTypyPraci.Location = new System.Drawing.Point(12, 12);
            this.listViewTypyPraci.MultiSelect = false;
            this.listViewTypyPraci.Name = "listViewTypyPraci";
            this.listViewTypyPraci.Size = new System.Drawing.Size(631, 426);
            this.listViewTypyPraci.TabIndex = 0;
            this.listViewTypyPraci.UseCompatibleStateImageBehavior = false;
            this.listViewTypyPraci.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 50;
            // 
            // jmeno
            // 
            this.jmeno.Text = "Jméno";
            this.jmeno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jmeno.Width = 150;
            // 
            // popis
            // 
            this.popis.Text = "Popis";
            this.popis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.popis.Width = 400;
            // 
            // btnPridatTypPrace
            // 
            this.btnPridatTypPrace.Location = new System.Drawing.Point(672, 58);
            this.btnPridatTypPrace.Name = "btnPridatTypPrace";
            this.btnPridatTypPrace.Size = new System.Drawing.Size(105, 36);
            this.btnPridatTypPrace.TabIndex = 1;
            this.btnPridatTypPrace.Text = "Přidat typ práce";
            this.btnPridatTypPrace.UseVisualStyleBackColor = true;
            this.btnPridatTypPrace.Click += new System.EventHandler(this.btnPridatTypPrace_Click);
            // 
            // btnUpravitTypPrace
            // 
            this.btnUpravitTypPrace.Location = new System.Drawing.Point(672, 131);
            this.btnUpravitTypPrace.Name = "btnUpravitTypPrace";
            this.btnUpravitTypPrace.Size = new System.Drawing.Size(105, 36);
            this.btnUpravitTypPrace.TabIndex = 2;
            this.btnUpravitTypPrace.Text = "Upravit typ práce";
            this.btnUpravitTypPrace.UseVisualStyleBackColor = true;
            this.btnUpravitTypPrace.Click += new System.EventHandler(this.btnUpravitTypPrace_Click);
            // 
            // btnSmazatTypPrace
            // 
            this.btnSmazatTypPrace.Location = new System.Drawing.Point(672, 206);
            this.btnSmazatTypPrace.Name = "btnSmazatTypPrace";
            this.btnSmazatTypPrace.Size = new System.Drawing.Size(105, 36);
            this.btnSmazatTypPrace.TabIndex = 3;
            this.btnSmazatTypPrace.Text = "Smazat typ práce";
            this.btnSmazatTypPrace.UseVisualStyleBackColor = true;
            this.btnSmazatTypPrace.Click += new System.EventHandler(this.btnSmazatTypPrace_Click);
            // 
            // SpravaTypuPrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSmazatTypPrace);
            this.Controls.Add(this.btnUpravitTypPrace);
            this.Controls.Add(this.btnPridatTypPrace);
            this.Controls.Add(this.listViewTypyPraci);
            this.Name = "SpravaTypuPrace";
            this.Text = "SpravaTypuPrace";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTypyPraci;
        private System.Windows.Forms.ColumnHeader jmeno;
        private System.Windows.Forms.ColumnHeader popis;
        private System.Windows.Forms.Button btnPridatTypPrace;
        private System.Windows.Forms.Button btnUpravitTypPrace;
        private System.Windows.Forms.Button btnSmazatTypPrace;
        private System.Windows.Forms.ColumnHeader id;
    }
}