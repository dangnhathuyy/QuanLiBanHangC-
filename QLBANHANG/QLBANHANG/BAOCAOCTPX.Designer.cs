namespace QLBANHANG
{
    partial class BAOCAOCTPX
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLBHDataSet2 = new QLBANHANG.QLBHDataSet2();
            this.cTPXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTPXTableAdapter = new QLBANHANG.QLBHDataSet2TableAdapters.CTPXTableAdapter();
            this.qLBHDataSet3 = new QLBANHANG.QLBHDataSet3();
            this.qLBHDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet = new QLBANHANG.QLBHDataSet();
            this.qLBHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cTPXBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLBANHANG.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLBHDataSet2
            // 
            this.qLBHDataSet2.DataSetName = "QLBHDataSet2";
            this.qLBHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTPXBindingSource
            // 
            this.cTPXBindingSource.DataMember = "CTPX";
            this.cTPXBindingSource.DataSource = this.qLBHDataSet2;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // qLBHDataSet3
            // 
            this.qLBHDataSet3.DataSetName = "QLBHDataSet3";
            this.qLBHDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBHDataSet3BindingSource
            // 
            this.qLBHDataSet3BindingSource.DataSource = this.qLBHDataSet3;
            this.qLBHDataSet3BindingSource.Position = 0;
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBHDataSetBindingSource
            // 
            this.qLBHDataSetBindingSource.DataSource = this.qLBHDataSet;
            this.qLBHDataSetBindingSource.Position = 0;
            // 
            // BAOCAOCTPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BAOCAOCTPX";
            this.Text = "BAOCAOCTPX";
            this.Load += new System.EventHandler(this.BAOCAOCTPX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLBHDataSet2 qLBHDataSet2;
        private System.Windows.Forms.BindingSource cTPXBindingSource;
        private QLBHDataSet2TableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource qLBHDataSet3BindingSource;
        private QLBHDataSet3 qLBHDataSet3;
        private System.Windows.Forms.BindingSource qLBHDataSetBindingSource;
        private QLBHDataSet qLBHDataSet;
    }
}