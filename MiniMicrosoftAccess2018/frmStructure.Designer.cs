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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStructure));
            this.metroTileFields = new MetroFramework.Controls.MetroTile();
            this.metroTileTable = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileFields
            // 
            this.metroTileFields.ActiveControl = null;
            this.metroTileFields.Location = new System.Drawing.Point(448, 106);
            this.metroTileFields.Name = "metroTileFields";
            this.metroTileFields.Size = new System.Drawing.Size(253, 266);
            this.metroTileFields.TabIndex = 1;
            this.metroTileFields.Text = "Fields";
            this.metroTileFields.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileFields.TileImage")));
            this.metroTileFields.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileFields.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileFields.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileFields.UseSelectable = true;
            this.metroTileFields.UseTileImage = true;
            // 
            // metroTileTable
            // 
            this.metroTileTable.ActiveControl = null;
            this.metroTileTable.Location = new System.Drawing.Point(185, 106);
            this.metroTileTable.Name = "metroTileTable";
            this.metroTileTable.Size = new System.Drawing.Size(257, 266);
            this.metroTileTable.TabIndex = 0;
            this.metroTileTable.Text = "Tables";
            this.metroTileTable.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileTable.TileImage")));
            this.metroTileTable.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileTable.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileTable.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileTable.UseSelectable = true;
            this.metroTileTable.UseTileImage = true;
            this.metroTileTable.Click += new System.EventHandler(this.metroTileTable_Click);
            // 
            // frmStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 507);
            this.Controls.Add(this.metroTileFields);
            this.Controls.Add(this.metroTileTable);
            this.Name = "frmStructure";
            this.Text = "Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileTable;
        private MetroFramework.Controls.MetroTile metroTileFields;
    }
}