namespace NeighbourHub
{
    partial class AdminDashboard
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
            this.sidebar = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnManagement = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblBuildings = new System.Windows.Forms.Label();
            this.lblComplaints = new System.Windows.Forms.Label();
            this.lblPayments = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.sidebar.Controls.Add(this.lblBrand);
            this.sidebar.Controls.Add(this.btnManagement);
            this.sidebar.Controls.Add(this.btnReports);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(220, 450);
            this.sidebar.TabIndex = 11;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(25, 35);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(261, 46);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "NeighbourHub";
            // 
            // btnManagement
            // 
            this.btnManagement.Location = new System.Drawing.Point(20, 130);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(180, 42);
            this.btnManagement.TabIndex = 1;
            this.btnManagement.Text = "Management";
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(20, 185);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(180, 42);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(20, 450);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(339, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(337, 50);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Admin Dashboard";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblUsers.Location = new System.Drawing.Point(359, 140);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(159, 111);
            this.lblUsers.TabIndex = 7;
            this.lblUsers.Text = "Total Users\n\n24";
            // 
            // lblBuildings
            // 
            this.lblBuildings.AutoSize = true;
            this.lblBuildings.Font = this.lblUsers.Font;
            this.lblBuildings.Location = new System.Drawing.Point(579, 140);
            this.lblBuildings.Name = "lblBuildings";
            this.lblBuildings.Size = new System.Drawing.Size(136, 111);
            this.lblBuildings.TabIndex = 8;
            this.lblBuildings.Text = "Buildings\n\n08";
            // 
            // lblComplaints
            // 
            this.lblComplaints.AutoSize = true;
            this.lblComplaints.Font = this.lblUsers.Font;
            this.lblComplaints.Location = new System.Drawing.Point(359, 290);
            this.lblComplaints.Name = "lblComplaints";
            this.lblComplaints.Size = new System.Drawing.Size(163, 111);
            this.lblComplaints.TabIndex = 9;
            this.lblComplaints.Text = "Complaints\n\n12";
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Font = this.lblUsers.Font;
            this.lblPayments.Location = new System.Drawing.Point(579, 290);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(142, 111);
            this.lblPayments.TabIndex = 10;
            this.lblPayments.Text = "Payments\n\n56";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblBuildings);
            this.Controls.Add(this.lblComplaints);
            this.Controls.Add(this.lblPayments);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblBuildings;
        private System.Windows.Forms.Label lblComplaints;
        private System.Windows.Forms.Label lblPayments;
    }
}