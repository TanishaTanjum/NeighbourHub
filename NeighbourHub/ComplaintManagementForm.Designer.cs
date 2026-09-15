namespace NeighbourHub
{
    partial class ComplaintManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpComplaintDetails;
        private System.Windows.Forms.Label lblTenant;
        private System.Windows.Forms.ComboBox cmbTenant;
        private System.Windows.Forms.Label lblFlatUnit;
        private System.Windows.Forms.ComboBox cmbFlatUnit;
        private System.Windows.Forms.Label lblComplaintTitle;
        private System.Windows.Forms.TextBox txtComplaintTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblComplaintDate;
        private System.Windows.Forms.DateTimePicker dtpComplaintDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddComplaint;
        private System.Windows.Forms.Button btnEditComplaint;
        private System.Windows.Forms.Button btnDeleteComplaint;
        private System.Windows.Forms.DataGridView dgvComplaints;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlatUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplaintTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplaintDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
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
            this.grpComplaintDetails = new System.Windows.Forms.GroupBox();
            this.lblTenant = new System.Windows.Forms.Label();
            this.cmbTenant = new System.Windows.Forms.ComboBox();
            this.lblFlatUnit = new System.Windows.Forms.Label();
            this.cmbFlatUnit = new System.Windows.Forms.ComboBox();
            this.lblComplaintTitle = new System.Windows.Forms.Label();
            this.txtComplaintTitle = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblComplaintDate = new System.Windows.Forms.Label();
            this.dtpComplaintDate = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddComplaint = new System.Windows.Forms.Button();
            this.btnEditComplaint = new System.Windows.Forms.Button();
            this.btnDeleteComplaint = new System.Windows.Forms.Button();
            this.dgvComplaints = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlatUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplaintTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplaintDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpComplaintDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(48, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(365, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Complaint Management";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.Location = new System.Drawing.Point(51, 77);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(397, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Add, update and track tenant complaints and their status.";

            this.grpComplaintDetails.Controls.Add(this.lblTenant);
            this.grpComplaintDetails.Controls.Add(this.cmbTenant);
            this.grpComplaintDetails.Controls.Add(this.lblFlatUnit);
            this.grpComplaintDetails.Controls.Add(this.cmbFlatUnit);
            this.grpComplaintDetails.Controls.Add(this.lblComplaintTitle);
            this.grpComplaintDetails.Controls.Add(this.txtComplaintTitle);
            this.grpComplaintDetails.Controls.Add(this.lblCategory);
            this.grpComplaintDetails.Controls.Add(this.cmbCategory);
            this.grpComplaintDetails.Controls.Add(this.lblComplaintDate);
            this.grpComplaintDetails.Controls.Add(this.dtpComplaintDate);
            this.grpComplaintDetails.Controls.Add(this.lblStatus);
            this.grpComplaintDetails.Controls.Add(this.cmbStatus);
            this.grpComplaintDetails.Controls.Add(this.lblDescription);
            this.grpComplaintDetails.Controls.Add(this.txtDescription);
            this.grpComplaintDetails.Controls.Add(this.btnAddComplaint);
            this.grpComplaintDetails.Controls.Add(this.btnEditComplaint);
            this.grpComplaintDetails.Controls.Add(this.btnDeleteComplaint);
            this.grpComplaintDetails.Location = new System.Drawing.Point(50, 121);
            this.grpComplaintDetails.Name = "grpComplaintDetails";
            this.grpComplaintDetails.Size = new System.Drawing.Size(1050, 290);
            this.grpComplaintDetails.TabIndex = 2;
            this.grpComplaintDetails.TabStop = false;

            this.lblTenant.AutoSize = true;
            this.lblTenant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenant.Location = new System.Drawing.Point(28, 28);
            this.lblTenant.Name = "lblTenant";
            this.lblTenant.Size = new System.Drawing.Size(45, 15);
            this.lblTenant.TabIndex = 0;
            this.lblTenant.Text = "Tenant";

            this.cmbTenant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTenant.FormattingEnabled = true;
            this.cmbTenant.Location = new System.Drawing.Point(31, 49);
            this.cmbTenant.Name = "cmbTenant";
            this.cmbTenant.Size = new System.Drawing.Size(260, 23);
            this.cmbTenant.TabIndex = 1;

            this.lblFlatUnit.AutoSize = true;
            this.lblFlatUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFlatUnit.Location = new System.Drawing.Point(324, 28);
            this.lblFlatUnit.Name = "lblFlatUnit";
            this.lblFlatUnit.Size = new System.Drawing.Size(62, 15);
            this.lblFlatUnit.TabIndex = 2;
            this.lblFlatUnit.Text = "Flat / Unit";

            this.cmbFlatUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlatUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFlatUnit.FormattingEnabled = true;
            this.cmbFlatUnit.Location = new System.Drawing.Point(327, 49);
            this.cmbFlatUnit.Name = "cmbFlatUnit";
            this.cmbFlatUnit.Size = new System.Drawing.Size(250, 23);
            this.cmbFlatUnit.TabIndex = 3;

            this.lblComplaintTitle.AutoSize = true;
            this.lblComplaintTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblComplaintTitle.Location = new System.Drawing.Point(610, 28);
            this.lblComplaintTitle.Name = "lblComplaintTitle";
            this.lblComplaintTitle.Size = new System.Drawing.Size(94, 15);
            this.lblComplaintTitle.TabIndex = 4;
            this.lblComplaintTitle.Text = "Complaint Title";

            this.txtComplaintTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComplaintTitle.Location = new System.Drawing.Point(613, 49);
            this.txtComplaintTitle.Name = "txtComplaintTitle";
            this.txtComplaintTitle.Size = new System.Drawing.Size(300, 23);
            this.txtComplaintTitle.TabIndex = 5;

            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(28, 91);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 15);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category";

            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Noise",
            "Neighbour",
            "Cleanliness",
            "Security",
            "Parking",
            "Management",
            "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(31, 112);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(180, 23);
            this.cmbCategory.TabIndex = 7;

            this.lblComplaintDate.AutoSize = true;
            this.lblComplaintDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblComplaintDate.Location = new System.Drawing.Point(243, 91);
            this.lblComplaintDate.Name = "lblComplaintDate";
            this.lblComplaintDate.Size = new System.Drawing.Size(95, 15);
            this.lblComplaintDate.TabIndex = 8;
            this.lblComplaintDate.Text = "Complaint Date";

            this.dtpComplaintDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpComplaintDate.Location = new System.Drawing.Point(246, 112);
            this.dtpComplaintDate.Name = "dtpComplaintDate";
            this.dtpComplaintDate.Size = new System.Drawing.Size(170, 23);
            this.dtpComplaintDate.TabIndex = 9;

            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(448, 91);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";

            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Resolved"});
            this.cmbStatus.Location = new System.Drawing.Point(451, 112);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(170, 23);
            this.cmbStatus.TabIndex = 11;

            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(28, 155);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 15);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";

            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Location = new System.Drawing.Point(31, 176);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(882, 48);
            this.txtDescription.TabIndex = 13;

            this.btnAddComplaint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddComplaint.Location = new System.Drawing.Point(31, 239);
            this.btnAddComplaint.Name = "btnAddComplaint";
            this.btnAddComplaint.Size = new System.Drawing.Size(150, 38);
            this.btnAddComplaint.TabIndex = 14;
            this.btnAddComplaint.Text = "Add Complaint";
            this.btnAddComplaint.UseVisualStyleBackColor = true;
            this.btnAddComplaint.Click += new System.EventHandler(this.btnAddComplaint_Click);

            this.btnEditComplaint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditComplaint.Location = new System.Drawing.Point(201, 239);
            this.btnEditComplaint.Name = "btnEditComplaint";
            this.btnEditComplaint.Size = new System.Drawing.Size(150, 38);
            this.btnEditComplaint.TabIndex = 15;
            this.btnEditComplaint.Text = "Edit Complaint";
            this.btnEditComplaint.UseVisualStyleBackColor = true;
            this.btnEditComplaint.Click += new System.EventHandler(this.btnEditComplaint_Click);

            this.btnDeleteComplaint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteComplaint.Location = new System.Drawing.Point(371, 239);
            this.btnDeleteComplaint.Name = "btnDeleteComplaint";
            this.btnDeleteComplaint.Size = new System.Drawing.Size(150, 38);
            this.btnDeleteComplaint.TabIndex = 16;
            this.btnDeleteComplaint.Text = "Delete Complaint";
            this.btnDeleteComplaint.UseVisualStyleBackColor = true;
            this.btnDeleteComplaint.Click += new System.EventHandler(this.btnDeleteComplaint_Click);

            this.dgvComplaints.AllowUserToAddRows = false;
            this.dgvComplaints.AllowUserToDeleteRows = false;
            this.dgvComplaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComplaints.BackgroundColor = System.Drawing.Color.White;
            this.dgvComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplaints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTenant,
            this.colFlatUnit,
            this.colComplaintTitle,
            this.colCategory,
            this.colComplaintDate,
            this.colStatus,
            this.colDescription});
            this.dgvComplaints.Location = new System.Drawing.Point(50, 436);
            this.dgvComplaints.MultiSelect = false;
            this.dgvComplaints.Name = "dgvComplaints";
            this.dgvComplaints.ReadOnly = true;
            this.dgvComplaints.RowHeadersVisible = false;
            this.dgvComplaints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaints.Size = new System.Drawing.Size(1050, 220);
            this.dgvComplaints.TabIndex = 3;
            this.dgvComplaints.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComplaints_CellClick);

            this.colID.FillWeight = 35F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;

            this.colTenant.HeaderText = "Tenant";
            this.colTenant.Name = "colTenant";
            this.colTenant.ReadOnly = true;

            this.colFlatUnit.HeaderText = "Flat / Unit";
            this.colFlatUnit.Name = "colFlatUnit";
            this.colFlatUnit.ReadOnly = true;

            this.colComplaintTitle.HeaderText = "Complaint Title";
            this.colComplaintTitle.Name = "colComplaintTitle";
            this.colComplaintTitle.ReadOnly = true;

            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;

            this.colComplaintDate.HeaderText = "Date";
            this.colComplaintDate.Name = "colComplaintDate";
            this.colComplaintDate.ReadOnly = true;

            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;

            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;

            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Location = new System.Drawing.Point(970, 675);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1150, 735);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.grpComplaintDetails);
            this.Controls.Add(this.dgvComplaints);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ComplaintManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complaint Management";
            this.grpComplaintDetails.ResumeLayout(false);
            this.grpComplaintDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
