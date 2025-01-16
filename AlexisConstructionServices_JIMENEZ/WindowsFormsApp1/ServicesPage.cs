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
        private int _selectedServiceId;

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
                var dataTable = CreateServicesDataTable();

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
                ShowErrorMessage("Error loading services", ex);
            }
        }

        private static DataTable CreateServicesDataTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ServiceID", typeof(int));
            dataTable.Columns.Add("ServiceName", typeof(string));
            dataTable.Columns.Add("HourlyRate", typeof(decimal));
            return dataTable;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string validationMessage))
            {
                MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                ShowErrorMessage("Error saving service", ex);
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedServiceId(out int serviceId))
            {
                MessageBox.Show("Please select a row to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this service?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _repository.DeleteService(serviceId);
                    MessageBox.Show("Service deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadServices();
                }
                catch (Exception ex)
                {
                    ShowErrorMessage("Error deleting service", ex);
                }
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

        private bool ValidateInputs(out string validationMessage)
        {
            if (string.IsNullOrWhiteSpace(Servicetb.Text))
            {
                validationMessage = "Service name is required.";
                return false;
            }

            if (!decimal.TryParse(HourlyRatetb.Text, out _))
            {
                validationMessage = "Hourly rate must be a valid number.";
                return false;
            }

            validationMessage = string.Empty;
            return true;
        }

        private bool TryGetSelectedServiceId(out int serviceId)
        {
            serviceId = -1;

            if (ServicesTable.SelectedRows.Count == 0)
            {
                return false;
            }

            var selectedRow = ServicesTable.SelectedRows[0];
            serviceId = Convert.ToInt32(selectedRow.Cells["ServiceID"].Value);
            return true;
        }

        private void ShowErrorMessage(string title, Exception ex)
        {
            MessageBox.Show($"{title}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
