using DocumentFormat.OpenXml.Spreadsheet;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace RVStorageManager
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        //
        // Click Listener Sends to Customer Form
        //
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustForm custForm = new CustForm();
            custForm.Show();
        }
        //
        // Click Listener Sends to RV Form
        //
        private void btnRV_Click(object sender, EventArgs e)
        {
            RVForm rvForm = new RVForm();
            rvForm.Show();
        }
        //
        // Click Listener Sends to Lot Form
        //
        private void btnLot_Click(object sender, EventArgs e)
        {
            LotForm lotForm = new LotForm();
            lotForm.Show();
        }
        //
        // Click Listener Exports Data to Excel
        //
        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportDatabaseToExcel();
        }

        private void ExportDatabaseToExcel()
        {
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            string connectionString = ConfigurationManager.ConnectionStrings["RVStorageConnection"].ConnectionString;

                            // Define the table names for export
                            string[] tableNames = new string[] { "Customer", "ParkingLot", "RV" };

                            // For each table, export its data to a separate excel sheet
                            foreach (string tableName in tableNames)
                            {
                                using (SQLiteConnection conn = new SQLiteConnection (connectionString))
                                {
                                    conn.Open();
                                    string query = $"SELECT * FROM [{tableName}]"; // SQL Query which selects all data from the tables
                                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn))
                                    {
                                        DataTable dt = new DataTable();
                                        da.Fill(dt);

                                        var worksheet = workbook.Worksheets.Add(tableName);
                                        worksheet.Cell(1, 1).InsertTable(dt); // Insert the data table into the worksheet starting at cell A1
                                    }    
                                }
                            }
                            workbook.SaveAs(sfd.FileName); // Save the workbook to the specified path
                        }
                        MessageBox.Show("Export successful.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }
    }
}
