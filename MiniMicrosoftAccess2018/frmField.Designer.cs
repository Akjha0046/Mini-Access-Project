namespace MiniMicrosoftAccess2018
{
    partial class frmField
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
            this.metroButtonAddField = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxFieldName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelFieldName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelFieldDatatype = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxFlDatatype = new MetroFramework.Controls.MetroComboBox();
            this.metroTabControlTableNames = new MetroFramework.Controls.MetroTabControl();
            this.metroLabelFieldSize = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFieldSize = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonFinish = new MetroFramework.Controls.MetroButton();
            this.metroCheckBoxAutoIncre = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxPrimaryKey = new MetroFramework.Controls.MetroCheckBox();
            this.metroButtonCreateDB = new MetroFramework.Controls.MetroButton();
            this.lblFieldNameRequired = new System.Windows.Forms.Label();
            this.lblFieldSizeRequired = new System.Windows.Forms.Label();
            this.metroLabelMessage = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButtonAddField
            // 
            this.metroButtonAddField.Location = new System.Drawing.Point(655, 262);
            this.metroButtonAddField.Name = "metroButtonAddField";
            this.metroButtonAddField.Size = new System.Drawing.Size(152, 48);
            this.metroButtonAddField.TabIndex = 1;
            this.metroButtonAddField.Text = "Add Field";
            this.metroButtonAddField.UseSelectable = true;
            this.metroButtonAddField.Click += new System.EventHandler(this.metroButtonAddField_Click);
            // 
            // metroTextBoxFieldName
            // 
            // 
            // 
            // 
            this.metroTextBoxFieldName.CustomButton.Image = null;
            this.metroTextBoxFieldName.CustomButton.Location = new System.Drawing.Point(169, 2);
            this.metroTextBoxFieldName.CustomButton.Name = "";
            this.metroTextBoxFieldName.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.metroTextBoxFieldName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFieldName.CustomButton.TabIndex = 1;
            this.metroTextBoxFieldName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFieldName.CustomButton.UseSelectable = true;
            this.metroTextBoxFieldName.CustomButton.Visible = false;
            this.metroTextBoxFieldName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxFieldName.Lines = new string[0];
            this.metroTextBoxFieldName.Location = new System.Drawing.Point(91, 301);
            this.metroTextBoxFieldName.MaxLength = 32767;
            this.metroTextBoxFieldName.Name = "metroTextBoxFieldName";
            this.metroTextBoxFieldName.PasswordChar = '\0';
            this.metroTextBoxFieldName.PromptText = "Field Name";
            this.metroTextBoxFieldName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFieldName.SelectedText = "";
            this.metroTextBoxFieldName.SelectionLength = 0;
            this.metroTextBoxFieldName.SelectionStart = 0;
            this.metroTextBoxFieldName.ShortcutsEnabled = true;
            this.metroTextBoxFieldName.Size = new System.Drawing.Size(207, 40);
            this.metroTextBoxFieldName.TabIndex = 2;
            this.metroTextBoxFieldName.UseSelectable = true;
            this.metroTextBoxFieldName.WaterMark = "Field Name";
            this.metroTextBoxFieldName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFieldName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelFieldName
            // 
            this.metroLabelFieldName.AutoSize = true;
            this.metroLabelFieldName.Location = new System.Drawing.Point(91, 262);
            this.metroLabelFieldName.Name = "metroLabelFieldName";
            this.metroLabelFieldName.Size = new System.Drawing.Size(77, 19);
            this.metroLabelFieldName.TabIndex = 3;
            this.metroLabelFieldName.Text = "Field Name";
            // 
            // metroLabelFieldDatatype
            // 
            this.metroLabelFieldDatatype.AutoSize = true;
            this.metroLabelFieldDatatype.Location = new System.Drawing.Point(91, 357);
            this.metroLabelFieldDatatype.Name = "metroLabelFieldDatatype";
            this.metroLabelFieldDatatype.Size = new System.Drawing.Size(92, 19);
            this.metroLabelFieldDatatype.TabIndex = 5;
            this.metroLabelFieldDatatype.Text = "Field datatype";
            // 
            // metroComboBoxFlDatatype
            // 
            this.metroComboBoxFlDatatype.FormattingEnabled = true;
            this.metroComboBoxFlDatatype.ItemHeight = 23;
            this.metroComboBoxFlDatatype.Location = new System.Drawing.Point(91, 392);
            this.metroComboBoxFlDatatype.Name = "metroComboBoxFlDatatype";
            this.metroComboBoxFlDatatype.Size = new System.Drawing.Size(207, 29);
            this.metroComboBoxFlDatatype.TabIndex = 6;
            this.metroComboBoxFlDatatype.UseSelectable = true;
            // 
            // metroTabControlTableNames
            // 
            this.metroTabControlTableNames.Location = new System.Drawing.Point(23, 88);
            this.metroTabControlTableNames.Name = "metroTabControlTableNames";
            this.metroTabControlTableNames.Size = new System.Drawing.Size(784, 70);
            this.metroTabControlTableNames.TabIndex = 7;
            this.metroTabControlTableNames.UseSelectable = true;
            // 
            // metroLabelFieldSize
            // 
            this.metroLabelFieldSize.AutoSize = true;
            this.metroLabelFieldSize.Location = new System.Drawing.Point(91, 440);
            this.metroLabelFieldSize.Name = "metroLabelFieldSize";
            this.metroLabelFieldSize.Size = new System.Drawing.Size(62, 19);
            this.metroLabelFieldSize.TabIndex = 9;
            this.metroLabelFieldSize.Text = "Field size";
            // 
            // metroTextBoxFieldSize
            // 
            // 
            // 
            // 
            this.metroTextBoxFieldSize.CustomButton.Image = null;
            this.metroTextBoxFieldSize.CustomButton.Location = new System.Drawing.Point(169, 2);
            this.metroTextBoxFieldSize.CustomButton.Name = "";
            this.metroTextBoxFieldSize.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.metroTextBoxFieldSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFieldSize.CustomButton.TabIndex = 1;
            this.metroTextBoxFieldSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFieldSize.CustomButton.UseSelectable = true;
            this.metroTextBoxFieldSize.CustomButton.Visible = false;
            this.metroTextBoxFieldSize.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxFieldSize.Lines = new string[0];
            this.metroTextBoxFieldSize.Location = new System.Drawing.Point(91, 479);
            this.metroTextBoxFieldSize.MaxLength = 32767;
            this.metroTextBoxFieldSize.Name = "metroTextBoxFieldSize";
            this.metroTextBoxFieldSize.PasswordChar = '\0';
            this.metroTextBoxFieldSize.PromptText = "Field Size";
            this.metroTextBoxFieldSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFieldSize.SelectedText = "";
            this.metroTextBoxFieldSize.SelectionLength = 0;
            this.metroTextBoxFieldSize.SelectionStart = 0;
            this.metroTextBoxFieldSize.ShortcutsEnabled = true;
            this.metroTextBoxFieldSize.Size = new System.Drawing.Size(207, 40);
            this.metroTextBoxFieldSize.TabIndex = 8;
            this.metroTextBoxFieldSize.UseSelectable = true;
            this.metroTextBoxFieldSize.WaterMark = "Field Size";
            this.metroTextBoxFieldSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFieldSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonFinish
            // 
            this.metroButtonFinish.Location = new System.Drawing.Point(655, 338);
            this.metroButtonFinish.Name = "metroButtonFinish";
            this.metroButtonFinish.Size = new System.Drawing.Size(152, 48);
            this.metroButtonFinish.TabIndex = 10;
            this.metroButtonFinish.Text = "Finish";
            this.metroButtonFinish.UseSelectable = true;
            this.metroButtonFinish.Click += new System.EventHandler(this.metroButtonFinish_Click);
            // 
            // metroCheckBoxAutoIncre
            // 
            this.metroCheckBoxAutoIncre.AutoSize = true;
            this.metroCheckBoxAutoIncre.Location = new System.Drawing.Point(313, 301);
            this.metroCheckBoxAutoIncre.Name = "metroCheckBoxAutoIncre";
            this.metroCheckBoxAutoIncre.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBoxAutoIncre.TabIndex = 12;
            this.metroCheckBoxAutoIncre.Text = "Auto-increment?";
            this.metroCheckBoxAutoIncre.UseSelectable = true;
            // 
            // metroCheckBoxPrimaryKey
            // 
            this.metroCheckBoxPrimaryKey.AutoSize = true;
            this.metroCheckBoxPrimaryKey.Location = new System.Drawing.Point(511, 301);
            this.metroCheckBoxPrimaryKey.Name = "metroCheckBoxPrimaryKey";
            this.metroCheckBoxPrimaryKey.Size = new System.Drawing.Size(42, 15);
            this.metroCheckBoxPrimaryKey.TabIndex = 13;
            this.metroCheckBoxPrimaryKey.Text = "PK?";
            this.metroCheckBoxPrimaryKey.UseSelectable = true;
            // 
            // metroButtonCreateDB
            // 
            this.metroButtonCreateDB.Location = new System.Drawing.Point(655, 411);
            this.metroButtonCreateDB.Name = "metroButtonCreateDB";
            this.metroButtonCreateDB.Size = new System.Drawing.Size(152, 48);
            this.metroButtonCreateDB.TabIndex = 14;
            this.metroButtonCreateDB.Text = "Create database";
            this.metroButtonCreateDB.UseSelectable = true;
            this.metroButtonCreateDB.Click += new System.EventHandler(this.metroButtonCreateDB_Click);
            // 
            // lblFieldNameRequired
            // 
            this.lblFieldNameRequired.AutoSize = true;
            this.lblFieldNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lblFieldNameRequired.Location = new System.Drawing.Point(224, 278);
            this.lblFieldNameRequired.Name = "lblFieldNameRequired";
            this.lblFieldNameRequired.Size = new System.Drawing.Size(74, 20);
            this.lblFieldNameRequired.TabIndex = 15;
            this.lblFieldNameRequired.Text = "Required";
            // 
            // lblFieldSizeRequired
            // 
            this.lblFieldSizeRequired.AutoSize = true;
            this.lblFieldSizeRequired.ForeColor = System.Drawing.Color.Red;
            this.lblFieldSizeRequired.Location = new System.Drawing.Point(224, 456);
            this.lblFieldSizeRequired.Name = "lblFieldSizeRequired";
            this.lblFieldSizeRequired.Size = new System.Drawing.Size(74, 20);
            this.lblFieldSizeRequired.TabIndex = 16;
            this.lblFieldSizeRequired.Text = "Required";
            // 
            // metroLabelMessage
            // 
            this.metroLabelMessage.AutoSize = true;
            this.metroLabelMessage.Location = new System.Drawing.Point(23, 175);
            this.metroLabelMessage.Name = "metroLabelMessage";
            this.metroLabelMessage.Size = new System.Drawing.Size(390, 19);
            this.metroLabelMessage.TabIndex = 17;
            this.metroLabelMessage.Text = "You did not create any tables. Go to tables form to create a table";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 206);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(274, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Select The table above you wish to add fields.";
            // 
            // frmField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 580);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabelMessage);
            this.Controls.Add(this.lblFieldSizeRequired);
            this.Controls.Add(this.lblFieldNameRequired);
            this.Controls.Add(this.metroButtonCreateDB);
            this.Controls.Add(this.metroCheckBoxPrimaryKey);
            this.Controls.Add(this.metroCheckBoxAutoIncre);
            this.Controls.Add(this.metroButtonFinish);
            this.Controls.Add(this.metroLabelFieldSize);
            this.Controls.Add(this.metroTextBoxFieldSize);
            this.Controls.Add(this.metroTabControlTableNames);
            this.Controls.Add(this.metroComboBoxFlDatatype);
            this.Controls.Add(this.metroLabelFieldDatatype);
            this.Controls.Add(this.metroLabelFieldName);
            this.Controls.Add(this.metroTextBoxFieldName);
            this.Controls.Add(this.metroButtonAddField);
            this.Name = "frmField";
            this.Text = "Add Fields to table";
            this.Load += new System.EventHandler(this.frmField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButtonAddField;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFieldName;
        private MetroFramework.Controls.MetroLabel metroLabelFieldName;
        private MetroFramework.Controls.MetroLabel metroLabelFieldDatatype;
        private MetroFramework.Controls.MetroComboBox metroComboBoxFlDatatype;
        private MetroFramework.Controls.MetroTabControl metroTabControlTableNames;
        private MetroFramework.Controls.MetroLabel metroLabelFieldSize;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFieldSize;
        private MetroFramework.Controls.MetroButton metroButtonFinish;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxAutoIncre;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxPrimaryKey;
        private MetroFramework.Controls.MetroButton metroButtonCreateDB;
        private System.Windows.Forms.Label lblFieldNameRequired;
        private System.Windows.Forms.Label lblFieldSizeRequired;
        private MetroFramework.Controls.MetroLabel metroLabelMessage;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}