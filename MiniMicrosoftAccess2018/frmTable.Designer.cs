namespace MiniMicrosoftAccess2018
{
    partial class frmTable
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
            this.metroButtonFinish = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxTableName = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControlTables = new MetroFramework.Controls.MetroTabControl();
            this.metroLabelTableName = new MetroFramework.Controls.MetroLabel();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabelInfo = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButtonFinish
            // 
            this.metroButtonFinish.Location = new System.Drawing.Point(693, 292);
            this.metroButtonFinish.Name = "metroButtonFinish";
            this.metroButtonFinish.Size = new System.Drawing.Size(126, 38);
            this.metroButtonFinish.TabIndex = 1;
            this.metroButtonFinish.Text = "Finish";
            this.metroButtonFinish.UseSelectable = true;
            this.metroButtonFinish.Click += new System.EventHandler(this.metroButtonFinish_Click);
            // 
            // metroTextBoxTableName
            // 
            // 
            // 
            // 
            this.metroTextBoxTableName.CustomButton.Image = null;
            this.metroTextBoxTableName.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.metroTextBoxTableName.CustomButton.Name = "";
            this.metroTextBoxTableName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxTableName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTableName.CustomButton.TabIndex = 1;
            this.metroTextBoxTableName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTableName.CustomButton.UseSelectable = true;
            this.metroTextBoxTableName.CustomButton.Visible = false;
            this.metroTextBoxTableName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxTableName.Lines = new string[0];
            this.metroTextBoxTableName.Location = new System.Drawing.Point(84, 237);
            this.metroTextBoxTableName.MaxLength = 32767;
            this.metroTextBoxTableName.Name = "metroTextBoxTableName";
            this.metroTextBoxTableName.PasswordChar = '\0';
            this.metroTextBoxTableName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTableName.SelectedText = "";
            this.metroTextBoxTableName.SelectionLength = 0;
            this.metroTextBoxTableName.SelectionStart = 0;
            this.metroTextBoxTableName.ShortcutsEnabled = true;
            this.metroTextBoxTableName.Size = new System.Drawing.Size(207, 35);
            this.metroTextBoxTableName.TabIndex = 2;
            this.metroTextBoxTableName.UseSelectable = true;
            this.metroTextBoxTableName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTableName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabControlTables
            // 
            this.metroTabControlTables.Location = new System.Drawing.Point(84, 95);
            this.metroTabControlTables.Name = "metroTabControlTables";
            this.metroTabControlTables.Size = new System.Drawing.Size(735, 70);
            this.metroTabControlTables.TabIndex = 3;
            this.metroTabControlTables.UseSelectable = true;
            // 
            // metroLabelTableName
            // 
            this.metroLabelTableName.AutoSize = true;
            this.metroLabelTableName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelTableName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelTableName.Location = new System.Drawing.Point(84, 190);
            this.metroLabelTableName.Name = "metroLabelTableName";
            this.metroLabelTableName.Size = new System.Drawing.Size(101, 25);
            this.metroLabelTableName.TabIndex = 4;
            this.metroLabelTableName.Text = "Table name";
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.Location = new System.Drawing.Point(693, 228);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(126, 39);
            this.metroButtonAdd.TabIndex = 5;
            this.metroButtonAdd.Text = "Add new table";
            this.metroButtonAdd.UseSelectable = true;
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // metroLabelInfo
            // 
            this.metroLabelInfo.Location = new System.Drawing.Point(230, 472);
            this.metroLabelInfo.Name = "metroLabelInfo";
            this.metroLabelInfo.Size = new System.Drawing.Size(513, 51);
            this.metroLabelInfo.TabIndex = 6;
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 598);
            this.Controls.Add(this.metroLabelInfo);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.metroLabelTableName);
            this.Controls.Add(this.metroTabControlTables);
            this.Controls.Add(this.metroTextBoxTableName);
            this.Controls.Add(this.metroButtonFinish);
            this.Name = "frmTable";
            this.Text = "Table Creation";
            this.TransparencyKey = System.Drawing.Color.DodgerBlue;
            this.Load += new System.EventHandler(this.frmTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButtonFinish;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTableName;
        private MetroFramework.Controls.MetroTabControl metroTabControlTables;
        private MetroFramework.Controls.MetroLabel metroLabelTableName;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroLabel metroLabelInfo;
    }
}