using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class FlatManagementForm : Form
    {
        public FlatManagementForm()
        {
            InitializeComponent();
            LoadProperties();
            LoadUnits();
        }

        private void LoadProperties()
        {
            DataTable table = Database.Query(
                "SELECT ID, PropertyName FROM dbo.Properties ORDER BY PropertyName"
            );

            cmbProperty.DataSource = table;
            cmbProperty.DisplayMember = "PropertyName";
            cmbProperty.ValueMember = "ID";
            cmbProperty.SelectedIndex = -1;
        }

        private void LoadUnits()
        {
            DataTable table = Database.Query(
                @"SELECT
                    F.ID,
                    P.PropertyName,
                    F.UnitNumber,
                    F.Floor,
                    F.Bedrooms,
                    F.Details
                  FROM dbo.FlatUnits F
                  INNER JOIN dbo.Properties P
                    ON F.PropertyID = P.ID
                  ORDER BY F.ID"
            );

            dgvUnits.Rows.Clear();

            foreach (DataRow row in table.Rows)
            {
                dgvUnits.Rows.Add(
                    row["ID"],
                    row["PropertyName"],
                    row["UnitNumber"],
                    row["Floor"],
                    row["Bedrooms"],
                    row["Details"]
                );
            }
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            if (cmbProperty.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a property.");
                return;
            }

            if (txtUnitNumber.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a unit number.");
                return;
            }

            int bedrooms;

            if (!int.TryParse(txtBedrooms.Text.Trim(), out bedrooms))
            {
                MessageBox.Show("Bedrooms must be a number.");
                return;
            }

            Database.Execute(
                @"INSERT INTO dbo.FlatUnits
                  (PropertyID, UnitNumber, Floor, Bedrooms, Details)
                  VALUES
                  (@PropertyID, @UnitNumber, @Floor, @Bedrooms, @Details)",

                new SqlParameter(
                    "@PropertyID",
                    Convert.ToInt32(cmbProperty.SelectedValue)
                ),

                new SqlParameter(
                    "@UnitNumber",
                    txtUnitNumber.Text.Trim()
                ),

                new SqlParameter(
                    "@Floor",
                    txtFloor.Text.Trim()
                ),

                new SqlParameter(
                    "@Bedrooms",
                    bedrooms
                ),

                new SqlParameter(
                    "@Details",
                    txtDetails.Text.Trim()
                )
            );

            MessageBox.Show("Flat/unit added successfully.");

            ClearFields();
            LoadUnits();
        }

        private void btnEditUnit_Click(object sender, EventArgs e)
        {
            if (dgvUnits.CurrentRow == null ||
                dgvUnits.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a unit.");
                return;
            }

            if (cmbProperty.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a property.");
                return;
            }

            int bedrooms;

            if (!int.TryParse(txtBedrooms.Text.Trim(), out bedrooms))
            {
                MessageBox.Show("Bedrooms must be a number.");
                return;
            }

            int id = Convert.ToInt32(
                dgvUnits.CurrentRow.Cells[0].Value
            );

            Database.Execute(
                @"UPDATE dbo.FlatUnits
                  SET PropertyID = @PropertyID,
                      UnitNumber = @UnitNumber,
                      Floor = @Floor,
                      Bedrooms = @Bedrooms,
                      Details = @Details
                  WHERE ID = @ID",

                new SqlParameter(
                    "@PropertyID",
                    Convert.ToInt32(cmbProperty.SelectedValue)
                ),

                new SqlParameter(
                    "@UnitNumber",
                    txtUnitNumber.Text.Trim()
                ),

                new SqlParameter(
                    "@Floor",
                    txtFloor.Text.Trim()
                ),

                new SqlParameter(
                    "@Bedrooms",
                    bedrooms
                ),

                new SqlParameter(
                    "@Details",
                    txtDetails.Text.Trim()
                ),

                new SqlParameter(
                    "@ID",
                    id
                )
            );

            MessageBox.Show("Flat/unit updated successfully.");

            ClearFields();
            LoadUnits();
        }

        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            if (dgvUnits.CurrentRow == null ||
                dgvUnits.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a unit.");
                return;
            }

            int id = Convert.ToInt32(
                dgvUnits.CurrentRow.Cells[0].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this unit?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                Database.Execute(
                    "DELETE FROM dbo.FlatUnits WHERE ID = @ID",
                    new SqlParameter("@ID", id)
                );

                MessageBox.Show("Flat/unit deleted successfully.");

                ClearFields();
                LoadUnits();
            }
        }

        private void dgvUnits_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvUnits.Rows[e.RowIndex];

            int id =
                Convert.ToInt32(row.Cells[0].Value);

            txtUnitNumber.Text =
                row.Cells[2].Value?.ToString();

            txtFloor.Text =
                row.Cells[3].Value?.ToString();

            txtBedrooms.Text =
                row.Cells[4].Value?.ToString();

            txtDetails.Text =
                row.Cells[5].Value?.ToString();

            DataTable table = Database.Query(
                "SELECT PropertyID FROM dbo.FlatUnits WHERE ID = @ID",
                new SqlParameter("@ID", id)
            );

            if (table.Rows.Count > 0)
            {
                cmbProperty.SelectedValue =
                    table.Rows[0]["PropertyID"];
            }
        }

        private void ClearFields()
        {
            cmbProperty.SelectedIndex = -1;
            txtUnitNumber.Clear();
            txtFloor.Clear();
            txtBedrooms.Clear();
            txtDetails.Clear();
            dgvUnits.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUnit_Click_1(object sender, EventArgs e)
        {
            btnAddUnit_Click(sender, e);
        }

        private void btnEditUnit_Click_1(object sender, EventArgs e)
        {
            btnEditUnit_Click(sender, e);
        }

        private void btnDeleteUnit_Click_1(object sender, EventArgs e)
        {
            btnDeleteUnit_Click(sender, e);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }
    }
}