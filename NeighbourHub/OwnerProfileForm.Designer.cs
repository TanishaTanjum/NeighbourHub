namespace NeighbourHub
{
    partial class OwnerProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.GroupBox grpAccountInfo;
        private System.Windows.Forms.Label lblAccountTypeText;
        private System.Windows.Forms.Label lblAccountTypeValue;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblProfileNote;
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
            this.grpProfile = new System.Windows.Forms.GroupBox();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.grpAccountInfo = new System.Windows.Forms.GroupBox();
            this.lblAccountTypeText = new System.Windows.Forms.Label();
            this.lblAccountTypeValue = new System.Windows.Forms.Label();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblProfileNote = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpProfile.SuspendLayout();
            this.grpAccountInfo.SuspendLayout();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(48, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Owner Profile";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.Location = new System.Drawing.Point(51, 77);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(350, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "View and update the property owner's account details.";

            this.grpProfile.Controls.Add(this.lblOwnerName);
            this.grpProfile.Controls.Add(this.txtOwnerName);
            this.grpProfile.Controls.Add(this.lblEmail);
            this.grpProfile.Controls.Add(this.txtEmail);
            this.grpProfile.Controls.Add(this.lblPhone);
            this.grpProfile.Controls.Add(this.txtPhone);
            this.grpProfile.Controls.Add(this.lblUsername);
            this.grpProfile.Controls.Add(this.txtUsername);
            this.grpProfile.Controls.Add(this.lblAddress);
            this.grpProfile.Controls.Add(this.txtAddress);
            this.grpProfile.Controls.Add(this.lblRole);
            this.grpProfile.Controls.Add(this.txtRole);
            this.grpProfile.Controls.Add(this.btnUpdateProfile);
            this.grpProfile.Controls.Add(this.btnChangePassword);
            this.grpProfile.Location = new System.Drawing.Point(50, 121);
            this.grpProfile.Name = "grpProfile";
            this.grpProfile.Size = new System.Drawing.Size(720, 410);
            this.grpProfile.TabIndex = 2;
            this.grpProfile.TabStop = false;
            this.grpProfile.Text = "Profile Details";

            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOwnerName.Location = new System.Drawing.Point(28, 35);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(83, 15);
            this.lblOwnerName.TabIndex = 0;
            this.lblOwnerName.Text = "Owner Name";

            this.txtOwnerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOwnerName.Location = new System.Drawing.Point(31, 56);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(300, 23);
            this.txtOwnerName.TabIndex = 1;

            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(369, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";

            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(372, 56);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 23);
            this.txtEmail.TabIndex = 3;

            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(28, 101);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 15);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";

            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(31, 122);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 23);
            this.txtPhone.TabIndex = 5;

            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(369, 101);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(63, 15);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";

            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.Location = new System.Drawing.Point(372, 122);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 23);
            this.txtUsername.TabIndex = 7;

            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(28, 167);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 15);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";

            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.Location = new System.Drawing.Point(31, 188);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(641, 70);
            this.txtAddress.TabIndex = 9;

            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(28, 280);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(32, 15);
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "Role";

            this.txtRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRole.Location = new System.Drawing.Point(31, 301);
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(220, 23);
            this.txtRole.TabIndex = 11;
            this.txtRole.Text = "Property Owner";

            this.btnUpdateProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateProfile.Location = new System.Drawing.Point(31, 347);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(150, 40);
            this.btnUpdateProfile.TabIndex = 12;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);

            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangePassword.Location = new System.Drawing.Point(201, 347);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(150, 40);
            this.btnChangePassword.TabIndex = 13;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);

            this.grpAccountInfo.Controls.Add(this.lblAccountTypeText);
            this.grpAccountInfo.Controls.Add(this.lblAccountTypeValue);
            this.grpAccountInfo.Controls.Add(this.lblStatusText);
            this.grpAccountInfo.Controls.Add(this.lblStatusValue);
            this.grpAccountInfo.Controls.Add(this.lblProfileNote);
            this.grpAccountInfo.Location = new System.Drawing.Point(795, 121);
            this.grpAccountInfo.Name = "grpAccountInfo";
            this.grpAccountInfo.Size = new System.Drawing.Size(305, 280);
            this.grpAccountInfo.TabIndex = 3;
            this.grpAccountInfo.TabStop = false;
            this.grpAccountInfo.Text = "Account Information";

            this.lblAccountTypeText.AutoSize = true;
            this.lblAccountTypeText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAccountTypeText.Location = new System.Drawing.Point(28, 40);
            this.lblAccountTypeText.Name = "lblAccountTypeText";
            this.lblAccountTypeText.Size = new System.Drawing.Size(82, 15);
            this.lblAccountTypeText.TabIndex = 0;
            this.lblAccountTypeText.Text = "Account Type";

            this.lblAccountTypeValue.AutoSize = true;
            this.lblAccountTypeValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAccountTypeValue.Location = new System.Drawing.Point(27, 62);
            this.lblAccountTypeValue.Name = "lblAccountTypeValue";
            this.lblAccountTypeValue.Size = new System.Drawing.Size(155, 25);
            this.lblAccountTypeValue.TabIndex = 1;
            this.lblAccountTypeValue.Text = "Property Owner";

            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusText.Location = new System.Drawing.Point(28, 115);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(88, 15);
            this.lblStatusText.TabIndex = 2;
            this.lblStatusText.Text = "Account Status";

            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStatusValue.Location = new System.Drawing.Point(27, 137);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(67, 25);
            this.lblStatusValue.TabIndex = 3;
            this.lblStatusValue.Text = "Active";

            this.lblProfileNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProfileNote.Location = new System.Drawing.Point(28, 190);
            this.lblProfileNote.Name = "lblProfileNote";
            this.lblProfileNote.Size = new System.Drawing.Size(245, 65);
            this.lblProfileNote.TabIndex = 4;
            this.lblProfileNote.Text = "Keep your contact information up to date so tenants and system records remain accurate.";

            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Location = new System.Drawing.Point(970, 556);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1150, 620);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.grpProfile);
            this.Controls.Add(this.grpAccountInfo);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OwnerProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner Profile";
            this.grpProfile.ResumeLayout(false);
            this.grpProfile.PerformLayout();
            this.grpAccountInfo.ResumeLayout(false);
            this.grpAccountInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
