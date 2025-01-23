using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Messages;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1
{
    public partial class CreateEditForm : Form
    {
        public CreateEditForm()
        {
            InitializeComponent();
            
            this.DialogResult = DialogResult.Cancel;
        }

        private int clientId = 0;
        public void EditClient(Client client)
        {
            
            MessageBox.Show($"Editing Client - ID: {client.ClientID}, Name: {client.Name}, Contact: {client.Contact}, Address: {client.Address}");

            this.Text = "Edit Client";
            this.lbTitle.Text = "Edit Client";

          
            this.lbclient.Text = client.ClientID.ToString();
            this.Nametb.Text = client.Name;
            this.Addresstb.Text = client.Address;
            this.Contacttb.Text = client.Contact;

            // Store the client ID for later use when saving
            this.clientId = client.ClientID;

        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alexisconstructionDBDataSet);

        }

        private void CreateEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alexisconstructionDBDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.alexisconstructionDBDataSet.Clients);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.ClientID = this.clientId;
            client.Name = this.Nametb.Text;
            client.Contact = this.Contacttb.Text;
            client.Address = this.Addresstb.Text;

            if (string.IsNullOrEmpty(Nametb.Text) && string.IsNullOrEmpty(Contacttb.Text) && string.IsNullOrEmpty(Addresstb.Text))
            {
                MessageBox.Show(ALEXISMessages.Erroremptyfields);
                return;
            }

            var repo = new Clientrepository();
            if (client.ClientID==0)
            {
                repo.CreateClient(client);
            }
            else
            {
                repo.UpdateClient(client);
            }

            this.DialogResult= DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void PopulateClientsTable()
        {
            try
            {
                // Initialize the typed DataSet
                var dataSet = new AlexisconstructionDBDataSet();

                // Access the Clients table
                var clientsTable = dataSet.Clients;

                // Add a new row to the Clients table
                var newRow = clientsTable.NewClientsRow();
                newRow.ClientID = 1;               // Set ClientID
                newRow.Name = "John Doe";          // Set Name
                newRow.Contact = "123-456-7890";  // Set Contact
                newRow.Address = "123 Main St";   // Set Address
                clientsTable.AddClientsRow(newRow);

                // Add another row for testing
                var newRow2 = clientsTable.NewClientsRow();
                newRow2.ClientID = 2;
                newRow2.Name = "Jane Smith";
                newRow2.Contact = "987-654-3210";
                newRow2.Address = "456 Oak St";
                clientsTable.AddClientsRow(newRow2);

                // Display the rows in a MessageBox or console
                foreach (var client in clientsTable)
                {
                    MessageBox.Show($"ClientID: {client.ClientID}, Name: {client.Name}, Contact: {client.Contact}, Address: {client.Address}");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnPopulate_Click(object sender, EventArgs e)
        {
            PopulateClientsTable();
        }

    }
}
