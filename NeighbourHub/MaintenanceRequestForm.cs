using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class MaintenanceRequestForm : Form
    {
        public MaintenanceRequestForm()
        {
            InitializeComponent();
            LoadFlatUnits();
            LoadRequests();
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

        private void LoadRequests()
        {
            DataTable table = Database.Query(
                @"SELECT
                    M.ID,
                    P.PropertyName + ' - Unit ' +
                    CONVERT(NVARCHAR(50), F.UnitNumber) AS FlatUnit,
                    M.RequestTitle,
                    M.Category,
                    M.RequestDate,
                    M.Status,
                    M.Description
                  FROM dbo.OwnerMaintenanceRequests M
                  INNER JOIN dbo.FlatUnits F
                    ON M.FlatUnitID = F.ID
                  INNER JOIN dbo.Properties P
                    ON F.PropertyID = P.ID
                  ORDER BY M.ID"
            );

            dgvMaintenance.Rows.Clear();

            foreach (DataRow row in table.Rows)
            {
                dgvMaintenance.Rows.Add(
                    row["ID"],
                    row["FlatUnit"],
                    row["RequestTitle"],
                    row["Category"],
                    Convert.ToDateTime(row["RequestDate"]).ToShortDateString(),
                    row["Status"],
                    row["Description"]
                );
            }

            dgvMaintenance.ClearSelection();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            if (cmbFlatUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flat/unit.");
                return;
            }

            if (txtRequestTitle.Text.Trim() == "")
            {
                MessageBox.Show("Please enter request title.");
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
                @"INSERT INTO dbo.OwnerMaintenanceRequests
                  (
                    FlatUnitID,
                    RequestTitle,
                    Category,
                    RequestDate,
                    Status,
                    Description
                  )
                  VALUES
                  (
                    @FlatUnitID,
                    @RequestTitle,
                    @Category,
                    @RequestDate,
                    @Status,
                    @Description
                  )",
                new SqlParameter("@FlatUnitID", Convert.ToInt32(cmbFlatUnit.SelectedValue)),
                new SqlParameter("@RequestTitle", txtRequestTitle.Text.Trim()),
                new SqlParameter("@Category", cmbCategory.Text),
                new SqlParameter("@RequestDate", dtpRequestDate.Value.Date),
                new SqlParameter("@Status", cmbStatus.Text),
                new SqlParameter("@Description", txtDescription.Text.Trim())
            );

            MessageBox.Show("Maintenance request added successfully.");

            ClearFields();
            LoadRequests();
        }

        private void btnEditRequest_Click(object sender, EventArgs e)
        {
            if (dgvMaintenance.CurrentRow == null ||
                dgvMaintenance.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a maintenance request.");
                return;
            }

            if (cmbFlatUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flat/unit.");
                return;
            }

            int id = Convert.ToInt32(
                dgvMaintenance.CurrentRow.Cells[0].Value
            );

            Database.Execute(
                @"UPDATE dbo.OwnerMaintenanceRequests
                  SET FlatUnitID = @FlatUnitID,
                      RequestTitle = @RequestTitle,
                      Category = @Category,
                      RequestDate = @RequestDate,
                      Status = @Status,
                      Description = @Description
                  WHERE ID = @ID",
                new SqlParameter("@FlatUnitID", Convert.ToInt32(cmbFlatUnit.SelectedValue)),
                new SqlParameter("@RequestTitle", txtRequestTitle.Text.Trim()),
                new SqlParameter("@Category", cmbCategory.Text),
                new SqlParameter("@RequestDate", dtpRequestDate.Value.Date),
                new SqlParameter("@Status", cmbStatus.Text),
                new SqlParameter("@Description", txtDescription.Text.Trim()),
                new SqlParameter("@ID", id)
            );

            MessageBox.Show("Maintenance request updated successfully.");

            ClearFields();
            LoadRequests();
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            if (dgvMaintenance.CurrentRow == null ||
                dgvMaintenance.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a maintenance request.");
                return;
            }

            int id = Convert.ToInt32(
                dgvMaintenance.CurrentRow.Cells[0].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this request?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            Database.Execute(
                @"DELETE FROM dbo.OwnerMaintenanceRequests
                  WHERE ID = @ID",
                new SqlParameter("@ID", id)
            );

            MessageBox.Show("Maintenance request deleted successfully.");

            ClearFields();
            LoadRequests();
        }

        private void dgvMaintenance_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(
                dgvMaintenance.Rows[e.RowIndex].Cells[0].Value
            );

            DataTable table = Database.Query(
                @"SELECT
                    FlatUnitID,
                    RequestTitle,
                    Category,
                    RequestDate,
                    Status,
                    Description
                  FROM dbo.OwnerMaintenanceRequests
                  WHERE ID = @ID",
                new SqlParameter("@ID", id)
            );

            if (table.Rows.Count == 0)
                return;

            DataRow row = table.Rows[0];

            cmbFlatUnit.SelectedValue = row["FlatUnitID"];
            txtRequestTitle.Text = row["RequestTitle"].ToString();
            cmbCategory.Text = row["Category"].ToString();
            dtpRequestDate.Value = Convert.ToDateTime(row["RequestDate"]);
            cmbStatus.Text = row["Status"].ToString();
            txtDescription.Text = row["Description"].ToString();
        }

        private void ClearFields()
        {
            cmbFlatUnit.SelectedIndex = -1;
            txtRequestTitle.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            txtDescription.Clear();
            dtpRequestDate.Value = DateTime.Today;
            dgvMaintenance.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}