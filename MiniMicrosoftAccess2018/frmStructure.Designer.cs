namespace MiniMicrosoftAccess2018
{
    partial class frmStructure
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
            this.metroTileTable = new MetroFramework.Controls.MetroTile();
            this.metroTileFields = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileTable
            // 
            this.metroTileTable.ActiveControl = null;
            this.metroTileTable.Location = new System.Drawing.Point(78, 106);
            this.metroTileTable.Name = "metroTileTable";
            this.metroTileTable.Size = new System.Drawing.Size(273, 181);
            this.metroTileTable.TabIndex = 0;
            this.metroTileTable.Text = "Tables";
            this.metroTileTable.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileTable.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileTable.UseSelectable = true;
            // 
            // metroTileFields
            // 
            this.metroTileFields.ActiveControl = null;
            this.metroTileFields.Location = new System.Drawing.Point(357, 106);
            this.metroTileFields.Name = "metroTileFields";
            this.metroTileFields.Size = new System.Drawing.Size(273, 181);
            this.metroTileFields.TabIndex = 1;
            this.metroTileFields.Text = "Fields";
            this.metroTileFields.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileFields.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileFields.UseSelectable = true;
            // 
            // frmStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 457);
            this.Controls.Add(this.metroTileFields);
            this.Controls.Add(this.metroTileTable);
            this.Name = "frmStructure";
            this.Text = "frmStructure";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileTable;
        private MetroFramework.Controls.MetroTile metroTileFields;
    }
}