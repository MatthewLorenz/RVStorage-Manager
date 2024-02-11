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
    public partial class RVForm : Form
    {
        public RVForm()
        {
            InitializeComponent();
            this.Load += RVForm_Load;
        }
        private void RVForm_Load(object sender, EventArgs e)
        {
            LoadRVData();
        }

        private void LoadRVData()
        {
            // Retrieve the connection string from the App.config
            string connectionString = ConfigurationManager.ConnectionStrings["RVStorageConnection"].ConnectionString;

            // Connect to the SQLite Database
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                // Create a SQL query which selects the desired columns from the RV table
                string query = "SELECT rvID, custID, make, model, plate FROM RV";
                // Execute the query and fill in the DataTable (datagrid) with results
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    // Set the DataGridView's DataSource to the DataTable we just created
                    RVGrid.DataSource = dt;
                }
            }
        }
        //
        // Listener for ADD for ADD RV method
        //
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRV();
        }
        //
        //Listener for REMOVE for REMOVE RV method
        //
        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveRV();
        }

        //
        // ADD RV METHOD
        //
        private void AddRV()
        {
            //Input Validation
            if (string.IsNullOrWhiteSpace(txtRVID.Text) ||
                string.IsNullOrWhiteSpace(txtCustID.Text) ||
                string.IsNullOrWhiteSpace(txtMake.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtPlate.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // Prepare the command text with parameters to prevent SQL injection
            string commandText = "INSERT INTO RV (rvID, custID, make, model, plate) VALUES (@rvID, @custID, @make, @model, @plate)";
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["RVStorageConnection"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(commandText, conn)) 
                {
                    // Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@rvID", txtRVID.Text);
                    cmd.Parameters.AddWithValue("@custID", txtCustID.Text);
                    cmd.Parameters.AddWithValue("@make", txtMake.Text);
                    cmd.Parameters.AddWithValue("@model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@plate", txtPlate.Text); //TODO: Plate is mistakenly accepting integer only instead of string

                    // Execute the command and check the number of rows affected
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0) 
                        {
                            MessageBox.Show("RV information added successfully");
                        }
                        else
                        {
                            MessageBox.Show("No RV information was added to the database");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            //Refresh the DataGridView to show the new data
            LoadRVData();

            // Clear the input fields
            txtRVID.Clear();
            txtCustID.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtPlate.Clear();
        }

        //
        //REMOVE RV METHOD
        //
        private void RemoveRV()
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(txtRVID.Text))
            {
                MessageBox.Show("Please enter the RV ID to remove.");
                return;
            }

            // Prepare the command text with parameter
            string commandText = "DELETE FROM RV WHERE rvID = @rvID";
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["RVStorageConnection"].ConnectionString))
            { 
                conn.Open();
                using(SQLiteCommand cmd = new SQLiteCommand(commandText, conn)) 
                {
                    // Use parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@rvID", txtRVID.Text);

                    // Execute the command and check the number of rows affected
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); 
                        if (rowsAffected > 0) 
                        {
                            MessageBox.Show("RV information removed successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No RV information found with given ID");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message );
                    }
                }
            }

            // Refresh the DataGridView to show the data after deletion
            LoadRVData();

            // Clear the input fields
            txtRVID.Clear();
            txtCustID.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtPlate.Clear();
        }
    }
}
