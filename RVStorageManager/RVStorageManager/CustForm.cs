using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RVStorageManager
{
    public partial class CustForm : Form
    {
        public CustForm()
        {
            InitializeComponent();
            this.Load += CustForm_Load;
            btnAdd.Click += btnAdd_Click;
        }

        private void CustForm_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            // Retrieve the connection string from App.config
            string connectionString = ConfigurationManager.ConnectionStrings["RVStorageConnection"].ConnectionString;

            // Connect to the SQLite database
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                // Create a query to select the desired columns from the Customer table
                string query = "SELECT custName, custID, email, phone FROM Customer";
                // Execute the query and fill a DataTable with the results
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    // Set the DataGridView's DataSource to the DataTable
                    custGrid.DataSource = dt;
                }
            }
        }

        //
        //Event Listener ADD for ADD CUSTOMER method
        //
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }

        //
        //Event Listener REMOVE for REMOVE CUSTOMER method
        //
        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveCustomer();
        }
        //
        //ADD CUSTOMER METHOD
        //
        private void AddCustomer()
        {
            //Input Validation
            if (string.IsNullOrWhiteSpace(txtCustID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Prepare the command text with parameters to prevent SQL injection
            string commandText = "INSERT INTO Customer (custID, custName, email, phone) VALUES (@custID, @custName, @email, @phone)";
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["RVStorageConnection"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(commandText, conn))
                {
                    // Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@custID", txtCustID.Text);
                    cmd.Parameters.AddWithValue("@custName", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

                    // Execute the command and check the number of rows affected
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No customer was added to the database.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            // Refresh the DataGridView to show the new data
            LoadCustomerData();

            // Clear the input fields
            txtCustID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }

        //
        //REMOVE CUSTOMER METHOD
        //
        private void RemoveCustomer()
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(txtCustID.Text))
            {
                MessageBox.Show("Please enter the Customer ID to remove.");
                return;
            }

            // Prepare the command text with parameter
            string commandText = "DELETE FROM Customer WHERE custID = @custID";
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["RVStorageConnection"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(commandText, conn))
                {
                    // Use parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@custID", txtCustID.Text);

                    // Execute the command and check the number of rows affected
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer removed successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the given ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            // Refresh the DataGridView to show the data after deletion
            LoadCustomerData();

            // Clear the input fields
            txtCustID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }


    }
}