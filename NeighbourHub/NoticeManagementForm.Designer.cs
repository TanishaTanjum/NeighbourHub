namespace NeighbourHub
{
    partial class NoticeManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpNoticeDetails;
        private System.Windows.Forms.Label lblNoticeTitle;
        private System.Windows.Forms.TextBox txtNoticeTitle;
        private System.Windows.Forms.Label lblAudience;
        private System.Windows.Forms.ComboBox cmbAudience;
        private System.Windows.Forms.Label lblPublishDate;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblNoticeText;
        private System.Windows.Forms.TextBox txtNoticeText;
        private System.Windows.Forms.Button btnAddNotice;
        private System.Windows.Forms.Button btnEditNotice;
        private System.Windows.Forms.Button btnDeleteNotice;
        private System.Windows.Forms.DataGridView dgvNotices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAudience;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPublishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoticeText;
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
            this.grpNoticeDetails = new System.Windows.Forms.GroupBox();
            this.lblNoticeTitle = new System.Windows.Forms.Label();
            this.txtNoticeTitle = new System.Windows.Forms.TextBox();
            this.lblAudience = new System.Windows.Forms.Label();
            this.cmbAudience = new System.Windows.Forms.ComboBox();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblNoticeText = new System.Windows.Forms.Label();
            this.txtNoticeText = new System.Windows.Forms.TextBox();
            this.btnAddNotice = new System.Windows.Forms.Button();
            this.btnEditNotice = new System.Windows.Forms.Button();
            this.btnDeleteNotice = new System.Windows.Forms.Button();
            this.dgvNotices = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAudience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoticeText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpNoticeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(48, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(312, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Notice Management";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.Location = new System.Drawing.Point(51, 77);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(383, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Create, update and manage notices for tenants and residents.";

            this.grpNoticeDetails.Controls.Add(this.lblNoticeTitle);
            this.grpNoticeDetails.Controls.Add(this.txtNoticeTitle);
            this.grpNoticeDetails.Controls.Add(this.lblAudience);
            this.grpNoticeDetails.Controls.Add(this.cmbAudience);
            this.grpNoticeDetails.Controls.Add(this.lblPublishDate);
            this.grpNoticeDetails.Controls.Add(this.dtpPublishDate);
            this.grpNoticeDetails.Controls.Add(this.lblExpiryDate);
            this.grpNoticeDetails.Controls.Add(this.dtpExpiryDate);
            this.grpNoticeDetails.Controls.Add(this.lblPriority);
            this.grpNoticeDetails.Controls.Add(this.cmbPriority);
            this.grpNoticeDetails.Controls.Add(this.lblNoticeText);
            this.grpNoticeDetails.Controls.Add(this.txtNoticeText);
            this.grpNoticeDetails.Controls.Add(this.btnAddNotice);
            this.grpNoticeDetails.Controls.Add(this.btnEditNotice);
            this.grpNoticeDetails.Controls.Add(this.btnDeleteNotice);
            this.grpNoticeDetails.Location = new System.Drawing.Point(50, 121);
            this.grpNoticeDetails.Name = "grpNoticeDetails";
            this.grpNoticeDetails.Size = new System.Drawing.Size(1050, 275);
            this.grpNoticeDetails.TabIndex = 2;
            this.grpNoticeDetails.TabStop = false;

            this.lblNoticeTitle.AutoSize = true;
            this.lblNoticeTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNoticeTitle.Location = new System.Drawing.Point(28, 28);
            this.lblNoticeTitle.Name = "lblNoticeTitle";
            this.lblNoticeTitle.Size = new System.Drawing.Size(73, 15);
            this.lblNoticeTitle.TabIndex = 0;
            this.lblNoticeTitle.Text = "Notice Title";

            this.txtNoticeTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNoticeTitle.Location = new System.Drawing.Point(31, 49);
            this.txtNoticeTitle.Name = "txtNoticeTitle";
            this.txtNoticeTitle.Size = new System.Drawing.Size(320, 23);
            this.txtNoticeTitle.TabIndex = 1;

            this.lblAudience.AutoSize = true;
            this.lblAudience.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAudience.Location = new System.Drawing.Point(385, 28);
            this.lblAudience.Name = "lblAudience";
            this.lblAudience.Size = new System.Drawing.Size(58, 15);
            this.lblAudience.TabIndex = 2;
            this.lblAudience.Text = "Audience";

            this.cmbAudience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAudience.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbAudience.FormattingEnabled = true;
            this.cmbAudience.Items.AddRange(new object[] {
            "All Tenants",
            "All Residents",
            "Specific Flat / Unit",
            "Property Wide"});
            this.cmbAudience.Location = new System.Drawing.Point(388, 49);
            this.cmbAudience.Name = "cmbAudience";
            this.cmbAudience.Size = new System.Drawing.Size(220, 23);
            this.cmbAudience.TabIndex = 3;

            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPriority.Location = new System.Drawing.Point(642, 28);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(49, 15);
            this.lblPriority.TabIndex = 4;
            this.lblPriority.Text = "Priority";

            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "Normal",
            "Important",
            "Urgent"});
            this.cmbPriority.Location = new System.Drawing.Point(645, 49);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(180, 23);
            this.cmbPriority.TabIndex = 5;

            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPublishDate.Location = new System.Drawing.Point(28, 91);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(77, 15);
            this.lblPublishDate.TabIndex = 6;
            this.lblPublishDate.Text = "Publish Date";

            this.dtpPublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublishDate.Location = new System.Drawing.Point(31, 112);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(170, 23);
            this.dtpPublishDate.TabIndex = 7;

            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExpiryDate.Location = new System.Drawing.Point(235, 91);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(68, 15);
            this.lblExpiryDate.TabIndex = 8;
            this.lblExpiryDate.Text = "Expiry Date";

            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiryDate.Location = new System.Drawing.Point(238, 112);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(170, 23);
            this.dtpExpiryDate.TabIndex = 9;

            this.lblNoticeText.AutoSize = true;
            this.lblNoticeText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNoticeText.Location = new System.Drawing.Point(28, 153);
            this.lblNoticeText.Name = "lblNoticeText";
            this.lblNoticeText.Size = new System.Drawing.Size(76, 15);
            this.lblNoticeText.TabIndex = 10;
            this.lblNoticeText.Text = "Notice Text";

            this.txtNoticeText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNoticeText.Location = new System.Drawing.Point(31, 174);
            this.txtNoticeText.Multiline = true;
            this.txtNoticeText.Name = "txtNoticeText";
            this.txtNoticeText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoticeText.Size = new System.Drawing.Size(794, 50);
            this.txtNoticeText.TabIndex = 11;

            this.btnAddNotice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNotice.Location = new System.Drawing.Point(31, 233);
            this.btnAddNotice.Name = "btnAddNotice";
            this.btnAddNotice.Size = new System.Drawing.Size(150, 34);
            this.btnAddNotice.TabIndex = 12;
            this.btnAddNotice.Text = "Add Notice";
            this.btnAddNotice.UseVisualStyleBackColor = true;
            this.btnAddNotice.Click += new System.EventHandler(this.btnAddNotice_Click);

            this.btnEditNotice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditNotice.Location = new System.Drawing.Point(201, 233);
            this.btnEditNotice.Name = "btnEditNotice";
            this.btnEditNotice.Size = new System.Drawing.Size(150, 34);
            this.btnEditNotice.TabIndex = 13;
            this.btnEditNotice.Text = "Edit Notice";
            this.btnEditNotice.UseVisualStyleBackColor = true;
            this.btnEditNotice.Click += new System.EventHandler(this.btnEditNotice_Click);

            this.btnDeleteNotice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteNotice.Location = new System.Drawing.Point(371, 233);
            this.btnDeleteNotice.Name = "btnDeleteNotice";
            this.btnDeleteNotice.Size = new System.Drawing.Size(150, 34);
            this.btnDeleteNotice.TabIndex = 14;
            this.btnDeleteNotice.Text = "Delete Notice";
            this.btnDeleteNotice.UseVisualStyleBackColor = true;
            this.btnDeleteNotice.Click += new System.EventHandler(this.btnDeleteNotice_Click);

            this.dgvNotices.AllowUserToAddRows = false;
            this.dgvNotices.AllowUserToDeleteRows = false;
            this.dgvNotices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotices.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTitle,
            this.colAudience,
            this.colPublishDate,
            this.colExpiryDate,
            this.colPriority,
            this.colNoticeText});
            this.dgvNotices.Location = new System.Drawing.Point(50, 421);
            this.dgvNotices.MultiSelect = false;
            this.dgvNotices.Name = "dgvNotices";
            this.dgvNotices.ReadOnly = true;
            this.dgvNotices.RowHeadersVisible = false;
            this.dgvNotices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotices.Size = new System.Drawing.Size(1050, 220);
            this.dgvNotices.TabIndex = 3;
            this.dgvNotices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotices_CellClick);

            this.colID.FillWeight = 35F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;

            this.colTitle.HeaderText = "Notice Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;

            this.colAudience.HeaderText = "Audience";
            this.colAudience.Name = "colAudience";
            this.colAudience.ReadOnly = true;

            this.colPublishDate.HeaderText = "Publish Date";
            this.colPublishDate.Name = "colPublishDate";
            this.colPublishDate.ReadOnly = true;

            this.colExpiryDate.HeaderText = "Expiry Date";
            this.colExpiryDate.Name = "colExpiryDate";
            this.colExpiryDate.ReadOnly = true;

            this.colPriority.HeaderText = "Priority";
            this.colPriority.Name = "colPriority";
            this.colPriority.ReadOnly = true;

            this.colNoticeText.HeaderText = "Notice Text";
            this.colNoticeText.Name = "colNoticeText";
            this.colNoticeText.ReadOnly = true;

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
            this.Controls.Add(this.grpNoticeDetails);
            this.Controls.Add(this.dgvNotices);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NoticeManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notice Management";
            this.grpNoticeDetails.ResumeLayout(false);
            this.grpNoticeDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
