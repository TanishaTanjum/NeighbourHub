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
            try
            {
                DataTable table = Database.Query(
                    "SELECT ID, PropertyName FROM Properties ORDER BY PropertyName"
                );

                cmbProperty.DataSource = table;
                cmbProperty.DisplayMember = "PropertyName";
                cmbProperty.ValueMember = "ID";

                cmbProperty.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load properties.\n\n" + ex.Message
                );
            }
        }


        private void LoadUnits()
        {
            try
            {
                DataTable table = Database.Query(
                    @"SELECT 
                        U.ID,
                        P.PropertyName,
                        U.UnitNumber,
                        U.Floor,
                        U.Bedrooms,
                        U.Details
                      FROM Units U
                      INNER JOIN Properties P
                      ON U.PropertyID = P.ID
                      ORDER BY U.ID"
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
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load units.\n\n" + ex.Message
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
                MessageBox.Show("Please enter a flat/unit number.");
                return;
            }

            int bedrooms = 0;

            if (txtBedrooms.Text.Trim() != "")
            {
                if (!int.TryParse(txtBedrooms.Text.Trim(), out bedrooms))
                {
                    MessageBox.Show(
                        "Bedrooms must be a number."
                    );

                    return;
                }
            }

            try
            {
                string query =
                    @"INSERT INTO Units
                      (PropertyID, UnitNumber, Floor, Bedrooms, Details)

                      VALUES
                      (@PropertyID, @UnitNumber, @Floor, @Bedrooms, @Details)";

                Database.Execute(
                    query,

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

                MessageBox.Show(
                    "Unit added successfully."
                );

                ClearFields();
                LoadUnits();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not add unit.\n\n" + ex.Message
                );
            }
        }


        private void btnEditUnit_Click(object sender, EventArgs e)
        {
            if (dgvUnits.CurrentRow == null ||
                dgvUnits.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Please select a unit to edit."
                );

                return;
            }

            if (cmbProperty.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a property."
                );

                return;
            }

            if (txtUnitNumber.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter a flat/unit number."
                );

                return;
            }

            int bedrooms = 0;

            if (txtBedrooms.Text.Trim() != "")
            {
                if (!int.TryParse(
                    txtBedrooms.Text.Trim(),
                    out bedrooms))
                {
                    MessageBox.Show(
                        "Bedrooms must be a number."
                    );

                    return;
                }
            }

            try
            {
                int unitId = Convert.ToInt32(
                    dgvUnits.CurrentRow.Cells[0].Value
                );

                string query =
                    @"UPDATE Units

                      SET PropertyID = @PropertyID,
                          UnitNumber = @UnitNumber,
                          Floor = @Floor,
                          Bedrooms = @Bedrooms,
                          Details = @Details

                      WHERE ID = @ID";

                Database.Execute(
                    query,

                    new SqlParameter(
                        "@PropertyID",
                        Convert.ToInt32(
                            cmbProperty.SelectedValue
                        )
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
                        unitId
                    )
                );

                MessageBox.Show(
                    "Unit updated successfully."
                );

                ClearFields();
                LoadUnits();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not update unit.\n\n" +
                    ex.Message
                );
            }
        }

        private void btnDeleteUnit_Click(
            object sender,
            EventArgs e)
        {
            if (dgvUnits.CurrentRow == null ||
                dgvUnits.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Please select a unit to delete."
                );

                return;
            }

            int unitId = Convert.ToInt32(
                dgvUnits.CurrentRow.Cells[0].Value
            );

            string unitNumber =
                dgvUnits.CurrentRow.Cells[2]
                .Value?.ToString();

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete Unit " +
                    unitNumber + "?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Database.Execute(
                    "DELETE FROM Units WHERE ID = @ID",

                    new SqlParameter(
                        "@ID",
                        unitId
                    )
                );

                MessageBox.Show(
                    "Unit deleted successfully."
                );

                ClearFields();
                LoadUnits();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not delete unit.\n\n" +
                    ex.Message
                );
            }
        }


        private void dgvUnits_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvUnits.Rows[e.RowIndex];

            int unitId =
                Convert.ToInt32(row.Cells[0].Value);

            txtUnitNumber.Text =
                row.Cells[2].Value?.ToString();

            txtFloor.Text =
                row.Cells[3].Value?.ToString();

            txtBedrooms.Text =
                row.Cells[4].Value?.ToString();

            txtDetails.Text =
                row.Cells[5].Value?.ToString();

            try
            {
                DataTable table = Database.Query(
                    "SELECT PropertyID FROM Units WHERE ID = @ID",

                    new SqlParameter(
                        "@ID",
                        unitId
                    )
                );

                if (table.Rows.Count > 0)
                {
                    cmbProperty.SelectedValue =
                        table.Rows[0]["PropertyID"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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


        private void btnClose_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        private void btnAddUnit_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditUnit_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDeleteUnit_Click_1(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {

        }
    }
}
