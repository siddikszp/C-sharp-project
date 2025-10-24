using login_2;
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployeeDashboard
{
    public partial class EmployeeControl3 : Form
    {
        // TODO: Maybe move this to a config file later
        private readonly string connectionString = @"Server=DESKTOP-55GE2MB\SQLEXPRESS;Database=JERSEY SHOP;User Id=sa;Password=1234;Encrypt=False;TrustServerCertificate=True;";

        
        private DataGridViewRow SelectedCartRow;
        public bool SaleConfirmed = false;

        public EmployeeControl3(string empid, string empname, string jerseyID, string quantity, string Unitprice, decimal totalprice)
        {
            InitializeComponent();

            // Setting up the form with the passed data
            txtProductID.Text = jerseyID;
            txtProductQuantity.Text = quantity;
            txtPrice.Text = Unitprice;
            txttotalprice.Text = totalprice.ToString("0.00");
            txtEmpID.Text = empid;
            txtEmpName.Text = empname;

            // Configure the data grid - I prefer doing this manually for better control
            dgvCustomerInfo.AutoGenerateColumns = true;
            dgvCustomerInfo.ReadOnly = true;
            dgvCustomerInfo.AllowUserToAddRows = false;
            dgvCustomerInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            LoadJerseyDbTable(); // Load existing data
        }

        private void LoadJerseyDbTable()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from [dbo].[sell Info];", con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvCustomerInfo.DataSource = dt;
                        dgvCustomerInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show("Error loading data: " + ex.Message, "LoadJerseyDbTable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtGmail.Text.Trim(); // trim removes any extra spaces

            // Basic email validation - could be improved but this works for now
            if (!email.ToLower().EndsWith("@gmail.com"))
            {
                emailerror.Text = "Please enter a valid email address.";
            }
            else
            {
                emailerror.Text = ""; // Clear error message
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Simple reset functionality
            this.txtCusName.Clear();
            this.txtGmail.Clear();
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            // Check if user selected a row first
            if (dgvCustomerInfo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = Convert.ToInt32(dgvCustomerInfo.SelectedRows[0].Cells["Product ID"].Value);

            // Ask for confirmation before deleting - always good practice
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string deleteQuery = "DELETE FROM [dbo].[sell Info] WHERE [product ID] = @ID";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", selectedId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadJerseyDbTable(); // Refresh the grid to show updated data
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmSale_Click(object sender, EventArgs e)
        {
            // Validate required fields before proceeding
            if (string.IsNullOrWhiteSpace(txtCusName.Text))
            {
                MessageBox.Show("Please Fillup all the fields. ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Insert the sale record first
                    string insertSaleQuery = @"insert into[dbo].[sell Info]
                                        ([Product ID],[Customer Name],[Gmail],[Quantity],[Purchase Date],[Price])
                                        values(@ProductID,@CustomerName,@Gmail,@Quantity,@PurchaseDate,@Price);
                                         SELECT SCOPE_IDENTITY();"; // Get the new ID

                    int newSellId = 0;
                    using (SqlCommand cmd = new SqlCommand(insertSaleQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text.Trim());
                        cmd.Parameters.AddWithValue("@CustomerName", txtCusName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gmail", txtGmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Quantity", txtProductQuantity.Text.Trim());
                        cmd.Parameters.AddWithValue("@PurchaseDate", DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@Price", txttotalprice.Text.Trim());

                        newSellId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    if (newSellId > 0)
                    {
                        // Update stock quantity - subtract sold quantity
                        string updateStockQuery = @"Update [dbo].Jersey set [Stock Quantity]=[Stock Quantity] - @SoldQty
                         WHERE JerseyID = @ProductID";

                        using (SqlCommand stockUpdateCmd = new SqlCommand(updateStockQuery, conn))
                        {
                            stockUpdateCmd.Parameters.AddWithValue("@SoldQty", txtProductQuantity.Text.Trim());
                            stockUpdateCmd.Parameters.AddWithValue("@ProductID", txtProductID.Text.Trim());
                            stockUpdateCmd.ExecuteNonQuery();
                        }

                        // Record employee sale statistics
                        string empStatsQuery = @"INSERT INTO [dbo].[Emp Sell Stats] 
                                         ([Sell ID], [EmpID], [EmpName], [Price]) 
                                         VALUES (@SellID, @EmpID, @EmpName, @Price)";

                        using (SqlCommand empStatsCmd = new SqlCommand(empStatsQuery, conn))
                        {
                            empStatsCmd.Parameters.AddWithValue("@SellID", newSellId);
                            empStatsCmd.Parameters.AddWithValue("@EmpID", txtEmpID.Text.Trim());
                            empStatsCmd.Parameters.AddWithValue("@EmpName", txtEmpName.Text.Trim());
                            empStatsCmd.Parameters.AddWithValue("@Price", txttotalprice.Text.Trim());
                            empStatsCmd.ExecuteNonQuery();
                        }

                        SaleConfirmed = true; // Set flag for parent form

                        MessageBox.Show("Sale confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadJerseyDbTable(); // Refresh the display
                        btnReset_Click(null, null); // Clear the form
                    }
                    else
                    {
                        MessageBox.Show("Failed to add record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            // Navigate back to sell product form
            SellProduct backForm = new SellProduct();
            backForm.Show();
            this.Hide(); // Hide current form instead of closing
        }

        private void EmployeeControl3_Load(object sender, EventArgs e)
        {
            // Empty for now - might add initialization code later if needed
        }
    }
}