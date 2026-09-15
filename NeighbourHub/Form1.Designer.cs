namespace NeighbourHub
{
    partial class Dashboard
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.moduleTable = new System.Windows.Forms.TableLayoutPanel();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.b11 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.moduleTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(1097, 632);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 35);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(192, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 50);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Property Owner Dashboard";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(197, 108);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(259, 16);
            this.lblSubtitle.TabIndex = 9;
            this.lblSubtitle.Text = "Select a module to open its design screen.";
            // 
            // moduleTable
            // 
            this.moduleTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moduleTable.ColumnCount = 3;
            this.moduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333F));
            this.moduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333F));
            this.moduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333F));
            this.moduleTable.Controls.Add(this.b1, 0, 0);
            this.moduleTable.Controls.Add(this.b2, 1, 0);
            this.moduleTable.Controls.Add(this.b3, 2, 0);
            this.moduleTable.Controls.Add(this.b4, 0, 1);
            this.moduleTable.Controls.Add(this.b5, 1, 1);
            this.moduleTable.Controls.Add(this.b6, 2, 1);
            this.moduleTable.Controls.Add(this.b7, 0, 2);
            this.moduleTable.Controls.Add(this.b8, 1, 2);
            this.moduleTable.Controls.Add(this.b9, 2, 2);
            this.moduleTable.Controls.Add(this.b10, 0, 3);
            this.moduleTable.Controls.Add(this.b11, 1, 3);
            this.moduleTable.Location = new System.Drawing.Point(193, 148);
            this.moduleTable.Name = "moduleTable";
            this.moduleTable.RowCount = 4;
            this.moduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.moduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.moduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.moduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.moduleTable.Size = new System.Drawing.Size(820, 350);
            this.moduleTable.TabIndex = 10;
            // 
            // b1
            // 
            this.b1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b1.Location = new System.Drawing.Point(8, 8);
            this.b1.Margin = new System.Windows.Forms.Padding(8);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(257, 71);
            this.b1.TabIndex = 0;
            this.b1.Text = "Property Management";
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b2.Location = new System.Drawing.Point(281, 8);
            this.b2.Margin = new System.Windows.Forms.Padding(8);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(257, 71);
            this.b2.TabIndex = 1;
            this.b2.Text = "Flat Management";
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b3.Location = new System.Drawing.Point(554, 8);
            this.b3.Margin = new System.Windows.Forms.Padding(8);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(258, 71);
            this.b3.TabIndex = 2;
            this.b3.Text = "Tenant Management";
            // 
            // b4
            // 
            this.b4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b4.Location = new System.Drawing.Point(8, 95);
            this.b4.Margin = new System.Windows.Forms.Padding(8);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(257, 71);
            this.b4.TabIndex = 3;
            this.b4.Text = "Rent Management";
            // 
            // b5
            // 
            this.b5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b5.Location = new System.Drawing.Point(281, 95);
            this.b5.Margin = new System.Windows.Forms.Padding(8);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(257, 71);
            this.b5.TabIndex = 4;
            this.b5.Text = "Payment Tracking";
            // 
            // b6
            // 
            this.b6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b6.Location = new System.Drawing.Point(554, 95);
            this.b6.Margin = new System.Windows.Forms.Padding(8);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(258, 71);
            this.b6.TabIndex = 5;
            this.b6.Text = "Maintenance Requests";
            // 
            // b7
            // 
            this.b7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b7.Location = new System.Drawing.Point(8, 182);
            this.b7.Margin = new System.Windows.Forms.Padding(8);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(257, 71);
            this.b7.TabIndex = 6;
            this.b7.Text = "Complaint Management";
            // 
            // b8
            // 
            this.b8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b8.Location = new System.Drawing.Point(281, 182);
            this.b8.Margin = new System.Windows.Forms.Padding(8);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(257, 71);
            this.b8.TabIndex = 7;
            this.b8.Text = "Notice Management";
            // 
            // b9
            // 
            this.b9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b9.Location = new System.Drawing.Point(554, 182);
            this.b9.Margin = new System.Windows.Forms.Padding(8);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(258, 71);
            this.b9.TabIndex = 8;
            this.b9.Text = "Utility Bill Management";
            // 
            // b10
            // 
            this.b10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b10.Location = new System.Drawing.Point(8, 269);
            this.b10.Margin = new System.Windows.Forms.Padding(8);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(257, 73);
            this.b10.TabIndex = 9;
            this.b10.Text = "Reports & Summaries";
            // 
            // b11
            // 
            this.b11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b11.Location = new System.Drawing.Point(281, 269);
            this.b11.Margin = new System.Windows.Forms.Padding(8);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(257, 73);
            this.b11.TabIndex = 10;
            this.b11.Text = "Owner Profile";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(893, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Logout";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 637);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.moduleTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Name = "Dashboard";
            this.Text = "Owners Dashboard";
            this.moduleTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TableLayoutPanel moduleTable;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b10;
        private System.Windows.Forms.Button b11;
        private System.Windows.Forms.Button button1;
    }
}