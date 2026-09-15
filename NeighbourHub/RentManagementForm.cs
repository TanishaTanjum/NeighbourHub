using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class RentManagementForm : Form
    {
        public RentManagementForm()
        {
            InitializeComponent();
            LoadFlatUnits();
            LoadRents();
        }

        private void LoadFlatUnits()
        {
            DataTable table = Database.Query(
                @"SELECT
                    F.ID,
                    P.PropertyName + ' - Unit ' + F.UnitNumber AS DisplayName
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

        private void LoadRents()
        {
            DataTable table = Database.Query(
                @"SELECT
                    R.ID,
                    P.PropertyName,
                    F.UnitNumber,
                    R.MonthlyRent
                  FROM dbo.Rents R
                  INNER JOIN dbo.FlatUnits F
                    ON R.FlatUnitID = F.ID
                  INNER JOIN dbo.Properties P
                    ON F.PropertyID = P.ID
                  ORDER BY R.ID"
            );

            dgvRents.Rows.Clear();

            foreach (DataRow row in table.Rows)
            {
                dgvRents.Rows.Add(
                    row["ID"],
                    row["PropertyName"],
                    row["UnitNumber"],
                    Convert.ToDecimal(row["MonthlyRent"]).ToString("0.00")
                );
            }

            dgvRents.ClearSelection();
        }

        private void btnSetRent_Click(object sender, EventArgs e)
        {
            if (cmbFlatUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flat/unit.");
                return;
            }

            decimal monthlyRent;

            if (!decimal.TryParse(txtMonthlyRent.Text.Trim(), out monthlyRent))
            {
                MessageBox.Show("Please enter a valid monthly rent.");
                return;
            }

            if (monthlyRent <= 0)
            {
                MessageBox.Show("Monthly rent must be greater than zero.");
                return;
            }

            int flatUnitID = Convert.ToInt32(cmbFlatUnit.SelectedValue);

            DataTable existing = Database.Query(
                @"SELECT ID
                  FROM dbo.Rents
                  WHERE FlatUnitID = @FlatUnitID",
                new SqlParameter("@FlatUnitID", flatUnitID)
            );

            if (existing.Rows.Count > 0)
            {
                MessageBox.Show("Rent has already been set for this flat/unit.");
                return;
            }

            Database.Execute(
                @"INSERT INTO dbo.Rents
                  (FlatUnitID, MonthlyRent)
                  VALUES
                  (@FlatUnitID, @MonthlyRent)",
                new SqlParameter("@FlatUnitID", flatUnitID),
                new SqlParameter("@MonthlyRent", monthlyRent)
            );

            MessageBox.Show("Rent added successfully.");

            ClearFields();
            LoadRents();
        }

        private void btnEditRent_Click(object sender, EventArgs e)
        {
            if (dgvRents.CurrentRow == null ||
                dgvRents.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a rent record.");
                return;
            }

            if (cmbFlatUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flat/unit.");
                return;
            }

            decimal monthlyRent;

            if (!decimal.TryParse(txtMonthlyRent.Text.Trim(), out monthlyRent))
            {
                MessageBox.Show("Please enter a valid monthly rent.");
                return;
            }

            if (monthlyRent <= 0)
            {
                MessageBox.Show("Monthly rent must be greater than zero.");
                return;
            }

            int id = Convert.ToInt32(
                dgvRents.CurrentRow.Cells[0].Value
            );

            int flatUnitID = Convert.ToInt32(
                cmbFlatUnit.SelectedValue
            );

            DataTable existing = Database.Query(
                @"SELECT ID
                  FROM dbo.Rents
                  WHERE FlatUnitID = @FlatUnitID
                  AND ID <> @ID",
                new SqlParameter("@FlatUnitID", flatUnitID),
                new SqlParameter("@ID", id)
            );

            if (existing.Rows.Count > 0)
            {
                MessageBox.Show("Rent already exists for this flat/unit.");
                return;
            }

            Database.Execute(
                @"UPDATE dbo.Rents
                  SET FlatUnitID = @FlatUnitID,
                      MonthlyRent = @MonthlyRent
                  WHERE ID = @ID",
                new SqlParameter("@FlatUnitID", flatUnitID),
                new SqlParameter("@MonthlyRent", monthlyRent),
                new SqlParameter("@ID", id)
            );

            MessageBox.Show("Rent updated successfully.");

            ClearFields();
            LoadRents();
        }

        private void btnDeleteRent_Click(object sender, EventArgs e)
        {
            if (dgvRents.CurrentRow == null ||
                dgvRents.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a rent record.");
                return;
            }

            int id = Convert.ToInt32(
                dgvRents.CurrentRow.Cells[0].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this rent record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            Database.Execute(
                @"DELETE FROM dbo.Rents
                  WHERE ID = @ID",
                new SqlParameter("@ID", id)
            );

            MessageBox.Show("Rent deleted successfully.");

            ClearFields();
            LoadRents();
        }

        private void dgvRents_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(
                dgvRents.Rows[e.RowIndex].Cells[0].Value
            );

            DataTable table = Database.Query(
                @"SELECT FlatUnitID, MonthlyRent
                  FROM dbo.Rents
                  WHERE ID = @ID",
                new SqlParameter("@ID", id)
            );

            if (table.Rows.Count == 0)
                return;

            cmbFlatUnit.SelectedValue =
                table.Rows[0]["FlatUnitID"];

            txtMonthlyRent.Text =
                Convert.ToDecimal(
                    table.Rows[0]["MonthlyRent"]
                ).ToString("0.00");
        }

        private void ClearFields()
        {
            cmbFlatUnit.SelectedIndex = -1;
            txtMonthlyRent.Clear();
            dgvRents.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}