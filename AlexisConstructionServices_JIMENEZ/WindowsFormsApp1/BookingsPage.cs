using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1
{
    public partial class BookingsPage : Form
    {
        private readonly BookingsRepository _repository;

        public BookingsPage()
        {
            InitializeComponent();
            _repository = new BookingsRepository();
            LoadBookings();
        }

        private void LoadBookings()
        {
            try
            {
                var bookings = _repository.GetBookings();

                var dataTable = CreateBookingsDataTable();
                foreach (var booking in bookings)
                {
                    var row = dataTable.NewRow();
                    row["BookingID"] = booking.BookingID;
                    row["ClientName"] = booking.ClientName;
                    row["BookingDate"] = booking.BookingDate;
                    row["TotalAmount"] = booking.TotalAmount;
                    dataTable.Rows.Add(row);
                }

                BookingsTable.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error loading bookings", ex);
            }
        }

        private static DataTable CreateBookingsDataTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("BookingID", typeof(int));
            dataTable.Columns.Add("ClientName", typeof(string));
            dataTable.Columns.Add("BookingDate", typeof(DateTime));
            dataTable.Columns.Add("TotalAmount", typeof(decimal));
            return dataTable;
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            if (IsInputValid(out string validationError))
            {
                try
                {
                    var booking = new Booking
                    {
                        ClientID = int.Parse(ClientTb.Text),
                        BookingDate = datetimepickertb.Value,
                        TotalAmount = decimal.Parse(totalamounttb.Text)
                    };

                    _repository.CreateBooking(booking);
                    MessageBox.Show("Booking added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadBookings();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input format. Please check your entries.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    ShowErrorMessage("Error adding booking", ex);
                }
            }
            else
            {
                MessageBox.Show(validationError, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsInputValid(out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(ClientTb.Text))
            {
                errorMessage = "Client ID is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(totalamounttb.Text))
            {
                errorMessage = "Total Amount is required.";
                return false;
            }

            if (!int.TryParse(ClientTb.Text, out _))
            {
                errorMessage = "Client ID must be a valid number.";
                return false;
            }

            if (!decimal.TryParse(totalamounttb.Text, out _))
            {
                errorMessage = "Total Amount must be a valid decimal number.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        private void ShowErrorMessage(string title, Exception ex)
        {
            MessageBox.Show($"{title}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BookingsPage_Load(object sender, EventArgs e)
        {
            // Uncomment and configure as needed
            // this.bookingsTableAdapter.Fill(this.alexisconstructionDBDataSet.Bookings);
        }

        private void bookingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                bookingsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(alexisconstructionDBDataSet);
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error saving changes", ex);
            }
        }
    }
}
