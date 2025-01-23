namespace WindowsFormsApp1
{
    partial class BillingPage
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
            System.Windows.Forms.Label bookingid;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.dataGridBilling = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.btnDeleteTool = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.amttb = new System.Windows.Forms.TextBox();
            this.amtpaidtb = new System.Windows.Forms.TextBox();
            this.cbBookingID = new System.Windows.Forms.ComboBox();
            this.ClientNametb = new System.Windows.Forms.TextBox();
            this.Searchbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            bookingid = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBilling)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingid
            // 
            bookingid.AutoSize = true;
            bookingid.Location = new System.Drawing.Point(16, 97);
            bookingid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bookingid.Name = "bookingid";
            bookingid.Size = new System.Drawing.Size(126, 16);
            bookingid.TabIndex = 17;
            bookingid.Text = "Booking Reference:";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(16, 162);
            contactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(83, 16);
            contactLabel.TabIndex = 18;
            contactLabel.Text = "Amount Due:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(16, 198);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(86, 16);
            addressLabel.TabIndex = 19;
            addressLabel.Text = "Amount Paid:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 130);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(80, 16);
            label3.TabIndex = 38;
            label3.Text = "Client Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(891, 63);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 16);
            label4.TabIndex = 40;
            label4.Text = "Search:";
            // 
            // dataGridBilling
            // 
            this.dataGridBilling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBilling.Location = new System.Drawing.Point(589, 92);
            this.dataGridBilling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridBilling.Name = "dataGridBilling";
            this.dataGridBilling.RowHeadersWidth = 51;
            this.dataGridBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBilling.Size = new System.Drawing.Size(641, 477);
            this.dataGridBilling.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(517, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "Billing Page";
            // 
            // Update
            // 
            this.Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Update.Location = new System.Drawing.Point(120, 273);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(115, 30);
            this.Update.TabIndex = 30;
            this.Update.Text = "Update Biling";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // btnDeleteTool
            // 
            this.btnDeleteTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTool.Location = new System.Drawing.Point(473, 273);
            this.btnDeleteTool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteTool.Name = "btnDeleteTool";
            this.btnDeleteTool.Size = new System.Drawing.Size(92, 30);
            this.btnDeleteTool.TabIndex = 29;
            this.btnDeleteTool.Text = "Delete";
            this.btnDeleteTool.UseVisualStyleBackColor = true;
            this.btnDeleteTool.Click += new System.EventHandler(this.btnDeleteTool_Click_1);
            // 
            // btnAddBill
            // 
            this.btnAddBill.Location = new System.Drawing.Point(20, 273);
            this.btnAddBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(92, 30);
            this.btnAddBill.TabIndex = 28;
            this.btnAddBill.Text = "Add Billing";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // amttb
            // 
            this.amttb.Location = new System.Drawing.Point(160, 159);
            this.amttb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amttb.Name = "amttb";
            this.amttb.ReadOnly = true;
            this.amttb.Size = new System.Drawing.Size(404, 22);
            this.amttb.TabIndex = 34;
            // 
            // amtpaidtb
            // 
            this.amtpaidtb.Location = new System.Drawing.Point(160, 194);
            this.amtpaidtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amtpaidtb.Name = "amtpaidtb";
            this.amtpaidtb.Size = new System.Drawing.Size(404, 22);
            this.amtpaidtb.TabIndex = 35;
            // 
            // cbBookingID
            // 
            this.cbBookingID.FormattingEnabled = true;
            this.cbBookingID.Location = new System.Drawing.Point(160, 94);
            this.cbBookingID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBookingID.Name = "cbBookingID";
            this.cbBookingID.Size = new System.Drawing.Size(404, 24);
            this.cbBookingID.TabIndex = 36;
            // 
            // ClientNametb
            // 
            this.ClientNametb.Location = new System.Drawing.Point(160, 127);
            this.ClientNametb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientNametb.Name = "ClientNametb";
            this.ClientNametb.ReadOnly = true;
            this.ClientNametb.Size = new System.Drawing.Size(404, 22);
            this.ClientNametb.TabIndex = 37;
            // 
            // Searchbox
            // 
            this.Searchbox.Location = new System.Drawing.Point(957, 59);
            this.Searchbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(272, 22);
            this.Searchbox.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 595);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 100);
            this.panel1.TabIndex = 41;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(573, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Alexis Construction Services";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BillingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1268, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(label4);
            this.Controls.Add(this.Searchbox);
            this.Controls.Add(label3);
            this.Controls.Add(this.ClientNametb);
            this.Controls.Add(this.cbBookingID);
            this.Controls.Add(this.amtpaidtb);
            this.Controls.Add(this.amttb);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.btnDeleteTool);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(bookingid);
            this.Controls.Add(contactLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.dataGridBilling);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BillingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillingPage";
            this.Load += new System.EventHandler(this.BillingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBilling)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBilling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button btnDeleteTool;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.TextBox amttb;
        private System.Windows.Forms.TextBox amtpaidtb;
        private System.Windows.Forms.ComboBox cbBookingID;
        private System.Windows.Forms.TextBox ClientNametb;
        private System.Windows.Forms.TextBox Searchbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}