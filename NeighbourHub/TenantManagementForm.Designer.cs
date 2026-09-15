namespace NeighbourHub
{
    partial class TenantManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTenantName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIdPassport;
        private System.Windows.Forms.TextBox txtTenantName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIdPassportNo;
        private System.Windows.Forms.Button btnAddTenant;
        private System.Windows.Forms.Button btnEditTenant;
        private System.Windows.Forms.Button btnDeleteTenant;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTenants;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPassport;

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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenantName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIdPassport = new System.Windows.Forms.Label();
            this.txtTenantName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtIdPassportNo = new System.Windows.Forms.TextBox();
            this.btnAddTenant = new System.Windows.Forms.Button();
            this.btnEditTenant = new System.Windows.Forms.Button();
            this.btnDeleteTenant = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvTenants = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenants)).BeginInit();
            this.SuspendLayout();

            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 105);
            this.panelHeader.TabIndex = 0;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(28, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tenant Management";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitle.Location = new System.Drawing.Point(31, 67);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(349, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Add, edit and manage tenant information.";

            this.lblTenantName.AutoSize = true;
            this.lblTenantName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenantName.Location = new System.Drawing.Point(32, 137);
            this.lblTenantName.Name = "lblTenantName";
            this.lblTenantName.Size = new System.Drawing.Size(92, 19);
            this.lblTenantName.TabIndex = 1;
            this.lblTenantName.Text = "Tenant Name";

            this.txtTenantName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenantName.Location = new System.Drawing.Point(35, 163);
            this.txtTenantName.Name = "txtTenantName";
            this.txtTenantName.Size = new System.Drawing.Size(425, 25);
            this.txtTenantName.TabIndex = 2;

            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(506, 137);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 19);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone";

            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(509, 163);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(425, 25);
            this.txtPhone.TabIndex = 4;

            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(32, 211);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 19);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";

            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(35, 237);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(425, 25);
            this.txtEmail.TabIndex = 6;

            this.lblIdPassport.AutoSize = true;
            this.lblIdPassport.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblIdPassport.Location = new System.Drawing.Point(506, 211);
            this.lblIdPassport.Name = "lblIdPassport";
            this.lblIdPassport.Size = new System.Drawing.Size(113, 19);
            this.lblIdPassport.TabIndex = 7;
            this.lblIdPassport.Text = "ID / Passport No";

            this.txtIdPassportNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdPassportNo.Location = new System.Drawing.Point(509, 237);
            this.txtIdPassportNo.Name = "txtIdPassportNo";
            this.txtIdPassportNo.Size = new System.Drawing.Size(425, 25);
            this.txtIdPassportNo.TabIndex = 8;

            this.btnAddTenant.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnAddTenant.FlatAppearance.BorderSize = 0;
            this.btnAddTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTenant.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddTenant.ForeColor = System.Drawing.Color.White;
            this.btnAddTenant.Location = new System.Drawing.Point(35, 292);
            this.btnAddTenant.Name = "btnAddTenant";
            this.btnAddTenant.Size = new System.Drawing.Size(130, 38);
            this.btnAddTenant.TabIndex = 9;
            this.btnAddTenant.Text = "Add Tenant";
            this.btnAddTenant.UseVisualStyleBackColor = false;

            this.btnEditTenant.BackColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnEditTenant.FlatAppearance.BorderSize = 0;
            this.btnEditTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTenant.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditTenant.ForeColor = System.Drawing.Color.White;
            this.btnEditTenant.Location = new System.Drawing.Point(177, 292);
            this.btnEditTenant.Name = "btnEditTenant";
            this.btnEditTenant.Size = new System.Drawing.Size(130, 38);
            this.btnEditTenant.TabIndex = 10;
            this.btnEditTenant.Text = "Edit Tenant";
            this.btnEditTenant.UseVisualStyleBackColor = false;

            this.btnDeleteTenant.BackColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnDeleteTenant.FlatAppearance.BorderSize = 0;
            this.btnDeleteTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTenant.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTenant.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTenant.Location = new System.Drawing.Point(319, 292);
            this.btnDeleteTenant.Name = "btnDeleteTenant";
            this.btnDeleteTenant.Size = new System.Drawing.Size(130, 38);
            this.btnDeleteTenant.TabIndex = 11;
            this.btnDeleteTenant.Text = "Delete Tenant";
            this.btnDeleteTenant.UseVisualStyleBackColor = false;

            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(804, 292);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 38);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;

            this.dgvTenants.AllowUserToAddRows = false;
            this.dgvTenants.AllowUserToDeleteRows = false;
            this.dgvTenants.AllowUserToResizeRows = false;
            this.dgvTenants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTenants.BackgroundColor = System.Drawing.Color.White;
            this.dgvTenants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTenants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTenantName,
            this.colPhone,
            this.colEmail,
            this.colIdPassport});
            this.dgvTenants.Location = new System.Drawing.Point(35, 359);
            this.dgvTenants.MultiSelect = false;
            this.dgvTenants.Name = "dgvTenants";
            this.dgvTenants.ReadOnly = true;
            this.dgvTenants.RowHeadersVisible = false;
            this.dgvTenants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTenants.Size = new System.Drawing.Size(899, 270);
            this.dgvTenants.TabIndex = 13;

            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.FillWeight = 45F;

            this.colTenantName.HeaderText = "Tenant Name";
            this.colTenantName.Name = "colTenantName";
            this.colTenantName.ReadOnly = true;

            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;

            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;

            this.colIdPassport.HeaderText = "ID / Passport No";
            this.colIdPassport.Name = "colIdPassport";
            this.colIdPassport.ReadOnly = true;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 248);
            this.ClientSize = new System.Drawing.Size(1000, 665);
            this.Controls.Add(this.dgvTenants);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteTenant);
            this.Controls.Add(this.btnEditTenant);
            this.Controls.Add(this.btnAddTenant);
            this.Controls.Add(this.txtIdPassportNo);
            this.Controls.Add(this.lblIdPassport);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtTenantName);
            this.Controls.Add(this.lblTenantName);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TenantManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeighbourHub - Tenant Management";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
