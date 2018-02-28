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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void metroButtonAbout_Click(object sender, EventArgs e)
        {
            frmCredits crd = new frmCredits();

            this.Hide();

            crd.Show();

        }

        private void metroButtonPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult dialog = fbd.ShowDialog();

            metroLabelPath.Text = fbd.SelectedPath;

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            //Checks if the textbox for database name is empty
            if (metroTextBoxDatabaseName.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter the database name in textbox", "Important", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else if (metroLabelPath.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this,"Specify a path for database","Important", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            DBEngine dbe = new DBEngine();

            Database myDB = dbe.CreateDatabase(metroLabelPath.Text + "\\" + metroTextBoxDatabaseName.Text + ".accdb",LanguageConstants.dbLangGeneral);


        }
    }
}
