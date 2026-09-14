namespace NeighbourHub
{
    partial class AdminManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(130, 123);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(348, 46);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Admin Management";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(135, 188);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(180, 16);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Choose a module to manage";
            // 
            // cmbModule
            // 
            this.cmbModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModule.Items.AddRange(new object[] {
            "Users",
            "Buildings",
            "Properties / Flats",
            "Residents / Tenants",
            "Managers",
            "Notices",
            "Complaints",
            "Payments / Rent"});
            this.cmbModule.Location = new System.Drawing.Point(135, 218);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(260, 24);
            this.cmbModule.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(420, 218);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 22);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Text = "Search...";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(135, 288);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(270, 288);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(405, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            // 
            // AdminManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cmbModule);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Name = "AdminManagement";
            this.Text = "AdminManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}