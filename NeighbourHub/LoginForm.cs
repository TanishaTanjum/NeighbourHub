using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NeighbourHub
{
    public partial class LoginForm : Form
    {
        public static string CurrentUserEmail = "";
        public static string CurrentUserRole = "";

        public LoginForm()
        {
            InitializeComponent();

            cmbRole.SelectedIndex = 0;

        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string role = Convert.ToString(cmbRole.SelectedItem);

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(
                    "Please enter your email address.",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show(
                    "Please enter a valid email address.",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show(
                    "Password must be at least 6 characters.",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show(
                    "Please select a role.",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbRole.Focus();
                return;
            }

            try
            {
                string query = @"
                    SELECT UserId, Name, Email, Role
                    FROM Users
                    WHERE Email = @Email
                    AND Password = @Password
                    AND Role = @Role";

                DataTable result = Database.Query(
                    query,
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Password", password),
                    new SqlParameter("@Role", role)
                );

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Email, password or role is incorrect.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                CurrentUserEmail = Convert.ToString(result.Rows[0]["Email"]);
                CurrentUserRole = Convert.ToString(result.Rows[0]["Role"]);

                MessageBox.Show(
                    "Login successful!",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                BuildingManagerDashboard dashboard =
                    new BuildingManagerDashboard();

                this.Hide();
                dashboard.FormClosed += (s, args) => this.Close();
                dashboard.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to connect to the database.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();

            this.Hide();

            registerForm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            registerForm.Show();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

       
    }
}