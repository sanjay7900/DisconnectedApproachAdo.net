using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DisconnectedApproach
{
    public class Accounts
    {
        public static string connectionString = @"Data Source=DESKTOP-AMR2CQS\MSSQLSERVER01;Initial Catalog=BankDb;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public string InsertAccount(int accId, string holderName, int age, string Address)
        {
            string sql = "insert into Account values(" + accId + ",'" + holderName + "'," + age + ",'" + Address + "')";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return "inserted";
        }
        public void SelectAccount()
        {
            string sql = "select * from Account";
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
        public string DeleteAccount(int accId)
        {
            string sql = "delete from Account where AccId= " + accId + " ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return "Customer Deleted with Account id " + accId.ToString();

        }
        public string UpdateAccountHolderNameAndAddress(int accId, string name, string address)
        {
            string sql = "update Account set AccHolderName='" + name + "',AccHolderAddress='" + address + "' where AccId=" + accId + "";
            SqlDataAdapter adp = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return "Update Account with Id " + accId.ToString();
        }
        public void SelectAccountId(int id)
        {
            string sql = "select * from Account where CustId=" + id + "";
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
