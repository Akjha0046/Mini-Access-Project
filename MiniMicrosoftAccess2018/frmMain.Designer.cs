namespace MiniMicrosoftAccess2018
{
    partial class frmMain
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
            this.metroButtonAbout = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxDatabaseName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelDatabaseName = new MetroFramework.Controls.MetroLabel();
            this.metroButtonPath = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabelPath = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButtonAbout
            // 
            this.metroButtonAbout.Location = new System.Drawing.Point(525, 34);
            this.metroButtonAbout.Name = "metroButtonAbout";
            this.metroButtonAbout.Size = new System.Drawing.Size(97, 31);
            this.metroButtonAbout.TabIndex = 1;
            this.metroButtonAbout.Text = "Credits";
            this.metroButtonAbout.UseSelectable = true;
            this.metroButtonAbout.Click += new System.EventHandler(this.metroButtonAbout_Click);
            // 
            // metroTextBoxDatabaseName
            // 
            // 
            // 
            // 
            this.metroTextBoxDatabaseName.CustomButton.Image = null;
            this.metroTextBoxDatabaseName.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.metroTextBoxDatabaseName.CustomButton.Name = "";
            this.metroTextBoxDatabaseName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxDatabaseName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxDatabaseName.CustomButton.TabIndex = 1;
            this.metroTextBoxDatabaseName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxDatabaseName.CustomButton.UseSelectable = true;
            this.metroTextBoxDatabaseName.CustomButton.Visible = false;
            this.metroTextBoxDatabaseName.Lines = new string[0];
            this.metroTextBoxDatabaseName.Location = new System.Drawing.Point(184, 109);
            this.metroTextBoxDatabaseName.MaxLength = 32767;
            this.metroTextBoxDatabaseName.Name = "metroTextBoxDatabaseName";
            this.metroTextBoxDatabaseName.PasswordChar = '\0';
            this.metroTextBoxDatabaseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxDatabaseName.SelectedText = "";
            this.metroTextBoxDatabaseName.SelectionLength = 0;
            this.metroTextBoxDatabaseName.SelectionStart = 0;
            this.metroTextBoxDatabaseName.ShortcutsEnabled = true;
            this.metroTextBoxDatabaseName.Size = new System.Drawing.Size(157, 23);
            this.metroTextBoxDatabaseName.TabIndex = 2;
            this.metroTextBoxDatabaseName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxDatabaseName.UseSelectable = true;
            this.metroTextBoxDatabaseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxDatabaseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelDatabaseName
            // 
            this.metroLabelDatabaseName.AutoSize = true;
            this.metroLabelDatabaseName.Location = new System.Drawing.Point(184, 87);
            this.metroLabelDatabaseName.Name = "metroLabelDatabaseName";
            this.metroLabelDatabaseName.Size = new System.Drawing.Size(103, 19);
            this.metroLabelDatabaseName.TabIndex = 4;
            this.metroLabelDatabaseName.Text = "Database Name";
            this.metroLabelDatabaseName.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButtonPath
            // 
            this.metroButtonPath.BackColor = System.Drawing.Color.Gainsboro;
            this.metroButtonPath.BackgroundImage = global::MiniMicrosoftAccess2018.Properties.Resources.folder1;
            this.metroButtonPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButtonPath.Location = new System.Drawing.Point(356, 99);
            this.metroButtonPath.Name = "metroButtonPath";
            this.metroButtonPath.Size = new System.Drawing.Size(62, 44);
            this.metroButtonPath.TabIndex = 3;
            this.metroButtonPath.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButtonPath.UseSelectable = true;
            this.metroButtonPath.Click += new System.EventHandler(this.metroButtonPath_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(465, 201);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(124, 119);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Create Database";
            this.metroTile1.TileImage = global::MiniMicrosoftAccess2018.Properties.Resources.database;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabelPath
            // 
            this.metroLabelPath.Location = new System.Drawing.Point(184, 159);
            this.metroLabelPath.Name = "metroLabelPath";
            this.metroLabelPath.Size = new System.Drawing.Size(271, 27);
            this.metroLabelPath.TabIndex = 5;
            this.metroLabelPath.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 343);
            this.Controls.Add(this.metroLabelPath);
            this.Controls.Add(this.metroLabelDatabaseName);
            this.Controls.Add(this.metroButtonPath);
            this.Controls.Add(this.metroTextBoxDatabaseName);
            this.Controls.Add(this.metroButtonAbout);
            this.Controls.Add(this.metroTile1);
            this.Name = "frmMain";
            this.Text = "Mini Microsoft Access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton metroButtonAbout;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDatabaseName;
        private MetroFramework.Controls.MetroButton metroButtonPath;
        private MetroFramework.Controls.MetroLabel metroLabelDatabaseName;
        private MetroFramework.Controls.MetroLabel metroLabelPath;
    }
}