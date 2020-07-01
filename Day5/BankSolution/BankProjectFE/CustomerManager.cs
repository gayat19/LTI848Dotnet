using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankModel;

namespace BankProjectFE
{
    //Crud-Creation Reading Updation Deletion
    class CustomerManager
    {
        Customer[] customers;
        //int[] numbers;
        public CustomerManager()
        {
            customers = new Customer[3];
            //customers[0] = new Customer();
            //customers[0].Id = 101;
            //numbers = new int[5];
        }
        public void AddCustomer()
        {
            //Customer customer;
            for (int i = 0; i < 3; i++)
            {
                //customer = new Customer();
                //customer.TakeCustomerDetailsFromUSer();
                customers[i] = new Customer();
                customers[i].TakeCustomerDetailsFromUSer();
            }
        }
        public void PrintCustomerByIndex(int idx)
        {
            if(idx>=0 && idx<customers.Length)
                Console.WriteLine(customers[idx]);
            else
                Console.WriteLine("No such index");
        }
        public void PrintAllCustomers()
        {
            foreach (Customer customer in customers)
            {
                if (customer != null)
                {
                    Console.WriteLine(customer);
                    Console.WriteLine("---------------------");
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idx">index in which the updation has to be done</param>
        /// <param name="customer">The reference that points to the updated customer object</param>
        /// <returns></returns> //      0           newObject
        public bool UpdateCustomer(int idx,Customer customer)
        {
            bool updateStatus = false;
            if (idx >= 0 && idx < customers.Length)
            {
                //customers[idx].Name = customer.Name;
                //customers[idx].Id = customer.Id;
                customers[idx] = customer;
                updateStatus = true;
            }
            else
                Console.WriteLine("No such customer");

            return updateStatus;
        }
        /// <summary>
        /// delete the customer suing the index
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool DeleteCustomer(int idx)
        {
            bool deleteStatus = false;
            if (idx >= 0 && idx < customers.Length)
            {
                customers[idx] = null;
                deleteStatus = true;
            }
            else
                Console.WriteLine("No such index");
            //GC.Collect();
            return deleteStatus;
        }
    }
}
