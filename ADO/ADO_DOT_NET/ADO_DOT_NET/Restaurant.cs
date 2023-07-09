using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DOT_NET
{
    internal class Restaurant
    {
        SqlConnection conn;
        string connectionString = "data source =DESKTOP-4H18AAA\\SQLEXPRESS;database = ADO;integrated security = SSPI";

        int cust_id;
        string cus_name;
        DateTime date;
        int points;
        int invoice_no;
        int product_id;
        DateTime date_of_purchase;
        int total_amount;
        public Restaurant(int cust_id,string cus_name)
        {
            this.cust_id = cust_id;
            this.cus_name= cus_name;
            //this.date = date;
            this.points = 0;
        }
        public Restaurant(int invoice_no,int cust_id,int product_id,DateTime date_of_purchase,int total_amount)
        {
            this.invoice_no = invoice_no;
            this.cust_id = cust_id;
            this.product_id = product_id;
            this.date_of_purchase = date_of_purchase;
            this.total_amount = total_amount;

        }
        public int Cust_id { get => cust_id; set => cust_id = value; }
        public string Cus_name { get => cus_name; set => cus_name = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Points { get => points; set => points = value; }
        public int Invoice_no { get => invoice_no; set => invoice_no = value; }
        public int Product_id { get => product_id; set => product_id = value; }
        public DateTime Date_of_purchase { get => date_of_purchase; set => date_of_purchase = value; }
        public int Total_amount { get => total_amount; set => total_amount = value; }

        

        public void OpenConn()
        {

            //string connectionString = ConfigurationManager.ConnectionStrings["join"].ConnectionString;
            conn = new SqlConnection(connectionString);
            conn.Open();
            Console.WriteLine("Opened");
        }
        public void Add_member_data()
        {
            //int customer_id = this.cust_id;
            //string customer_name=this.Cus_name
            //conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Members values(1,'kanna',0);", conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("value inserted into member");

        }
    }
}
