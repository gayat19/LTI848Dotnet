using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace LoginProject
{
    class TransactionExample
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conUser"].ConnectionString);
            conn.Open();
            SqlTransaction tran = conn.BeginTransaction();//brgin in tran
            SqlCommand cmd = conn.CreateCommand();//cmd start
            cmd.Transaction = tran;
            try
            {
                cmd.CommandText = "Insert into Users values('Yomu','2222',default)";//DML 1
                cmd.ExecuteNonQuery();//DML1 execution
                cmd.CommandText = "Insert into Users values('Gimu','2222',default)";//DML2
                cmd.ExecuteNonQuery();//DML2 Execution
                tran.Commit();//Tran commit
                Console.WriteLine("Inserted 2 records");
            }
            catch (Exception oe)
            {
                try
                {
                    Console.WriteLine(oe.Message);
                    tran.Rollback();//Tran Rollback
                    Console.WriteLine("None of the records inserted");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
