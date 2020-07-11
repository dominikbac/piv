using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace pivotal
{
    public partial class Form1 : Form
    {
        string connString = @"Data Source=DESKTOP-QBM3H1T;database=NORTHWND;user ID=pivotal;Password=P!viotal123;Trusted_Connection=true";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlDataAdapter statment = new SqlDataAdapter("SELECT * FROM dbo.TopCustomers()",conn);
                DataTable DtTopCustomer = new DataTable();
                statment.Fill(DtTopCustomer);

                dataGridView1.DataSource = DtTopCustomer;
                conn.Close();
            }
        }

        private void BestCustormerOrdersDetail_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlDataAdapter statment = new SqlDataAdapter("SELECT * FROM dbo.BestCustormerOrdersDetail()", conn);
                DataTable DtBestCustomer = new DataTable();
                statment.Fill(DtBestCustomer);

                dataGridView2.DataSource = DtBestCustomer;
                conn.Close();
            }
        }
    }
}
