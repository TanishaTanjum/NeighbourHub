namespace NeighbourHub
{
    partial class FlatManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblProperty = new System.Windows.Forms.Label();
            this.cmbProperty = new System.Windows.Forms.ComboBox();
            this.lblUnitNumber = new System.Windows.Forms.Label();
            this.txtUnitNumber = new System.Windows.Forms.TextBox();
            this.lblFloor = new System.Windows.Forms.Label();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.lblBedrooms = new System.Windows.Forms.Label();
            this.txtBedrooms = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.btnEditUnit = new System.Windows.Forms.Button();
            this.btnDeleteUnit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvUnits = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBedrooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInput = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(42, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(436, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Flat / Unit Management";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.Location = new System.Drawing.Point(47, 76);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(367, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Add, edit and manage flats/units under each property.";
            // 
            // lblProperty
            // 
            this.lblProperty.AutoSize = true;
            this.lblProperty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProperty.Location = new System.Drawing.Point(24, 22);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(70, 20);
            this.lblProperty.TabIndex = 0;
            this.lblProperty.Text = "Property";
            // 
            // cmbProperty
            // 
            this.cmbProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProperty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProperty.FormattingEnabled = true;
            this.cmbProperty.Location = new System.Drawing.Point(28, 48);
            this.cmbProperty.Name = "cmbProperty";
            this.cmbProperty.Size = new System.Drawing.Size(275, 31);
            this.cmbProperty.TabIndex = 1;
            // 
            // lblUnitNumber
            // 
            this.lblUnitNumber.AutoSize = true;
            this.lblUnitNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUnitNumber.Location = new System.Drawing.Point(330, 22);
            this.lblUnitNumber.Name = "lblUnitNumber";
            this.lblUnitNumber.Size = new System.Drawing.Size(109, 20);
            this.lblUnitNumber.TabIndex = 2;
            this.lblUnitNumber.Text = "Flat / Unit No.";
            // 
            // txtUnitNumber
            // 
            this.txtUnitNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUnitNumber.Location = new System.Drawing.Point(334, 49);
            this.txtUnitNumber.Name = "txtUnitNumber";
            this.txtUnitNumber.Size = new System.Drawing.Size(175, 30);
            this.txtUnitNumber.TabIndex = 3;
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFloor.Location = new System.Drawing.Point(536, 22);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(45, 20);
            this.lblFloor.TabIndex = 4;
            this.lblFloor.Text = "Floor";
            // 
            // txtFloor
            // 
            this.txtFloor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFloor.Location = new System.Drawing.Point(540, 49);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(120, 30);
            this.txtFloor.TabIndex = 5;
            // 
            // lblBedrooms
            // 
            this.lblBedrooms.AutoSize = true;
            this.lblBedrooms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBedrooms.Location = new System.Drawing.Point(687, 22);
            this.lblBedrooms.Name = "lblBedrooms";
            this.lblBedrooms.Size = new System.Drawing.Size(81, 20);
            this.lblBedrooms.TabIndex = 6;
            this.lblBedrooms.Text = "Bedrooms";
            // 
            // txtBedrooms
            // 
            this.txtBedrooms.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBedrooms.Location = new System.Drawing.Point(691, 49);
            this.txtBedrooms.Name = "txtBedrooms";
            this.txtBedrooms.Size = new System.Drawing.Size(120, 30);
            this.txtBedrooms.TabIndex = 7;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDetails.Location = new System.Drawing.Point(24, 100);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(57, 20);
            this.lblDetails.TabIndex = 8;
            this.lblDetails.Text = "Details";
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDetails.Location = new System.Drawing.Point(28, 126);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(480, 58);
            this.txtDetails.TabIndex = 9;
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddUnit.Location = new System.Drawing.Point(540, 126);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(130, 44);
            this.btnAddUnit.TabIndex = 10;
            this.btnAddUnit.Text = "Add Unit";
            this.btnAddUnit.UseVisualStyleBackColor = true;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click_1);
            // 
            // btnEditUnit
            // 
            this.btnEditUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditUnit.Location = new System.Drawing.Point(686, 126);
            this.btnEditUnit.Name = "btnEditUnit";
            this.btnEditUnit.Size = new System.Drawing.Size(130, 44);
            this.btnEditUnit.TabIndex = 11;
            this.btnEditUnit.Text = "Edit Unit";
            this.btnEditUnit.UseVisualStyleBackColor = true;
            this.btnEditUnit.Click += new System.EventHandler(this.btnEditUnit_Click_1);
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteUnit.Location = new System.Drawing.Point(832, 126);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(130, 44);
            this.btnDeleteUnit.TabIndex = 12;
            this.btnDeleteUnit.Text = "Delete Unit";
            this.btnDeleteUnit.UseVisualStyleBackColor = true;
            this.btnDeleteUnit.Click += new System.EventHandler(this.btnDeleteUnit_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Location = new System.Drawing.Point(920, 595);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // dgvUnits
            // 
            this.dgvUnits.AllowUserToAddRows = false;
            this.dgvUnits.AllowUserToDeleteRows = false;
            this.dgvUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnits.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colProperty,
            this.colUnitNumber,
            this.colFloor,
            this.colBedrooms,
            this.colDetails});
            this.dgvUnits.Location = new System.Drawing.Point(50, 350);
            this.dgvUnits.MultiSelect = false;
            this.dgvUnits.Name = "dgvUnits";
            this.dgvUnits.ReadOnly = true;
            this.dgvUnits.RowHeadersWidth = 51;
            this.dgvUnits.RowTemplate.Height = 24;
            this.dgvUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnits.Size = new System.Drawing.Size(1000, 230);
            this.dgvUnits.TabIndex = 3;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.FillWeight = 45F;
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colProperty
            // 
            this.colProperty.DataPropertyName = "PropertyName";
            this.colProperty.HeaderText = "Property";
            this.colProperty.MinimumWidth = 6;
            this.colProperty.Name = "colProperty";
            this.colProperty.ReadOnly = true;
            // 
            // colUnitNumber
            // 
            this.colUnitNumber.DataPropertyName = "UnitNumber";
            this.colUnitNumber.FillWeight = 75F;
            this.colUnitNumber.HeaderText = "Unit No.";
            this.colUnitNumber.MinimumWidth = 6;
            this.colUnitNumber.Name = "colUnitNumber";
            this.colUnitNumber.ReadOnly = true;
            // 
            // colFloor
            // 
            this.colFloor.DataPropertyName = "Floor";
            this.colFloor.FillWeight = 60F;
            this.colFloor.HeaderText = "Floor";
            this.colFloor.MinimumWidth = 6;
            this.colFloor.Name = "colFloor";
            this.colFloor.ReadOnly = true;
            // 
            // colBedrooms
            // 
            this.colBedrooms.DataPropertyName = "Bedrooms";
            this.colBedrooms.FillWeight = 65F;
            this.colBedrooms.HeaderText = "Bedrooms";
            this.colBedrooms.MinimumWidth = 6;
            this.colBedrooms.Name = "colBedrooms";
            this.colBedrooms.ReadOnly = true;
            // 
            // colDetails
            // 
            this.colDetails.DataPropertyName = "Details";
            this.colDetails.FillWeight = 150F;
            this.colDetails.HeaderText = "Details";
            this.colDetails.MinimumWidth = 6;
            this.colDetails.Name = "colDetails";
            this.colDetails.ReadOnly = true;
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.White;
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.lblProperty);
            this.panelInput.Controls.Add(this.cmbProperty);
            this.panelInput.Controls.Add(this.lblUnitNumber);
            this.panelInput.Controls.Add(this.txtUnitNumber);
            this.panelInput.Controls.Add(this.lblFloor);
            this.panelInput.Controls.Add(this.txtFloor);
            this.panelInput.Controls.Add(this.lblBedrooms);
            this.panelInput.Controls.Add(this.txtBedrooms);
            this.panelInput.Controls.Add(this.lblDetails);
            this.panelInput.Controls.Add(this.txtDetails);
            this.panelInput.Controls.Add(this.btnAddUnit);
            this.panelInput.Controls.Add(this.btnEditUnit);
            this.panelInput.Controls.Add(this.btnDeleteUnit);
            this.panelInput.Location = new System.Drawing.Point(50, 120);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1000, 210);
            this.panelInput.TabIndex = 2;
            // 
            // FlatManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvUnits);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FlatManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flat / Unit Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.ComboBox cmbProperty;
        private System.Windows.Forms.Label lblUnitNumber;
        private System.Windows.Forms.TextBox txtUnitNumber;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.Label lblBedrooms;
        private System.Windows.Forms.TextBox txtBedrooms;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.Button btnEditUnit;
        private System.Windows.Forms.Button btnDeleteUnit;
        private System.Windows.Forms.DataGridView dgvUnits;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBedrooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetails;
    }
}
