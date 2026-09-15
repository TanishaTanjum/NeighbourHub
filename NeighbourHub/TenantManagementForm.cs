using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class TenantManagementForm : Form
    {
        public TenantManagementForm()
        {
            InitializeComponent();
            LoadTenants();
        }

        private void LoadTenants()
        {
            DataTable table = Database.Query(
                @"SELECT
                    ID,
                    TenantName,
                    Phone,
                    Email,
                    IdPassportNo
                  FROM dbo.Tenants
                  ORDER BY ID"
            );

            dgvTenants.Rows.Clear();

            foreach (DataRow row in table.Rows)
            {
                dgvTenants.Rows.Add(
                    row["ID"],
                    row["TenantName"],
                    row["Phone"],
                    row["Email"],
                    row["IdPassportNo"]
                );
            }

            dgvTenants.ClearSelection();
        }

        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            if (txtTenantName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter tenant name.");
                return;
            }

            Database.Execute(
                @"INSERT INTO dbo.Tenants
                  (TenantName, Phone, Email, IdPassportNo)
                  VALUES
                  (@TenantName, @Phone, @Email, @IdPassportNo)",
                new SqlParameter("@TenantName", txtTenantName.Text.Trim()),
                new SqlParameter("@Phone", txtPhone.Text.Trim()),
                new SqlParameter("@Email", txtEmail.Text.Trim()),
                new SqlParameter("@IdPassportNo", txtIdPassportNo.Text.Trim())
            );

            MessageBox.Show("Tenant added successfully.");

            ClearFields();
            LoadTenants();
        }

        private void btnEditTenant_Click(object sender, EventArgs e)
        {
            if (dgvTenants.CurrentRow == null ||
                dgvTenants.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a tenant.");
                return;
            }

            if (txtTenantName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter tenant name.");
                return;
            }

            int id = Convert.ToInt32(
                dgvTenants.CurrentRow.Cells[0].Value
            );

            Database.Execute(
                @"UPDATE dbo.Tenants
                  SET TenantName = @TenantName,
                      Phone = @Phone,
                      Email = @Email,
                      IdPassportNo = @IdPassportNo
                  WHERE ID = @ID",
                new SqlParameter("@TenantName", txtTenantName.Text.Trim()),
                new SqlParameter("@Phone", txtPhone.Text.Trim()),
                new SqlParameter("@Email", txtEmail.Text.Trim()),
                new SqlParameter("@IdPassportNo", txtIdPassportNo.Text.Trim()),
                new SqlParameter("@ID", id)
            );

            MessageBox.Show("Tenant updated successfully.");

            ClearFields();
            LoadTenants();
        }

        private void btnDeleteTenant_Click(object sender, EventArgs e)
        {
            if (dgvTenants.CurrentRow == null ||
                dgvTenants.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a tenant.");
                return;
            }

            int id = Convert.ToInt32(
                dgvTenants.CurrentRow.Cells[0].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this tenant?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            Database.Execute(
                "DELETE FROM dbo.Tenants WHERE ID = @ID",
                new SqlParameter("@ID", id)
            );

            MessageBox.Show("Tenant deleted successfully.");

            ClearFields();
            LoadTenants();
        }

        private void dgvTenants_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvTenants.Rows[e.RowIndex];

            txtTenantName.Text =
                row.Cells[1].Value?.ToString();

            txtPhone.Text =
                row.Cells[2].Value?.ToString();

            txtEmail.Text =
                row.Cells[3].Value?.ToString();

            txtIdPassportNo.Text =
                row.Cells[4].Value?.ToString();
        }

        private void ClearFields()
        {
            txtTenantName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtIdPassportNo.Clear();

            dgvTenants.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}