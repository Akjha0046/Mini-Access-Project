using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMicrosoftAccess2018
{
    public partial class frmCredits : MetroFramework.Forms.MetroForm
    {
        public frmCredits()
        {
            InitializeComponent();
        }

        private void metroLinkFlatIcon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.flaticon.com");
        }

        private void metroButtonBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();

            this.Close();

            main.Show();

        }
    }
}
