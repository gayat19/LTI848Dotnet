using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DatabaseExampleProject
{
    class Program
    {
        SqlConnection conn;
        List<Account> accounts;
        Program()
        {
            try
            {
                //hardcoding the connection
                // conn = new SqlConnection(@"Data Source = DESKTOP-SGS06H0\G3;user id=sa;password=p@ssw0rd123;Initial Catalog = dbTraining");
                //writing in the config file is best practice
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conBank"].ConnectionString);
                //conn.Open();//cehcking if the connection is working
                //Console.WriteLine("Connection opened");
                accounts = new List<Account>();
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
        void GetAccountsFromDatabase()
        {
            SqlDataAdapter da = null;
            DataSet dsAccounts = new DataSet();//collection of tables
            try
            {
                da = new SqlDataAdapter("proc_GetAllAccounts", conn);
                //Adapter adapter my command is a storeed sprocedure
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dsAccounts,"Accounts");//connect->fetch->discon
                Account account = null;
                accounts.Clear();
                foreach (DataRow row in dsAccounts.Tables[0].Rows)//getting all rows in the first table in the dataset
                {//row is a collection of column
                    account = new Account();
                    account.Id = Convert.ToInt32(row[0]);
                    account.Name = row[1].ToString();
                    account.Age = Convert.ToInt32(row["age"]);
                    accounts.Add(account);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        void UpdateTupleInDatabase()
        {
            Account account = new Account();
            Console.WriteLine("Please enter the account number to be edited");
            account.Id = Convert.ToInt32(Console.ReadLine());
            bool isAccountPresent = false;
            GetAccountsFromDatabase();
            //for (int i = 0; i < accounts.Count; i++)
            //{
            //    if(accounts[i].Equals(account))
            //    {
            //        isAccountPresent = true;
            //        break;
            //    }
            //}
            isAccountPresent = accounts.Contains(account);
            if(isAccountPresent)
            {
                int iResult = 0;
                Console.WriteLine("Please enter the name to be updated");
                account.Name = Console.ReadLine();
                Console.WriteLine("Please enter the account holder's updated age");
                account.Age = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmdUpdateAccount = new SqlCommand("proc_UpdateAccount", conn);
                cmdUpdateAccount.CommandType = CommandType.StoredProcedure;
                //Option 1 for adding parameter
                cmdUpdateAccount.Parameters.Add("@acc_num", SqlDbType.Int);
                cmdUpdateAccount.Parameters[0].Value = account.Id;
                cmdUpdateAccount.Parameters.Add("@Acc_name", SqlDbType.VarChar, 20);
                cmdUpdateAccount.Parameters[1].Value = account.Name;
                //Option 2 adding parameter with value
                cmdUpdateAccount.Parameters.AddWithValue("@acc_Age", account.Age);
                try
                {
                    conn.Open();
                    iResult = cmdUpdateAccount.ExecuteNonQuery();//Will return back the numebr of rows affected
                    conn.Close();
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
                if (iResult == 1)
                    Console.WriteLine("Account updated");
                else
                    Console.WriteLine("Some problem. Unable to update");
            }
            else
                Console.WriteLine("No such Account number");
            
        }
        void PrintAllAccounts()
        {
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }
        }
        void UnderstandingConnectedArchType()
        {
            SqlCommand cmd = new SqlCommand("proc_GetAllAccounts", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if (conn.State == ConnectionState.Open)//checking if the connection is open already.
                    conn.Close();//if so then closing the connection

                conn.Open();//Opening the connection
                SqlDataReader dr = cmd.ExecuteReader();
                Account account= null;
                accounts.Clear();
                while (dr.Read())//Read method returns true moves and points to next row and return false if not able to 
                {
                    account = new Account();
                    account.Id = Convert.ToInt32(dr[0]);
                    account.Name = dr[1].ToString();
                    account.Age = Convert.ToInt32(dr["age"]);
                    accounts.Add(account);
                }
                conn.Close();//Explicit close of connection
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
        void InsertAccountToDatabase()
        {
            Account account = new Account();
            account.TakeAccountDetailsFromUser();
            int iResult = 0;
            SqlCommand cmdInsertAccount = new SqlCommand("procInserNewAccount",conn);
            cmdInsertAccount.CommandType = CommandType.StoredProcedure;
            //Option 1 for adding parameter
            cmdInsertAccount.Parameters.Add("@acc_num", SqlDbType.Int);
            cmdInsertAccount.Parameters[0].Value = account.Id;
            cmdInsertAccount.Parameters.Add("@acc_name", SqlDbType.VarChar,20);
            cmdInsertAccount.Parameters[1].Value = account.Name;
            //Option 2 adding parameter with value
            cmdInsertAccount.Parameters.AddWithValue("@acc_age", account.Age);
            try
            {
                conn.Open();
                iResult = cmdInsertAccount.ExecuteNonQuery();//Will return back the numebr of rows affected
                conn.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                    conn.Close();
            }
            if (iResult == 1)
                Console.WriteLine("Account added");
            else
                Console.WriteLine("Some problem. No Account created");
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            //program.GetAccountsFromDatabase();
            program.UpdateTupleInDatabase();
            program.UnderstandingConnectedArchType();
            program.PrintAllAccounts();
            Console.ReadKey();
        }
    }
 
    class Account : IComparable<Account>
    {
        int id, age;
        string name;
        public Account() { }
        public Account(int id,string name,int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return "Account number : "+id+" Name : "+name+" Age : "+age;
        }
        public override bool Equals(object obj)
        {
            Account a1 = this;
            Account a2 = (Account)obj;
            if (a1.id == a2.id)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return (id * 100 + 10);
        }

        public int CompareTo(Account other)
        {
            return this.Name.CompareTo(other.Name);
        }
        public void TakeAccountDetailsFromUser()
        {
            Console.WriteLine("Please enter the account number");
            while (!int.TryParse(Console.ReadLine(),out id))
            {
                Console.WriteLine("Invalid input for account number. Please try again");
            }
            Console.WriteLine("Please enter the account holder's name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the account holder's age");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid input for age. Please try again");
            }
        }
        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
    }
}
