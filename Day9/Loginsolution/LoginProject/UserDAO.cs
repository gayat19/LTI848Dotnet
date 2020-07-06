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
    class UserDAO
    {
        SqlConnection conn;
        public UserDAO()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conUser"].ConnectionString);
        }
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            SqlDataAdapter daUser = new SqlDataAdapter();
            daUser.SelectCommand = new SqlCommand("proc_GetAllUsers");
            daUser.SelectCommand.CommandType = CommandType.StoredProcedure;
            daUser.SelectCommand.Connection = conn;
            DataSet dsUsers = new DataSet();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            daUser.Fill(dsUsers, "Users");
            if (dsUsers.Tables[0].Rows.Count == 0)
            {
                Console.WriteLine("No User in table");
            }
            else
            {
                User user = null; 
                foreach (DataRow dr in dsUsers.Tables[0].Rows)
                {
                    user = new User();
                    user.Username = dr[0].ToString();
                    user.Password = dr[1].ToString();
                    user.Status = Convert.ToInt32(dr[2].ToString());
                    users.Add(user);
                }
            }
            return users;
        }
        public bool InsertUser(User user)
        {
            bool inserted = false;
            SqlCommand cmdInsert = new SqlCommand("proc_InsertUser", conn);
            cmdInsert.CommandType = CommandType.StoredProcedure;
            cmdInsert.Parameters.AddWithValue("@uname", user.Username);
            cmdInsert.Parameters.AddWithValue("@pass", user.Password);
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            if (cmdInsert.ExecuteNonQuery() > 0)
                inserted = true;
            conn.Close();
            return inserted;
        }
        public bool CheckLogin(User user)
        {
            bool allowLogIn = false;
            SqlCommand cmdCheckUser = new SqlCommand("proc_CheckUser", conn);
            cmdCheckUser.CommandType = CommandType.StoredProcedure;
            cmdCheckUser.Parameters.AddWithValue("@uname", user.Username);
            cmdCheckUser.Parameters.AddWithValue("@pass", user.Password);
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlDataReader drUser = cmdCheckUser.ExecuteReader();
            if(drUser.Read())
            {
                User u = new User();
                u.Username = drUser[0].ToString();
                if (Convert.ToInt32(drUser[2].ToString()) == 1)
                    allowLogIn = true;
                else
                {
                    cmdCheckUser.Cancel();
                    throw new InactiveUserException();
                }
                    
            }
            conn.Close();
            return allowLogIn;
        }
        public bool ChangePassword(User user)
        {
            bool passwordUpdated = false;
            SqlCommand cmdUpdatePasword = new SqlCommand("proc_UpdatePasword", conn);
            cmdUpdatePasword.CommandType = CommandType.StoredProcedure;
            cmdUpdatePasword.Parameters.AddWithValue("@uname", user.Username);
            cmdUpdatePasword.Parameters.AddWithValue("@pass", user.Password);
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlDataReader drUser = cmdUpdatePasword.ExecuteReader();
            if (cmdUpdatePasword.ExecuteNonQuery() > 0)
                passwordUpdated = true;
            conn.Close();
            return passwordUpdated;
        }
        public bool DeactivateUser(User user)
        {
            bool passwordUpdated = false;
            SqlCommand cmdUpdateStatus = new SqlCommand("proc_deactivateUser", conn);
            cmdUpdateStatus.CommandType = CommandType.StoredProcedure;
            cmdUpdateStatus.Parameters.AddWithValue("@uname", user.Username);
            conn.Open();
            SqlDataReader drUser = cmdUpdateStatus.ExecuteReader();
            if (cmdUpdateStatus.ExecuteNonQuery() > 0)
                passwordUpdated = true;
            conn.Close();
            return passwordUpdated;
        }
    }
}
