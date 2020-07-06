using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject
{
    class UserFE
    {
        Predicate<User> userPredicate;
        UserDAO userDAO;
        public UserFE()
        {
            userDAO = new UserDAO();
        }
        void PrintMainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
        }
        void PrintChildMenu()
        {
            Console.WriteLine("Sub Menu");
            Console.WriteLine("1. View All Users");
            Console.WriteLine("2. Update Password");
            Console.WriteLine("3. Back to main menu");
        }
       public void HandleUser()
        {
            int ch = 0;
            int ctr = 0;
            do
            {
                PrintMainMenu();
                ch = Convert.ToInt32(Console.ReadLine());
                User user = null;
               
                try
                {
                    switch (ch)
                    {
                        case 1:
                            user = new User();
                            user.TakeUserData();
                            if(userDAO.InsertUser(user))
                                Console.WriteLine("User Registered");
                            else
                                Console.WriteLine("User not registered");
                            //userPredicate = userDAO.InsertUser;
                            break;
                        case 2:
                            if(ctr<3)
                            {
                                user = new User();
                                user.TakeUserData();
                                if (userDAO.CheckLogin(user))
                                {
                                    Console.WriteLine("you have logged in " + user.Username);
                                    PrintChildMenu();
                                    WorkWithUSer();

                                }
                                else
                                    Console.WriteLine("Invalid username or password");
                            }
                               // userPredicate = userDAO.CheckLogin;
                            else
                            {
                                Console.WriteLine("Exiting...");
                                if (userDAO.DeactivateUser(user))
                                    Console.WriteLine("You have attempted 3 times already");
                                else
                                    ch = 3;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Choice. Please try again");
                            break;
                    }
                   //if( userPredicate != null && userPredicate(user))
                   // {
                   //     PrintChildMenu();
                   //     WorkWithUSer();
                   // }
                   //else
                   // {
                   //     Console.WriteLine("Please login agian");
                   //     ctr++;
                    //}

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (ch!=3);
        }

        private void WorkWithUSer()
        {
            int ch = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (ch)
                {
                    case 1:
                        ListUsers();
                        break;
                    case 2:
                        User user = null;
                        user = new User();
                        user.TakeUserData();
                        if (userDAO.ChangePassword(user))
                            Console.WriteLine("Password Updated");
                        else
                            Console.WriteLine("Some Error");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice. Please try again");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void ListUsers()
        {
            List<User> users = userDAO.GetAllUsers();
            foreach (User user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}

