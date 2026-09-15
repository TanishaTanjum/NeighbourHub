using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class PaymentTrackingForm : Form
    {
        public PaymentTrackingForm()
        {
            InitializeComponent();
            LoadAllocations();
            LoadPayments();

            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;
        }

        private void LoadAllocations()
        {
            DataTable table = Database.Query(
                @"SELECT
                    A.ID,
                    T.TenantName + ' - ' +
                    P.PropertyName + ' - Unit ' +
                    CONVERT(NVARCHAR(50), F.UnitNumber) AS DisplayName
                  FROM dbo.TenantAllocations A
                  INNER JOIN dbo.Tenants T
                    ON A.TenantID = T.ID
                  INNER JOIN dbo.FlatUnits F
                    ON A.FlatUnitID = F.ID
                  INNER JOIN dbo.Properties P
                    ON F.PropertyID = P.ID
                  WHERE A.IsActive = 1
                  ORDER BY T.TenantName"
            );

            cmbAllocation.DataSource = table;
            cmbAllocation.DisplayMember = "DisplayName";
            cmbAllocation.ValueMember = "ID";
            cmbAllocation.SelectedIndex = -1;
        }

        private void LoadPayments()
        {
            DataTable table = Database.Query(
                @"SELECT
                    RP.ID,
                    T.TenantName,
                    P.PropertyName + ' - Unit ' +
                    CONVERT(NVARCHAR(50), F.UnitNumber) AS FlatUnit,
                    RP.RentMonth,
                    RP.Amount,
                    RP.PaymentDate,
                    RP.Status
                  FROM dbo.RentPayments RP
                  INNER JOIN dbo.TenantAllocations A
                    ON RP.AllocationID = A.ID
                  INNER JOIN dbo.Tenants T
                    ON A.TenantID = T.ID
                  INNER JOIN dbo.FlatUnits F
                    ON A.FlatUnitID = F.ID
                  INNER JOIN dbo.Properties P
                    ON F.PropertyID = P.ID
                  ORDER BY RP.ID"
            );

            dgvPayments.Rows.Clear();

            foreach (DataRow row in table.Rows)
            {
                string paymentDate = "";

                if (row["PaymentDate"] != DBNull.Value)
                {
                    paymentDate =
                        Convert.ToDateTime(
                            row["PaymentDate"]
                        ).ToShortDateString();
                }

                dgvPayments.Rows.Add(
                    row["ID"],
                    row["TenantName"],
                    row["FlatUnit"],
                    Convert.ToDateTime(
                        row["RentMonth"]
                    ).ToString("MMMM yyyy"),
                    Convert.ToDecimal(
                        row["Amount"]
                    ).ToString("0.00"),
                    paymentDate,
                    row["Status"]
                );
            }

            dgvPayments.ClearSelection();
        }

        private void btnRecordPayment_Click(object sender, EventArgs e)
        {
            if (cmbAllocation.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a tenant / flat.");
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
                MessageBox.Show("Please select payment status.");
                return;
            }

            int allocationID =
                Convert.ToInt32(cmbAllocation.SelectedValue);

            DateTime rentMonth =
                new DateTime(
                    dtpRentMonth.Value.Year,
                    dtpRentMonth.Value.Month,
                    1
                );

            DataTable existing = Database.Query(
                @"SELECT ID
                  FROM dbo.RentPayments
                  WHERE AllocationID = @AllocationID
                  AND YEAR(RentMonth) = @Year
                  AND MONTH(RentMonth) = @Month",
                new SqlParameter("@AllocationID", allocationID),
                new SqlParameter("@Year", rentMonth.Year),
                new SqlParameter("@Month", rentMonth.Month)
            );

            if (existing.Rows.Count > 0)
            {
                MessageBox.Show(
                    "A payment record already exists for this month."
                );
                return;
            }

            object paymentDate = DBNull.Value;

            if (cmbStatus.Text == "Paid")
            {
                paymentDate = dtpPaymentDate.Value.Date;
            }

            Database.Execute(
                @"INSERT INTO dbo.RentPayments
                  (
                    AllocationID,
                    RentMonth,
                    Amount,
                    PaymentDate,
                    Status
                  )
                  VALUES
                  (
                    @AllocationID,
                    @RentMonth,
                    @Amount,
                    @PaymentDate,
                    @Status
                  )",
                new SqlParameter("@AllocationID", allocationID),
                new SqlParameter("@RentMonth", rentMonth),
                new SqlParameter("@Amount", amount),
                new SqlParameter("@PaymentDate", paymentDate),
                new SqlParameter("@Status", cmbStatus.Text)
            );

            MessageBox.Show("Payment recorded successfully.");

            ClearFields();
            LoadPayments();
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            if (dgvPayments.CurrentRow == null ||
                dgvPayments.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a payment record.");
                return;
            }

            if (cmbAllocation.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a tenant / flat.");
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

            int id = Convert.ToInt32(
                dgvPayments.CurrentRow.Cells[0].Value
            );

            int allocationID =
                Convert.ToInt32(cmbAllocation.SelectedValue);

            DateTime rentMonth =
                new DateTime(
                    dtpRentMonth.Value.Year,
                    dtpRentMonth.Value.Month,
                    1
                );

            object paymentDate = DBNull.Value;

            if (cmbStatus.Text == "Paid")
            {
                paymentDate = dtpPaymentDate.Value.Date;
            }

            Database.Execute(
                @"UPDATE dbo.RentPayments
                  SET AllocationID = @AllocationID,
                      RentMonth = @RentMonth,
                      Amount = @Amount,
                      PaymentDate = @PaymentDate,
                      Status = @Status
                  WHERE ID = @ID",
                new SqlParameter("@AllocationID", allocationID),
                new SqlParameter("@RentMonth", rentMonth),
                new SqlParameter("@Amount", amount),
                new SqlParameter("@PaymentDate", paymentDate),
                new SqlParameter("@Status", cmbStatus.Text),
                new SqlParameter("@ID", id)
            );

            MessageBox.Show("Payment updated successfully.");

            ClearFields();
            LoadPayments();
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            if (dgvPayments.CurrentRow == null ||
                dgvPayments.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a payment record.");
                return;
            }

            int id = Convert.ToInt32(
                dgvPayments.CurrentRow.Cells[0].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this payment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            Database.Execute(
                @"DELETE FROM dbo.RentPayments
                  WHERE ID = @ID",
                new SqlParameter("@ID", id)
            );

            MessageBox.Show("Payment deleted successfully.");

            ClearFields();
            LoadPayments();
        }

        private void dgvPayments_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(
                dgvPayments.Rows[e.RowIndex]
                .Cells[0].Value
            );

            DataTable table = Database.Query(
                @"SELECT
                    AllocationID,
                    RentMonth,
                    Amount,
                    PaymentDate,
                    Status
                  FROM dbo.RentPayments
                  WHERE ID = @ID",
                new SqlParameter("@ID", id)
            );

            if (table.Rows.Count == 0)
                return;

            DataRow row = table.Rows[0];

            cmbAllocation.SelectedValue =
                row["AllocationID"];

            dtpRentMonth.Value =
                Convert.ToDateTime(row["RentMonth"]);

            txtAmount.Text =
                Convert.ToDecimal(
                    row["Amount"]
                ).ToString("0.00");

            cmbStatus.Text =
                row["Status"].ToString();

            if (row["PaymentDate"] != DBNull.Value)
            {
                dtpPaymentDate.Value =
                    Convert.ToDateTime(
                        row["PaymentDate"]
                    );
            }
        }

        private void ClearFields()
        {
            cmbAllocation.SelectedIndex = -1;
            txtAmount.Clear();

            dtpRentMonth.Value = DateTime.Today;
            dtpPaymentDate.Value = DateTime.Today;

            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;

            dgvPayments.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}