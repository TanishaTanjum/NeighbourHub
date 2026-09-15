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

        private void b4_Click(object sender, EventArgs e)
        {
            RentManagementForm form =
                new RentManagementForm();

            form.ShowDialog();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            PaymentTrackingForm form =
                new PaymentTrackingForm();

            form.ShowDialog();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            MaintenanceRequestForm form =
                new MaintenanceRequestForm();

            form.ShowDialog();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            ComplaintManagementForm form =
                new ComplaintManagementForm();

            form.ShowDialog();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            NoticeManagementForm form =
                new NoticeManagementForm();

            form.ShowDialog();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            UtilityBillManagementForm form =
                new UtilityBillManagementForm();

            form.ShowDialog();
        }

        private void b10_Click(object sender, EventArgs e)
        {
            ReportSummaryForm form =
                new ReportSummaryForm();

            form.ShowDialog();
        }

        private void b11_Click(object sender, EventArgs e)
        {
            OwnerProfileForm form =
                new OwnerProfileForm();

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