using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class OwnerProfileForm : Form
    {
        private int currentUserId = 0;

        public OwnerProfileForm()
        {
            InitializeComponent();

            txtUsername.ReadOnly = true;
            txtRole.ReadOnly = true;

            LoadOwnerProfile();
        }

        private void LoadOwnerProfile()
        {
            DataTable table = Database.Query(
                @"SELECT TOP 1
                    UserId,
                    Name,
                    Email,
                    Phone,
                    Address,
                    Role
                  FROM dbo.Users
                  ORDER BY
                    CASE
                        WHEN Role LIKE '%Owner%' THEN 0
                        ELSE 1
                    END,
                    UserId"
            );

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("No user account was found.");
                return;
            }

            DataRow row = table.Rows[0];

            currentUserId =
                Convert.ToInt32(row["UserId"]);

            txtOwnerName.Text =
                row["Name"].ToString();

            txtEmail.Text =
                row["Email"].ToString();

            txtPhone.Text =
                row["Phone"].ToString();

            txtAddress.Text =
                row["Address"].ToString();

            txtRole.Text =
                row["Role"].ToString();

            txtUsername.Text =
                currentUserId.ToString();
        }

        private void btnUpdateProfile_Click(
            object sender,
            EventArgs e)
        {
            if (currentUserId == 0)
            {
                MessageBox.Show("No user account is loaded.");
                return;
            }

            if (txtOwnerName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your email.");
                return;
            }

            Database.Execute(
                @"UPDATE dbo.Users
                  SET Name = @Name,
                      Email = @Email,
                      Phone = @Phone,
                      Address = @Address
                  WHERE UserId = @UserId",
                new SqlParameter(
                    "@Name",
                    txtOwnerName.Text.Trim()
                ),
                new SqlParameter(
                    "@Email",
                    txtEmail.Text.Trim()
                ),
                new SqlParameter(
                    "@Phone",
                    txtPhone.Text.Trim()
                ),
                new SqlParameter(
                    "@Address",
                    txtAddress.Text.Trim()
                ),
                new SqlParameter(
                    "@UserId",
                    currentUserId
                )
            );

            MessageBox.Show(
                "Profile updated successfully."
            );

            LoadOwnerProfile();
        }

        private void btnChangePassword_Click(
            object sender,
            EventArgs e)
        {
            if (currentUserId == 0)
            {
                MessageBox.Show("No user account is loaded.");
                return;
            }

            Form passwordForm = new Form();

            passwordForm.Text = "Change Password";
            passwordForm.StartPosition =
                FormStartPosition.CenterParent;
            passwordForm.FormBorderStyle =
                FormBorderStyle.FixedDialog;
            passwordForm.MaximizeBox = false;
            passwordForm.MinimizeBox = false;
            passwordForm.ClientSize =
                new Size(360, 180);

            Label lblPassword = new Label();

            lblPassword.Text = "New Password";
            lblPassword.Location =
                new Point(30, 30);
            lblPassword.AutoSize = true;

            TextBox txtPassword = new TextBox();

            txtPassword.Location =
                new Point(30, 55);
            txtPassword.Width = 295;
            txtPassword.UseSystemPasswordChar = true;

            Label lblConfirm = new Label();

            lblConfirm.Text = "Confirm Password";
            lblConfirm.Location =
                new Point(30, 90);
            lblConfirm.AutoSize = true;

            TextBox txtConfirm = new TextBox();

            txtConfirm.Location =
                new Point(30, 115);
            txtConfirm.Width = 190;
            txtConfirm.UseSystemPasswordChar = true;

            Button btnSave = new Button();

            btnSave.Text = "Save";
            btnSave.Location =
                new Point(230, 112);
            btnSave.Size =
                new Size(95, 27);

            btnSave.Click += (s, args) =>
            {
                if (txtPassword.Text == "")
                {
                    MessageBox.Show(
                        "Please enter a new password."
                    );
                    return;
                }

                if (txtPassword.Text !=
                    txtConfirm.Text)
                {
                    MessageBox.Show(
                        "Passwords do not match."
                    );
                    return;
                }

                Database.Execute(
                    @"UPDATE dbo.Users
                      SET Password = @Password
                      WHERE UserId = @UserId",
                    new SqlParameter(
                        "@Password",
                        txtPassword.Text
                    ),
                    new SqlParameter(
                        "@UserId",
                        currentUserId
                    )
                );

                MessageBox.Show(
                    "Password changed successfully."
                );

                passwordForm.Close();
            };

            passwordForm.Controls.Add(lblPassword);
            passwordForm.Controls.Add(txtPassword);
            passwordForm.Controls.Add(lblConfirm);
            passwordForm.Controls.Add(txtConfirm);
            passwordForm.Controls.Add(btnSave);

            passwordForm.ShowDialog(this);
        }

        private void btnClose_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}