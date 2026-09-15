namespace NeighbourHub
{
    partial class MaintenanceRequestForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpRequestDetails;
        private System.Windows.Forms.Label lblFlatUnit;
        private System.Windows.Forms.ComboBox cmbFlatUnit;
        private System.Windows.Forms.Label lblRequestTitle;
        private System.Windows.Forms.TextBox txtRequestTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblRequestDate;
        private System.Windows.Forms.DateTimePicker dtpRequestDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Button btnEditRequest;
        private System.Windows.Forms.Button btnDeleteRequest;
        private System.Windows.Forms.DataGridView dgvMaintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlatUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDate;
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
            this.grpRequestDetails = new System.Windows.Forms.GroupBox();
            this.lblFlatUnit = new System.Windows.Forms.Label();
            this.cmbFlatUnit = new System.Windows.Forms.ComboBox();
            this.lblRequestTitle = new System.Windows.Forms.Label();
            this.txtRequestTitle = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblRequestDate = new System.Windows.Forms.Label();
            this.dtpRequestDate = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.btnEditRequest = new System.Windows.Forms.Button();
            this.btnDeleteRequest = new System.Windows.Forms.Button();
            this.dgvMaintenance = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlatUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpRequestDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(48, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(364, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Maintenance Requests";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.Location = new System.Drawing.Point(51, 77);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(386, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Add, update and track maintenance requests for flats/units.";

            this.grpRequestDetails.Controls.Add(this.lblFlatUnit);
            this.grpRequestDetails.Controls.Add(this.cmbFlatUnit);
            this.grpRequestDetails.Controls.Add(this.lblRequestTitle);
            this.grpRequestDetails.Controls.Add(this.txtRequestTitle);
            this.grpRequestDetails.Controls.Add(this.lblCategory);
            this.grpRequestDetails.Controls.Add(this.cmbCategory);
            this.grpRequestDetails.Controls.Add(this.lblRequestDate);
            this.grpRequestDetails.Controls.Add(this.dtpRequestDate);
            this.grpRequestDetails.Controls.Add(this.lblStatus);
            this.grpRequestDetails.Controls.Add(this.cmbStatus);
            this.grpRequestDetails.Controls.Add(this.lblDescription);
            this.grpRequestDetails.Controls.Add(this.txtDescription);
            this.grpRequestDetails.Controls.Add(this.btnAddRequest);
            this.grpRequestDetails.Controls.Add(this.btnEditRequest);
            this.grpRequestDetails.Controls.Add(this.btnDeleteRequest);
            this.grpRequestDetails.Location = new System.Drawing.Point(50, 121);
            this.grpRequestDetails.Name = "grpRequestDetails";
            this.grpRequestDetails.Size = new System.Drawing.Size(1050, 265);
            this.grpRequestDetails.TabIndex = 2;
            this.grpRequestDetails.TabStop = false;

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

            this.lblRequestTitle.AutoSize = true;
            this.lblRequestTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRequestTitle.Location = new System.Drawing.Point(346, 28);
            this.lblRequestTitle.Name = "lblRequestTitle";
            this.lblRequestTitle.Size = new System.Drawing.Size(81, 15);
            this.lblRequestTitle.TabIndex = 2;
            this.lblRequestTitle.Text = "Request Title";

            this.txtRequestTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRequestTitle.Location = new System.Drawing.Point(349, 49);
            this.txtRequestTitle.Name = "txtRequestTitle";
            this.txtRequestTitle.Size = new System.Drawing.Size(300, 23);
            this.txtRequestTitle.TabIndex = 3;

            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(684, 28);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 15);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category";

            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Plumbing",
            "Electrical",
            "Appliance",
            "Cleaning",
            "Structural",
            "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(687, 49);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(225, 23);
            this.cmbCategory.TabIndex = 5;

            this.lblRequestDate.AutoSize = true;
            this.lblRequestDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRequestDate.Location = new System.Drawing.Point(28, 91);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(80, 15);
            this.lblRequestDate.TabIndex = 6;
            this.lblRequestDate.Text = "Request Date";

            this.dtpRequestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequestDate.Location = new System.Drawing.Point(31, 112);
            this.dtpRequestDate.Name = "dtpRequestDate";
            this.dtpRequestDate.Size = new System.Drawing.Size(170, 23);
            this.dtpRequestDate.TabIndex = 7;

            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(236, 91);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";

            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(239, 112);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(170, 23);
            this.cmbStatus.TabIndex = 9;

            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(445, 91);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 15);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description";

            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Location = new System.Drawing.Point(448, 112);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(464, 62);
            this.txtDescription.TabIndex = 11;

            this.btnAddRequest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddRequest.Location = new System.Drawing.Point(31, 198);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(150, 42);
            this.btnAddRequest.TabIndex = 12;
            this.btnAddRequest.Text = "Add Request";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);

            this.btnEditRequest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditRequest.Location = new System.Drawing.Point(201, 198);
            this.btnEditRequest.Name = "btnEditRequest";
            this.btnEditRequest.Size = new System.Drawing.Size(150, 42);
            this.btnEditRequest.TabIndex = 13;
            this.btnEditRequest.Text = "Edit Request";
            this.btnEditRequest.UseVisualStyleBackColor = true;
            this.btnEditRequest.Click += new System.EventHandler(this.btnEditRequest_Click);

            this.btnDeleteRequest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteRequest.Location = new System.Drawing.Point(371, 198);
            this.btnDeleteRequest.Name = "btnDeleteRequest";
            this.btnDeleteRequest.Size = new System.Drawing.Size(150, 42);
            this.btnDeleteRequest.TabIndex = 14;
            this.btnDeleteRequest.Text = "Delete Request";
            this.btnDeleteRequest.UseVisualStyleBackColor = true;
            this.btnDeleteRequest.Click += new System.EventHandler(this.btnDeleteRequest_Click);

            this.dgvMaintenance.AllowUserToAddRows = false;
            this.dgvMaintenance.AllowUserToDeleteRows = false;
            this.dgvMaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaintenance.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colFlatUnit,
            this.colRequestTitle,
            this.colCategory,
            this.colRequestDate,
            this.colStatus,
            this.colDescription});
            this.dgvMaintenance.Location = new System.Drawing.Point(50, 411);
            this.dgvMaintenance.MultiSelect = false;
            this.dgvMaintenance.Name = "dgvMaintenance";
            this.dgvMaintenance.ReadOnly = true;
            this.dgvMaintenance.RowHeadersVisible = false;
            this.dgvMaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaintenance.Size = new System.Drawing.Size(1050, 230);
            this.dgvMaintenance.TabIndex = 3;
            this.dgvMaintenance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaintenance_CellClick);

            this.colID.FillWeight = 38F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;

            this.colFlatUnit.HeaderText = "Flat / Unit";
            this.colFlatUnit.Name = "colFlatUnit";
            this.colFlatUnit.ReadOnly = true;

            this.colRequestTitle.HeaderText = "Request Title";
            this.colRequestTitle.Name = "colRequestTitle";
            this.colRequestTitle.ReadOnly = true;

            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;

            this.colRequestDate.HeaderText = "Request Date";
            this.colRequestDate.Name = "colRequestDate";
            this.colRequestDate.ReadOnly = true;

            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;

            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;

            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Location = new System.Drawing.Point(970, 660);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1150, 720);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.grpRequestDetails);
            this.Controls.Add(this.dgvMaintenance);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MaintenanceRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance Requests";
            this.grpRequestDetails.ResumeLayout(false);
            this.grpRequestDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
