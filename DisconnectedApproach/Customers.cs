using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DisconnectedApproach
{
    public class Customers
    {
        public static string connectionString=@"Data Source=DESKTOP-AMR2CQS\MSSQLSERVER01;Initial Catalog=BankDb;Integrated Security=True";
        SqlConnection connection=new SqlConnection(connectionString);
        public string InsertCustomers(int custId,string CustName,string CustEmail,decimal PhoneNo,string Address)
        {
            string sql = "insert into Customer values(" + custId + ",'" + CustName + "','" + CustEmail + "'," + PhoneNo + ",'" + Address + "')";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,connection);
            DataTable dataTable=new DataTable();
            adapter.Fill(dataTable);

            return "inserted";
        }
        public void SelectCustomers()
        {
            string sql = "select * from Customer";
            SqlDataAdapter adapter=new SqlDataAdapter(sql,connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                for(int j = 0; j < dataTable.Columns.Count; j++)
                {
                    Console.Write(dataTable.Rows[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
        public string DeleteCustomer(int CustId)
        {
            string sql = "delete from Customer where CustId= "+CustId+" ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql,connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return "Customer Deleted with Customer_id " + CustId.ToString();

        }
        public string UpdateCustomersNameAndEmail(int custId,string name ,string email)
        {
            string sql = "update Customer set CustName='" + name + "',Email='" + email + "' where CustId=" + custId + "";
            SqlDataAdapter adp = new SqlDataAdapter(sql,connection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return "Update Customer with Id " + custId.ToString();
        }
        public void SelectCustomersById(int id)
        {
            string sql = "select * from Customer where CustId="+id+"";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    Console.Write(dataTable.Rows[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
