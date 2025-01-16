using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Repositories;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class ClientPage : Form
    {
        private readonly ClientRepository _repository;

        public ClientPage()
        {
            InitializeComponent();
            _repository = new ClientRepository();
            LoadClients();
        }

        private void LoadClients()
        {
            try
            {
                var clients = _repository.GetClients();
                var dataTable = CreateClientsDataTable();

                foreach (var client in clients)
                {
                    var row = dataTable.NewRow();
                    row["ClientID"] = client.ClientID;
                    row["Name"] = client.Name;
                    row["Contact"] = client.Contact;
                    row["Address"] = client.Address;
                    dataTable.Rows.Add(row);
                }

                ClientsTable.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error loading clients", ex);
            }
        }

        private static DataTable CreateClientsDataTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ClientID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Contact", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            return dataTable;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            using (var form = new CreateEditForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadClients();
                }
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedClientId(out int clientId))
            {
                MessageBox.Show("Please select a client to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var client = _repository.GetClient(clientId);

                if (client == null)
                {
                    MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var form = new CreateEditForm())
                {
                    form.EditClient(client);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadClients();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error editing client", ex);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedClientId(out int clientId))
            {
                MessageBox.Show("Please select a client to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this client?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _repository.DeleteClient(clientId);
                    MessageBox.Show("Client deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClients();
                }
                catch (Exception ex)
                {
                    ShowErrorMessage("Error deleting client", ex);
                }
            }
        }

        private bool TryGetSelectedClientId(out int clientId)
        {
            clientId = -1;

            if (ClientsTable.SelectedRows.Count == 0)
            {
                return false;
            }

            var selectedRow = ClientsTable.SelectedRows[0];
            clientId = Convert.ToInt32(selectedRow.Cells["ClientID"].Value);
            return true;
        }

        private void ShowErrorMessage(string title, Exception ex)
        {
            MessageBox.Show($"{title}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
