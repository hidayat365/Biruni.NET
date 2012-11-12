using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biruni.Orders.Entry;

namespace Biruni.Orders.List
{
    public partial class frmPurchaseOrderList : Biruni.Shared.Templates.frmList
    {
        public frmPurchaseOrderList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form fx = new frmPurchaseOrderEntry();
            fx.ShowDialog();
        }
    }
}
