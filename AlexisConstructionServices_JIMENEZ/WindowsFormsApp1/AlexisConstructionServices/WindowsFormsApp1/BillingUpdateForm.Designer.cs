namespace WindowsFormsApp1
{
    partial class BillingUpdateForm
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
            System.Windows.Forms.Label BillingLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label AmountPaid;
            System.Windows.Forms.Label AmountDue;
            System.Windows.Forms.Label paymentstat;
            this.Amtdue = new System.Windows.Forms.TextBox();
            this.Amtpaid = new System.Windows.Forms.TextBox();
            this.Nametb = new System.Windows.Forms.TextBox();
            this.lbbillingreference = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pmtlbl = new System.Windows.Forms.Label();
            BillingLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            AmountPaid = new System.Windows.Forms.Label();
            AmountDue = new System.Windows.Forms.Label();
            paymentstat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BillingLabel
            // 
            BillingLabel.AutoSize = true;
            BillingLabel.Location = new System.Drawing.Point(32, 63);
            BillingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            BillingLabel.Name = "BillingLabel";
            BillingLabel.Size = new System.Drawing.Size(112, 16);
            BillingLabel.TabIndex = 16;
            BillingLabel.Text = "Billing Reference:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(32, 95);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 16);
            nameLabel.TabIndex = 17;
            nameLabel.Text = "Name:";
            // 
            // AmountPaid
            // 
            AmountPaid.AutoSize = true;
            AmountPaid.Location = new System.Drawing.Point(32, 220);
            AmountPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AmountPaid.Name = "AmountPaid";
            AmountPaid.Size = new System.Drawing.Size(86, 16);
            AmountPaid.TabIndex = 18;
            AmountPaid.Text = "Amount Paid:";
            // 
            // AmountDue
            // 
            AmountDue.AutoSize = true;
            AmountDue.Location = new System.Drawing.Point(32, 133);
            AmountDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AmountDue.Name = "AmountDue";
            AmountDue.Size = new System.Drawing.Size(83, 16);
            AmountDue.TabIndex = 19;
            AmountDue.Text = "Amount Due:";
            // 
            // paymentstat
            // 
            paymentstat.AutoSize = true;
            paymentstat.Location = new System.Drawing.Point(32, 169);
            paymentstat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            paymentstat.Name = "paymentstat";
            paymentstat.Size = new System.Drawing.Size(100, 16);
            paymentstat.TabIndex = 30;
            paymentstat.Text = "Payment Status";
            // 
            // Amtdue
            // 
            this.Amtdue.Location = new System.Drawing.Point(164, 129);
            this.Amtdue.Margin = new System.Windows.Forms.Padding(4);
            this.Amtdue.Name = "Amtdue";
            this.Amtdue.ReadOnly = true;
            this.Amtdue.Size = new System.Drawing.Size(297, 22);
            this.Amtdue.TabIndex = 23;
            // 
            // Amtpaid
            // 
            this.Amtpaid.Location = new System.Drawing.Point(165, 217);
            this.Amtpaid.Margin = new System.Windows.Forms.Padding(4);
            this.Amtpaid.Name = "Amtpaid";
            this.Amtpaid.Size = new System.Drawing.Size(297, 22);
            this.Amtpaid.TabIndex = 22;
            // 
            // Nametb
            // 
            this.Nametb.Location = new System.Drawing.Point(164, 95);
            this.Nametb.Margin = new System.Windows.Forms.Padding(4);
            this.Nametb.Name = "Nametb";
            this.Nametb.ReadOnly = true;
            this.Nametb.Size = new System.Drawing.Size(297, 22);
            this.Nametb.TabIndex = 21;
            // 
            // lbbillingreference
            // 
            this.lbbillingreference.AutoSize = true;
            this.lbbillingreference.Location = new System.Drawing.Point(160, 63);
            this.lbbillingreference.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbillingreference.Name = "lbbillingreference";
            this.lbbillingreference.Size = new System.Drawing.Size(0, 16);
            this.lbbillingreference.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 31);
            this.label2.TabIndex = 27;
            this.label2.Text = "Update Billing";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(349, 266);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 28);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(164, 266);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 28);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pmtlbl
            // 
            this.pmtlbl.AutoSize = true;
            this.pmtlbl.Location = new System.Drawing.Point(160, 169);
            this.pmtlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pmtlbl.Name = "pmtlbl";
            this.pmtlbl.Size = new System.Drawing.Size(0, 16);
            this.pmtlbl.TabIndex = 31;
            // 
            // BillingUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(485, 309);
            this.Controls.Add(this.pmtlbl);
            this.Controls.Add(paymentstat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Amtdue);
            this.Controls.Add(this.Amtpaid);
            this.Controls.Add(this.Nametb);
            this.Controls.Add(this.lbbillingreference);
            this.Controls.Add(BillingLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(AmountPaid);
            this.Controls.Add(AmountDue);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BillingUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillingUpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Amtdue;
        private System.Windows.Forms.TextBox Amtpaid;
        private System.Windows.Forms.TextBox Nametb;
        private System.Windows.Forms.Label lbbillingreference;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label pmtlbl;
    }
}