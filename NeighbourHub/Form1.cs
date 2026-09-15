using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            PropertyManagementForm form =
                new PropertyManagementForm();

            form.ShowDialog();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            FlatManagementForm form =
                new FlatManagementForm();

            form.ShowDialog();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            TenantManagementForm form =
                new TenantManagementForm();

            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();

                LoginForm loginForm =
                    new LoginForm();

                loginForm.ShowDialog();

                this.Close();
            }
        }
    }
}