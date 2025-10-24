using EmployeeDashboard;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace login_2
{
    public partial class SellProduct : Form
    {
        public DataGridView CartDGV => dgvCart;
        private readonly string connectionString = @"Server=DESKTOP-55GE2MB\SQLEXPRESS;Database=JERSEY SHOP;User Id=sa;Password=1234;Encrypt=False;TrustServerCertificate=True;";
        private DataTable products = new DataTable();
        string EmpID;
        string EmpName;
        public SellProduct(string empid, string empname)
        {
            InitializeComponent();
            EmpID = empid;
            EmpName = empname;
            dgvProduct.AutoGenerateColumns = true;
            dgvProduct.ReadOnly = true;
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadProductsFromDB();

            comboBox1.Items.Add("Name");
            comboBox1.Items.Add("Team");
            comboBox1.Items.Add("JerseyID");
            comboBox1.SelectedIndex = 0;
        }
        public SellProduct()
        {
            InitializeComponent();
            dgvProduct.AutoGenerateColumns = true;
            dgvProduct.ReadOnly = true;
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadProductsFromDB();

            comboBox1.Items.Add("Name");
            comboBox1.Items.Add("Team");
            comboBox1.Items.Add("JerseyID");
            comboBox1.SelectedIndex = 0;
        }

        private void LoadProductsFromDB()
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                using (var da = new SqlDataAdapter("select * from [dbo].[Jersey];", con))
                {
                    products.Clear();
                    da.Fill(products);
                    dgvProduct.DataSource = products;
                    dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "LoadJerseyDbTable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void productGridSearch(object sender, EventArgs e)
        {
            if (products.Rows.Count == 0)
                return;

            string column = comboBox1.SelectedItem.ToString();
            string filterText = searchTextBox.Text.Trim();


            filterText = filterText.Replace("'", "''");

            DataView dv = products.DefaultView;

            if (string.IsNullOrEmpty(filterText))
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = $"{column} LIKE '%{filterText}%'";
            }

            dgvProduct.DataSource = dv;
        }

        private void SortCombobox(object sender, EventArgs e)
        {
            string column = comboBox1.SelectedItem.ToString(); // "Name", "Team", or "JerseyID"

            DataView dv = products.DefaultView;
            dv.Sort = column + " ASC";

            dgvProduct.DataSource = dv;

        }
        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            EmployeeDashboard back = new EmployeeDashboard(EmpID, EmpName);
            back.Show();
            this.Close();
        }

        private void ProcessToSaleBtn_work(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product from the cart!");
                return;
            }
            var row = dgvCart.SelectedRows[0];

            string productID = row.Cells["JerseyID"].Value.ToString();
            string quantity = row.Cells["JerseyQuantity"].Value.ToString();
            string unitPrice = row.Cells["UnitPrice"].Value.ToString();
            decimal price = Convert.ToDecimal(unitPrice);
            int qty = Convert.ToInt32(quantity);
            decimal totalprice = (price * qty);

            EmployeeControl3 sellInfo = new EmployeeControl3(EmpID, EmpName, productID, quantity, unitPrice, totalprice);
            sellInfo.ShowDialog();
            if (sellInfo.SaleConfirmed)
            {
                dgvCart.Rows.Remove(row);
                CalculateGrandTotal();
                LoadProductsFromDB();
            }


        }
        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                productGridSearch(sender, e);
            }

        }

        private void AddToCart_Click(object sender, EventArgs e)
        {

            if (dgvProduct.SelectedRows.Count == 0)
            { return; }


            var row = dgvProduct.SelectedRows[0];
            string id = row.Cells["JerseyID"].Value.ToString();
            string name = row.Cells["Name"].Value.ToString();
            string team = row.Cells["Team"].Value.ToString();
            string size = row.Cells["Size"].Value.ToString();
            decimal unitPrice = Convert.ToDecimal(row.Cells["Price"].Value);
            int stockQty = Convert.ToInt32(row.Cells["Stock Quantity"].Value);

            foreach (DataGridViewRow cartRow in dgvCart.Rows)
            {
                if (cartRow.IsNewRow) continue;

                string jerseyId = cartRow.Cells["JerseyID"].Value?.ToString() ?? "";
                string rowSize = cartRow.Cells["Size"].Value?.ToString() ?? "";

                if (jerseyId == id && rowSize == size)
                {
                    int qty = 0;
                    if (cartRow.Cells["JerseyQuantity"].Value != null)
                    {
                        qty = Convert.ToInt32(cartRow.Cells["JerseyQuantity"].Value);
                    }
                    if (qty + 1 > stockQty)
                    {
                        MessageBox.Show("Item is out of stock!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    cartRow.Cells["JerseyQuantity"].Value = qty + 1;

                    CalculateGrandTotal();
                    return;
                }
            }
            if (stockQty < 1)
            {
                MessageBox.Show("Item is out of stock!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvCart.Rows.Add(id, name, team, unitPrice, size, 1);

            CalculateGrandTotal();
        }
        private void CalculateGrandTotal()
        {
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["UnitPrice"].Value != null && row.Cells["JerseyQuantity"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                    int qty = Convert.ToInt32(row.Cells["JerseyQuantity"].Value);
                    grandTotal += price * qty;
                }
            }

            totalpricelbl.Text = grandTotal.ToString("0.00") + " BDT ";
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCart.CurrentRow == null || dgvCart.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Please select an item to remove from the cart.");
                    return;
                }
                dgvCart.Rows.RemoveAt(dgvCart.CurrentRow.Index);
                decimal grandTotal = 0;
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.IsNewRow) continue;

                    var priceCell = row.Cells["UnitPrice"];
                    var qtyCell = row.Cells["JerseyQuantity"];

                    if (priceCell.Value != null && qtyCell.Value != null)
                    {
                        grandTotal += Convert.ToDecimal(priceCell.Value) * Convert.ToInt32(qtyCell.Value);
                    }
                }

                totalpricelbl.Text = grandTotal.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

