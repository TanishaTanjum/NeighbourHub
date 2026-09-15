using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeighbourHub
{
    public partial class Owners_dashboard : Form
    {
        public Owners_dashboard()
        {
            InitializeComponent();

            ConnectDashboardButtons(this);
        }

        private void ConnectDashboardButtons(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    // Prevent duplicate event connections
                    button.Click -= DashboardButton_Click;
                    button.Click += DashboardButton_Click;
                }

                // Also search inside panels, group boxes, etc.
                if (control.HasChildren)
                {
                    ConnectDashboardButtons(control);
                }
            }
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null)
                return;

            string moduleName = clickedButton.Text.Trim();

            if (moduleName.Equals("Logout",
                StringComparison.OrdinalIgnoreCase))
            {
                Close();
                return;
            }

            if (moduleName.Equals("Property Management",
                StringComparison.OrdinalIgnoreCase))
            {
                using (PropertyManagementForm propertyForm =
                       new PropertyManagementForm())
                {
                    propertyForm.ShowDialog(this);
                }

                return;
            }

            MessageBox.Show(
                "This module is not available yet.",
                "NeighbourHub",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void b1_Click(object sender, EventArgs e)
        {

        }

        private void b2_Click(object sender, EventArgs e)
        {
            FlatManagementForm flatForm = new FlatManagementForm();
            flatForm.ShowDialog();
        }

        private void b11_Click(object sender, EventArgs e)
        {

        }
    }
}