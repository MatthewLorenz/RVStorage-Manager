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
    public partial class LotForm : Form
    {
        public LotForm()
        {
            InitializeComponent();
            this.Load += LotForm_Load;
        }

        private void LotForm_Load(object sender, EventArgs e)
        {
            LoadLotData();
        }

        private void LoadLotData()
        {
            // Retrieve the connection string fro the App.config file
            string connectionString = ConfigurationManager.ConnectionStrings["RVStorageConnection"].ConnectionString;

            // Connect to the SQLite Database
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                //Create a SQL query which selects the desired columns from the Lot Table
                string query = "SELECT lotID, rvID, spotName FROM ParkingLot";
                // Execute the query and fill in the grid with results
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    // Set the DataGridView's DataSource to the DataTable we just created
                    lotGrid.DataSource = dt;
                }
            }
        }
        //
        // Listener for ASSIGN for ASSIGN LOT method
        //
        private void btnAssign_Click(object sender, EventArgs e)
        {
            AssignLot();
        }
        //
        // Listener for REMOVE for REMOVE RV method
        //
        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveLot();
        }

        //
        // ASSIGN LOT method
        //
        private void AssignLot()
        {
            // Input Validation
            if (string.IsNullOrWhiteSpace(txtLotID.Text) ||
                string.IsNullOrWhiteSpace(txtRVID.Text) ||
                string.IsNullOrWhiteSpace(txtSpot.Text)) 
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // Prepare the command text with parameters to prevent SQL injections
            string commandText = "INSERT INTO ParkingLot (lotID, rvID, spotName) VALUES (@lotID, @rvID, @spotName)";
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["RVStorageConnection"].ConnectionString)) 
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(commandText, conn))
                {
                    // Use parameters to prevent SQL Injection
                    cmd.Parameters.AddWithValue("@lotID", txtLotID.Text);
                    cmd.Parameters.AddWithValue("@rvID", txtRVID.Text);
                    cmd.Parameters.AddWithValue("@spotName", txtSpot.Text);

                    // Execute the command and check the number of rows affected
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0) 
                        {
                            MessageBox.Show("Lot information has been updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("No Lot information was added to the database");
                        }    
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            // Referesh the DataGRidView to show the new data
            LoadLotData();

            // Clear the input fields
            txtLotID.Clear();
            txtRVID.Clear();
            txtSpot.Clear();
        }

        //
        // REMOVE LOT method
        //
        private void RemoveLot()
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(txtLotID.Text))
            {
                MessageBox.Show("Please enter the Lot ID to remove");
                return;
            }

            // Prepare the command text with parameter
            string commandText = "DELETE FROM ParkingLot WHERE lotID = @lotID";
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["RVStorageConnection"].ConnectionString))
            {
                conn.Open();
                using(SQLiteCommand cmd = new SQLiteCommand(commandText, conn)) 
                {
                    // Use parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@lotID", txtLotID.Text);

                    // Execute the command and check the number of rows affected
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if(rowsAffected > 0)
                        {
                            MessageBox.Show("Lot information removed successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No Lot information found with given ID");
                        }    
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            // Referesh the grid to show data after deletion
            LoadLotData();

            // Clear the input fields
            txtLotID.Clear();
            txtRVID.Clear();
            txtSpot.Clear();
        }
    }
}
