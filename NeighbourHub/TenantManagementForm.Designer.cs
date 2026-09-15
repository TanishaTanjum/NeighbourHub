namespace NeighbourHub
{
    partial class TenantManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpTenantDetails;
        private System.Windows.Forms.Label lblTenantName;
        private System.Windows.Forms.TextBox txtTenantName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblIdPassportNo;
        private System.Windows.Forms.TextBox txtIdPassportNo;
        private System.Windows.Forms.Button btnAddTenant;
        private System.Windows.Forms.Button btnEditTenant;
        private System.Windows.Forms.Button btnDeleteTenant;
        private System.Windows.Forms.DataGridView dgvTenants;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPassportNo;
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
            this.grpTenantDetails = new System.Windows.Forms.GroupBox();
            this.lblTenantName = new System.Windows.Forms.Label();
            this.txtTenantName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblIdPassportNo = new System.Windows.Forms.Label();
            this.txtIdPassportNo = new System.Windows.Forms.TextBox();
            this.btnAddTenant = new System.Windows.Forms.Button();
            this.btnEditTenant = new System.Windows.Forms.Button();
            this.btnDeleteTenant = new System.Windows.Forms.Button();
            this.dgvTenants = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdPassportNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpTenantDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenants)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(48, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(319, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tenant Management";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.Location = new System.Drawing.Point(51, 77);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(306, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Add, edit and manage tenant information.";

            this.grpTenantDetails.Controls.Add(this.lblTenantName);
            this.grpTenantDetails.Controls.Add(this.txtTenantName);
            this.grpTenantDetails.Controls.Add(this.lblPhone);
            this.grpTenantDetails.Controls.Add(this.txtPhone);
            this.grpTenantDetails.Controls.Add(this.lblEmail);
            this.grpTenantDetails.Controls.Add(this.txtEmail);
            this.grpTenantDetails.Controls.Add(this.lblIdPassportNo);
            this.grpTenantDetails.Controls.Add(this.txtIdPassportNo);
            this.grpTenantDetails.Controls.Add(this.btnAddTenant);
            this.grpTenantDetails.Controls.Add(this.btnEditTenant);
            this.grpTenantDetails.Controls.Add(this.btnDeleteTenant);
            this.grpTenantDetails.Location = new System.Drawing.Point(50, 121);
            this.grpTenantDetails.Name = "grpTenantDetails";
            this.grpTenantDetails.Size = new System.Drawing.Size(1000, 210);
            this.grpTenantDetails.TabIndex = 2;
            this.grpTenantDetails.TabStop = false;

            this.lblTenantName.AutoSize = true;
            this.lblTenantName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenantName.Location = new System.Drawing.Point(28, 28);
            this.lblTenantName.Name = "lblTenantName";
            this.lblTenantName.Size = new System.Drawing.Size(84, 15);
            this.lblTenantName.TabIndex = 0;
            this.lblTenantName.Text = "Tenant Name";

            this.txtTenantName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenantName.Location = new System.Drawing.Point(31, 49);
            this.txtTenantName.Name = "txtTenantName";
            this.txtTenantName.Size = new System.Drawing.Size(280, 23);
            this.txtTenantName.TabIndex = 1;

            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(352, 28);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 15);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone";

            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(355, 49);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 23);
            this.txtPhone.TabIndex = 3;

            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(28, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";

            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(31, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 23);
            this.txtEmail.TabIndex = 5;

            this.lblIdPassportNo.AutoSize = true;
            this.lblIdPassportNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdPassportNo.Location = new System.Drawing.Point(352, 94);
            this.lblIdPassportNo.Name = "lblIdPassportNo";
            this.lblIdPassportNo.Size = new System.Drawing.Size(99, 15);
            this.lblIdPassportNo.TabIndex = 6;
            this.lblIdPassportNo.Text = "ID / Passport No";

            this.txtIdPassportNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdPassportNo.Location = new System.Drawing.Point(355, 115);
            this.txtIdPassportNo.Name = "txtIdPassportNo";
            this.txtIdPassportNo.Size = new System.Drawing.Size(250, 23);
            this.txtIdPassportNo.TabIndex = 7;

            this.btnAddTenant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTenant.Location = new System.Drawing.Point(650, 50);
            this.btnAddTenant.Name = "btnAddTenant";
            this.btnAddTenant.Size = new System.Drawing.Size(130, 42);
            this.btnAddTenant.TabIndex = 8;
            this.btnAddTenant.Text = "Add Tenant";
            this.btnAddTenant.UseVisualStyleBackColor = true;
            this.btnAddTenant.Click += new System.EventHandler(this.btnAddTenant_Click);

            this.btnEditTenant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditTenant.Location = new System.Drawing.Point(800, 50);
            this.btnEditTenant.Name = "btnEditTenant";
            this.btnEditTenant.Size = new System.Drawing.Size(130, 42);
            this.btnEditTenant.TabIndex = 9;
            this.btnEditTenant.Text = "Edit Tenant";
            this.btnEditTenant.UseVisualStyleBackColor = true;
            this.btnEditTenant.Click += new System.EventHandler(this.btnEditTenant_Click);

            this.btnDeleteTenant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteTenant.Location = new System.Drawing.Point(650, 108);
            this.btnDeleteTenant.Name = "btnDeleteTenant";
            this.btnDeleteTenant.Size = new System.Drawing.Size(280, 42);
            this.btnDeleteTenant.TabIndex = 10;
            this.btnDeleteTenant.Text = "Delete Tenant";
            this.btnDeleteTenant.UseVisualStyleBackColor = true;
            this.btnDeleteTenant.Click += new System.EventHandler(this.btnDeleteTenant_Click);

            this.dgvTenants.AllowUserToAddRows = false;
            this.dgvTenants.AllowUserToDeleteRows = false;
            this.dgvTenants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTenants.BackgroundColor = System.Drawing.Color.White;
            this.dgvTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTenants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colID,
                this.colTenantName,
                this.colPhone,
                this.colEmail,
                this.colIdPassportNo});
            this.dgvTenants.Location = new System.Drawing.Point(50, 351);
            this.dgvTenants.MultiSelect = false;
            this.dgvTenants.Name = "dgvTenants";
            this.dgvTenants.ReadOnly = true;
            this.dgvTenants.RowHeadersVisible = false;
            this.dgvTenants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTenants.Size = new System.Drawing.Size(1000, 215);
            this.dgvTenants.TabIndex = 3;
            this.dgvTenants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTenants_CellClick);

            this.colID.FillWeight = 45F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;

            this.colTenantName.HeaderText = "Tenant Name";
            this.colTenantName.Name = "colTenantName";
            this.colTenantName.ReadOnly = true;

            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;

            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;

            this.colIdPassportNo.HeaderText = "ID / Passport No";
            this.colIdPassportNo.Name = "colIdPassportNo";
            this.colIdPassportNo.ReadOnly = true;

            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Location = new System.Drawing.Point(920, 584);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 640);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.grpTenantDetails);
            this.Controls.Add(this.dgvTenants);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TenantManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tenant Management";
            this.grpTenantDetails.ResumeLayout(false);
            this.grpTenantDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
