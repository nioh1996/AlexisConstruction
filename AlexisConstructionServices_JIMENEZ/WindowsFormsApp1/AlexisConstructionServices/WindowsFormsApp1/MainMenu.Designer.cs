namespace WindowsFormsApp1
{
    partial class MainMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ClientPage = new System.Windows.Forms.Button();
            this.Bookings = new System.Windows.Forms.Button();
            this.Billings = new System.Windows.Forms.Button();
            this.Inventory = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Services = new System.Windows.Forms.Button();
            this.MainmenuDGT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.alexisconstructionDBDataSet = new WindowsFormsApp1.AlexisconstructionDBDataSet();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingsTableAdapter = new WindowsFormsApp1.AlexisconstructionDBDataSetTableAdapters.BookingsTableAdapter();
            this.Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainmenuDGT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexisconstructionDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientPage
            // 
            this.ClientPage.BackColor = System.Drawing.Color.White;
            this.ClientPage.Location = new System.Drawing.Point(13, 111);
            this.ClientPage.Margin = new System.Windows.Forms.Padding(4);
            this.ClientPage.Name = "ClientPage";
            this.ClientPage.Size = new System.Drawing.Size(143, 25);
            this.ClientPage.TabIndex = 0;
            this.ClientPage.Text = "Add Client";
            this.ClientPage.UseVisualStyleBackColor = false;
            this.ClientPage.Click += new System.EventHandler(this.ClientPage_Click);
            // 
            // Bookings
            // 
            this.Bookings.BackColor = System.Drawing.Color.White;
            this.Bookings.Location = new System.Drawing.Point(315, 111);
            this.Bookings.Margin = new System.Windows.Forms.Padding(4);
            this.Bookings.Name = "Bookings";
            this.Bookings.Size = new System.Drawing.Size(143, 30);
            this.Bookings.TabIndex = 1;
            this.Bookings.Text = "Bookings";
            this.Bookings.UseVisualStyleBackColor = false;
            this.Bookings.Click += new System.EventHandler(this.Bookings_Click);
            // 
            // Billings
            // 
            this.Billings.BackColor = System.Drawing.Color.White;
            this.Billings.Location = new System.Drawing.Point(466, 114);
            this.Billings.Margin = new System.Windows.Forms.Padding(4);
            this.Billings.Name = "Billings";
            this.Billings.Size = new System.Drawing.Size(143, 27);
            this.Billings.TabIndex = 2;
            this.Billings.Text = "Billings";
            this.Billings.UseVisualStyleBackColor = false;
            this.Billings.Click += new System.EventHandler(this.Billings_Click);
            // 
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.Color.White;
            this.Inventory.Location = new System.Drawing.Point(13, 161);
            this.Inventory.Margin = new System.Windows.Forms.Padding(4);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(143, 27);
            this.Inventory.TabIndex = 3;
            this.Inventory.Text = "Inventory";
            this.Inventory.UseVisualStyleBackColor = false;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Services
            // 
            this.Services.BackColor = System.Drawing.Color.White;
            this.Services.Location = new System.Drawing.Point(164, 110);
            this.Services.Margin = new System.Windows.Forms.Padding(4);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(143, 26);
            this.Services.TabIndex = 6;
            this.Services.Text = "Services";
            this.Services.UseVisualStyleBackColor = false;
            this.Services.Click += new System.EventHandler(this.Services_Click);
            // 
            // MainmenuDGT
            // 
            this.MainmenuDGT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainmenuDGT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainmenuDGT.DefaultCellStyle = dataGridViewCellStyle3;
            this.MainmenuDGT.Location = new System.Drawing.Point(628, 138);
            this.MainmenuDGT.Margin = new System.Windows.Forms.Padding(4);
            this.MainmenuDGT.Name = "MainmenuDGT";
            this.MainmenuDGT.ReadOnly = true;
            this.MainmenuDGT.RowHeadersWidth = 51;
            this.MainmenuDGT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MainmenuDGT.Size = new System.Drawing.Size(843, 164);
            this.MainmenuDGT.TabIndex = 7;
            this.MainmenuDGT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainmenuDGT_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(829, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Alexis ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.White;
            this.Refresh.Location = new System.Drawing.Point(426, 360);
            this.Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(143, 27);
            this.Refresh.TabIndex = 9;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 52);
            this.label2.TabIndex = 10;
            this.label2.Text = "Construction Services";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(1, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1772, 100);
            this.panel1.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(854, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Alexis Construction Services";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1498, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainmenuDGT);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.Billings);
            this.Controls.Add(this.Bookings);
            this.Controls.Add(this.ClientPage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainmenuDGT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexisconstructionDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClientPage;
        private System.Windows.Forms.Button Bookings;
        private System.Windows.Forms.Button Billings;
        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Services;
        private System.Windows.Forms.DataGridView MainmenuDGT;
        private System.Windows.Forms.Label label1;
        private AlexisconstructionDBDataSet alexisconstructionDBDataSet;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private AlexisconstructionDBDataSetTableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}