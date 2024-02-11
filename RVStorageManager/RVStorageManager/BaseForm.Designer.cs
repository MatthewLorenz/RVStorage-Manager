namespace RVStorageManager
{
    partial class BaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLot = new Button();
            btnCustomers = new Button();
            btnRV = new Button();
            custDescription = new Label();
            rvDescription = new Label();
            lotDescription = new Label();
            btnExport = new Button();
            labExport = new Label();
            SuspendLayout();
            // 
            // btnLot
            // 
            btnLot.BackColor = SystemColors.ActiveCaption;
            btnLot.Font = new Font("Segoe UI", 18F);
            btnLot.Location = new Point(374, 21);
            btnLot.Name = "btnLot";
            btnLot.Size = new Size(164, 47);
            btnLot.TabIndex = 0;
            btnLot.Text = "Lot";
            btnLot.UseVisualStyleBackColor = false;
            btnLot.Click += btnLot_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = SystemColors.ActiveCaption;
            btnCustomers.Font = new Font("Segoe UI", 18F);
            btnCustomers.Location = new Point(12, 21);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(164, 47);
            btnCustomers.TabIndex = 1;
            btnCustomers.Text = "CUSTOMERS";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnRV
            // 
            btnRV.BackColor = SystemColors.ActiveCaption;
            btnRV.Font = new Font("Segoe UI", 18F);
            btnRV.Location = new Point(192, 21);
            btnRV.Name = "btnRV";
            btnRV.Size = new Size(164, 47);
            btnRV.TabIndex = 2;
            btnRV.Text = "RV";
            btnRV.UseVisualStyleBackColor = false;
            btnRV.Click += btnRV_Click;
            // 
            // custDescription
            // 
            custDescription.Location = new Point(12, 74);
            custDescription.Name = "custDescription";
            custDescription.Size = new Size(164, 54);
            custDescription.TabIndex = 6;
            custDescription.Text = "Add/Remove Customers, Manage Customer Information";
            custDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // rvDescription
            // 
            rvDescription.Location = new Point(192, 74);
            rvDescription.Name = "rvDescription";
            rvDescription.Size = new Size(164, 54);
            rvDescription.TabIndex = 7;
            rvDescription.Text = "Add/Remove RVs, Assign them to Customers";
            rvDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // lotDescription
            // 
            lotDescription.Location = new Point(374, 74);
            lotDescription.Name = "lotDescription";
            lotDescription.Size = new Size(164, 54);
            lotDescription.TabIndex = 8;
            lotDescription.Text = "Assign RVs to Lots, Check Availability";
            lotDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnExport
            // 
            btnExport.BackColor = SystemColors.ActiveCaption;
            btnExport.Font = new Font("Segoe UI", 18F);
            btnExport.Location = new Point(560, 21);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(164, 47);
            btnExport.TabIndex = 9;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // labExport
            // 
            labExport.Location = new Point(560, 74);
            labExport.Name = "labExport";
            labExport.Size = new Size(164, 54);
            labExport.TabIndex = 10;
            labExport.Text = "Export Database to Excel File";
            labExport.TextAlign = ContentAlignment.TopCenter;
            // 
            // BaseForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 159);
            Controls.Add(labExport);
            Controls.Add(btnExport);
            Controls.Add(lotDescription);
            Controls.Add(rvDescription);
            Controls.Add(custDescription);
            Controls.Add(btnRV);
            Controls.Add(btnCustomers);
            Controls.Add(btnLot);
            Name = "BaseForm";
            Text = "RV Storage Management";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLot;
        private Button btnCustomers;
        private Button btnRV;
        private Label custDescription;
        private Label rvDescription;
        private Label lotDescription;
        private Button btnExport;
        private Label labExport;
    }
}
