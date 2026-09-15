using System;
using System.Data;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class PropertyManagementForm : Form
    {
        public PropertyManagementForm()
        {
            InitializeComponent();
            LoadProperties();
        }


        private void LoadProperties()
        {
            try
            {
                DataTable table = Database.Query(
                    "SELECT ID, PropertyName, Details FROM Properties ORDER BY ID"
                );

                dataGridView1.Rows.Clear();

                foreach (DataRow row in table.Rows)
                {
                    dataGridView1.Rows.Add(
                        row["ID"],
                        row["PropertyName"],
                        row["Details"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load properties.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check that both fields have values
            if (textBox1.Text.Trim() == "" ||
                textBox2.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter the property name and details.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                string query =
                    @"INSERT INTO Properties
              (PropertyName, Details)
              VALUES
              (@PropertyName, @Details)";

                Database.Execute(
                    query,

                    new System.Data.SqlClient.SqlParameter(
                        "@PropertyName",
                        textBox1.Text.Trim()
                    ),

                    new System.Data.SqlClient.SqlParameter(
                        "@Details",
                        textBox2.Text.Trim()
                    )
                );

                MessageBox.Show(
                    "Property added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Clear input fields
                textBox1.Clear();
                textBox2.Clear();

                // Reload data from SQL Server
                LoadProperties();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not add the property.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void txtPropertyName_TextChanged(
            object sender,
            EventArgs e)
        {

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null ||
                dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Please select a property to edit.",
                    "No Property Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (textBox1.Text.Trim() == "" ||
                textBox2.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter the property name and details.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                // Get the database ID from the selected row
                int propertyId = Convert.ToInt32(
                    dataGridView1.CurrentRow.Cells[0].Value
                );

                string query =
                    @"UPDATE Properties
              SET PropertyName = @PropertyName,
                  Details = @Details
              WHERE ID = @ID";

                Database.Execute(
                    query,

                    new System.Data.SqlClient.SqlParameter(
                        "@PropertyName",
                        textBox1.Text.Trim()
                    ),

                    new System.Data.SqlClient.SqlParameter(
                        "@Details",
                        textBox2.Text.Trim()
                    ),

                    new System.Data.SqlClient.SqlParameter(
                        "@ID",
                        propertyId
                    )
                );

                MessageBox.Show(
                    "Property updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                textBox1.Clear();
                textBox2.Clear();

                // Reload the updated data from SQL Server
                LoadProperties();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not update the property.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null ||
                dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Please select a property to delete.",
                    "No Property Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int propertyId = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells[0].Value
            );

            string propertyName =
                dataGridView1.CurrentRow.Cells[1].Value?.ToString();

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete \"" +
                propertyName + "\"?",
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
                string query =
                    "DELETE FROM Properties WHERE ID = @ID";

                Database.Execute(
                    query,
                    new System.Data.SqlClient.SqlParameter(
                        "@ID",
                        propertyId
                    )
                );

                MessageBox.Show(
                    "Property deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                textBox1.Clear();
                textBox2.Clear();

                // Reload remaining properties from SQL Server
                LoadProperties();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not delete the property.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void dataGridView1_CellContentClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow =
                    dataGridView1.Rows[e.RowIndex];

                textBox1.Text =
                    selectedRow.Cells[1].Value?.ToString();

                textBox2.Text =
                    selectedRow.Cells[2].Value?.ToString();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}