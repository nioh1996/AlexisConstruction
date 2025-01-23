namespace WindowsFormsApp1
{
    partial class BookingsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label clientIDLabel;
            System.Windows.Forms.Label bookingDateLabel;
            System.Windows.Forms.Label totalAmountLabel;
            System.Windows.Forms.Label Search;
            this.BookingsTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.datetimepickertb = new System.Windows.Forms.DateTimePicker();
            this.totalamounttb = new System.Windows.Forms.TextBox();
            this.clientcmb = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.alexisconstructionDBDataSet = new WindowsFormsApp1.AlexisconstructionDBDataSet();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingsTableAdapter = new WindowsFormsApp1.AlexisconstructionDBDataSetTableAdapters.BookingsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.AlexisconstructionDBDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            clientIDLabel = new System.Windows.Forms.Label();
            bookingDateLabel = new System.Windows.Forms.Label();
            totalAmountLabel = new System.Windows.Forms.Label();
            Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookingsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexisconstructionDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(16, 101);
            clientIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(83, 16);
            clientIDLabel.TabIndex = 5;
            clientIDLabel.Text = "Client Name:";
            // 
            // bookingDateLabel
            // 
            bookingDateLabel.AutoSize = true;
            bookingDateLabel.Location = new System.Drawing.Point(16, 134);
            bookingDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bookingDateLabel.Name = "bookingDateLabel";
            bookingDateLabel.Size = new System.Drawing.Size(92, 16);
            bookingDateLabel.TabIndex = 7;
            bookingDateLabel.Text = "Booking Date:";
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Location = new System.Drawing.Point(16, 165);
            totalAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new System.Drawing.Size(89, 16);
            totalAmountLabel.TabIndex = 9;
            totalAmountLabel.Text = "Total Amount:";
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Location = new System.Drawing.Point(885, 62);
            Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Search.Name = "Search";
            Search.Size = new System.Drawing.Size(53, 16);
            Search.TabIndex = 20;
            Search.Text = "Search:";
            // 
            // BookingsTable
            // 
            this.BookingsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookingsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookingsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingsTable.Location = new System.Drawing.Point(485, 90);
            this.BookingsTable.Margin = new System.Windows.Forms.Padding(4);
            this.BookingsTable.MultiSelect = false;
            this.BookingsTable.Name = "BookingsTable";
            this.BookingsTable.ReadOnly = true;
            this.BookingsTable.RowHeadersWidth = 51;
            this.BookingsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookingsTable.Size = new System.Drawing.Size(1284, 346);
            this.BookingsTable.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "List of Bookings";
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditBooking.Location = new System.Drawing.Point(143, 226);
            this.btnEditBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(128, 28);
            this.btnEditBooking.TabIndex = 15;
            this.btnEditBooking.Text = "Booking Details";
            this.btnEditBooking.UseVisualStyleBackColor = true;
            this.btnEditBooking.Click += new System.EventHandler(this.btnEditBooking_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBooking.Location = new System.Drawing.Point(279, 226);
            this.btnDeleteBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(95, 28);
            this.btnDeleteBooking.TabIndex = 14;
            this.btnDeleteBooking.Text = "Delete";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(20, 226);
            this.btnAddBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(115, 28);
            this.btnAddBooking.TabIndex = 13;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // datetimepickertb
            // 
            this.datetimepickertb.Location = new System.Drawing.Point(136, 133);
            this.datetimepickertb.Margin = new System.Windows.Forms.Padding(4);
            this.datetimepickertb.Name = "datetimepickertb";
            this.datetimepickertb.Size = new System.Drawing.Size(328, 22);
            this.datetimepickertb.TabIndex = 16;
            // 
            // totalamounttb
            // 
            this.totalamounttb.Location = new System.Drawing.Point(136, 165);
            this.totalamounttb.Margin = new System.Windows.Forms.Padding(4);
            this.totalamounttb.Name = "totalamounttb";
            this.totalamounttb.ReadOnly = true;
            this.totalamounttb.Size = new System.Drawing.Size(328, 22);
            this.totalamounttb.TabIndex = 12;
            // 
            // clientcmb
            // 
            this.clientcmb.FormattingEnabled = true;
            this.clientcmb.Location = new System.Drawing.Point(136, 97);
            this.clientcmb.Margin = new System.Windows.Forms.Padding(4);
            this.clientcmb.Name = "clientcmb";
            this.clientcmb.Size = new System.Drawing.Size(328, 24);
            this.clientcmb.TabIndex = 18;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(960, 58);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 22);
            this.txtSearch.TabIndex = 19;
            // 
            // alexisconstructionDBDataSet
            // 
            this.alexisconstructionDBDataSet.DataSetName = "AlexisconstructionDBDataSet";
            this.alexisconstructionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.alexisconstructionDBDataSet;
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingsTableAdapter = this.bookingsTableAdapter;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.AlexisconstructionDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 608);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1782, 92);
            this.panel1.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1047, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Alexis Construction Services";
            // 
            // BookingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1785, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(Search);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.clientcmb);
            this.Controls.Add(this.datetimepickertb);
            this.Controls.Add(this.btnEditBooking);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.totalamounttb);
            this.Controls.Add(clientIDLabel);
            this.Controls.Add(bookingDateLabel);
            this.Controls.Add(totalAmountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookingsTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookingsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingsPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookingsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookingsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexisconstructionDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BookingsTable;
        private System.Windows.Forms.Label label2;
        private AlexisconstructionDBDataSet alexisconstructionDBDataSet;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private AlexisconstructionDBDataSetTableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private AlexisconstructionDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnEditBooking;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.DateTimePicker datetimepickertb;
        private System.Windows.Forms.TextBox totalamounttb;
        private System.Windows.Forms.ComboBox clientcmb;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}