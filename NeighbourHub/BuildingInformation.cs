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
    public partial class BuildingInformation : Form
    {
        public BuildingInformation()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuildingName.Text))
            {
                MessageBox.Show("Please enter the building name.");
                txtBuildingName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbAddress.Text))
            {
                MessageBox.Show("Please enter the address.");
                rtbAddress.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTotalFloors.Text))
            {
                MessageBox.Show("Please enter the total floors.");
                txtTotalFloors.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTotalUnits.Text))
            {
                MessageBox.Show("Please enter the total units.");
                txtTotalUnits.Focus();
                return;
            }

            int floors;
            int units;

            if (!int.TryParse(txtTotalFloors.Text, out floors) || floors <= 0)
            {
                MessageBox.Show("Please enter a valid number of floors.");
                txtTotalFloors.Focus();
                return;
            }

            if (!int.TryParse(txtTotalUnits.Text, out units) || units <= 0)
            {
                MessageBox.Show("Please enter a valid number of units.");
                txtTotalUnits.Focus();
                return;
            }

            try
            {
                string query =
                    "INSERT INTO Buildings " +
                    "(BuildingName, Address, TotalFloors, TotalUnits) " +
                    "VALUES (@name, @address, @floors, @units)";

                Database.Execute(
                    query,
                    new SqlParameter("@name",
                        txtBuildingName.Text.Trim()),

                    new SqlParameter("@address",
                        rtbAddress.Text.Trim()),

                    new SqlParameter("@floors",
                        floors),

                    new SqlParameter("@units",
                        units)
                );

                MessageBox.Show(
                    "Building information saved successfully!",
                    "NeighbourHub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtBuildingName.Clear();
                rtbAddress.Clear();
                txtTotalFloors.Clear();
                txtTotalUnits.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not save building information.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }
    }
}