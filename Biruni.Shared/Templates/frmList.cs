using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biruni.Shared.Templates
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        protected override void OnActivated(EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            base.OnActivated(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
