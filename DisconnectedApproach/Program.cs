using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customers customers = new Customers();
            //Console.WriteLine(customers.InsertCustomers(10090,"PusPa ","JhukegaNahi@gmail.com",3339000,"South"));
            //customers.SelectCustomers();

            //Console.WriteLine(customers.DeleteCustomer(10090));
            //customers.SelectCustomers();

            //customers.UpdateCustomersNameAndEmail(1001, "Kejriwal", "Kejriwal@gmail.com");
            //customers.SelectCustomers();

            //customers.SelectCustomersById(1001);

            Accounts accounts = new Accounts();
            Console.WriteLine(accounts.InsertAccount(18420043, "GopalKirshna", 24, "Delhi"));
            accounts.SelectAccount();
            Console.WriteLine();

            Console.WriteLine(accounts.DeleteAccount(18420043));
            accounts.SelectAccount();
            Console.WriteLine();
            Console.WriteLine(accounts.UpdateAccountHolderNameAndAddress(1003,"Vishnu","jhajhar"));
            accounts.SelectAccount();
            Console.WriteLine();
            accounts.SelectAccountId(1003);


            Console.ReadLine();
        }
    }
}
