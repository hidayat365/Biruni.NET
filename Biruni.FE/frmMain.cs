using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biruni.Orders.List;
using Biruni.Master.List;

namespace Biruni.FE
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /*
         * Company List
         * */
        private void c1Command10_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Form fx = new frmCompanyList();
            fx.MdiParent = this;
            fx.Show();
        }

        /*
         * Item List
         * */
        private void c1Command11_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Form fx = new frmItemList();
            fx.MdiParent = this;
            fx.Show();
        }

        /*
         * Purchase Order List
         * */
        private void c1Command12_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Form fx = new frmPurchaseOrderList();
            fx.MdiParent = this;
            fx.Show();

        }

        /*
         * Receiving Report List
         * */
        private void c1Command13_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Form fx = new frmReceivingReportList();
            fx.MdiParent = this;
            fx.Show();

        }
    }
}
