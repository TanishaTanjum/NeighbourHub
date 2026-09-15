using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class NoticeManagementForm : Form
    {
        public NoticeManagementForm()
        {
            InitializeComponent();
            LoadNotices();
        }

        private void LoadNotices()
        {
            DataTable table = Database.Query(
                @"SELECT
                    ID,
                    NoticeTitle,
                    Audience,
                    PublishDate,
                    ExpiryDate,
                    Priority,
                    NoticeText
                  FROM dbo.OwnerNotices
                  ORDER BY ID DESC"
            );

            dgvNotices.Rows.Clear();

            foreach (DataRow row in table.Rows)
            {
                string expiryDate = "";

                if (row["ExpiryDate"] != DBNull.Value)
                {
                    expiryDate =
                        Convert.ToDateTime(
                            row["ExpiryDate"]
                        ).ToShortDateString();
                }

                dgvNotices.Rows.Add(
                    row["ID"],
                    row["NoticeTitle"],
                    row["Audience"],
                    Convert.ToDateTime(
                        row["PublishDate"]
                    ).ToShortDateString(),
                    expiryDate,
                    row["Priority"],
                    row["NoticeText"]
                );
            }

            dgvNotices.ClearSelection();
        }

        private void btnAddNotice_Click(object sender, EventArgs e)
        {
            if (txtNoticeTitle.Text.Trim() == "")
            {
                MessageBox.Show("Please enter notice title.");
                return;
            }

            if (cmbAudience.SelectedIndex == -1)
            {
                MessageBox.Show("Please select audience.");
                return;
            }

            if (cmbPriority.SelectedIndex == -1)
            {
                MessageBox.Show("Please select priority.");
                return;
            }

            if (txtNoticeText.Text.Trim() == "")
            {
                MessageBox.Show("Please enter notice text.");
                return;
            }

            if (dtpExpiryDate.Value.Date <
                dtpPublishDate.Value.Date)
            {
                MessageBox.Show(
                    "Expiry date cannot be before publish date."
                );
                return;
            }

            Database.Execute(
                @"INSERT INTO dbo.OwnerNotices
                  (
                    NoticeTitle,
                    Audience,
                    Priority,
                    PublishDate,
                    ExpiryDate,
                    NoticeText
                  )
                  VALUES
                  (
                    @NoticeTitle,
                    @Audience,
                    @Priority,
                    @PublishDate,
                    @ExpiryDate,
                    @NoticeText
                  )",
                new SqlParameter(
                    "@NoticeTitle",
                    txtNoticeTitle.Text.Trim()
                ),
                new SqlParameter(
                    "@Audience",
                    cmbAudience.Text
                ),
                new SqlParameter(
                    "@Priority",
                    cmbPriority.Text
                ),
                new SqlParameter(
                    "@PublishDate",
                    dtpPublishDate.Value.Date
                ),
                new SqlParameter(
                    "@ExpiryDate",
                    dtpExpiryDate.Value.Date
                ),
                new SqlParameter(
                    "@NoticeText",
                    txtNoticeText.Text.Trim()
                )
            );

            MessageBox.Show("Notice added successfully.");

            ClearFields();
            LoadNotices();
        }

        private void btnEditNotice_Click(object sender, EventArgs e)
        {
            if (dgvNotices.CurrentRow == null ||
                dgvNotices.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a notice.");
                return;
            }

            if (txtNoticeTitle.Text.Trim() == "")
            {
                MessageBox.Show("Please enter notice title.");
                return;
            }

            if (cmbAudience.SelectedIndex == -1 ||
                cmbPriority.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select audience and priority."
                );
                return;
            }

            if (txtNoticeText.Text.Trim() == "")
            {
                MessageBox.Show("Please enter notice text.");
                return;
            }

            if (dtpExpiryDate.Value.Date <
                dtpPublishDate.Value.Date)
            {
                MessageBox.Show(
                    "Expiry date cannot be before publish date."
                );
                return;
            }

            int id = Convert.ToInt32(
                dgvNotices.CurrentRow.Cells[0].Value
            );

            Database.Execute(
                @"UPDATE dbo.OwnerNotices
                  SET NoticeTitle = @NoticeTitle,
                      Audience = @Audience,
                      Priority = @Priority,
                      PublishDate = @PublishDate,
                      ExpiryDate = @ExpiryDate,
                      NoticeText = @NoticeText
                  WHERE ID = @ID",
                new SqlParameter(
                    "@NoticeTitle",
                    txtNoticeTitle.Text.Trim()
                ),
                new SqlParameter(
                    "@Audience",
                    cmbAudience.Text
                ),
                new SqlParameter(
                    "@Priority",
                    cmbPriority.Text
                ),
                new SqlParameter(
                    "@PublishDate",
                    dtpPublishDate.Value.Date
                ),
                new SqlParameter(
                    "@ExpiryDate",
                    dtpExpiryDate.Value.Date
                ),
                new SqlParameter(
                    "@NoticeText",
                    txtNoticeText.Text.Trim()
                ),
                new SqlParameter(
                    "@ID",
                    id
                )
            );

            MessageBox.Show("Notice updated successfully.");

            ClearFields();
            LoadNotices();
        }

        private void btnDeleteNotice_Click(object sender, EventArgs e)
        {
            if (dgvNotices.CurrentRow == null ||
                dgvNotices.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a notice.");
                return;
            }

            int id = Convert.ToInt32(
                dgvNotices.CurrentRow.Cells[0].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this notice?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            Database.Execute(
                @"DELETE FROM dbo.OwnerNotices
                  WHERE ID = @ID",
                new SqlParameter("@ID", id)
            );

            MessageBox.Show("Notice deleted successfully.");

            ClearFields();
            LoadNotices();
        }

        private void dgvNotices_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(
                dgvNotices.Rows[e.RowIndex]
                .Cells[0].Value
            );

            DataTable table = Database.Query(
                @"SELECT
                    NoticeTitle,
                    Audience,
                    Priority,
                    PublishDate,
                    ExpiryDate,
                    NoticeText
                  FROM dbo.OwnerNotices
                  WHERE ID = @ID",
                new SqlParameter("@ID", id)
            );

            if (table.Rows.Count == 0)
                return;

            DataRow row = table.Rows[0];

            txtNoticeTitle.Text =
                row["NoticeTitle"].ToString();

            cmbAudience.Text =
                row["Audience"].ToString();

            cmbPriority.Text =
                row["Priority"].ToString();

            dtpPublishDate.Value =
                Convert.ToDateTime(
                    row["PublishDate"]
                );

            if (row["ExpiryDate"] != DBNull.Value)
            {
                dtpExpiryDate.Value =
                    Convert.ToDateTime(
                        row["ExpiryDate"]
                    );
            }

            txtNoticeText.Text =
                row["NoticeText"].ToString();
        }

        private void ClearFields()
        {
            txtNoticeTitle.Clear();
            cmbAudience.SelectedIndex = -1;
            cmbPriority.SelectedIndex = -1;
            dtpPublishDate.Value = DateTime.Today;
            dtpExpiryDate.Value = DateTime.Today;
            txtNoticeText.Clear();
            dgvNotices.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}