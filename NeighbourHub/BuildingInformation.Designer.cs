namespace NeighbourHub
{
    partial class BuildingInformation
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
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTotalFloors = new System.Windows.Forms.Label();
            this.lblBuildingName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fieldPanel = new System.Windows.Forms.Panel();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.txtTotalUnits = new System.Windows.Forms.TextBox();
            this.lblTotalUnits = new System.Windows.Forms.Label();
            this.txtTotalFloors = new System.Windows.Forms.TextBox();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.brandLabel = new System.Windows.Forms.Label();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.lblFeatureDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.fieldPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Location = new System.Drawing.Point(76, 137);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(391, 20);
            this.txtBuildingName.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(73, 166);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblTotalFloors
            // 
            this.lblTotalFloors.AutoSize = true;
            this.lblTotalFloors.Location = new System.Drawing.Point(73, 277);
            this.lblTotalFloors.Name = "lblTotalFloors";
            this.lblTotalFloors.Size = new System.Drawing.Size(62, 13);
            this.lblTotalFloors.TabIndex = 5;
            this.lblTotalFloors.Text = "Total Floors";
            // 
            // lblBuildingName
            // 
            this.lblBuildingName.AutoSize = true;
            this.lblBuildingName.Location = new System.Drawing.Point(73, 104);
            this.lblBuildingName.Name = "lblBuildingName";
            this.lblBuildingName.Size = new System.Drawing.Size(75, 13);
            this.lblBuildingName.TabIndex = 4;
            this.lblBuildingName.Text = "Building Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Building Information";
            // 
            // fieldPanel
            // 
            this.fieldPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.fieldPanel.Controls.Add(this.rtbAddress);
            this.fieldPanel.Controls.Add(this.buttonSave);
            this.fieldPanel.Controls.Add(this.txtTotalUnits);
            this.fieldPanel.Controls.Add(this.lblTotalUnits);
            this.fieldPanel.Controls.Add(this.txtTotalFloors);
            this.fieldPanel.Controls.Add(this.txtBuildingName);
            this.fieldPanel.Controls.Add(this.lblAddress);
            this.fieldPanel.Controls.Add(this.lblTotalFloors);
            this.fieldPanel.Controls.Add(this.lblBuildingName);
            this.fieldPanel.Controls.Add(this.label1);
            this.fieldPanel.Location = new System.Drawing.Point(358, 91);
            this.fieldPanel.Name = "fieldPanel";
            this.fieldPanel.Size = new System.Drawing.Size(660, 520);
            this.fieldPanel.TabIndex = 2;
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(76, 197);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbAddress.Size = new System.Drawing.Size(363, 70);
            this.rtbAddress.TabIndex = 15;
            this.rtbAddress.Text = "";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(76, 437);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 38);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // txtTotalUnits
            // 
            this.txtTotalUnits.Location = new System.Drawing.Point(76, 368);
            this.txtTotalUnits.Name = "txtTotalUnits";
            this.txtTotalUnits.Size = new System.Drawing.Size(335, 20);
            this.txtTotalUnits.TabIndex = 13;
            // 
            // lblTotalUnits
            // 
            this.lblTotalUnits.AutoSize = true;
            this.lblTotalUnits.Location = new System.Drawing.Point(73, 337);
            this.lblTotalUnits.Name = "lblTotalUnits";
            this.lblTotalUnits.Size = new System.Drawing.Size(58, 13);
            this.lblTotalUnits.TabIndex = 12;
            this.lblTotalUnits.Text = "Total Units";
            // 
            // txtTotalFloors
            // 
            this.txtTotalFloors.Location = new System.Drawing.Point(76, 309);
            this.txtTotalFloors.Name = "txtTotalFloors";
            this.txtTotalFloors.Size = new System.Drawing.Size(350, 20);
            this.txtTotalFloors.TabIndex = 10;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(15, 478);
            this.btn8.Name = "btn8";
            this.btn8.Padding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.btn8.Size = new System.Drawing.Size(240, 42);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "Maintenance Management";
            this.btn8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(15, 528);
            this.btn9.Name = "btn9";
            this.btn9.Padding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.btn9.Size = new System.Drawing.Size(240, 42);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "Utility/Service Management";
            this.btn9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.btn10.FlatAppearance.BorderSize = 0;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn10.ForeColor = System.Drawing.Color.White;
            this.btn10.Location = new System.Drawing.Point(15, 578);
            this.btn10.Name = "btn10";
            this.btn10.Padding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.btn10.Size = new System.Drawing.Size(240, 42);
            this.btn10.TabIndex = 11;
            this.btn10.Text = "Building Dashboard";
            this.btn10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn10.UseVisualStyleBackColor = false;
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.btn11.FlatAppearance.BorderSize = 0;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn11.ForeColor = System.Drawing.Color.White;
            this.btn11.Location = new System.Drawing.Point(15, 628);
            this.btn11.Name = "btn11";
            this.btn11.Padding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.btn11.Size = new System.Drawing.Size(240, 42);
            this.btn11.TabIndex = 12;
            this.btn11.Text = "Building Report Generation";
            this.btn11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn11.UseVisualStyleBackColor = false;
            // 
            // menuPanel
            // 
            this.menuPanel.AutoScroll = true;
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(36)))), ((int)(((byte)(28)))));
            this.menuPanel.Controls.Add(this.brandLabel);
            this.menuPanel.Controls.Add(this.btn0);
            this.menuPanel.Controls.Add(this.btn1);
            this.menuPanel.Controls.Add(this.btn2);
            this.menuPanel.Controls.Add(this.btn3);
            this.menuPanel.Controls.Add(this.btn4);
            this.menuPanel.Controls.Add(this.btn5);
            this.menuPanel.Controls.Add(this.btn6);
            this.menuPanel.Controls.Add(this.btn7);
            this.menuPanel.Controls.Add(this.btn8);
            this.menuPanel.Controls.Add(this.btn9);
            this.menuPanel.Controls.Add(this.btn10);
            this.menuPanel.Controls.Add(this.btn11);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(270, 721);
            this.menuPanel.TabIndex = 7;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.brandLabel.ForeColor = System.Drawing.Color.White;
            this.brandLabel.Location = new System.Drawing.Point(18, 20);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(234, 37);
            this.brandLabel.TabIndex = 0;
            this.brandLabel.Text = "NEIGHBOURHUB";
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(15, 78);
            this.btn0.Name = "btn0";
            this.btn0.Padding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.btn0.Size = new System.Drawing.Size(240, 42);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "Login & Profile Management";
            this.btn0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(15, 128);
            this.btn1.Name = "btn1";
            this.btn1.Padding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.btn1.Size = new System.Drawing.Size(240, 42);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Building Information Management";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(15, 180);
            this.btn2.Name = "btn2";
            this.btn2.Padding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.btn2.Size = new System.Drawing.Size(240, 42);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Flat/Unit Management";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(15, 228);
            this.btn3.Name = "btn3";
            this.btn3.Padding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.btn3.Size = new System.Drawing.Size(240, 42);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "Resident/Tenant Management";
            this.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(12, 276);
            this.btn4.Name = "btn4";
            this.btn4.Padding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.btn4.Size = new System.Drawing.Size(240, 42);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "Notice Management";
            this.btn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(15, 328);
            this.btn5.Name = "btn5";
            this.btn5.Padding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.btn5.Size = new System.Drawing.Size(240, 42);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "Complaint Management";
            this.btn5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(15, 378);
            this.btn6.Name = "btn6";
            this.btn6.Padding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.btn6.Size = new System.Drawing.Size(240, 42);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "Visitor Entry Management";
            this.btn6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(15, 428);
            this.btn7.Name = "btn7";
            this.btn7.Padding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.btn7.Size = new System.Drawing.Size(240, 42);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "Emergency Contact Management";
            this.btn7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // lblFeatureDescription
            // 
            this.lblFeatureDescription.AutoSize = true;
            this.lblFeatureDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFeatureDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(85)))), ((int)(((byte)(75)))));
            this.lblFeatureDescription.Location = new System.Drawing.Point(32, 62);
            this.lblFeatureDescription.Name = "lblFeatureDescription";
            this.lblFeatureDescription.Size = new System.Drawing.Size(0, 19);
            this.lblFeatureDescription.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.lblTitle.Location = new System.Drawing.Point(318, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(542, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Building Information Management";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.contentPanel.Controls.Add(this.lblTitle);
            this.contentPanel.Controls.Add(this.lblFeatureDescription);
            this.contentPanel.Controls.Add(this.fieldPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1264, 721);
            this.contentPanel.TabIndex = 6;
            // 
            // BuildingInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 721);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.contentPanel);
            this.Name = "BuildingInformation";
            this.Text = "BuildingInformation";
            this.fieldPanel.ResumeLayout(false);
            this.fieldPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTotalFloors;
        private System.Windows.Forms.Label lblBuildingName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel fieldPanel;
        private System.Windows.Forms.TextBox txtTotalFloors;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Label lblFeatureDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label lblTotalUnits;
        private System.Windows.Forms.TextBox txtTotalUnits;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RichTextBox rtbAddress;
    }
}