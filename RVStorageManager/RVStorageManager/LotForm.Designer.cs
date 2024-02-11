namespace RVStorageManager
{
    partial class LotForm
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
            lotGrid = new DataGridView();
            txtLotID = new TextBox();
            txtRVID = new TextBox();
            txtSpot = new TextBox();
            labLotID = new Label();
            labRVID = new Label();
            labSpot = new Label();
            labLotDescription = new Label();
            labAssignDescription = new Label();
            labRemoveDescription = new Label();
            btnRemove = new Button();
            btnAssign = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)lotGrid).BeginInit();
            SuspendLayout();
            // 
            // lotGrid
            // 
            lotGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lotGrid.Location = new Point(12, 12);
            lotGrid.Name = "lotGrid";
            lotGrid.Size = new Size(776, 315);
            lotGrid.TabIndex = 1;
            // 
            // txtLotID
            // 
            txtLotID.BackColor = SystemColors.InactiveCaption;
            txtLotID.BorderStyle = BorderStyle.FixedSingle;
            txtLotID.Location = new Point(285, 363);
            txtLotID.Name = "txtLotID";
            txtLotID.Size = new Size(71, 23);
            txtLotID.TabIndex = 3;
            // 
            // txtRVID
            // 
            txtRVID.BackColor = SystemColors.InactiveCaption;
            txtRVID.BorderStyle = BorderStyle.FixedSingle;
            txtRVID.Location = new Point(362, 363);
            txtRVID.Name = "txtRVID";
            txtRVID.Size = new Size(71, 23);
            txtRVID.TabIndex = 4;
            // 
            // txtSpot
            // 
            txtSpot.BackColor = SystemColors.InactiveCaption;
            txtSpot.BorderStyle = BorderStyle.FixedSingle;
            txtSpot.Location = new Point(439, 363);
            txtSpot.Name = "txtSpot";
            txtSpot.Size = new Size(71, 23);
            txtSpot.TabIndex = 5;
            // 
            // labLotID
            // 
            labLotID.AutoSize = true;
            labLotID.Location = new Point(304, 345);
            labLotID.Name = "labLotID";
            labLotID.Size = new Size(38, 15);
            labLotID.TabIndex = 6;
            labLotID.Text = "Lot ID";
            // 
            // labRVID
            // 
            labRVID.AutoSize = true;
            labRVID.Location = new Point(383, 345);
            labRVID.Name = "labRVID";
            labRVID.Size = new Size(35, 15);
            labRVID.TabIndex = 7;
            labRVID.Text = "RV ID";
            // 
            // labSpot
            // 
            labSpot.AutoSize = true;
            labSpot.Location = new Point(439, 345);
            labSpot.Name = "labSpot";
            labSpot.Size = new Size(66, 15);
            labSpot.TabIndex = 8;
            labSpot.Text = "Spot Name";
            // 
            // labLotDescription
            // 
            labLotDescription.AutoSize = true;
            labLotDescription.Location = new Point(12, 345);
            labLotDescription.Name = "labLotDescription";
            labLotDescription.Size = new Size(218, 15);
            labLotDescription.TabIndex = 9;
            labLotDescription.Text = "Lot ID indicates Directory for Gate Code.";
            // 
            // labAssignDescription
            // 
            labAssignDescription.AutoSize = true;
            labAssignDescription.Location = new Point(12, 401);
            labAssignDescription.Name = "labAssignDescription";
            labAssignDescription.Size = new Size(505, 15);
            labAssignDescription.TabIndex = 10;
            labAssignDescription.Text = "To ASSIGN RVs to Lot enter information in all fields: Lot ID, RV ID, Spot Name, and click ASSIGN";
            // 
            // labRemoveDescription
            // 
            labRemoveDescription.AutoSize = true;
            labRemoveDescription.Location = new Point(12, 426);
            labRemoveDescription.Name = "labRemoveDescription";
            labRemoveDescription.Size = new Size(302, 15);
            labRemoveDescription.TabIndex = 11;
            labRemoveDescription.Text = "To REMOVE RVs from Lot enter Lot ID and click REMOVE";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.RosyBrown;
            btnRemove.Location = new Point(699, 361);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(71, 23);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = SystemColors.ActiveCaption;
            btnAssign.Location = new Point(622, 361);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(71, 23);
            btnAssign.TabIndex = 12;
            btnAssign.Text = "ASSIGN";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 371);
            label1.Name = "label1";
            label1.Size = new Size(256, 15);
            label1.TabIndex = 14;
            label1.Text = "Gate Code Procedure: * * 002 + (Lot ID) + 83456";
            // 
            // LotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnRemove);
            Controls.Add(btnAssign);
            Controls.Add(labRemoveDescription);
            Controls.Add(labAssignDescription);
            Controls.Add(labLotDescription);
            Controls.Add(labSpot);
            Controls.Add(labRVID);
            Controls.Add(labLotID);
            Controls.Add(txtSpot);
            Controls.Add(txtRVID);
            Controls.Add(txtLotID);
            Controls.Add(lotGrid);
            Name = "LotForm";
            Text = "Parking Lot Form";
            ((System.ComponentModel.ISupportInitialize)lotGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView lotGrid;
        private TextBox txtLotID;
        private TextBox txtRVID;
        private TextBox txtSpot;
        private Label labLotID;
        private Label labRVID;
        private Label labSpot;
        private Label labLotDescription;
        private Label labAssignDescription;
        private Label labRemoveDescription;
        private Button btnRemove;
        private Button btnAssign;
        private Label label1;
    }
}