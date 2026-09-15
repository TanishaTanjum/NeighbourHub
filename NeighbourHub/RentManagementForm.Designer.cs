namespace NeighbourHub
{
    partial class RentManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpRentDetails;
        private System.Windows.Forms.Label lblFlatUnit;
        private System.Windows.Forms.ComboBox cmbFlatUnit;
        private System.Windows.Forms.Label lblMonthlyRent;
        private System.Windows.Forms.TextBox txtMonthlyRent;
        private System.Windows.Forms.Button btnSetRent;
        private System.Windows.Forms.Button btnEditRent;
        private System.Windows.Forms.Button btnDeleteRent;
        private System.Windows.Forms.DataGridView dgvRents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonthlyRent;
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
            this.grpRentDetails = new System.Windows.Forms.GroupBox();
            this.lblFlatUnit = new System.Windows.Forms.Label();
            this.cmbFlatUnit = new System.Windows.Forms.ComboBox();
            this.lblMonthlyRent = new System.Windows.Forms.Label();
            this.txtMonthlyRent = new System.Windows.Forms.TextBox();
            this.btnSetRent = new System.Windows.Forms.Button();
            this.btnEditRent = new System.Windows.Forms.Button();
            this.btnDeleteRent = new System.Windows.Forms.Button();
            this.dgvRents = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonthlyRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpRentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRents)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(48, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Rent Management";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.Location = new System.Drawing.Point(51, 77);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(338, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Set and manage monthly rent for each flat/unit.";

            this.grpRentDetails.Controls.Add(this.lblFlatUnit);
            this.grpRentDetails.Controls.Add(this.cmbFlatUnit);
            this.grpRentDetails.Controls.Add(this.lblMonthlyRent);
            this.grpRentDetails.Controls.Add(this.txtMonthlyRent);
            this.grpRentDetails.Controls.Add(this.btnSetRent);
            this.grpRentDetails.Controls.Add(this.btnEditRent);
            this.grpRentDetails.Controls.Add(this.btnDeleteRent);
            this.grpRentDetails.Location = new System.Drawing.Point(50, 121);
            this.grpRentDetails.Name = "grpRentDetails";
            this.grpRentDetails.Size = new System.Drawing.Size(1000, 165);
            this.grpRentDetails.TabIndex = 2;
            this.grpRentDetails.TabStop = false;

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
            this.cmbFlatUnit.Size = new System.Drawing.Size(360, 23);
            this.cmbFlatUnit.TabIndex = 1;

            this.lblMonthlyRent.AutoSize = true;
            this.lblMonthlyRent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyRent.Location = new System.Drawing.Point(430, 28);
            this.lblMonthlyRent.Name = "lblMonthlyRent";
            this.lblMonthlyRent.Size = new System.Drawing.Size(83, 15);
            this.lblMonthlyRent.TabIndex = 2;
            this.lblMonthlyRent.Text = "Monthly Rent";

            this.txtMonthlyRent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMonthlyRent.Location = new System.Drawing.Point(433, 49);
            this.txtMonthlyRent.Name = "txtMonthlyRent";
            this.txtMonthlyRent.Size = new System.Drawing.Size(210, 23);
            this.txtMonthlyRent.TabIndex = 3;

            this.btnSetRent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSetRent.Location = new System.Drawing.Point(31, 99);
            this.btnSetRent.Name = "btnSetRent";
            this.btnSetRent.Size = new System.Drawing.Size(130, 42);
            this.btnSetRent.TabIndex = 4;
            this.btnSetRent.Text = "Set Rent";
            this.btnSetRent.UseVisualStyleBackColor = true;
            this.btnSetRent.Click += new System.EventHandler(this.btnSetRent_Click);

            this.btnEditRent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditRent.Location = new System.Drawing.Point(181, 99);
            this.btnEditRent.Name = "btnEditRent";
            this.btnEditRent.Size = new System.Drawing.Size(130, 42);
            this.btnEditRent.TabIndex = 5;
            this.btnEditRent.Text = "Edit Rent";
            this.btnEditRent.UseVisualStyleBackColor = true;
            this.btnEditRent.Click += new System.EventHandler(this.btnEditRent_Click);

            this.btnDeleteRent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteRent.Location = new System.Drawing.Point(331, 99);
            this.btnDeleteRent.Name = "btnDeleteRent";
            this.btnDeleteRent.Size = new System.Drawing.Size(130, 42);
            this.btnDeleteRent.TabIndex = 6;
            this.btnDeleteRent.Text = "Delete Rent";
            this.btnDeleteRent.UseVisualStyleBackColor = true;
            this.btnDeleteRent.Click += new System.EventHandler(this.btnDeleteRent_Click);

            this.dgvRents.AllowUserToAddRows = false;
            this.dgvRents.AllowUserToDeleteRows = false;
            this.dgvRents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRents.BackgroundColor = System.Drawing.Color.White;
            this.dgvRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colID,
                this.colProperty,
                this.colUnitNumber,
                this.colMonthlyRent});
            this.dgvRents.Location = new System.Drawing.Point(50, 311);
            this.dgvRents.MultiSelect = false;
            this.dgvRents.Name = "dgvRents";
            this.dgvRents.ReadOnly = true;
            this.dgvRents.RowHeadersVisible = false;
            this.dgvRents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRents.Size = new System.Drawing.Size(1000, 245);
            this.dgvRents.TabIndex = 3;
            this.dgvRents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRents_CellClick);

            this.colID.FillWeight = 45F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;

            this.colProperty.HeaderText = "Property";
            this.colProperty.Name = "colProperty";
            this.colProperty.ReadOnly = true;

            this.colUnitNumber.HeaderText = "Flat / Unit No.";
            this.colUnitNumber.Name = "colUnitNumber";
            this.colUnitNumber.ReadOnly = true;

            this.colMonthlyRent.HeaderText = "Monthly Rent";
            this.colMonthlyRent.Name = "colMonthlyRent";
            this.colMonthlyRent.ReadOnly = true;

            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Location = new System.Drawing.Point(920, 576);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 635);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.grpRentDetails);
            this.Controls.Add(this.dgvRents);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RentManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Management";
            this.grpRentDetails.ResumeLayout(false);
            this.grpRentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
