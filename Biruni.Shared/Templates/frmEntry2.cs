using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biruni.Shared.Templates
{
    public partial class frmEntry2 : Form
    {
        public frmEntry2()
        {
            frmEntry2_Helper(-1);
        }

        public frmEntry2(int id)
        {
            frmEntry2_Helper(id);
        }

        private void frmEntry2_Helper(int id)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
