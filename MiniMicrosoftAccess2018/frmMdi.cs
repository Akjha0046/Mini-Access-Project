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
    public partial class frmMdi : MetroFramework.Forms.MetroForm
    {
        public frmMdi()
        {
            InitializeComponent();
        }

        private void frmMdi_Load(object sender, EventArgs e)
        {
            frmMain main = new frmMain();

            main.MdiParent = this;

            main.Show();
        }
    }
}
