using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Todozo.Models;

// https://www.youtube.com/watch?v=Et2khGnrIqc&list=WL&index=2&t=0s

namespace Todozo
{
    public class DataAccess
    {
        // All that there is to talk to our SQLServer. It is done like so
        public List<Task> GetListOfTasks(int listID)
        {
            // With these two lines, we can open a connection to SQL, get data out of it and close that connection. Beautiful code.
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                // Don't use raw SQL statements, use stored procedures that you build in SMSS. 
                // var output = connection.Query<Person>($"select * from People where LastName = '{lastName}'").ToList();

                // In the braces with the string, put the stored procedure!

                //make a stored procedure for selecting data from task 
                List<Task> output = connection.Query<Task>("dbo.GetByListID @ListID", new { ListID = listID }).ToList();
                return output;
            }
        }



        #region List 

        //code that inserts lists in the database 
        public void InsertList(string name, int userID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {

                List<List> taskLists = new List<List>();
                taskLists.Add(new List { Name = name, UserID = userID });

                connection.Execute("dbo.Insert_List @Name, @UserID", taskLists);
            }
        }

        public void UpdateList(int listID, string name)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                // Two ways of doing it:
                // var newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber};

                List<List> lists = new List<List>();
                lists.Add(new List { ListID = listID, Name = name});

                //Need to make a stored procedure and insert the values
                connection.Execute("dbo.Update_List @ListID, @Name", lists);

            }

        }

        public void DeleteList(int listID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                // Two ways of doing it:
                // var newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber};
                List<List> lists = new List<List>();
                lists.Add(new List { ListID = listID});

                //Need to make a stored procedure and insert the values
                connection.Execute("dbo.Delete_List @ListID", lists);


            }

        }

        //code that retrieves the list in the database 
        //reminder --> when the user is implemented, only retrieve lists that match the userID

        public List<List> GetLists(int userID)
        {
            // With these two lines, we can open a connection to SQL, get data out of it and close that connection. Beautiful code.
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                // Don't use raw SQL statements, use stored procedures that you build in SMSS. 
                // var output = connection.Query<Person>($"select * from People where LastName = '{lastName}'").ToList();

                // In the braces with the string, put the stored procedure!


                //make a stored procedure for selecting data from task 
                //List<List> output = connection.Query<List>($"SELECT ListID, Name FROM List INNER JOIN [User] ON List.{UserID} = [User].UserID").ToList(); 
                List<List> output = connection.Query<List>($"dbo.Get_Lists @UserID", new { UserID = userID } ).ToList();
                return output;
            }
        }



        #endregion

        #region Task 

        //code that inserts tasks into the database
        public void InsertTask(int listID, string name, string description, DateTime date, int priority, bool status)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                // Two ways of doing it:
                // var newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber};
                List<Task> tasks = new List<Task>();
                tasks.Add(new Task { ListID = listID, Status = status, Name = name, Description = description, Deadline = date, Priority = priority });

                //Need to make a stored procedure and insert the values
                connection.Execute("dbo.Insert_Task @ListID, @Status, @Name, @Description, @Deadline, @Priority", tasks);
            }
        }



        //code that retrieves tasks from the database that matches the listID 
        //reminder --> need to replace the sql statement with a stored procedure 
        public List<Task> GetTasks(int listID)
        {
            // With these two lines, we can open a connection to SQL, get data out of it and close that connection. Beautiful code.
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                // Don't use raw SQL statements, use stored procedures that you build in SMSS. 
                // var output = connection.Query<Person>($"select * from People where LastName = '{lastName}'").ToList();

                // In the braces with the string, put the stored procedure!

                //make a stored procedure for selecting data from task 
                List<Task> output = connection.Query<Task>($"dbo.Get_Tasks @ListID", new { ListID = listID }).ToList();
                return output;
            }
        }

        //code that sets the status of a task to complete 
        public void InsertStatus(int taskID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                // Two ways of doing it:
                // var newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber};

                List<Task> tasks = new List<Task>();

                tasks.Add(new Task { TaskID = taskID });

                connection.Execute("dbo.Update_Task_Status @TaskID", tasks);


                //Need to make a stored procedure and insert the values
            }
        }

        public void DeleteTask(int taskID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                // Two ways of doing it:
                // var newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber};

                List<Task> tasks = new List<Task>();
                tasks.Add(new Task { TaskID = taskID });

                //Need to make a stored procedure and insert the values
                connection.Execute("dbo.Delete_Task @TaskID", tasks);
            }
        }

        public void UpdateTask(int taskID, string name, string description, DateTime date, int priority)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                // Two ways of doing it:
                // var newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber};

                List<Task> tasks = new List<Task>();
                tasks.Add(new Task { TaskID = taskID, Name = name, Description = description, Deadline = date, Priority = priority });

                //Need to make a stored procedure and insert the values
                connection.Execute("dbo.Update_Task @TaskID, @Name, @Description, @Deadline, @Priority", tasks);
            }
        }

        #endregion

        #region User


        // If you hash a string (or other data) you will receive a string that is impossible to transform back to it's original form.
        // But the key thing is that you will always get the same result if you use the same hash algorithm.
        public static string HashSHA1(string value)
        {
            // I'm using SHA-1 which will return a string with a length of 40 no matter what the input value is. If you hash a megabyte of plain text, the hash would still be 40 characters long. 
            var sha1 = System.Security.Cryptography.SHA1.Create();
            var inputBytes = Encoding.ASCII.GetBytes(value);
            var hash = sha1.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            for (var i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }

        public void AddUser(string name, string password)
        {

            // First create a new Guid for the user. This will be unique for each user.
            Guid userGuid = Guid.NewGuid();

            // Hash the password together with our unique userGuid.
            string hashedPassword = HashSHA1(password + userGuid.ToString());

            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                List<User> users = new List<User>();
                users.Add(new User { Name = name, Password = hashedPassword, UserGuid = userGuid });
                connection.Execute($"dbo.AddUser @UserID, @Name, @Password, @UserGuid", users);
            }
        }

        public List<User> GetUsers()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                List<User> output = connection.Query<User>($"dbo.Get_Users").ToList();
                return output;
            }
        }

        public List<User> CheckLogin(string name)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                List<User> output = connection.Query<User>($"dbo.Check_User_Login @Name", new { Name = name }).ToList();
                return output;
            }
        }

        public void DeleteUser(int userID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {

                


                //Need to make a stored procedure and insert the values
                connection.Execute($"dbo.Delete_User @UserID", new { UserID = userID });
            }
        
        }

        #endregion
    }
}
