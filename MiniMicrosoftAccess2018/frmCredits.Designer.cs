namespace MiniMicrosoftAccess2018
{
    partial class frmCredits
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
            this.metroLinkFlatIcon = new MetroFramework.Controls.MetroLink();
            this.metroLabelSmashicons = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonBack = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLinkFlatIcon
            // 
            this.metroLinkFlatIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkFlatIcon.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLinkFlatIcon.Location = new System.Drawing.Point(137, 63);
            this.metroLinkFlatIcon.Name = "metroLinkFlatIcon";
            this.metroLinkFlatIcon.Size = new System.Drawing.Size(390, 38);
            this.metroLinkFlatIcon.TabIndex = 1;
            this.metroLinkFlatIcon.Text = "Icons taken from https://www.flaticon.com";
            this.metroLinkFlatIcon.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLinkFlatIcon.UseSelectable = true;
            this.metroLinkFlatIcon.Click += new System.EventHandler(this.metroLinkFlatIcon_Click);
            // 
            // metroLabelSmashicons
            // 
            this.metroLabelSmashicons.AutoSize = true;
            this.metroLabelSmashicons.Location = new System.Drawing.Point(46, 158);
            this.metroLabelSmashicons.Name = "metroLabelSmashicons";
            this.metroLabelSmashicons.Size = new System.Drawing.Size(192, 19);
            this.metroLabelSmashicons.TabIndex = 2;
            this.metroLabelSmashicons.Text = "Folder icon author: Smashicons";
            this.metroLabelSmashicons.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 125);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(208, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Database icon author: Smashicons";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButtonBack
            // 
            this.metroButtonBack.Location = new System.Drawing.Point(553, 17);
            this.metroButtonBack.Name = "metroButtonBack";
            this.metroButtonBack.Size = new System.Drawing.Size(82, 23);
            this.metroButtonBack.TabIndex = 3;
            this.metroButtonBack.Text = "Back";
            this.metroButtonBack.UseSelectable = true;
            this.metroButtonBack.Click += new System.EventHandler(this.metroButtonBack_Click);
            // 
            // frmCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 385);
            this.Controls.Add(this.metroButtonBack);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabelSmashicons);
            this.Controls.Add(this.metroLinkFlatIcon);
            this.Name = "frmCredits";
            this.Text = "Credits";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink metroLinkFlatIcon;
        private MetroFramework.Controls.MetroLabel metroLabelSmashicons;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButtonBack;
    }
}