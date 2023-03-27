namespace projekt_Mandys
{
    partial class SpravaRoli
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
            this.listViewRole = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NazevRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewRole
            // 
            this.listViewRole.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.NazevRole});
            this.listViewRole.GridLines = true;
            this.listViewRole.HideSelection = false;
            this.listViewRole.Location = new System.Drawing.Point(12, 12);
            this.listViewRole.Name = "listViewRole";
            this.listViewRole.Size = new System.Drawing.Size(183, 426);
            this.listViewRole.TabIndex = 0;
            this.listViewRole.UseCompatibleStateImageBehavior = false;
            this.listViewRole.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID role";
            // 
            // NazevRole
            // 
            this.NazevRole.Text = "Název role";
            this.NazevRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NazevRole.Width = 100;
            // 
            // SpravaRoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.listViewRole);
            this.Name = "SpravaRoli";
            this.Text = "SpravaRoli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewRole;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader NazevRole;
    }
}