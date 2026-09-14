namespace NeighbourHub
{
    partial class ReportForm
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
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnBuildings = new System.Windows.Forms.Button();
            this.btnComplaints = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(205, 118);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 46);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Reports";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(210, 178);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(174, 16);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Choose a report to generate";
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(210, 218);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(180, 45);
            this.btnUsers.TabIndex = 8;
            this.btnUsers.Text = "User Report";
            // 
            // btnBuildings
            // 
            this.btnBuildings.Location = new System.Drawing.Point(415, 218);
            this.btnBuildings.Name = "btnBuildings";
            this.btnBuildings.Size = new System.Drawing.Size(180, 45);
            this.btnBuildings.TabIndex = 9;
            this.btnBuildings.Text = "Building Report";
            // 
            // btnComplaints
            // 
            this.btnComplaints.Location = new System.Drawing.Point(210, 288);
            this.btnComplaints.Name = "btnComplaints";
            this.btnComplaints.Size = new System.Drawing.Size(180, 45);
            this.btnComplaints.TabIndex = 10;
            this.btnComplaints.Text = "Complaint Report";
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(415, 288);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(180, 45);
            this.btnPayments.TabIndex = 11;
            this.btnPayments.Text = "Payment Report";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnBuildings);
            this.Controls.Add(this.btnComplaints);
            this.Controls.Add(this.btnPayments);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnBuildings;
        private System.Windows.Forms.Button btnComplaints;
        private System.Windows.Forms.Button btnPayments;
    }
}