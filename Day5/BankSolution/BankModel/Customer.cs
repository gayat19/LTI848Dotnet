using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class Customer
    {
        int id;
        string name, phone;

        public Customer()
        { 
        }
        public Customer(int id,string name,string phone)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
        }
        public void TakeCustomerDetailsFromUSer()
        {
            Console.WriteLine("Please enter the customer id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the customer name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the cutsomer phoone");
            phone = Console.ReadLine();
        }
        public override string ToString()
        {
            return "ID = " + id + " Name : " + name + " phone : " + phone;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
