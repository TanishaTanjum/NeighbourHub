using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class UtilityBillManagementForm : Form
    {
        public UtilityBillManagementForm()
        {
            InitializeComponent();
            LoadFlatUnits();
            LoadBills();
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

        private void LoadBills()
        {
            DataTable table = Database.Query(
                @"SELECT
                    U.ID,
                    P.PropertyName + ' - Unit ' +
                    CONVERT(NVARCHAR(50), F.UnitNumber) AS FlatUnit,
                    U.UtilityType,
                    U.BillingMonth,
                    U.Amount,
                    U.DueDate,
                    U.Status
                  FROM dbo.OwnerUtilityBills U
                  INNER JOIN dbo.FlatUnits F
                    ON U.FlatUnitID = F.ID
                  INNER JOIN dbo.Properties P
                    ON F.PropertyID = P.ID
                  ORDER BY U.ID DESC"
            );

            dgvUtilityBills.Rows.Clear();

            foreach (DataRow row in table.Rows)
            {
                dgvUtilityBills.Rows.Add(
                    row["ID"],
                    row["FlatUnit"],
                    row["UtilityType"],
                    Convert.ToDateTime(row["BillingMonth"]).ToString("MMMM yyyy"),
                    Convert.ToDecimal(row["Amount"]).ToString("0.00"),
                    Convert.ToDateTime(row["DueDate"]).ToShortDateString(),
                    row["Status"]
                );
            }

            dgvUtilityBills.ClearSelection();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            if (cmbFlatUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flat/unit.");
                return;
            }

            if (cmbUtilityType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select utility type.");
                return;
            }

            decimal amount;

            if (!decimal.TryParse(txtAmount.Text.Trim(), out amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Amount must be greater than zero.");
                return;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select status.");
                return;
            }

            DateTime billingMonth =
                new DateTime(
                    dtpBillingMonth.Value.Year,
                    dtpBillingMonth.Value.Month,
                    1
                );

            Database.Execute(
                @"INSERT INTO dbo.OwnerUtilityBills
                  (
                    FlatUnitID,
                    UtilityType,
                    BillingMonth,
                    Amount,
                    DueDate,
                    Status
                  )
                  VALUES
                  (
                    @FlatUnitID,
                    @UtilityType,
                    @BillingMonth,
                    @Amount,
                    @DueDate,
                    @Status
                  )",
                new SqlParameter(
                    "@FlatUnitID",
                    Convert.ToInt32(cmbFlatUnit.SelectedValue)
                ),
                new SqlParameter(
                    "@UtilityType",
                    cmbUtilityType.Text
                ),
                new SqlParameter(
                    "@BillingMonth",
                    billingMonth
                ),
                new SqlParameter(
                    "@Amount",
                    amount
                ),
                new SqlParameter(
                    "@DueDate",
                    dtpDueDate.Value.Date
                ),
                new SqlParameter(
                    "@Status",
                    cmbStatus.Text
                )
            );

            MessageBox.Show("Utility bill added successfully.");

            ClearFields();
            LoadBills();
        }

        private void btnEditBill_Click(object sender, EventArgs e)
        {
            if (dgvUtilityBills.CurrentRow == null ||
                dgvUtilityBills.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a utility bill.");
                return;
            }

            if (cmbFlatUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flat/unit.");
                return;
            }

            decimal amount;

            if (!decimal.TryParse(txtAmount.Text.Trim(), out amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            int id = Convert.ToInt32(
                dgvUtilityBills.CurrentRow.Cells[0].Value
            );

            DateTime billingMonth =
                new DateTime(
                    dtpBillingMonth.Value.Year,
                    dtpBillingMonth.Value.Month,
                    1
                );

            Database.Execute(
                @"UPDATE dbo.OwnerUtilityBills
                  SET FlatUnitID = @FlatUnitID,
                      UtilityType = @UtilityType,
                      BillingMonth = @BillingMonth,
                      Amount = @Amount,
                      DueDate = @DueDate,
                      Status = @Status
                  WHERE ID = @ID",
                new SqlParameter(
                    "@FlatUnitID",
                    Convert.ToInt32(cmbFlatUnit.SelectedValue)
                ),
                new SqlParameter(
                    "@UtilityType",
                    cmbUtilityType.Text
                ),
                new SqlParameter(
                    "@BillingMonth",
                    billingMonth
                ),
                new SqlParameter(
                    "@Amount",
                    amount
                ),
                new SqlParameter(
                    "@DueDate",
                    dtpDueDate.Value.Date
                ),
                new SqlParameter(
                    "@Status",
                    cmbStatus.Text
                ),
                new SqlParameter(
                    "@ID",
                    id
                )
            );

            MessageBox.Show("Utility bill updated successfully.");

            ClearFields();
            LoadBills();
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            if (dgvUtilityBills.CurrentRow == null ||
                dgvUtilityBills.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a utility bill.");
                return;
            }

            int id = Convert.ToInt32(
                dgvUtilityBills.CurrentRow.Cells[0].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this utility bill?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            Database.Execute(
                @"DELETE FROM dbo.OwnerUtilityBills
                  WHERE ID = @ID",
                new SqlParameter("@ID", id)
            );

            MessageBox.Show("Utility bill deleted successfully.");

            ClearFields();
            LoadBills();
        }

        private void dgvUtilityBills_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(
                dgvUtilityBills.Rows[e.RowIndex].Cells[0].Value
            );

            DataTable table = Database.Query(
                @"SELECT
                    FlatUnitID,
                    UtilityType,
                    BillingMonth,
                    Amount,
                    DueDate,
                    Status
                  FROM dbo.OwnerUtilityBills
                  WHERE ID = @ID",
                new SqlParameter("@ID", id)
            );

            if (table.Rows.Count == 0)
                return;

            DataRow row = table.Rows[0];

            cmbFlatUnit.SelectedValue = row["FlatUnitID"];
            cmbUtilityType.Text = row["UtilityType"].ToString();
            dtpBillingMonth.Value =
                Convert.ToDateTime(row["BillingMonth"]);
            txtAmount.Text =
                Convert.ToDecimal(row["Amount"]).ToString("0.00");
            dtpDueDate.Value =
                Convert.ToDateTime(row["DueDate"]);
            cmbStatus.Text = row["Status"].ToString();
        }

        private void ClearFields()
        {
            cmbFlatUnit.SelectedIndex = -1;
            cmbUtilityType.SelectedIndex = -1;
            txtAmount.Clear();
            cmbStatus.SelectedIndex = -1;

            dtpBillingMonth.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today;

            dgvUtilityBills.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}