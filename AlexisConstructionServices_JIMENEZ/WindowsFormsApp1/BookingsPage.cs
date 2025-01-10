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

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("BookingID", typeof(int));
                dataTable.Columns.Add("ClientName", typeof(string));
                dataTable.Columns.Add("BookingDate", typeof(DateTime));
                dataTable.Columns.Add("TotalAmount", typeof(decimal));

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
                MessageBox.Show($"Error loading bookings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ClientTb.Text) || string.IsNullOrWhiteSpace(totalamounttb.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Booking booking = new Booking
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
                MessageBox.Show($"Error adding booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookingsPage_Load(object sender, EventArgs e)
        {
            // This line is commented but could be re-enabled if needed to load data.
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
                MessageBox.Show($"Error saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
