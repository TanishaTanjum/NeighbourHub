using System;
using System.Data;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();

            btnManagement.Click += btnManagement_Click;
            btnReports.Click += btnReports_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                int totalUsers = GetCount("dbo.Users");
                int totalBuildings = GetCount("dbo.AdminBuildings");
                int totalComplaints = GetCount("dbo.AdminComplaints");

                lblUsers.Text =
                    "Total Users\n\n" + totalUsers;

                lblBuildings.Text =
                    "Total Buildings\n\n" + totalBuildings;

                lblComplaints.Text =
                    "Total Complaints\n\n" + totalComplaints;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database connection failed!\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private int GetCount(string tableName)
        {
            string query =
                "SELECT COUNT(*) FROM " + tableName;

            DataTable result = Database.Query(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0][0]);
            }

            return 0;
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            AdminManagement form = new AdminManagement();

           
            form.ShowDialog();

           
            LoadDashboardData();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}