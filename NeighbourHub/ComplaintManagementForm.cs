using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class ComplaintManagementForm : Form
    {
        public ComplaintManagementForm()
        {
            InitializeComponent();
            LoadTenants();
            LoadFlatUnits();
            LoadComplaints();
        }

        private void LoadTenants()
        {
            DataTable table = Database.Query(
                @"SELECT ID, TenantName
                  FROM dbo.Tenants
                  ORDER BY TenantName"
            );

            cmbTenant.DataSource = table;
            cmbTenant.DisplayMember = "TenantName";
            cmbTenant.ValueMember = "ID";
            cmbTenant.SelectedIndex = -1;
        }

        private void LoadFlatUnits()
        {
            DataTable table = Database.Query(
                @"SELECT
                    F.ID,
                    P.PropertyName + ' - Unit ' +
                    CONVERT(NVARCHAR(50), F.UnitNumber) AS DisplayName
                  FROM dbo.FlatUnits F
                  INNER JOIN dbo.Properties P
                    ON F.PropertyID = P.ID
                  ORDER BY P.PropertyName, F.UnitNumber"
            );

            cmbFlatUnit.DataSource = table;
            cmbFlatUnit.DisplayMember = "DisplayName";
            cmbFlatUnit.ValueMember = "ID";
            cmbFlatUnit.SelectedIndex = -1;
        }

        private void LoadComplaints()
        {
            DataTable table = Database.Query(
                @"SELECT
                    C.ID,
                    T.TenantName,
                    P.PropertyName + ' - Unit ' +
                    CONVERT(NVARCHAR(50), F.UnitNumber) AS FlatUnit,
                    C.ComplaintTitle,
                    C.Category,
                    C.ComplaintDate,
                    C.Status,
                    C.Description
                  FROM dbo.OwnerComplaints C
                  INNER JOIN dbo.Tenants T
                    ON C.TenantID = T.ID
                  INNER JOIN dbo.FlatUnits F
                    ON C.FlatUnitID = F.ID
                  INNER JOIN dbo.Properties P
                    ON F.PropertyID = P.ID
                  ORDER BY C.ID"
            );

            dgvComplaints.Rows.Clear();

            foreach (DataRow row in table.Rows)
            {
                dgvComplaints.Rows.Add(
                    row["ID"],
                    row["TenantName"],
                    row["FlatUnit"],
                    row["ComplaintTitle"],
                    row["Category"],
                    Convert.ToDateTime(row["ComplaintDate"]).ToShortDateString(),
                    row["Status"],
                    row["Description"]
                );
            }

            dgvComplaints.ClearSelection();
        }

        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            if (cmbTenant.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a tenant.");
                return;
            }

            if (cmbFlatUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flat/unit.");
                return;
            }

            if (txtComplaintTitle.Text.Trim() == "")
            {
                MessageBox.Show("Please enter complaint title.");
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select category.");
                return;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select status.");
                return;
            }

            Database.Execute(
                @"INSERT INTO dbo.OwnerComplaints
                  (
                    TenantID,
                    FlatUnitID,
                    ComplaintTitle,
                    Category,
                    ComplaintDate,
                    Status,
                    Description
                  )
                  VALUES
                  (
                    @TenantID,
                    @FlatUnitID,
                    @ComplaintTitle,
                    @Category,
                    @ComplaintDate,
                    @Status,
                    @Description
                  )",
                new SqlParameter("@TenantID",
                    Convert.ToInt32(cmbTenant.SelectedValue)),
                new SqlParameter("@FlatUnitID",
                    Convert.ToInt32(cmbFlatUnit.SelectedValue)),
                new SqlParameter("@ComplaintTitle",
                    txtComplaintTitle.Text.Trim()),
                new SqlParameter("@Category",
                    cmbCategory.Text),
                new SqlParameter("@ComplaintDate",
                    dtpComplaintDate.Value.Date),
                new SqlParameter("@Status",
                    cmbStatus.Text),
                new SqlParameter("@Description",
                    txtDescription.Text.Trim())
            );

            MessageBox.Show("Complaint added successfully.");

            ClearFields();
            LoadComplaints();
        }

        private void btnEditComplaint_Click(object sender, EventArgs e)
        {
            if (dgvComplaints.CurrentRow == null ||
                dgvComplaints.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a complaint.");
                return;
            }

            if (cmbTenant.SelectedIndex == -1 ||
                cmbFlatUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Please select tenant and flat/unit.");
                return;
            }

            if (txtComplaintTitle.Text.Trim() == "")
            {
                MessageBox.Show("Please enter complaint title.");
                return;
            }

            int id = Convert.ToInt32(
                dgvComplaints.CurrentRow.Cells[0].Value
            );

            Database.Execute(
                @"UPDATE dbo.OwnerComplaints
                  SET TenantID = @TenantID,
                      FlatUnitID = @FlatUnitID,
                      ComplaintTitle = @ComplaintTitle,
                      Category = @Category,
                      ComplaintDate = @ComplaintDate,
                      Status = @Status,
                      Description = @Description
                  WHERE ID = @ID",
                new SqlParameter("@TenantID",
                    Convert.ToInt32(cmbTenant.SelectedValue)),
                new SqlParameter("@FlatUnitID",
                    Convert.ToInt32(cmbFlatUnit.SelectedValue)),
                new SqlParameter("@ComplaintTitle",
                    txtComplaintTitle.Text.Trim()),
                new SqlParameter("@Category",
                    cmbCategory.Text),
                new SqlParameter("@ComplaintDate",
                    dtpComplaintDate.Value.Date),
                new SqlParameter("@Status",
                    cmbStatus.Text),
                new SqlParameter("@Description",
                    txtDescription.Text.Trim()),
                new SqlParameter("@ID", id)
            );

            MessageBox.Show("Complaint updated successfully.");

            ClearFields();
            LoadComplaints();
        }

        private void btnDeleteComplaint_Click(object sender, EventArgs e)
        {
            if (dgvComplaints.CurrentRow == null ||
                dgvComplaints.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a complaint.");
                return;
            }

            int id = Convert.ToInt32(
                dgvComplaints.CurrentRow.Cells[0].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this complaint?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            Database.Execute(
                @"DELETE FROM dbo.OwnerComplaints
                  WHERE ID = @ID",
                new SqlParameter("@ID", id)
            );

            MessageBox.Show("Complaint deleted successfully.");

            ClearFields();
            LoadComplaints();
        }

        private void dgvComplaints_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(
                dgvComplaints.Rows[e.RowIndex].Cells[0].Value
            );

            DataTable table = Database.Query(
                @"SELECT
                    TenantID,
                    FlatUnitID,
                    ComplaintTitle,
                    Category,
                    ComplaintDate,
                    Status,
                    Description
                  FROM dbo.OwnerComplaints
                  WHERE ID = @ID",
                new SqlParameter("@ID", id)
            );

            if (table.Rows.Count == 0)
                return;

            DataRow row = table.Rows[0];

            cmbTenant.SelectedValue = row["TenantID"];
            cmbFlatUnit.SelectedValue = row["FlatUnitID"];
            txtComplaintTitle.Text = row["ComplaintTitle"].ToString();
            cmbCategory.Text = row["Category"].ToString();
            dtpComplaintDate.Value =
                Convert.ToDateTime(row["ComplaintDate"]);
            cmbStatus.Text = row["Status"].ToString();
            txtDescription.Text = row["Description"].ToString();
        }

        private void ClearFields()
        {
            cmbTenant.SelectedIndex = -1;
            cmbFlatUnit.SelectedIndex = -1;
            txtComplaintTitle.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            txtDescription.Clear();
            dtpComplaintDate.Value = DateTime.Today;
            dgvComplaints.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}