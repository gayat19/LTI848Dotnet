using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankModel;

namespace BankProjectFE
{
    class CustomerFE
    {
        void PrintMenu()
        {
            Console.WriteLine("Welcome to the Shopping Site");
            Console.WriteLine("Menu Details");
            Console.WriteLine("1. Adding Customers");
            Console.WriteLine("2. Printing a single Customer");
            Console.WriteLine("3. Printing all the Customers");
            Console.WriteLine("4. Updating a Customer");
            Console.WriteLine("5. Deleting a Customer");
            Console.WriteLine("6. Exit");
        }

        void SelectOption()
        {
            int ch = 6;
            CustomerManager customerManager = new CustomerManager();
            do
            {
                PrintMenu();
               ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        customerManager.AddCustomer();
                        break;
                    case 2:
                        Console.WriteLine("Select the index you want to print");
                        int index = Convert.ToInt32(Console.ReadLine());
                        customerManager.PrintCustomerByIndex(index);
                        break;
                    case 3:
                        customerManager.PrintAllCustomers();
                        break;
                    case 4:
                        Console.WriteLine("Please enter the index you wish to edit");
                        int updateIndex = Convert.ToInt32(Console.ReadLine());
                        Customer customer = new Customer();
                        customer.TakeCustomerDetailsFromUSer();
                        if(customerManager.UpdateCustomer(updateIndex,customer))
                            Console.WriteLine("Update success");
                        else
                            Console.WriteLine("Could not update");
                        break;
                    case 5:
                        Console.WriteLine("Please enter the index youu wish to delete");
                        int deleteIndex = Convert.ToInt32(Console.ReadLine());
                        if (customerManager.DeleteCustomer(deleteIndex))
                            Console.WriteLine("Delete success");
                        else
                            Console.WriteLine("Unable to delete");
                        break;
                    case 6:
                        Console.WriteLine("You have made the choice to exit...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;
                }
            } while (ch!=6);
        }
        static void Main(string[] args)
        {
            new CustomerFE().SelectOption();
            Console.ReadKey();
        }
    }
}
