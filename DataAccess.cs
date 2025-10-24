using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Reflection.Metadata;


namespace login_2 
{
    public class DataAccess : IDisposable 
    {
        private SqlConnection sqlcon = new SqlConnection(); 
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom = new SqlCommand(); //declares Nullable
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda = new SqlDataAdapter();
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds = new DataSet();
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }
        public DataAccess()
        {
            this.Sqlcon = new SqlConnection( @"Server=DESKTOP-55GE2MB\SQLEXPRESS;Database=JERSEY SHOP;User Id=sa;Password=1234;Encrypt=False;TrustServerCertificate=True;");
            this.Sqlcon.Open();
        }

        private void QueryText(string query, params SqlParameter[] parameters)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
            if (parameters != null && parameters.Length > 0)
            {
                this.Sqlcom.Parameters.AddRange(parameters);
            }
        }

        public DataSet ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            this.QueryText(sql, parameters);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds;
        }

        // Select DataTable
        public DataTable ExecuteQueryTable(string sql, params SqlParameter[] parameters)
        {
            this.QueryText(sql, parameters);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds.Tables[0];
        }

        //Insert,Update,delete
        public int ExecuteDMLQuery(string sql, params SqlParameter[] parameters)
        {
            this.QueryText(sql, parameters);
            return this.Sqlcom.ExecuteNonQuery();
        }

        // Single value count,max, etc.
        public object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            this.QueryText(sql, parameters);
            return this.Sqlcom.ExecuteScalar();
        }
        public void Dispose()
        {
            if (this.Sqlcon != null && this.Sqlcon.State == ConnectionState.Open)
            {
                this.Sqlcon.Close();
                this.Sqlcon.Dispose();
            }
        }
    }
}
