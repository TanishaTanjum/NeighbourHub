using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();

          
            btnUsers.Click += btnUsers_Click;
            btnBuildings.Click += btnBuildings_Click;
            btnComplaints.Click += btnComplaints_Click;
            btnPayments.Click += btnPayments_Click;
        }

        private void btnUsers_Click(
            object sender,
            EventArgs e)
        {
            ShowReport(
                "dbo.Users",
                "User Report"
            );
        }

        private void btnBuildings_Click(
            object sender,
            EventArgs e)
        {
            ShowReport(
                "dbo.AdminBuildings",
                "Building Report"
            );
        }

        private void btnComplaints_Click(
            object sender,
            EventArgs e)
        {
            ShowReport(
                "dbo.AdminComplaints",
                "Complaint Report"
            );
        }

        private void btnPayments_Click(
            object sender,
            EventArgs e)
        {
            ShowReport(
                "dbo.AdminPayments",
                "Payment Report"
            );
        }

        private void ShowReport(
            string tableName,
            string reportTitle)
        {
            try
            {
                string query =
                    "SELECT * FROM " + tableName;

                DataTable result =
                    Database.Query(query);

                Form reportWindow = new Form();

                reportWindow.Text = reportTitle;
                reportWindow.StartPosition =
                    FormStartPosition.CenterScreen;
                reportWindow.Size =
                    new Size(1000, 600);

                Label titleLabel = new Label();

                titleLabel.Text = reportTitle;
                titleLabel.Dock = DockStyle.Top;
                titleLabel.Height = 45;
                titleLabel.Font = new Font(
                    "Segoe UI",
                    16F,
                    FontStyle.Bold
                );
                titleLabel.TextAlign =
                    ContentAlignment.MiddleCenter;

                DataGridView reportGrid =
                    new DataGridView();

                reportGrid.Dock = DockStyle.Fill;
                reportGrid.ReadOnly = true;
                reportGrid.AllowUserToAddRows = false;
                reportGrid.AllowUserToDeleteRows = false;
                reportGrid.MultiSelect = false;

                reportGrid.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                reportGrid.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                reportGrid.BackgroundColor =
                    SystemColors.ControlLight;

                reportGrid.DataSource = result;

                reportWindow.Controls.Add(reportGrid);
                reportWindow.Controls.Add(titleLabel);

                reportWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Report load failed!\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}