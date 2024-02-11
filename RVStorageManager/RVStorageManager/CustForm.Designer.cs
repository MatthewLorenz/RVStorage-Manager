namespace RVStorageManager
{
    partial class CustForm
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
            custGrid = new DataGridView();
            txtCustID = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            labName = new Label();
            labCustID = new Label();
            labEmail = new Label();
            labPhone = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            addDescription = new Label();
            removeDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)custGrid).BeginInit();
            SuspendLayout();
            // 
            // custGrid
            // 
            custGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            custGrid.Location = new Point(12, 12);
            custGrid.Name = "custGrid";
            custGrid.Size = new Size(776, 315);
            custGrid.TabIndex = 0;
            // 
            // txtCustID
            // 
            txtCustID.BackColor = SystemColors.InactiveCaption;
            txtCustID.BorderStyle = BorderStyle.FixedSingle;
            txtCustID.Location = new Point(45, 364);
            txtCustID.Name = "txtCustID";
            txtCustID.Size = new Size(74, 23);
            txtCustID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.InactiveCaption;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(125, 364);
            txtName.Name = "txtName";
            txtName.Size = new Size(142, 23);
            txtName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.InactiveCaption;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(273, 364);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(142, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.InactiveCaption;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(421, 364);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(142, 23);
            txtPhone.TabIndex = 4;
            // 
            // labName
            // 
            labName.AutoSize = true;
            labName.Location = new Point(160, 346);
            labName.Name = "labName";
            labName.Size = new Size(61, 15);
            labName.TabIndex = 5;
            labName.Text = "Full Name";
            // 
            // labCustID
            // 
            labCustID.AutoSize = true;
            labCustID.Location = new Point(46, 346);
            labCustID.Name = "labCustID";
            labCustID.Size = new Size(73, 15);
            labCustID.TabIndex = 6;
            labCustID.Text = "Customer ID";
            // 
            // labEmail
            // 
            labEmail.AutoSize = true;
            labEmail.Location = new Point(321, 346);
            labEmail.Name = "labEmail";
            labEmail.Size = new Size(36, 15);
            labEmail.TabIndex = 7;
            labEmail.Text = "Email";
            // 
            // labPhone
            // 
            labPhone.AutoSize = true;
            labPhone.Location = new Point(470, 346);
            labPhone.Name = "labPhone";
            labPhone.Size = new Size(41, 15);
            labPhone.TabIndex = 8;
            labPhone.Text = "Phone";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(621, 364);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(71, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.RosyBrown;
            btnRemove.Location = new Point(698, 364);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(71, 23);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // addDescription
            // 
            addDescription.AutoSize = true;
            addDescription.Location = new Point(12, 400);
            addDescription.Name = "addDescription";
            addDescription.Size = new Size(546, 15);
            addDescription.TabIndex = 11;
            addDescription.Text = "To ADD customers enter information in all fields: Customer ID, Full Name, Email, Phone, and click ADD";
            // 
            // removeDescription
            // 
            removeDescription.AutoSize = true;
            removeDescription.Location = new Point(12, 426);
            removeDescription.Name = "removeDescription";
            removeDescription.Size = new Size(324, 15);
            removeDescription.TabIndex = 12;
            removeDescription.Text = "To REMOVE customers enter Customer ID and click REMOVE";
            // 
            // CustForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(removeDescription);
            Controls.Add(addDescription);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(labPhone);
            Controls.Add(labEmail);
            Controls.Add(labCustID);
            Controls.Add(labName);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtCustID);
            Controls.Add(custGrid);
            Name = "CustForm";
            Text = "Customer Form";
            ((System.ComponentModel.ISupportInitialize)custGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView custGrid;
        private TextBox txtCustID;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label labName;
        private Label labCustID;
        private Label labEmail;
        private Label labPhone;
        private Button btnAdd;
        private Button btnRemove;
        private Label addDescription;
        private Label removeDescription;
    }
}