namespace RVStorageManager
{
    partial class RVForm
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
            RVGrid = new DataGridView();
            txtRVID = new TextBox();
            txtCustID = new TextBox();
            txtMake = new TextBox();
            txtModel = new TextBox();
            txtPlate = new TextBox();
            btnRemove = new Button();
            btnAdd = new Button();
            labRVID = new Label();
            labCustID = new Label();
            labMake = new Label();
            labModel = new Label();
            labPlate = new Label();
            labRVADD = new Label();
            labRVREMOVE = new Label();
            ((System.ComponentModel.ISupportInitialize)RVGrid).BeginInit();
            SuspendLayout();
            // 
            // RVGrid
            // 
            RVGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RVGrid.Location = new Point(12, 12);
            RVGrid.Name = "RVGrid";
            RVGrid.Size = new Size(776, 315);
            RVGrid.TabIndex = 1;
            // 
            // txtRVID
            // 
            txtRVID.BackColor = SystemColors.InactiveCaption;
            txtRVID.BorderStyle = BorderStyle.FixedSingle;
            txtRVID.Location = new Point(12, 365);
            txtRVID.Name = "txtRVID";
            txtRVID.Size = new Size(71, 23);
            txtRVID.TabIndex = 2;
            // 
            // txtCustID
            // 
            txtCustID.BackColor = SystemColors.InactiveCaption;
            txtCustID.BorderStyle = BorderStyle.FixedSingle;
            txtCustID.Location = new Point(89, 365);
            txtCustID.Name = "txtCustID";
            txtCustID.Size = new Size(71, 23);
            txtCustID.TabIndex = 3;
            // 
            // txtMake
            // 
            txtMake.BackColor = SystemColors.InactiveCaption;
            txtMake.BorderStyle = BorderStyle.FixedSingle;
            txtMake.Location = new Point(166, 365);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(142, 23);
            txtMake.TabIndex = 4;
            // 
            // txtModel
            // 
            txtModel.BackColor = SystemColors.InactiveCaption;
            txtModel.BorderStyle = BorderStyle.FixedSingle;
            txtModel.Location = new Point(314, 365);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(142, 23);
            txtModel.TabIndex = 5;
            // 
            // txtPlate
            // 
            txtPlate.BackColor = SystemColors.InactiveCaption;
            txtPlate.BorderStyle = BorderStyle.FixedSingle;
            txtPlate.Location = new Point(462, 365);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(142, 23);
            txtPlate.TabIndex = 6;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.RosyBrown;
            btnRemove.Location = new Point(701, 365);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(71, 23);
            btnRemove.TabIndex = 12;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(624, 365);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(71, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // labRVID
            // 
            labRVID.AutoSize = true;
            labRVID.Location = new Point(26, 347);
            labRVID.Name = "labRVID";
            labRVID.Size = new Size(35, 15);
            labRVID.TabIndex = 13;
            labRVID.Text = "RV ID";
            // 
            // labCustID
            // 
            labCustID.AutoSize = true;
            labCustID.Location = new Point(89, 347);
            labCustID.Name = "labCustID";
            labCustID.Size = new Size(73, 15);
            labCustID.TabIndex = 14;
            labCustID.Text = "Customer ID";
            // 
            // labMake
            // 
            labMake.AutoSize = true;
            labMake.Location = new Point(214, 347);
            labMake.Name = "labMake";
            labMake.Size = new Size(36, 15);
            labMake.TabIndex = 15;
            labMake.Text = "Make";
            // 
            // labModel
            // 
            labModel.AutoSize = true;
            labModel.Location = new Point(369, 347);
            labModel.Name = "labModel";
            labModel.Size = new Size(41, 15);
            labModel.TabIndex = 16;
            labModel.Text = "Model";
            // 
            // labPlate
            // 
            labPlate.AutoSize = true;
            labPlate.Location = new Point(515, 347);
            labPlate.Name = "labPlate";
            labPlate.Size = new Size(33, 15);
            labPlate.TabIndex = 17;
            labPlate.Text = "Plate";
            // 
            // labRVADD
            // 
            labRVADD.AutoSize = true;
            labRVADD.Location = new Point(13, 405);
            labRVADD.Name = "labRVADD";
            labRVADD.Size = new Size(519, 15);
            labRVADD.TabIndex = 18;
            labRVADD.Text = "To ADD RVs enter information in all fields: RV ID, Customer ID, Make, Model, Plate, and click ADD ";
            // 
            // labRVREMOVE
            // 
            labRVREMOVE.AutoSize = true;
            labRVREMOVE.Location = new Point(12, 426);
            labRVREMOVE.Name = "labRVREMOVE";
            labRVREMOVE.Size = new Size(250, 15);
            labRVREMOVE.TabIndex = 19;
            labRVREMOVE.Text = "To REMOVE RVs enter RV ID and click REMOVE";
            // 
            // RVForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labRVREMOVE);
            Controls.Add(labRVADD);
            Controls.Add(labPlate);
            Controls.Add(labModel);
            Controls.Add(labMake);
            Controls.Add(labCustID);
            Controls.Add(labRVID);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtPlate);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Controls.Add(txtCustID);
            Controls.Add(txtRVID);
            Controls.Add(RVGrid);
            Name = "RVForm";
            Text = "Recreational Vehicle (RV) Form";
            ((System.ComponentModel.ISupportInitialize)RVGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RVGrid;
        private TextBox txtRVID;
        private TextBox txtCustID;
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtPlate;
        private Button btnRemove;
        private Button btnAdd;
        private Label labRVID;
        private Label labCustID;
        private Label labMake;
        private Label labModel;
        private Label labPlate;
        private Label labRVADD;
        private Label labRVREMOVE;
    }
}