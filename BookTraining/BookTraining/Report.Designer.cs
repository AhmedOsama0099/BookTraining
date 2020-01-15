namespace BookTraining
{
    partial class Report
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
            this._Train_Booking_DataSet = new BookTraining._Train_Booking_DataSet();
            this.BOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BOOKTableAdapter = new BookTraining._Train_Booking_DataSetTableAdapters.BOOKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._Train_Booking_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOOKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BOOKBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BookTraining.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(775, 280);
            this.reportViewer1.TabIndex = 0;
            // 
            // _Train_Booking_DataSet
            // 
            this._Train_Booking_DataSet.DataSetName = "_Train_Booking_DataSet";
            this._Train_Booking_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BOOKBindingSource
            // 
            this.BOOKBindingSource.DataMember = "BOOK";
            this.BOOKBindingSource.DataSource = this._Train_Booking_DataSet;
            // 
            // BOOKTableAdapter
            // 
            this.BOOKTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 280);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Train_Booking_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOOKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BOOKBindingSource;
        private _Train_Booking_DataSet _Train_Booking_DataSet;
        private _Train_Booking_DataSetTableAdapters.BOOKTableAdapter BOOKTableAdapter;
    }
}