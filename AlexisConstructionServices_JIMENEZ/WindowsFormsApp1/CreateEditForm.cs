using System;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1
{
    public partial class CreateEditForm : Form
    {
        private int _clientId;

        public CreateEditForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        public void EditClient(Client client)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));

            Text = "Edit Client";
            lbTitle.Text = "Edit Client";

            lbclient.Text = client.ClientID.ToString();
            Nametb.Text = client.Name;
            Addresstb.Text = client.Address;
            Contacttb.Text = client.Contact;

            _clientId = client.ClientID;
        }

        private void CreateEditForm_Load(object sender, EventArgs e)
        {
            // Uncomment if data loading is required
            // this.clientsTableAdapter.Fill(this.alexisconstructionDBDataSet.Clients);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string validationMessage))
            {
                MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var client = new Client
            {
                ClientID = _clientId,
                Name = Nametb.Text,
                Contact = Contacttb.Text,
                Address = Addresstb.Text
            };

            var repo = new ClientRepository();

            try
            {
                if (client.ClientID == 0)
                {
                    repo.CreateClient(client);
                }
                else
                {
                    repo.UpdateClient(client);
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool ValidateInputs(out string validationMessage)
        {
            if (string.IsNullOrWhiteSpace(Nametb.Text))
            {
                validationMessage = "Name field cannot be empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Contacttb.Text))
            {
                validationMessage = "Contact field cannot be empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Addresstb.Text))
            {
                validationMessage = "Address field cannot be empty.";
                return false;
            }

            validationMessage = string.Empty;
            return true;
        }
    }
}
