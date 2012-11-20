using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biruni.Shared.Templates
{
    public partial class frmEntry1 : Form
    {
        public frmEntry1()
        {
            frmEntry1_Helper(-1);
        }

        public frmEntry1(int id)
        {
            frmEntry1_Helper(id);
        }

        private void frmEntry1_Helper(int id)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
