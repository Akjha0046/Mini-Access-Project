using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace MiniMicrosoftAccess2018
{
    public partial class frmField : MetroFramework.Forms.MetroForm
    {
        public frmField()
        {
            InitializeComponent();
        }

        private void requiredLbl(bool enable)
        {
            lblFieldNameRequired.Visible = enable;
            lblFieldSizeRequired.Visible = enable;
        }

        private void metroButtonAddField_Click(object sender, EventArgs e)
        {
            if (metroTextBoxFieldName.Text == "")
            {
                lblFieldNameRequired.Visible = true;
                return;
            }

            if (metroTextBoxFieldSize.Text == "")
            {
                lblFieldSizeRequired.Visible = true;
                return;
            }

            TabPage selectedTab = metroTabControlTableNames.SelectedTab;

            if (metroTabControlTableNames.SelectedIndex != 0)
            {
                Variable.myTB = Variable.myDB.CreateTableDef(metroTabControlTableNames.TabPages[selectedTab.Text].Text);
            }

            Field myFl = Variable.myTB.CreateField(metroTextBoxFieldName.Text, (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), metroComboBoxFlDatatype.Text), metroTextBoxFieldSize.Text);

            if (metroCheckBoxAutoIncre.Checked)
            {
                myFl.Attributes = (int)FieldAttributeEnum.dbAutoIncrField;
            }

            Variable.myTB.Fields.Append(myFl);

            if (metroCheckBoxPrimaryKey.Checked)
            {
                Index myId = Variable.myTB.CreateIndex("primarykey");

                myFl = Variable.myTB.CreateField(metroTextBoxFieldName.Text);

                ((IndexFields)myId.Fields).Append(myFl);

                myId.Primary = true;

                Variable.myTB.Indexes.Append(myId);

            }

            metroTextBoxFieldName.Clear();

            metroTextBoxFieldSize.Clear();

            metroTextBoxFieldName.Focus();

            metroButtonFinish.Enabled = true;

            requiredLbl(false);

            metroCheckBoxAutoIncre.Checked = false;
            metroCheckBoxPrimaryKey.Checked = false;

        }

        private void frmField_Load(object sender, EventArgs e)
        {
            metroButtonCreateDB.Enabled = false;

            metroButtonFinish.Enabled = false;

            metroLabelMessage.Visible = false;

            requiredLbl(false);

            if (Variable.storeTableNames.Count == 0)
            {
                metroLabelMessage.Visible = true;
            }

            foreach (var tab in Variable.storeTableNames)
            {
                string tabPageName = tab;
                metroTabControlTableNames.TabPages.Add(tab,tabPageName);
            }

            foreach (var data in Enum.GetValues(typeof(DataTypeEnum)))
            {
                metroComboBoxFlDatatype.Items.Add(data);
            }
        }

        private void metroButtonFinish_Click(object sender, EventArgs e)
        {
            

            Variable.myDB.TableDefs.Append(Variable.myTB);
            metroButtonCreateDB.Enabled = true;

        }

        private void metroButtonCreateDB_Click(object sender, EventArgs e)
        {
            Variable.myDB.Close();
            MetroFramework.MetroMessageBox.Show(this,"Database created successfully.","Database created.",MessageBoxButtons.OK,MessageBoxIcon.Question,130);
            frmMain main = new frmMain();

            main.MdiParent = main.MdiParent;

            main.Show();

            this.Close();
        }

        /*
         *    ToDo
         *   ------
         *   Bring table names to frmField form.
         *   create comboBox and populate with datatypeenum for field datatypes
         *   create texbox for field name
         *   create Relations between tables
         *   Finish
         */

    }
}
