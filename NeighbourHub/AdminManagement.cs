using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class AdminManagement : Form
    {
        private DataGridView dataGridView;
        private DataTable currentTable;

        public AdminManagement()
        {
            InitializeComponent();

            this.Size = new Size(900, 600);
            this.MinimumSize = new Size(750, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            
            dataGridView = new DataGridView();

            dataGridView.Name = "dataGridView";
            dataGridView.Dock = DockStyle.Bottom;
            dataGridView.Height = 220;
            dataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView.MultiSelect = false;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            this.Controls.Add(dataGridView);

        }

        private void AdminManagement_Load(object sender, EventArgs e)
        {
            dataGridView.BringToFront();
        }

       
        private string GetTableName()
        {
            if (cmbModule.SelectedIndex == -1)
            {
                return "";
            }

            string module = cmbModule.SelectedItem.ToString();

            switch (module)
            {
                case "Users":
                    return "dbo.Users";

                case "Buildings":
                    return "dbo.AdminBuildings";

                case "Complaints":
                    return "dbo.AdminComplaints";

                default:
                    return "";
            }
        }

        
        private void cmbModule_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            LoadModuleData();
        }

        private void LoadModuleData()
        {
            string tableName = GetTableName();

            if (string.IsNullOrEmpty(tableName))
            {
                dataGridView.DataSource = null;
                currentTable = null;
                return;
            }

            try
            {
                string query = "SELECT * FROM " + tableName;

                currentTable = Database.Query(query);

                dataGridView.DataSource = currentTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Data load failed!\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

      
        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            if (currentTable == null)
            {
                return;
            }

            string searchText = txtSearch.Text.Trim();

            if (searchText == "Search..." ||
                searchText == "")
            {
                currentTable.DefaultView.RowFilter = "";
                return;
            }

            string filter = "";

            foreach (DataColumn column in currentTable.Columns)
            {
                if (filter != "")
                {
                    filter += " OR ";
                }

                filter +=
                    "CONVERT([" +
                    column.ColumnName +
                    "], 'System.String') LIKE '%" +
                    searchText.Replace("'", "''") +
                    "%'";
            }

            currentTable.DefaultView.RowFilter = filter;
        }

        // add
        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            if (cmbModule.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a module first!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string module = cmbModule.SelectedItem.ToString();

            try
            {
                if (module == "Users")
                {
                    AddUser();
                }
                else if (module == "Buildings")
                {
                    AddBuilding();
                }
                else if (module == "Complaints")
                {
                    AddComplaint();
                }
                else
                {
                    MessageBox.Show(
                        "This module is not connected yet.",
                        "Information"
                    );
                }

                LoadModuleData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Add failed!\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //aadd user
        private void AddUser()
        {
            string name = Ask("Enter user name:");
            if (name == "") return;

            string email = Ask("Enter email:");
            if (email == "") return;

            string password = Ask("Enter password:");
            if (password == "") return;

            string phone = Ask("Enter phone:");
            if (phone == "") return;

            string gender = Ask("Enter gender:");
            if (gender == "") return;

            string address = Ask("Enter address:");
            if (address == "") return;

            string role = Ask("Enter role:");
            if (role == "") return;

            string query = @"
                INSERT INTO dbo.Users
                (Name, Email, Password, Phone, Gender, Address, Role)
                VALUES
                (@Name, @Email, @Password, @Phone, @Gender, @Address, @Role)";

            Database.Execute(
                query,
                new SqlParameter("@Name", name),
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", password),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Gender", gender),
                new SqlParameter("@Address", address),
                new SqlParameter("@Role", role)
            );

            MessageBox.Show("User added successfully!");
        }

        // addd builginh
        private void AddBuilding()
        {
            string buildingName = Ask("Enter building name:");
            if (buildingName == "") return;

            string address = Ask("Enter address:");
            if (address == "") return;

            string totalUnitsText = Ask("Enter total units:");
            if (totalUnitsText == "") return;

            int totalUnits;

            if (!int.TryParse(totalUnitsText, out totalUnits))
            {
                MessageBox.Show("Total units must be a number!");
                return;
            }

            string query = @"
                INSERT INTO dbo.AdminBuildings
                (BuildingName, Address, TotalUnits, CreatedAt)
                VALUES
                (@BuildingName, @Address, @TotalUnits, @CreatedAt)";

            Database.Execute(
                query,
                new SqlParameter("@BuildingName", buildingName),
                new SqlParameter("@Address", address),
                new SqlParameter("@TotalUnits", totalUnits),
                new SqlParameter("@CreatedAt", DateTime.Now)
            );

            MessageBox.Show("Building added successfully!");
        }

        // add compline
        private void AddComplaint()
        {
            string userIdText = Ask("Enter User ID:");
            if (userIdText == "") return;

            string subject = Ask("Enter subject:");
            if (subject == "") return;

            string description = Ask("Enter description:");
            if (description == "") return;

            string status = Ask("Enter status:");
            if (status == "") return;

            int userId;

            if (!int.TryParse(userIdText, out userId))
            {
                MessageBox.Show("User ID must be a number!");
                return;
            }

            string query = @"
                INSERT INTO dbo.AdminComplaints
                (UserID, Subject, Description, Status, CreatedAt)
                VALUES
                (@UserID, @Subject, @Description, @Status, @CreatedAt)";

            Database.Execute(
                query,
                new SqlParameter("@UserID", userId),
                new SqlParameter("@Subject", subject),
                new SqlParameter("@Description", description),
                new SqlParameter("@Status", status),
                new SqlParameter("@CreatedAt", DateTime.Now)
            );

            MessageBox.Show("Complaint added successfully!");
        }

        // eedit
        private void btnEdit_Click(
            object sender,
            EventArgs e)
        {
            if (cmbModule.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a module first!");
                return;
            }

            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first!");
                return;
            }

            string module = cmbModule.SelectedItem.ToString();

            try
            {
                if (module == "Users")
                {
                    EditUser();
                }
                else if (module == "Buildings")
                {
                    EditBuilding();
                }
                else if (module == "Complaints")
                {
                    EditComplaint();
                }

                LoadModuleData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Edit failed!\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        
        private void EditUser()
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];

            int userId = Convert.ToInt32(row.Cells["UserId"].Value);

            string name = Ask("Name:", row.Cells["Name"].Value.ToString());
            if (name == "") return;

            string email = Ask("Email:", row.Cells["Email"].Value.ToString());
            if (email == "") return;

            string password = Ask("Password:", row.Cells["Password"].Value.ToString());
            if (password == "") return;

            string phone = Ask("Phone:", row.Cells["Phone"].Value.ToString());
            if (phone == "") return;

            string gender = Ask("Gender:", row.Cells["Gender"].Value.ToString());
            if (gender == "") return;

            string address = Ask("Address:", row.Cells["Address"].Value.ToString());
            if (address == "") return;

            string role = Ask("Role:", row.Cells["Role"].Value.ToString());
            if (role == "") return;

            string query = @"
                UPDATE dbo.Users SET
                Name=@Name,
                Email=@Email,
                Password=@Password,
                Phone=@Phone,
                Gender=@Gender,
                Address=@Address,
                Role=@Role
                WHERE UserId=@UserId";

            Database.Execute(
                query,
                new SqlParameter("@Name", name),
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", password),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Gender", gender),
                new SqlParameter("@Address", address),
                new SqlParameter("@Role", role),
                new SqlParameter("@UserId", userId)
            );

            MessageBox.Show("User updated successfully!");
        }

        
        private void EditBuilding()
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];

            int buildingId =
                Convert.ToInt32(row.Cells["BuildingID"].Value);

            string buildingName =
                Ask("Building name:",
                row.Cells["BuildingName"].Value.ToString());

            if (buildingName == "") return;

            string address =
                Ask("Address:",
                row.Cells["Address"].Value.ToString());

            if (address == "") return;

            string unitsText =
                Ask("Total units:",
                row.Cells["TotalUnits"].Value.ToString());

            if (unitsText == "") return;

            int totalUnits;

            if (!int.TryParse(unitsText, out totalUnits))
            {
                MessageBox.Show("Total units must be a number!");
                return;
            }

            string query = @"
                UPDATE dbo.AdminBuildings SET
                BuildingName=@BuildingName,
                Address=@Address,
                TotalUnits=@TotalUnits
                WHERE BuildingID=@BuildingID";

            Database.Execute(
                query,
                new SqlParameter("@BuildingName", buildingName),
                new SqlParameter("@Address", address),
                new SqlParameter("@TotalUnits", totalUnits),
                new SqlParameter("@BuildingID", buildingId)
            );

            MessageBox.Show("Building updated successfully!");
        }

       
        private void EditComplaint()
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];

            int complaintId =
                Convert.ToInt32(row.Cells["ComplaintID"].Value);

            string userIdText =
                Ask("User ID:",
                row.Cells["UserID"].Value.ToString());

            if (userIdText == "") return;

            string subject =
                Ask("Subject:",
                row.Cells["Subject"].Value.ToString());

            if (subject == "") return;

            string description =
                Ask("Description:",
                row.Cells["Description"].Value.ToString());

            string status =
                Ask("Status:",
                row.Cells["Status"].Value.ToString());

            int userId;

            if (!int.TryParse(userIdText, out userId))
            {
                MessageBox.Show("User ID must be a number!");
                return;
            }

            string query = @"
                UPDATE dbo.AdminComplaints SET
                UserID=@UserID,
                Subject=@Subject,
                Description=@Description,
                Status=@Status
                WHERE ComplaintID=@ComplaintID";

            Database.Execute(
                query,
                new SqlParameter("@UserID", userId),
                new SqlParameter("@Subject", subject),
                new SqlParameter("@Description", description),
                new SqlParameter("@Status", status),
                new SqlParameter("@ComplaintID", complaintId)
            );

            MessageBox.Show("Complaint updated successfully!");
        }

        
        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (cmbModule.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a module first!");
                return;
            }

            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
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
                string tableName = GetTableName();

                string primaryKeyColumn =
                    dataGridView.Columns[0].Name;

                object primaryKeyValue =
                    dataGridView.SelectedRows[0].Cells[0].Value;

                string query =
                    "DELETE FROM " +
                    tableName +
                    " WHERE [" +
                    primaryKeyColumn +
                    "] = @ID";

                Database.Execute(
                    query,
                    new SqlParameter("@ID", primaryKeyValue)
                );

                MessageBox.Show("Record deleted successfully!");

                LoadModuleData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Delete failed!\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

       
        private string Ask(
            string message,
            string defaultValue = "")
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 160,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "NeighbourHub",
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label()
            {
                Left = 20,
                Top = 20,
                Width = 340,
                Text = message
            };

            TextBox textBox = new TextBox()
            {
                Left = 20,
                Top = 50,
                Width = 340,
                Text = defaultValue
            };

            Button confirmation = new Button()
            {
                Text = "OK",
                Left = 270,
                Top = 85,
                Width = 90,
                DialogResult = DialogResult.OK
            };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK
                ? textBox.Text
                : "";
        }
    }
}