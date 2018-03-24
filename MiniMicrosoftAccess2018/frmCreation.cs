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
    public partial class frmCreation : MetroFramework.Forms.MetroForm
    {
        public frmCreation()
        {
            InitializeComponent();
        }

        TableDef myTb;
        Field myFl;

        private void Enable(bool enableTable, bool saveTable, bool enableFields, bool enableCreateDb)
        {
            metroButtonAddTb.Enabled = enableTable;
            metroButtonAddFl.Enabled = enableFields;
            metroButtonSaveTb.Enabled = saveTable;
           
            metroButtonCreateDB.Enabled = enableCreateDb;

        }

        private void frmCreation_Load(object sender, EventArgs e)
        {
            foreach (var dt in Enum.GetValues(typeof(DataTypeEnum)))
            {
                cboDt1.Items.Add(dt);
                cboDt2.Items.Add(dt);
                cboDt3.Items.Add(dt);
                cboDt4.Items.Add(dt);

            }

            Enable(true, false, false, false);
        }

        private void metroButtonAddTb_Click(object sender, EventArgs e)
        {
            myTb = Variable.myDB.CreateTableDef(metroTextBoxTbName.Text);


            Enable(false, false, true, false);
        }

        private void metroButtonAddFl_Click(object sender, EventArgs e)
        {
            myFl = myTb.CreateField(metroTextBoxField1.Text, (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), cboDt1.SelectedItem.ToString()));

            if (metroCheckBoxAutoIncre.Checked)
            {
                myFl.Attributes = (int)FieldAttributeEnum.dbAutoIncrField;
            }

            myTb.Fields.Append(myFl);

            if (metroCheckBoxPrimaryKey.Checked)
            {
                Index myId = myTb.CreateIndex("primarykey");

                myFl = myTb.CreateField(metroTextBoxField1.Text);

                ((IndexFields)myId.Fields).Append(myFl);

                myId.Primary = true;

                myTb.Indexes.Append(myId);

            }


            if (metroTextBoxField2.Text != "")
            {
                myFl = myTb.CreateField(metroTextBoxField2.Text, (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), cboDt2.SelectedItem.ToString()));

                myTb.Fields.Append(myFl);
            }

            if (metroTextBoxField3.Text != "")
            {
                myFl = myTb.CreateField(metroTextBoxField3.Text, (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), cboDt3.SelectedItem.ToString()));

                myTb.Fields.Append(myFl);
            }

            if (metroTextBoxField4.Text != "")
            {
                myFl = myTb.CreateField(metroTextBoxField4.Text, (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), cboDt4.SelectedItem.ToString()));

                myTb.Fields.Append(myFl);
            }

            metroTextBoxField1.Clear();
            metroTextBoxField2.Clear();
            metroTextBoxField3.Clear();
            metroTextBoxField4.Clear();

            cboDt1.ResetText();
            cboDt2.ResetText();
            cboDt3.ResetText();
            cboDt4.ResetText();

            metroTextBoxField1.Focus();

            Enable(false, true, true, false);

        }

        private void metroButtonSaveTb_Click(object sender, EventArgs e)
        {
            Variable.myDB.TableDefs.Append(myTb);

            Enable(true, false, false, true);
        }

        private void metroButtonCreateDB_Click(object sender, EventArgs e)
        {
            Variable.myDB.Close();

            this.Close();

            frmMain fm = new frmMain();

            fm.Show();
        }
    }
}
