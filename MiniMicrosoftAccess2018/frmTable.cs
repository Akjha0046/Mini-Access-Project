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
    public partial class frmTable : MetroFramework.Forms.MetroForm
    {
        public frmTable()
        {
            InitializeComponent();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            string tableName = metroTextBoxTableName.Text;

            if (tableName == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this,"Table name cannot be left blank.","Enter table name",MessageBoxButtons.OK,MessageBoxIcon.Error,130);

                return;
            }

            string title = metroTextBoxTableName.Text;
            string tabPageName = "tabPage" + metroTabControlTables.TabPages.Count;

            metroTabControlTables.TabPages.Add(title,tableName);

            metroTabControlTables.SelectTab(tableName);

            metroLabelInfo.Text = "Number of tables to create: " + metroTabControlTables.TabCount;

            metroTextBoxTableName.Clear();

            metroTextBoxTableName.Focus();
        }

        private void metroButtonFinish_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < metroTabControlTables.TabCount; i++)
            {
                // Variable.dbe.OpenDatabase(Variable.path);

                TableDef myTD = Variable.myDB.CreateTableDef(metroTabControlTables.TabPages[i].Name);

                 Field myFl = myTD.CreateField("Pizza", DataTypeEnum.dbText, 25);

                myTD.Fields.Append(myFl);

                Variable.myDB.TableDefs.Append(myTD);
            }
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
          
        }
    }
}
