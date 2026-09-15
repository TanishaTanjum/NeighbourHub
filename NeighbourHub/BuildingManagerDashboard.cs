using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NeighbourHub
{
    public partial class BuildingManagerDashboard : Form
    {
        private string currentTable = "";
        private string idColumn = "";
        private int selectedId = 0;

        public BuildingManagerDashboard()
        {
            InitializeComponent();
        
            HideDatePickers();
        }

     
        private void HideDatePickers()
        {
            dtpField2.Visible = false;
            dtpField3.Visible = false;

            txtField2.Visible = true;
            txtField3.Visible = true;
        }

      
        private void ShowFeature(
            string title,
            string field1,
            string field2,
            string field3,
            string field4,
            string table,
            string id)
        {
            lblFeatureTitle.Text = title;

            lblField1.Text = field1;
            lblField2.Text = field2;
            lblField3.Text = field3;
            lblField4.Text = field4;

            currentTable = table;
            idColumn = id;
            selectedId = 0;

            txtField1.Clear();
            txtField2.Clear();
            txtField3.Clear();
            txtField4.Clear();

            HideDatePickers();

           
            if (title == "Notice Management")
            {
                txtField2.Visible = false;
                dtpField2.Visible = true;
            }

          
            if (title == "Visitor Entry Management")
            {
                txtField3.Visible = false;
                dtpField3.Visible = true;
            }

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                featureGrid.DataSource =
                    Database.Query("SELECT * FROM " + currentTable);

                featureGrid.ClearSelection();
                selectedId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load data.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Login_Profile form = new Login_Profile();
            form.ShowDialog();
        }

       
        private void btn1_Click(object sender, EventArgs e)
        {
            BuildingInformation form = new BuildingInformation();
            form.ShowDialog();
        }

       
        private void btn2_Click(object sender, EventArgs e)
        {
            ShowFeature(
                "Flat/Unit Management",
                "Flat Number",
                "Building Name",
                "Floor Number",
                "Rent Amount",
                "Units",
                "UnitId");
        }

      
        private void btn3_Click(object sender, EventArgs e)
        {
            ShowFeature(
                "Resident/Tenant Management",
                "Resident Name",
                "Email",
                "Phone",
                "Unit Number",
                "Residents",
                "ResidentId");
        }

       
        private void btn4_Click(object sender, EventArgs e)
        {
            ShowFeature(
                "Notice Management",
                "Title",
                "Notice Date",
                "Category",
                "Description",
                "Notices",
                "NoticeId");
        }

     
        private void btn5_Click(object sender, EventArgs e)
        {
            ShowFeature(
                "Complaint Management",
                "Resident Name",
                "Subject",
                "Priority",
                "Status",
                "Complaints",
                "ComplaintId");
        }

 
        private void btn6_Click(object sender, EventArgs e)
        {
            ShowFeature(
                "Visitor Entry Management",
                "Visitor Name",
                "Resident Name",
                "Visit Date",
                "Purpose",
                "Visitors",
                "VisitorId");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ShowFeature(
                "Emergency Contact Management",
                "Contact Name",
                "Contact Type",
                "Phone",
                "Location",
                "EmergencyContacts",
                "ContactId");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ShowFeature(
                "Maintenance Management",
                "Title",
                "Flat ID",
                "Assigned To",
                "Status",
                "Maintenance",
                "MaintenanceId");
        }

   
        private void btn9_Click(object sender, EventArgs e)
        {
            ShowFeature(
                "Utility/Service Management",
                "Service Name",
                "Provider",
                "Description",
                "Status",
                "Utilities",
                "UtilityId");
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "You are already on the Building Manager Dashboard.",
                "NeighbourHub",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Building Report Generation will be available soon.",
                "NeighbourHub",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

       
        private bool CheckFields()
        {
            if (string.IsNullOrWhiteSpace(txtField1.Text))
            {
                MessageBox.Show("Please fill in " + lblField1.Text + ".");
                txtField1.Focus();
                return false;
            }

            if (txtField2.Visible &&
                string.IsNullOrWhiteSpace(txtField2.Text))
            {
                MessageBox.Show("Please fill in " + lblField2.Text + ".");
                txtField2.Focus();
                return false;
            }

            if (txtField3.Visible &&
                string.IsNullOrWhiteSpace(txtField3.Text))
            {
                MessageBox.Show("Please fill in " + lblField3.Text + ".");
                txtField3.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtField4.Text))
            {
                MessageBox.Show("Please fill in " + lblField4.Text + ".");
                txtField4.Focus();
                return false;
            }

          
            if (currentTable == "Residents")
            {
                if (txtField3.Text.Length != 11 ||
                    !txtField3.Text.StartsWith("01") ||
                    !txtField3.Text.All(char.IsDigit))
                {
                    MessageBox.Show(
                        "Phone number must be 11 digits and start with 01.");
                    txtField3.Focus();
                    return false;
                }

                if (!txtField2.Text.Contains("@") ||
                    !txtField2.Text.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email.");
                    txtField2.Focus();
                    return false;
                }
            }

       
            if (currentTable == "EmergencyContacts")
            {
                if (txtField3.Text.Length != 11 ||
                    !txtField3.Text.StartsWith("01") ||
                    !txtField3.Text.All(char.IsDigit))
                {
                    MessageBox.Show(
                        "Phone number must be 11 digits and start with 01.");
                    txtField3.Focus();
                    return false;
                }
            }

       
            if (currentTable == "Units")
            {
                int floor;
                decimal rent;

                if (!int.TryParse(txtField3.Text, out floor) ||
                    floor <= 0)
                {
                    MessageBox.Show("Please enter a valid floor number.");
                    txtField3.Focus();
                    return false;
                }

                if (!decimal.TryParse(txtField4.Text, out rent) ||
                    rent < 0)
                {
                    MessageBox.Show("Please enter a valid rent amount.");
                    txtField4.Focus();
                    return false;
                }
            }

           
            if (currentTable == "Maintenance")
            {
                int flatId;

                if (!int.TryParse(txtField2.Text, out flatId) ||
                    flatId <= 0)
                {
                    MessageBox.Show("Please enter a valid Flat ID.");
                    txtField2.Focus();
                    return false;
                }
            }

            return true;
        }

        // Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (currentTable == "")
            {
                MessageBox.Show("Please select a feature first.");
                return;
            }

            if (!CheckFields())
                return;

            string[] columns = GetColumns();

            string query =
                "INSERT INTO " + currentTable +
                " (" + string.Join(",", columns) + ")" +
                " VALUES (@p1,@p2,@p3,@p4)";

            try
            {
                Database.Execute(
                    query,
                    new SqlParameter("@p1", txtField1.Text.Trim()),
                    new SqlParameter("@p2", GetField2Value()),
                    new SqlParameter("@p3", GetField3Value()),
                    new SqlParameter("@p4", txtField4.Text.Trim()));

                MessageBox.Show(
                    "Record added successfully!",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not add record.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a record first.");
                return;
            }

            if (!CheckFields())
                return;

            string[] columns = GetColumns();

            string query =
                "UPDATE " + currentTable +
                " SET " +
                columns[0] + "=@p1," +
                columns[1] + "=@p2," +
                columns[2] + "=@p3," +
                columns[3] + "=@p4 " +
                "WHERE " + idColumn + "=@id";

            try
            {
                Database.Execute(
                    query,
                    new SqlParameter("@p1", txtField1.Text.Trim()),
                    new SqlParameter("@p2", GetField2Value()),
                    new SqlParameter("@p3", GetField3Value()),
                    new SqlParameter("@p4", txtField4.Text.Trim()),
                    new SqlParameter("@id", selectedId));

                MessageBox.Show(
                    "Record updated successfully!",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not update record.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Dlt
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a record first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "NeighbourHub",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                string query =
                    "DELETE FROM " + currentTable +
                    " WHERE " + idColumn + "=@id";

                Database.Execute(
                    query,
                    new SqlParameter("@id", selectedId));

                MessageBox.Show(
                    "Record deleted successfully!",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not delete record.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

     
        private void featureGrid_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                featureGrid.Rows[e.RowIndex];

            selectedId =
                Convert.ToInt32(row.Cells[0].Value);

            txtField1.Text =
                Convert.ToString(row.Cells[1].Value);

            if (dtpField2.Visible)
            {
                dtpField2.Value =
                    Convert.ToDateTime(row.Cells[2].Value);
            }
            else
            {
                txtField2.Text =
                    Convert.ToString(row.Cells[2].Value);
            }

            if (dtpField3.Visible)
            {
                dtpField3.Value =
                    Convert.ToDateTime(row.Cells[3].Value);
            }
            else
            {
                txtField3.Text =
                    Convert.ToString(row.Cells[3].Value);
            }

            txtField4.Text =
                Convert.ToString(row.Cells[4].Value);
        }

        private object GetField2Value()
        {
            if (dtpField2.Visible)
                return dtpField2.Value.Date;

            if (currentTable == "Maintenance")
                return Convert.ToInt32(txtField2.Text);

            return txtField2.Text.Trim();
        }

        private object GetField3Value()
        {
            if (dtpField3.Visible)
                return dtpField3.Value.Date;

            return txtField3.Text.Trim();
        }

        private string[] GetColumns()
        {
            if (currentTable == "Units")
                return new[]
                {
                    "FlatNo",
                    "BuildingName",
                    "FloorNo",
                    "RentAmount"
                };

            if (currentTable == "Residents")
                return new[]
                {
                    "FullName",
                    "Email",
                    "Phone",
                    "UnitNumber"
                };

            if (currentTable == "Notices")
                return new[]
                {
                    "Title",
                    "NoticeDate",
                    "Category",
                    "Description"
                };

            if (currentTable == "Complaints")
                return new[]
                {
                    "ResidentName",
                    "Subject",
                    "Priority",
                    "Status"
                };

            if (currentTable == "Visitors")
                return new[]
                {
                    "VisitorName",
                    "ResidentName",
                    "VisitDate",
                    "Purpose"
                };

            if (currentTable == "EmergencyContacts")
                return new[]
                {
                    "ContactName",
                    "ContactType",
                    "Phone",
                    "Location"
                };

            if (currentTable == "Maintenance")
                return new[]
                {
                    "Title",
                    "FlatId",
                    "AssignedTo",
                    "Status"
                };

            return new[]
            {
                "ServiceName",
                "Provider",
                "Description",
                "Status"
            };
        }

        private void ClearFields()
        {
            txtField1.Clear();
            txtField2.Clear();
            txtField3.Clear();
            txtField4.Clear();

            selectedId = 0;
            featureGrid.ClearSelection();
        }
    }
}