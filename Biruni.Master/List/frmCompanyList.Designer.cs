namespace Biruni.Master.List
{
    partial class frmCompanyList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanyList));
            this.companiesTableAdapter1 = new Biruni.Shared.Data.dsBiruniTableAdapters.CompaniesTableAdapter();
            this.dsBiruni1 = new Biruni.Shared.Data.dsBiruni();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBiruni1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridData
            // 
            this.gridData.Caption = "Company List";
            this.gridData.DataMember = "Companies";
            this.gridData.DataSource = this.dsBiruni1;
            this.gridData.Images.Add(((System.Drawing.Image)(resources.GetObject("gridData.Images"))));
            this.gridData.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.gridData.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.gridData.PreviewInfo.ZoomFactor = 75D;
            this.gridData.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("gridData.PrintInfo.PageSettings")));
            this.gridData.PropBag = resources.GetString("gridData.PropBag");
            // 
            // btnAdd
            // 
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(118, 19);
            this.lblTitle.Text = "Company List";
            // 
            // companiesTableAdapter1
            // 
            this.companiesTableAdapter1.ClearBeforeFill = true;
            // 
            // dsBiruni1
            // 
            this.dsBiruni1.DataSetName = "dsBiruni";
            this.dsBiruni1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmCompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(624, 362);
            this.Name = "frmCompanyList";
            this.Text = "Company List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBiruni1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Shared.Data.dsBiruniTableAdapters.CompaniesTableAdapter companiesTableAdapter1;
        private Shared.Data.dsBiruni dsBiruni1;
    }
}
