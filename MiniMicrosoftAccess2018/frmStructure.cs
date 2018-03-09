﻿using System;
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
    public partial class frmStructure : MetroFramework.Forms.MetroForm
    {
        public frmStructure()
        {
            InitializeComponent();
        }

        private void metroTileTable_Click(object sender, EventArgs e)
        {
            frmTable table = new frmTable();

            table.MdiParent = this.MdiParent;

            this.Close();

            table.Show();
        }

        private void metroTileFields_Click(object sender, EventArgs e)
        {
            frmField fl = new frmField();

            this.Close();

            fl.MdiParent = this.ParentForm;

            fl.Show();
        }
    }
}
