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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            if (cmbRole.Items.Count > 0)
                cmbRole.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string role = Convert.ToString(cmbRole.SelectedItem);

            string gender = "";

            if (rbMale.Checked)
                gender = "Male";
            else if (rbFemale.Checked)
                gender = "Female";

            // Name
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(
                    "Please enter your name.",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtName.Focus();
                return;
            }

            if (name.Length < 2)
            {
                MessageBox.Show(
                    "Name must contain at least 2 characters.",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtName.Focus();
                return;
            }

            foreach (char c in name)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show(
                        "Name can contain letters and spaces only.",
                        "NeighbourHub",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtName.Focus();
                    return;
                }
            }

            // Email
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

            if (!email.Contains("@") || !email.Contains(".") ||
                email.StartsWith("@") || email.EndsWith("@"))
            {
                MessageBox.Show(
                    "Please enter a valid email address.",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return;
            }

            // Phone
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show(
                    "Please enter your phone number.",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPhone.Focus();
                return;
            }

            if (phone.Length != 11 ||
                !phone.StartsWith("01") ||
                !phone.All(char.IsDigit))
            {
                MessageBox.Show(
                    "Phone number must be 11 digits and start with 01.",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPhone.Focus();
                return;
            }

            // Gender
            if (string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show(
                    "Please select your gender.",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Address
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show(
                    "Please enter your address.",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAddress.Focus();
                return;
            }

            // Password
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter a password.",
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

            // Confirm Password
            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show(
                    "Please confirm your password.",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtConfirmPassword.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtConfirmPassword.Focus();
                return;
            }

            // Role
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
                // Check whether the email already exists
                string checkQuery = @"
                    SELECT COUNT(*)
                    FROM Users
                    WHERE Email = @Email";

                DataTable existingUser = Database.Query(
                    checkQuery,
                    new SqlParameter("@Email", email)
                );

                int count = Convert.ToInt32(existingUser.Rows[0][0]);

                if (count > 0)
                {
                    MessageBox.Show(
                        "This email is already registered.",
                        "NeighbourHub",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtEmail.Focus();
                    return;
                }

                // Save the new user
                string insertQuery = @"
                    INSERT INTO Users
                    (Name, Email, Password, Phone, Gender, Address, Role)
                    VALUES
                    (@Name, @Email, @Password, @Phone, @Gender, @Address, @Role)";

                int result = Database.Execute(
                    insertQuery,
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Password", password),
                    new SqlParameter("@Phone", phone),
                    new SqlParameter("@Gender", gender),
                    new SqlParameter("@Address", address),
                    new SqlParameter("@Role", role)
                );

                if (result > 0)
                {
                    MessageBox.Show(
                        "Registration successful!",
                        "NeighbourHub",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ClearFields();

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Registration could not be completed.",
                        "NeighbourHub",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save your information.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            rbMale.Checked = false;
            rbFemale.Checked = false;

            if (cmbRole.Items.Count > 0)
                cmbRole.SelectedIndex = 0;

            txtName.Focus();
        }
    }
}