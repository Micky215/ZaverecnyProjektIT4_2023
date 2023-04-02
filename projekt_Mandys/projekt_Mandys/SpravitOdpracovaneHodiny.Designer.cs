namespace projekt_Mandys
{
    partial class SpravitOdpracovaneHodiny
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
            this.listViewOdpracovaneHodiny = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnozstviHodin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idContract = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idHodin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPridatOdpracovaneHodiny = new System.Windows.Forms.Button();
            this.btnUpravitOdpracovaneHodiny = new System.Windows.Forms.Button();
            this.btnSmazatOdpracovaneHodiny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewOdpracovaneHodiny
            // 
            this.listViewOdpracovaneHodiny.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.mnozstviHodin,
            this.datum,
            this.idEmployee,
            this.idContract,
            this.idHodin});
            this.listViewOdpracovaneHodiny.FullRowSelect = true;
            this.listViewOdpracovaneHodiny.GridLines = true;
            this.listViewOdpracovaneHodiny.HideSelection = false;
            this.listViewOdpracovaneHodiny.Location = new System.Drawing.Point(12, 12);
            this.listViewOdpracovaneHodiny.MultiSelect = false;
            this.listViewOdpracovaneHodiny.Name = "listViewOdpracovaneHodiny";
            this.listViewOdpracovaneHodiny.Size = new System.Drawing.Size(660, 426);
            this.listViewOdpracovaneHodiny.TabIndex = 0;
            this.listViewOdpracovaneHodiny.UseCompatibleStateImageBehavior = false;
            this.listViewOdpracovaneHodiny.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 100;
            // 
            // mnozstviHodin
            // 
            this.mnozstviHodin.Text = "Množství hodin";
            this.mnozstviHodin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mnozstviHodin.Width = 100;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datum.Width = 100;
            // 
            // idEmployee
            // 
            this.idEmployee.Text = "ID zaměstnance";
            this.idEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idEmployee.Width = 100;
            // 
            // idContract
            // 
            this.idContract.Text = "ID zakázky";
            this.idContract.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idContract.Width = 100;
            // 
            // idHodin
            // 
            this.idHodin.Text = "ID typu práce";
            this.idHodin.Width = 100;
            // 
            // btnPridatOdpracovaneHodiny
            // 
            this.btnPridatOdpracovaneHodiny.Location = new System.Drawing.Point(691, 34);
            this.btnPridatOdpracovaneHodiny.Name = "btnPridatOdpracovaneHodiny";
            this.btnPridatOdpracovaneHodiny.Size = new System.Drawing.Size(86, 30);
            this.btnPridatOdpracovaneHodiny.TabIndex = 1;
            this.btnPridatOdpracovaneHodiny.Text = "Přidat";
            this.btnPridatOdpracovaneHodiny.UseVisualStyleBackColor = true;
            this.btnPridatOdpracovaneHodiny.Click += new System.EventHandler(this.btnPridatOdpracovaneHodiny_Click);
            // 
            // btnUpravitOdpracovaneHodiny
            // 
            this.btnUpravitOdpracovaneHodiny.Location = new System.Drawing.Point(691, 98);
            this.btnUpravitOdpracovaneHodiny.Name = "btnUpravitOdpracovaneHodiny";
            this.btnUpravitOdpracovaneHodiny.Size = new System.Drawing.Size(86, 30);
            this.btnUpravitOdpracovaneHodiny.TabIndex = 2;
            this.btnUpravitOdpracovaneHodiny.Text = "Upravit";
            this.btnUpravitOdpracovaneHodiny.UseVisualStyleBackColor = true;
            this.btnUpravitOdpracovaneHodiny.Click += new System.EventHandler(this.btnUpravitOdpracovaneHodiny_Click);
            // 
            // btnSmazatOdpracovaneHodiny
            // 
            this.btnSmazatOdpracovaneHodiny.Location = new System.Drawing.Point(691, 160);
            this.btnSmazatOdpracovaneHodiny.Name = "btnSmazatOdpracovaneHodiny";
            this.btnSmazatOdpracovaneHodiny.Size = new System.Drawing.Size(86, 30);
            this.btnSmazatOdpracovaneHodiny.TabIndex = 3;
            this.btnSmazatOdpracovaneHodiny.Text = "Smazat";
            this.btnSmazatOdpracovaneHodiny.UseVisualStyleBackColor = true;
            this.btnSmazatOdpracovaneHodiny.Click += new System.EventHandler(this.btnSmazatOdpracovaneHodiny_Click);
            // 
            // SpravitOdpracovaneHodiny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSmazatOdpracovaneHodiny);
            this.Controls.Add(this.btnUpravitOdpracovaneHodiny);
            this.Controls.Add(this.btnPridatOdpracovaneHodiny);
            this.Controls.Add(this.listViewOdpracovaneHodiny);
            this.Name = "SpravitOdpracovaneHodiny";
            this.Text = "SpravitOdpracovaneHodiny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewOdpracovaneHodiny;
        private System.Windows.Forms.Button btnPridatOdpracovaneHodiny;
        private System.Windows.Forms.Button btnUpravitOdpracovaneHodiny;
        private System.Windows.Forms.Button btnSmazatOdpracovaneHodiny;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader mnozstviHodin;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader idEmployee;
        private System.Windows.Forms.ColumnHeader idContract;
        private System.Windows.Forms.ColumnHeader idHodin;
    }
}