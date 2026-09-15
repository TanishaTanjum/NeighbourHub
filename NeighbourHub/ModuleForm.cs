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
    public partial class ModuleForm : Form
    {
        private List<ModuleRecord> records =
            new List<ModuleRecord>();

        private int nextId = 1;

        public ModuleForm()
        {
            InitializeModule();
        }

        public ModuleForm(string moduleName)
        {
            InitializeModule();

            Text = "NeighbourHub - " + moduleName;
            lblTitle.Text = moduleName;
        }

        private void InitializeModule()
        {
            InitializeComponent();

            btnAdd.Click += BtnAdd_Click;
            btnClose.Click += BtnClose_Click;
            txtSearch.TextChanged += TxtSearch_TextChanged;

            PrepareGrid();
            LoadSampleData();
            RefreshGrid();
        }

        private void PrepareGrid()
        {
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add("ID", "ID");
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Details", "Details");

            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.MultiSelect = false;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadSampleData()
        {
            records.Add(new ModuleRecord
            {
                ID = nextId++,
                Name = "Sample Property",
                Details = "Example record"
            });

            records.Add(new ModuleRecord
            {
                ID = nextId++,
                Name = "Second Record",
                Details = "Another example"
            });
        }

        private void RefreshGrid()
        {
            string searchText =
                txtSearch.Text.Trim().ToLower();

            dataGridView.Rows.Clear();

            foreach (ModuleRecord record in records)
            {
                bool matchesSearch =
                    record.Name.ToLower().Contains(searchText) ||
                    record.Details.ToLower().Contains(searchText);

                if (matchesSearch)
                {
                    dataGridView.Rows.Add(
                        record.ID,
                        record.Name,
                        record.Details
                    );
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ModuleRecord newRecord = new ModuleRecord
            {
                ID = nextId++,
                Name = "New Record",
                Details = "Added from the Add button"
            };

            records.Add(newRecord);

            // Clear the search box so all records become visible
            txtSearch.Clear();

            RefreshGrid();

            MessageBox.Show(
                "Record added successfully.",
                "NeighbourHub",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void TxtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            RefreshGrid();
        }

        private void BtnClose_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }

    public class ModuleRecord
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Details { get; set; }
    }
}