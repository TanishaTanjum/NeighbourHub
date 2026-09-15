namespace NeighbourHub
{
    partial class ReportSummaryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblPropertiesText;
        private System.Windows.Forms.Label lblPropertiesValue;
        private System.Windows.Forms.Label lblUnitsText;
        private System.Windows.Forms.Label lblUnitsValue;
        private System.Windows.Forms.Label lblTenantsText;
        private System.Windows.Forms.Label lblTenantsValue;
        private System.Windows.Forms.Label lblPaidRentText;
        private System.Windows.Forms.Label lblPaidRentValue;
        private System.Windows.Forms.Label lblUnpaidRentText;
        private System.Windows.Forms.Label lblUnpaidRentValue;
        private System.Windows.Forms.Label lblMaintenanceText;
        private System.Windows.Forms.Label lblMaintenanceValue;
        private System.Windows.Forms.Label lblComplaintsText;
        private System.Windows.Forms.Label lblComplaintsValue;
        private System.Windows.Forms.Label lblUtilitiesText;
        private System.Windows.Forms.Label lblUtilitiesValue;
        private System.Windows.Forms.Label lblReportDetails;
        private System.Windows.Forms.DataGridView dgvReportSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblPropertiesText = new System.Windows.Forms.Label();
            this.lblPropertiesValue = new System.Windows.Forms.Label();
            this.lblUnitsText = new System.Windows.Forms.Label();
            this.lblUnitsValue = new System.Windows.Forms.Label();
            this.lblTenantsText = new System.Windows.Forms.Label();
            this.lblTenantsValue = new System.Windows.Forms.Label();
            this.lblPaidRentText = new System.Windows.Forms.Label();
            this.lblPaidRentValue = new System.Windows.Forms.Label();
            this.lblUnpaidRentText = new System.Windows.Forms.Label();
            this.lblUnpaidRentValue = new System.Windows.Forms.Label();
            this.lblMaintenanceText = new System.Windows.Forms.Label();
            this.lblMaintenanceValue = new System.Windows.Forms.Label();
            this.lblComplaintsText = new System.Windows.Forms.Label();
            this.lblComplaintsValue = new System.Windows.Forms.Label();
            this.lblUtilitiesText = new System.Windows.Forms.Label();
            this.lblUtilitiesValue = new System.Windows.Forms.Label();
            this.lblReportDetails = new System.Windows.Forms.Label();
            this.dgvReportSummary = new System.Windows.Forms.DataGridView();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpFilters.SuspendLayout();
            this.grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportSummary)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(48, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Report Summary";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.Location = new System.Drawing.Point(51, 77);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(415, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "View a summary of property, rent and management activity.";

            this.grpFilters.Controls.Add(this.lblFromDate);
            this.grpFilters.Controls.Add(this.dtpFromDate);
            this.grpFilters.Controls.Add(this.lblToDate);
            this.grpFilters.Controls.Add(this.dtpToDate);
            this.grpFilters.Controls.Add(this.btnGenerateReport);
            this.grpFilters.Controls.Add(this.btnRefresh);
            this.grpFilters.Location = new System.Drawing.Point(50, 116);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(1050, 95);
            this.grpFilters.TabIndex = 2;
            this.grpFilters.TabStop = false;

            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFromDate.Location = new System.Drawing.Point(28, 27);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(66, 15);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "From Date";

            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(31, 48);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(170, 23);
            this.dtpFromDate.TabIndex = 1;

            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblToDate.Location = new System.Drawing.Point(232, 27);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(50, 15);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "To Date";

            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(235, 48);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(170, 23);
            this.dtpToDate.TabIndex = 3;

            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerateReport.Location = new System.Drawing.Point(448, 38);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(160, 38);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Generate Summary";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);

            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.Location = new System.Drawing.Point(628, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 38);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.grpSummary.Controls.Add(this.lblPropertiesText);
            this.grpSummary.Controls.Add(this.lblPropertiesValue);
            this.grpSummary.Controls.Add(this.lblUnitsText);
            this.grpSummary.Controls.Add(this.lblUnitsValue);
            this.grpSummary.Controls.Add(this.lblTenantsText);
            this.grpSummary.Controls.Add(this.lblTenantsValue);
            this.grpSummary.Controls.Add(this.lblPaidRentText);
            this.grpSummary.Controls.Add(this.lblPaidRentValue);
            this.grpSummary.Controls.Add(this.lblUnpaidRentText);
            this.grpSummary.Controls.Add(this.lblUnpaidRentValue);
            this.grpSummary.Controls.Add(this.lblMaintenanceText);
            this.grpSummary.Controls.Add(this.lblMaintenanceValue);
            this.grpSummary.Controls.Add(this.lblComplaintsText);
            this.grpSummary.Controls.Add(this.lblComplaintsValue);
            this.grpSummary.Controls.Add(this.lblUtilitiesText);
            this.grpSummary.Controls.Add(this.lblUtilitiesValue);
            this.grpSummary.Location = new System.Drawing.Point(50, 228);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(1050, 190);
            this.grpSummary.TabIndex = 3;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";

            this.lblPropertiesText.AutoSize = true;
            this.lblPropertiesText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPropertiesText.Location = new System.Drawing.Point(32, 35);
            this.lblPropertiesText.Name = "lblPropertiesText";
            this.lblPropertiesText.Size = new System.Drawing.Size(100, 15);
            this.lblPropertiesText.TabIndex = 0;
            this.lblPropertiesText.Text = "Total Properties";

            this.lblPropertiesValue.AutoSize = true;
            this.lblPropertiesValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPropertiesValue.Location = new System.Drawing.Point(31, 56);
            this.lblPropertiesValue.Name = "lblPropertiesValue";
            this.lblPropertiesValue.Size = new System.Drawing.Size(29, 32);
            this.lblPropertiesValue.TabIndex = 1;
            this.lblPropertiesValue.Text = "0";

            this.lblUnitsText.AutoSize = true;
            this.lblUnitsText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUnitsText.Location = new System.Drawing.Point(280, 35);
            this.lblUnitsText.Name = "lblUnitsText";
            this.lblUnitsText.Size = new System.Drawing.Size(69, 15);
            this.lblUnitsText.TabIndex = 2;
            this.lblUnitsText.Text = "Total Units";

            this.lblUnitsValue.AutoSize = true;
            this.lblUnitsValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblUnitsValue.Location = new System.Drawing.Point(279, 56);
            this.lblUnitsValue.Name = "lblUnitsValue";
            this.lblUnitsValue.Size = new System.Drawing.Size(29, 32);
            this.lblUnitsValue.TabIndex = 3;
            this.lblUnitsValue.Text = "0";

            this.lblTenantsText.AutoSize = true;
            this.lblTenantsText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenantsText.Location = new System.Drawing.Point(520, 35);
            this.lblTenantsText.Name = "lblTenantsText";
            this.lblTenantsText.Size = new System.Drawing.Size(80, 15);
            this.lblTenantsText.TabIndex = 4;
            this.lblTenantsText.Text = "Total Tenants";

            this.lblTenantsValue.AutoSize = true;
            this.lblTenantsValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTenantsValue.Location = new System.Drawing.Point(519, 56);
            this.lblTenantsValue.Name = "lblTenantsValue";
            this.lblTenantsValue.Size = new System.Drawing.Size(29, 32);
            this.lblTenantsValue.TabIndex = 5;
            this.lblTenantsValue.Text = "0";

            this.lblPaidRentText.AutoSize = true;
            this.lblPaidRentText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaidRentText.Location = new System.Drawing.Point(760, 35);
            this.lblPaidRentText.Name = "lblPaidRentText";
            this.lblPaidRentText.Size = new System.Drawing.Size(61, 15);
            this.lblPaidRentText.TabIndex = 6;
            this.lblPaidRentText.Text = "Paid Rent";

            this.lblPaidRentValue.AutoSize = true;
            this.lblPaidRentValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPaidRentValue.Location = new System.Drawing.Point(759, 56);
            this.lblPaidRentValue.Name = "lblPaidRentValue";
            this.lblPaidRentValue.Size = new System.Drawing.Size(29, 32);
            this.lblPaidRentValue.TabIndex = 7;
            this.lblPaidRentValue.Text = "0";

            this.lblUnpaidRentText.AutoSize = true;
            this.lblUnpaidRentText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUnpaidRentText.Location = new System.Drawing.Point(32, 112);
            this.lblUnpaidRentText.Name = "lblUnpaidRentText";
            this.lblUnpaidRentText.Size = new System.Drawing.Size(76, 15);
            this.lblUnpaidRentText.TabIndex = 8;
            this.lblUnpaidRentText.Text = "Unpaid Rent";

            this.lblUnpaidRentValue.AutoSize = true;
            this.lblUnpaidRentValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblUnpaidRentValue.Location = new System.Drawing.Point(31, 133);
            this.lblUnpaidRentValue.Name = "lblUnpaidRentValue";
            this.lblUnpaidRentValue.Size = new System.Drawing.Size(29, 32);
            this.lblUnpaidRentValue.TabIndex = 9;
            this.lblUnpaidRentValue.Text = "0";

            this.lblMaintenanceText.AutoSize = true;
            this.lblMaintenanceText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaintenanceText.Location = new System.Drawing.Point(280, 112);
            this.lblMaintenanceText.Name = "lblMaintenanceText";
            this.lblMaintenanceText.Size = new System.Drawing.Size(127, 15);
            this.lblMaintenanceText.TabIndex = 10;
            this.lblMaintenanceText.Text = "Maintenance Requests";

            this.lblMaintenanceValue.AutoSize = true;
            this.lblMaintenanceValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMaintenanceValue.Location = new System.Drawing.Point(279, 133);
            this.lblMaintenanceValue.Name = "lblMaintenanceValue";
            this.lblMaintenanceValue.Size = new System.Drawing.Size(29, 32);
            this.lblMaintenanceValue.TabIndex = 11;
            this.lblMaintenanceValue.Text = "0";

            this.lblComplaintsText.AutoSize = true;
            this.lblComplaintsText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblComplaintsText.Location = new System.Drawing.Point(520, 112);
            this.lblComplaintsText.Name = "lblComplaintsText";
            this.lblComplaintsText.Size = new System.Drawing.Size(72, 15);
            this.lblComplaintsText.TabIndex = 12;
            this.lblComplaintsText.Text = "Complaints";

            this.lblComplaintsValue.AutoSize = true;
            this.lblComplaintsValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblComplaintsValue.Location = new System.Drawing.Point(519, 133);
            this.lblComplaintsValue.Name = "lblComplaintsValue";
            this.lblComplaintsValue.Size = new System.Drawing.Size(29, 32);
            this.lblComplaintsValue.TabIndex = 13;
            this.lblComplaintsValue.Text = "0";

            this.lblUtilitiesText.AutoSize = true;
            this.lblUtilitiesText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUtilitiesText.Location = new System.Drawing.Point(760, 112);
            this.lblUtilitiesText.Name = "lblUtilitiesText";
            this.lblUtilitiesText.Size = new System.Drawing.Size(71, 15);
            this.lblUtilitiesText.TabIndex = 14;
            this.lblUtilitiesText.Text = "Utility Bills";

            this.lblUtilitiesValue.AutoSize = true;
            this.lblUtilitiesValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblUtilitiesValue.Location = new System.Drawing.Point(759, 133);
            this.lblUtilitiesValue.Name = "lblUtilitiesValue";
            this.lblUtilitiesValue.Size = new System.Drawing.Size(29, 32);
            this.lblUtilitiesValue.TabIndex = 15;
            this.lblUtilitiesValue.Text = "0";

            this.lblReportDetails.AutoSize = true;
            this.lblReportDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblReportDetails.Location = new System.Drawing.Point(50, 440);
            this.lblReportDetails.Name = "lblReportDetails";
            this.lblReportDetails.Size = new System.Drawing.Size(109, 20);
            this.lblReportDetails.TabIndex = 4;
            this.lblReportDetails.Text = "Report Details";

            this.dgvReportSummary.AllowUserToAddRows = false;
            this.dgvReportSummary.AllowUserToDeleteRows = false;
            this.dgvReportSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportSummary.BackgroundColor = System.Drawing.Color.White;
            this.dgvReportSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCategory,
            this.colCount,
            this.colAmount,
            this.colStatus});
            this.dgvReportSummary.Location = new System.Drawing.Point(50, 469);
            this.dgvReportSummary.Name = "dgvReportSummary";
            this.dgvReportSummary.ReadOnly = true;
            this.dgvReportSummary.RowHeadersVisible = false;
            this.dgvReportSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportSummary.Size = new System.Drawing.Size(1050, 190);
            this.dgvReportSummary.TabIndex = 5;

            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;

            this.colCount.HeaderText = "Count";
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;

            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;

            this.colStatus.HeaderText = "Status / Notes";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;

            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Location = new System.Drawing.Point(970, 680);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 38);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1150, 740);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.grpFilters);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.lblReportDetails);
            this.Controls.Add(this.dgvReportSummary);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Summary";
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
