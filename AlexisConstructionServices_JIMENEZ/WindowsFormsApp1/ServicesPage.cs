using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1
{
    public partial class ServicesPage : Form
    {
        private readonly ServicesRepository _repository;
        private int _selectedServiceId = 0;

        public ServicesPage()
        {
            InitializeComponent();
            _repository = new ServicesRepository();
            ServicesTable.CellClick += ServicesTable_CellClick;
            LoadServices();
        }

        private void LoadServices()
        {
            try
            {
                var services = _repository.GetServices();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ServiceID", typeof(int));
                dataTable.Columns.Add("ServiceName", typeof(string));
                dataTable.Columns.Add("HourlyRate", typeof(decimal));

                foreach (var service in services)
                {
                    var row = dataTable.NewRow();
                    row["ServiceID"] = service.ServiceID;
                    row["ServiceName"] = service.ServiceName;
                    row["HourlyRate"] = service.HourlyRate;
                    dataTable.Rows.Add(row);
                }

                ServicesTable.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading services: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Servicetb.Text) || string.IsNullOrWhiteSpace(HourlyRatetb.Text))
            {
                MessageBox.Show("All fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var service = new Service
                {
                    ServiceID = _selectedServiceId,
                    ServiceName = Servicetb.Text,
                    HourlyRate = decimal.Parse(HourlyRatetb.Text)
                };

                if (_selectedServiceId == 0)
                {
                    _repository.CreateService(service);
                    MessageBox.Show("Service added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _repository.UpdateService(service);
                    MessageBox.Show("Service updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ResetForm();
                LoadServices();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving service: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (ServicesTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedRow = ServicesTable.SelectedRows[0];
                int serviceId = Convert.ToInt32(selectedRow.Cells["ServiceID"].Value);

                var confirmResult = MessageBox.Show("Are you sure you want to delete this service?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    _repository.DeleteService(serviceId);
                    MessageBox.Show("Service deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadServices();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting service: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ServicesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = ServicesTable.Rows[e.RowIndex];
                _selectedServiceId = Convert.ToInt32(row.Cells["ServiceID"].Value);
                Servicetb.Text = row.Cells["ServiceName"].Value.ToString();
                HourlyRatetb.Text = row.Cells["HourlyRate"].Value.ToString();
            }
        }

        private void ResetForm()
        {
            _selectedServiceId = 0;
            Servicetb.Clear();
            HourlyRatetb.Clear();
        }
    }
}
