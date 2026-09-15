namespace NeighbourHub
{
    partial class PaymentTrackingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpPaymentDetails;
        private System.Windows.Forms.Label lblAllocation;
        private System.Windows.Forms.ComboBox cmbAllocation;
        private System.Windows.Forms.Label lblRentMonth;
        private System.Windows.Forms.DateTimePicker dtpRentMonth;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnRecordPayment;
        private System.Windows.Forms.Button btnUpdatePayment;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlatUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRentMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDate;
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
            this.grpPaymentDetails = new System.Windows.Forms.GroupBox();
            this.lblAllocation = new System.Windows.Forms.Label();
            this.cmbAllocation = new System.Windows.Forms.ComboBox();
            this.lblRentMonth = new System.Windows.Forms.Label();
            this.dtpRentMonth = new System.Windows.Forms.DateTimePicker();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnRecordPayment = new System.Windows.Forms.Button();
            this.btnUpdatePayment = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlatUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRentMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpPaymentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(48, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(329, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Rent Payment Tracking";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.Location = new System.Drawing.Point(51, 77);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(374, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Track monthly rent payments and payment status.";

            this.grpPaymentDetails.Controls.Add(this.lblAllocation);
            this.grpPaymentDetails.Controls.Add(this.cmbAllocation);
            this.grpPaymentDetails.Controls.Add(this.lblRentMonth);
            this.grpPaymentDetails.Controls.Add(this.dtpRentMonth);
            this.grpPaymentDetails.Controls.Add(this.lblAmount);
            this.grpPaymentDetails.Controls.Add(this.txtAmount);
            this.grpPaymentDetails.Controls.Add(this.lblPaymentDate);
            this.grpPaymentDetails.Controls.Add(this.dtpPaymentDate);
            this.grpPaymentDetails.Controls.Add(this.lblStatus);
            this.grpPaymentDetails.Controls.Add(this.cmbStatus);
            this.grpPaymentDetails.Controls.Add(this.btnRecordPayment);
            this.grpPaymentDetails.Controls.Add(this.btnUpdatePayment);
            this.grpPaymentDetails.Controls.Add(this.btnDeletePayment);
            this.grpPaymentDetails.Location = new System.Drawing.Point(50, 121);
            this.grpPaymentDetails.Name = "grpPaymentDetails";
            this.grpPaymentDetails.Size = new System.Drawing.Size(1050, 205);
            this.grpPaymentDetails.TabIndex = 2;
            this.grpPaymentDetails.TabStop = false;

            this.lblAllocation.AutoSize = true;
            this.lblAllocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAllocation.Location = new System.Drawing.Point(28, 28);
            this.lblAllocation.Name = "lblAllocation";
            this.lblAllocation.Size = new System.Drawing.Size(91, 15);
            this.lblAllocation.TabIndex = 0;
            this.lblAllocation.Text = "Tenant / Flat";

            this.cmbAllocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAllocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbAllocation.FormattingEnabled = true;
            this.cmbAllocation.Location = new System.Drawing.Point(31, 49);
            this.cmbAllocation.Name = "cmbAllocation";
            this.cmbAllocation.Size = new System.Drawing.Size(330, 23);
            this.cmbAllocation.TabIndex = 1;

            this.lblRentMonth.AutoSize = true;
            this.lblRentMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRentMonth.Location = new System.Drawing.Point(394, 28);
            this.lblRentMonth.Name = "lblRentMonth";
            this.lblRentMonth.Size = new System.Drawing.Size(73, 15);
            this.lblRentMonth.TabIndex = 2;
            this.lblRentMonth.Text = "Rent Month";

            this.dtpRentMonth.CustomFormat = "MMMM yyyy";
            this.dtpRentMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRentMonth.Location = new System.Drawing.Point(397, 49);
            this.dtpRentMonth.Name = "dtpRentMonth";
            this.dtpRentMonth.ShowUpDown = true;
            this.dtpRentMonth.Size = new System.Drawing.Size(180, 23);
            this.dtpRentMonth.TabIndex = 3;

            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAmount.Location = new System.Drawing.Point(610, 28);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 15);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount";

            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.Location = new System.Drawing.Point(613, 49);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(170, 23);
            this.txtAmount.TabIndex = 5;

            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaymentDate.Location = new System.Drawing.Point(28, 91);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(84, 15);
            this.lblPaymentDate.TabIndex = 6;
            this.lblPaymentDate.Text = "Payment Date";

            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(31, 112);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(170, 23);
            this.dtpPaymentDate.TabIndex = 7;

            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(233, 91);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";

            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.cmbStatus.Location = new System.Drawing.Point(236, 112);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(160, 23);
            this.cmbStatus.TabIndex = 9;

            this.btnRecordPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecordPayment.Location = new System.Drawing.Point(455, 105);
            this.btnRecordPayment.Name = "btnRecordPayment";
            this.btnRecordPayment.Size = new System.Drawing.Size(150, 42);
            this.btnRecordPayment.TabIndex = 10;
            this.btnRecordPayment.Text = "Record Payment";
            this.btnRecordPayment.UseVisualStyleBackColor = true;
            this.btnRecordPayment.Click += new System.EventHandler(this.btnRecordPayment_Click);

            this.btnUpdatePayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdatePayment.Location = new System.Drawing.Point(625, 105);
            this.btnUpdatePayment.Name = "btnUpdatePayment";
            this.btnUpdatePayment.Size = new System.Drawing.Size(150, 42);
            this.btnUpdatePayment.TabIndex = 11;
            this.btnUpdatePayment.Text = "Update Payment";
            this.btnUpdatePayment.UseVisualStyleBackColor = true;
            this.btnUpdatePayment.Click += new System.EventHandler(this.btnUpdatePayment_Click);

            this.btnDeletePayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeletePayment.Location = new System.Drawing.Point(795, 105);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(150, 42);
            this.btnDeletePayment.TabIndex = 12;
            this.btnDeletePayment.Text = "Delete Payment";
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);

            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTenant,
            this.colFlatUnit,
            this.colRentMonth,
            this.colAmount,
            this.colPaymentDate,
            this.colStatus});
            this.dgvPayments.Location = new System.Drawing.Point(50, 351);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(1050, 245);
            this.dgvPayments.TabIndex = 3;
            this.dgvPayments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellClick);

            this.colID.FillWeight = 42F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;

            this.colTenant.HeaderText = "Tenant";
            this.colTenant.Name = "colTenant";
            this.colTenant.ReadOnly = true;

            this.colFlatUnit.HeaderText = "Flat / Unit";
            this.colFlatUnit.Name = "colFlatUnit";
            this.colFlatUnit.ReadOnly = true;

            this.colRentMonth.HeaderText = "Rent Month";
            this.colRentMonth.Name = "colRentMonth";
            this.colRentMonth.ReadOnly = true;

            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;

            this.colPaymentDate.HeaderText = "Payment Date";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.ReadOnly = true;

            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;

            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Location = new System.Drawing.Point(970, 616);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1150, 675);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.grpPaymentDetails);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PaymentTrackingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Payment Tracking";
            this.grpPaymentDetails.ResumeLayout(false);
            this.grpPaymentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
