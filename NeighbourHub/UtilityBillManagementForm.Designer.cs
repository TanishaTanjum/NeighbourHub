namespace NeighbourHub
{
    partial class UtilityBillManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpBillDetails;
        private System.Windows.Forms.Label lblFlatUnit;
        private System.Windows.Forms.ComboBox cmbFlatUnit;
        private System.Windows.Forms.Label lblUtilityType;
        private System.Windows.Forms.ComboBox cmbUtilityType;
        private System.Windows.Forms.Label lblBillingMonth;
        private System.Windows.Forms.DateTimePicker dtpBillingMonth;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnEditBill;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.DataGridView dgvUtilityBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlatUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUtilityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillingMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
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
            this.grpBillDetails = new System.Windows.Forms.GroupBox();
            this.lblFlatUnit = new System.Windows.Forms.Label();
            this.cmbFlatUnit = new System.Windows.Forms.ComboBox();
            this.lblUtilityType = new System.Windows.Forms.Label();
            this.cmbUtilityType = new System.Windows.Forms.ComboBox();
            this.lblBillingMonth = new System.Windows.Forms.Label();
            this.dtpBillingMonth = new System.Windows.Forms.DateTimePicker();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnEditBill = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.dgvUtilityBills = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlatUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUtilityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillingMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpBillDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilityBills)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(48, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(353, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Utility Bill Management";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.Location = new System.Drawing.Point(51, 77);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(397, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Add, update and track utility bills for each flat or unit.";

            this.grpBillDetails.Controls.Add(this.lblFlatUnit);
            this.grpBillDetails.Controls.Add(this.cmbFlatUnit);
            this.grpBillDetails.Controls.Add(this.lblUtilityType);
            this.grpBillDetails.Controls.Add(this.cmbUtilityType);
            this.grpBillDetails.Controls.Add(this.lblBillingMonth);
            this.grpBillDetails.Controls.Add(this.dtpBillingMonth);
            this.grpBillDetails.Controls.Add(this.lblAmount);
            this.grpBillDetails.Controls.Add(this.txtAmount);
            this.grpBillDetails.Controls.Add(this.lblDueDate);
            this.grpBillDetails.Controls.Add(this.dtpDueDate);
            this.grpBillDetails.Controls.Add(this.lblStatus);
            this.grpBillDetails.Controls.Add(this.cmbStatus);
            this.grpBillDetails.Controls.Add(this.btnAddBill);
            this.grpBillDetails.Controls.Add(this.btnEditBill);
            this.grpBillDetails.Controls.Add(this.btnDeleteBill);
            this.grpBillDetails.Location = new System.Drawing.Point(50, 121);
            this.grpBillDetails.Name = "grpBillDetails";
            this.grpBillDetails.Size = new System.Drawing.Size(1050, 220);
            this.grpBillDetails.TabIndex = 2;
            this.grpBillDetails.TabStop = false;

            this.lblFlatUnit.AutoSize = true;
            this.lblFlatUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFlatUnit.Location = new System.Drawing.Point(28, 28);
            this.lblFlatUnit.Name = "lblFlatUnit";
            this.lblFlatUnit.Size = new System.Drawing.Size(62, 15);
            this.lblFlatUnit.TabIndex = 0;
            this.lblFlatUnit.Text = "Flat / Unit";

            this.cmbFlatUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlatUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFlatUnit.FormattingEnabled = true;
            this.cmbFlatUnit.Location = new System.Drawing.Point(31, 49);
            this.cmbFlatUnit.Name = "cmbFlatUnit";
            this.cmbFlatUnit.Size = new System.Drawing.Size(280, 23);
            this.cmbFlatUnit.TabIndex = 1;

            this.lblUtilityType.AutoSize = true;
            this.lblUtilityType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUtilityType.Location = new System.Drawing.Point(347, 28);
            this.lblUtilityType.Name = "lblUtilityType";
            this.lblUtilityType.Size = new System.Drawing.Size(72, 15);
            this.lblUtilityType.TabIndex = 2;
            this.lblUtilityType.Text = "Utility Type";

            this.cmbUtilityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUtilityType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbUtilityType.FormattingEnabled = true;
            this.cmbUtilityType.Items.AddRange(new object[] {
            "Electricity",
            "Water",
            "Gas",
            "Internet",
            "Waste",
            "Other"});
            this.cmbUtilityType.Location = new System.Drawing.Point(350, 49);
            this.cmbUtilityType.Name = "cmbUtilityType";
            this.cmbUtilityType.Size = new System.Drawing.Size(210, 23);
            this.cmbUtilityType.TabIndex = 3;

            this.lblBillingMonth.AutoSize = true;
            this.lblBillingMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBillingMonth.Location = new System.Drawing.Point(596, 28);
            this.lblBillingMonth.Name = "lblBillingMonth";
            this.lblBillingMonth.Size = new System.Drawing.Size(84, 15);
            this.lblBillingMonth.TabIndex = 4;
            this.lblBillingMonth.Text = "Billing Month";

            this.dtpBillingMonth.CustomFormat = "MMMM yyyy";
            this.dtpBillingMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillingMonth.Location = new System.Drawing.Point(599, 49);
            this.dtpBillingMonth.Name = "dtpBillingMonth";
            this.dtpBillingMonth.ShowUpDown = true;
            this.dtpBillingMonth.Size = new System.Drawing.Size(180, 23);
            this.dtpBillingMonth.TabIndex = 5;

            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAmount.Location = new System.Drawing.Point(28, 93);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 15);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount";

            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.Location = new System.Drawing.Point(31, 114);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(180, 23);
            this.txtAmount.TabIndex = 7;

            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDueDate.Location = new System.Drawing.Point(249, 93);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(57, 15);
            this.lblDueDate.TabIndex = 8;
            this.lblDueDate.Text = "Due Date";

            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(252, 114);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(170, 23);
            this.dtpDueDate.TabIndex = 9;

            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(460, 93);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";

            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Unpaid",
            "Paid",
            "Overdue"});
            this.cmbStatus.Location = new System.Drawing.Point(463, 114);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(170, 23);
            this.cmbStatus.TabIndex = 11;

            this.btnAddBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddBill.Location = new System.Drawing.Point(31, 160);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(150, 38);
            this.btnAddBill.TabIndex = 12;
            this.btnAddBill.Text = "Add Bill";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);

            this.btnEditBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditBill.Location = new System.Drawing.Point(201, 160);
            this.btnEditBill.Name = "btnEditBill";
            this.btnEditBill.Size = new System.Drawing.Size(150, 38);
            this.btnEditBill.TabIndex = 13;
            this.btnEditBill.Text = "Edit Bill";
            this.btnEditBill.UseVisualStyleBackColor = true;
            this.btnEditBill.Click += new System.EventHandler(this.btnEditBill_Click);

            this.btnDeleteBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteBill.Location = new System.Drawing.Point(371, 160);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(150, 38);
            this.btnDeleteBill.TabIndex = 14;
            this.btnDeleteBill.Text = "Delete Bill";
            this.btnDeleteBill.UseVisualStyleBackColor = true;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);

            this.dgvUtilityBills.AllowUserToAddRows = false;
            this.dgvUtilityBills.AllowUserToDeleteRows = false;
            this.dgvUtilityBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUtilityBills.BackgroundColor = System.Drawing.Color.White;
            this.dgvUtilityBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilityBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colFlatUnit,
            this.colUtilityType,
            this.colBillingMonth,
            this.colAmount,
            this.colDueDate,
            this.colStatus});
            this.dgvUtilityBills.Location = new System.Drawing.Point(50, 366);
            this.dgvUtilityBills.MultiSelect = false;
            this.dgvUtilityBills.Name = "dgvUtilityBills";
            this.dgvUtilityBills.ReadOnly = true;
            this.dgvUtilityBills.RowHeadersVisible = false;
            this.dgvUtilityBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUtilityBills.Size = new System.Drawing.Size(1050, 260);
            this.dgvUtilityBills.TabIndex = 3;
            this.dgvUtilityBills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUtilityBills_CellClick);

            this.colID.FillWeight = 35F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;

            this.colFlatUnit.HeaderText = "Flat / Unit";
            this.colFlatUnit.Name = "colFlatUnit";
            this.colFlatUnit.ReadOnly = true;

            this.colUtilityType.HeaderText = "Utility Type";
            this.colUtilityType.Name = "colUtilityType";
            this.colUtilityType.ReadOnly = true;

            this.colBillingMonth.HeaderText = "Billing Month";
            this.colBillingMonth.Name = "colBillingMonth";
            this.colBillingMonth.ReadOnly = true;

            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;

            this.colDueDate.HeaderText = "Due Date";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;

            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;

            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Location = new System.Drawing.Point(970, 646);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1150, 705);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.grpBillDetails);
            this.Controls.Add(this.dgvUtilityBills);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UtilityBillManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utility Bill Management";
            this.grpBillDetails.ResumeLayout(false);
            this.grpBillDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilityBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
