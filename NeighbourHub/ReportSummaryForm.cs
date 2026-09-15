using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class ReportSummaryForm : Form
    {
        public ReportSummaryForm()
        {
            InitializeComponent();

            dtpFromDate.Value =
                new DateTime(
                    DateTime.Today.Year,
                    DateTime.Today.Month,
                    1
                );

            dtpToDate.Value = DateTime.Today;

            GenerateReport();
        }

        private int GetCount(
            string query,
            params SqlParameter[] parameters)
        {
            DataTable table =
                Database.Query(query, parameters);

            if (table.Rows.Count == 0)
                return 0;

            return Convert.ToInt32(
                table.Rows[0][0]
            );
        }

        private decimal GetAmount(
            string query,
            params SqlParameter[] parameters)
        {
            DataTable table =
                Database.Query(query, parameters);

            if (table.Rows.Count == 0)
                return 0;

            if (table.Rows[0][0] == DBNull.Value)
                return 0;

            return Convert.ToDecimal(
                table.Rows[0][0]
            );
        }

        private void GenerateReport()
        {
            DateTime fromDate =
                dtpFromDate.Value.Date;

            DateTime toDate =
                dtpToDate.Value.Date;

            if (fromDate > toDate)
            {
                MessageBox.Show(
                    "From Date cannot be after To Date."
                );
                return;
            }

            int properties = GetCount(
                "SELECT COUNT(*) FROM dbo.Properties"
            );

            int units = GetCount(
                "SELECT COUNT(*) FROM dbo.FlatUnits"
            );

            int tenants = GetCount(
                "SELECT COUNT(*) FROM dbo.Tenants"
            );

            int paidCount = GetCount(
                @"SELECT COUNT(*)
                  FROM dbo.RentPayments
                  WHERE Status = 'Paid'
                  AND RentMonth BETWEEN @FromDate AND @ToDate",
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate)
            );

            decimal paidAmount = GetAmount(
                @"SELECT ISNULL(SUM(Amount), 0)
                  FROM dbo.RentPayments
                  WHERE Status = 'Paid'
                  AND RentMonth BETWEEN @FromDate AND @ToDate",
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate)
            );

            int unpaidCount = GetCount(
                @"SELECT COUNT(*)
                  FROM dbo.RentPayments
                  WHERE Status = 'Unpaid'
                  AND RentMonth BETWEEN @FromDate AND @ToDate",
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate)
            );

            decimal unpaidAmount = GetAmount(
                @"SELECT ISNULL(SUM(Amount), 0)
                  FROM dbo.RentPayments
                  WHERE Status = 'Unpaid'
                  AND RentMonth BETWEEN @FromDate AND @ToDate",
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate)
            );

            int maintenance = GetCount(
                @"SELECT COUNT(*)
                  FROM dbo.OwnerMaintenanceRequests
                  WHERE RequestDate BETWEEN @FromDate AND @ToDate",
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate)
            );

            int complaints = GetCount(
                @"SELECT COUNT(*)
                  FROM dbo.OwnerComplaints
                  WHERE ComplaintDate BETWEEN @FromDate AND @ToDate",
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate)
            );

            int utilities = GetCount(
                @"SELECT COUNT(*)
                  FROM dbo.OwnerUtilityBills
                  WHERE BillingMonth BETWEEN @FromDate AND @ToDate",
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate)
            );

            decimal utilityAmount = GetAmount(
                @"SELECT ISNULL(SUM(Amount), 0)
                  FROM dbo.OwnerUtilityBills
                  WHERE BillingMonth BETWEEN @FromDate AND @ToDate",
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate)
            );

            lblPropertiesValue.Text =
                properties.ToString();

            lblUnitsValue.Text =
                units.ToString();

            lblTenantsValue.Text =
                tenants.ToString();

            lblPaidRentValue.Text =
                paidAmount.ToString("0.00");

            lblUnpaidRentValue.Text =
                unpaidAmount.ToString("0.00");

            lblMaintenanceValue.Text =
                maintenance.ToString();

            lblComplaintsValue.Text =
                complaints.ToString();

            lblUtilitiesValue.Text =
                utilityAmount.ToString("0.00");

            dgvReportSummary.Rows.Clear();

            dgvReportSummary.Rows.Add(
                "Properties",
                properties,
                "",
                "Total properties"
            );

            dgvReportSummary.Rows.Add(
                "Flat / Units",
                units,
                "",
                "Total units"
            );

            dgvReportSummary.Rows.Add(
                "Tenants",
                tenants,
                "",
                "Total tenants"
            );

            dgvReportSummary.Rows.Add(
                "Paid Rent",
                paidCount,
                paidAmount.ToString("0.00"),
                "Paid"
            );

            dgvReportSummary.Rows.Add(
                "Unpaid Rent",
                unpaidCount,
                unpaidAmount.ToString("0.00"),
                "Unpaid"
            );

            dgvReportSummary.Rows.Add(
                "Maintenance",
                maintenance,
                "",
                "Requests"
            );

            dgvReportSummary.Rows.Add(
                "Complaints",
                complaints,
                "",
                "Complaints"
            );

            dgvReportSummary.Rows.Add(
                "Utilities",
                utilities,
                utilityAmount.ToString("0.00"),
                "Utility bills"
            );

            dgvReportSummary.ClearSelection();
        }

        private void btnGenerateReport_Click(
            object sender,
            EventArgs e)
        {
            GenerateReport();
        }

        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            GenerateReport();
        }

        private void btnClose_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}