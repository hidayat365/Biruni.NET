using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biruni.Master.Entry;

namespace Biruni.Master.List
{
    public partial class frmItemList : Biruni.Shared.Templates.frmList
    {
        public frmItemList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form fx = new frmItemEntry();
            fx.ShowDialog();
        }
    }
}
