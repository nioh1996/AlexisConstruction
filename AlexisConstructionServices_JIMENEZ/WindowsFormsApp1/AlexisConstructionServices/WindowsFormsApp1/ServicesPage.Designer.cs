﻿namespace WindowsFormsApp1
{
    partial class ServicesPage
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
            System.Windows.Forms.Label serviceNameLabel;
            System.Windows.Forms.Label hourlyRateLabel;
            this.ServicesTable = new System.Windows.Forms.DataGridView();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alexisconstructionDBDataSet = new WindowsFormsApp1.AlexisconstructionDBDataSet();
            this.HourlyRatetb = new System.Windows.Forms.TextBox();
            this.Servicetb = new System.Windows.Forms.TextBox();
            this.servicesTableAdapter = new WindowsFormsApp1.AlexisconstructionDBDataSetTableAdapters.ServicesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.AlexisconstructionDBDataSetTableAdapters.TableAdapterManager();
            serviceNameLabel = new System.Windows.Forms.Label();
            hourlyRateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexisconstructionDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceNameLabel
            // 
            serviceNameLabel.AutoSize = true;
            serviceNameLabel.Location = new System.Drawing.Point(16, 113);
            serviceNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            serviceNameLabel.Name = "serviceNameLabel";
            serviceNameLabel.Size = new System.Drawing.Size(96, 16);
            serviceNameLabel.TabIndex = 10;
            serviceNameLabel.Text = "Service Name:";
            // 
            // hourlyRateLabel
            // 
            hourlyRateLabel.AutoSize = true;
            hourlyRateLabel.Location = new System.Drawing.Point(16, 145);
            hourlyRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hourlyRateLabel.Name = "hourlyRateLabel";
            hourlyRateLabel.Size = new System.Drawing.Size(81, 16);
            hourlyRateLabel.TabIndex = 12;
            hourlyRateLabel.Text = "Hourly Rate:";
            // 
            // ServicesTable
            // 
            this.ServicesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServicesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicesTable.Location = new System.Drawing.Point(385, 113);
            this.ServicesTable.Margin = new System.Windows.Forms.Padding(4);
            this.ServicesTable.Name = "ServicesTable";
            this.ServicesTable.ReadOnly = true;
            this.ServicesTable.RowHeadersWidth = 51;
            this.ServicesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServicesTable.Size = new System.Drawing.Size(619, 305);
            this.ServicesTable.TabIndex = 0;
            // 
            // btnEditClient
            // 
            this.btnEditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditClient.Location = new System.Drawing.Point(127, 187);
            this.btnEditClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(112, 28);
            this.btnEditClient.TabIndex = 7;
            this.btnEditClient.Text = "Edit Services";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteClient.Location = new System.Drawing.Point(283, 187);
            this.btnDeleteClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(95, 28);
            this.btnDeleteClient.TabIndex = 6;
            this.btnDeleteClient.Text = "Delete";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(7, 187);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(112, 28);
            this.btnAddService.TabIndex = 5;
            this.btnAddService.Text = "Add Services";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "List of Services";
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.alexisconstructionDBDataSet;
            // 
            // alexisconstructionDBDataSet
            // 
            this.alexisconstructionDBDataSet.DataSetName = "AlexisconstructionDBDataSet";
            this.alexisconstructionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HourlyRatetb
            // 
            this.HourlyRatetb.Location = new System.Drawing.Point(140, 145);
            this.HourlyRatetb.Margin = new System.Windows.Forms.Padding(4);
            this.HourlyRatetb.Name = "HourlyRatetb";
            this.HourlyRatetb.Size = new System.Drawing.Size(233, 22);
            this.HourlyRatetb.TabIndex = 18;
            // 
            // Servicetb
            // 
            this.Servicetb.Location = new System.Drawing.Point(140, 113);
            this.Servicetb.Margin = new System.Windows.Forms.Padding(4);
            this.Servicetb.Name = "Servicetb";
            this.Servicetb.Size = new System.Drawing.Size(233, 22);
            this.Servicetb.TabIndex = 17;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = this.servicesTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.AlexisconstructionDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ServicesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1020, 434);
            this.Controls.Add(this.HourlyRatetb);
            this.Controls.Add(this.Servicetb);
            this.Controls.Add(serviceNameLabel);
            this.Controls.Add(hourlyRateLabel);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServicesTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServicesPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services";
            this.Load += new System.EventHandler(this.ServicesPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServicesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexisconstructionDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ServicesTable;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Label label2;
        private AlexisconstructionDBDataSet alexisconstructionDBDataSet;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private AlexisconstructionDBDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private AlexisconstructionDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox HourlyRatetb;
        private System.Windows.Forms.TextBox Servicetb;
    }
}