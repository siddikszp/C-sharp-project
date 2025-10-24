using EmployeeDashboard;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using Microsoft.Data.SqlClient;

namespace login_2
{
    public partial class LoginPage : Form
    {
        private readonly string connectionString = @"Server=DESKTOP-55GE2MB\SQLEXPRESS;Database=JERSEY SHOP;User Id=sa;Password=1234;Encrypt=False;TrustServerCertificate=True;";

        public LoginPage()
        {
            InitializeComponent();
        }


        private void Login_Click(object sender, EventArgs e)
        {
            string UserID = txtuserID.Text.Trim();
            string password = txtpassword.Text.Trim();
            if (string.IsNullOrEmpty(UserID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your Id and password. ");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "Select password from Users where UserID=@UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string dbpassword = result.ToString();
                            if (dbpassword == password)
                            {
                                string First3Letter = UserID.Substring(0, 3).ToUpper();
                                if (First3Letter == "EMP")
                                {
                                    string nameQuery = "SELECT UserName FROM Users WHERE UserID = @UserID";
                                    using (SqlCommand nameCmd = new SqlCommand(nameQuery, conn))
                                    {
                                        nameCmd.Parameters.AddWithValue("@UserID", UserID);
                                        string empName = nameCmd.ExecuteScalar().ToString();
                                        EmployeeDashboard empLogin = new EmployeeDashboard(UserID, empName);
                                        empLogin.Show();
                                        this.Hide();
                                    }


                                }
                                else if (First3Letter == "ADM")
                                {

                                }
                                else if (First3Letter == "MAN")
                                {
                                    string nameQuery = @" SELECT TOP 1 UserName FROM dbo.Users WHERE UserID = @UserID AND UPPER(Role) = 'MANAGER'";

                                    using (SqlCommand nameCmd = new SqlCommand(nameQuery, conn))
                                    {
                                        nameCmd.Parameters.AddWithValue("@UserID", UserID.Trim());
                                        object val = nameCmd.ExecuteScalar();

                                        if (val == null || val == DBNull.Value)
                                        {
                                            MessageBox.Show("Manager account not found for this UserID.", "Login",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }

                                        string managerName = Convert.ToString(val)?.Trim() ?? "";


                                        var mgr = new ManagerDashboard(UserID.Trim(), managerName);
                                        mgr.Show();
                                        this.Hide();
                                    }
                                }

                                else
                                {
                                    MessageBox.Show(" Invalid role in User ID.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect password.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("User ID not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Showpass.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Showpass_CheckedChanged(object sender, EventArgs e)
        {
          txtpassword.UseSystemPasswordChar = !Showpass.Checked;
        }
    }
}