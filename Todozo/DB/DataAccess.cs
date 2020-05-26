using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Todozo.Models;

namespace Todozo
{
    /// <summary>
    /// Methods that interact with the database. Here, everytime we want to manipulate something inside the database, we only do it on the click events.
    /// We never have open connections. Here are all the methods with the stored procedures.
    /// </summary>
    public class DataAccess
    {
        #region List 

        public void InsertList(string name, int userID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                var taskLists = new List<List> { new List { Name = name, UserID = userID } };
                connection.Execute("dbo.Insert_List @Name, @UserID", taskLists);
            }
        }

        public void UpdateList(int listID, string name)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                var lists = new List<List> { new List { ListID = listID, Name = name } };
                connection.Execute("dbo.Update_List @ListID, @Name", lists);
            }

        }

        public void DeleteList(int listID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                var lists = new List<List> {new List {ListID = listID}};
                connection.Execute("dbo.Delete_List @ListID", lists);
            }
        }

        public List<List> GetLists(int userID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                var output = connection.Query<List>($"dbo.Get_Lists @UserID", new { UserID = userID }).ToList();
                return output;
            }
        }

        #endregion

        #region Task 

        public void InsertTask(int listID, string name, string description, DateTime date, int priority, bool status)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                var tasks = new List<Task>();
                tasks.Add(new Task { ListID = listID, Status = status, Name = name, Description = description, Deadline = date, Priority = priority });
                connection.Execute("dbo.Insert_Task @ListID, @Status, @Name, @Description, @Deadline, @Priority", tasks);
            }
        }

        public List<Task> GetTasks(int listID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                var output = connection.Query<Task>($"dbo.Get_Tasks @ListID", new { ListID = listID }).ToList();
                return output;
            }
        }

        public void InsertStatus(int taskID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                var tasks = new List<Task> {new Task {TaskID = taskID}};
                connection.Execute("dbo.Update_Task_Status @TaskID", tasks);
            }
        }

        public void DeleteTask(int taskID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                var tasks = new List<Task> {new Task {TaskID = taskID}};
                connection.Execute("dbo.Delete_Task @TaskID", tasks);
            }
        }

        public void UpdateTask(int taskID, string name, string description, DateTime date, int priority)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                var tasks = new List<Task>();
                tasks.Add(new Task { TaskID = taskID, Name = name, Description = description, Deadline = date, Priority = priority });
                connection.Execute("dbo.Update_Task @TaskID, @Name, @Description, @Deadline, @Priority", tasks);
            }
        }

        #endregion

        #region User

        // We hash the password so we get a string in the database that is impossible to transform back into the original string.
        public static string HashSHA1(string value)
        {
            // I'm using SHA-1 which will return a string with a length of 40 no matter what the input value is.
            var sha1 = System.Security.Cryptography.SHA1.Create();
            var inputBytes = Encoding.ASCII.GetBytes(value);
            var hash = sha1.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            for (var i = 0; i < hash.Length; i++)
            {
                sb.Append(i.ToString("X2"));
            }
            return sb.ToString();
        }

        public void AddUser(string name, string password)
        {
            // First create a new Guid for the user. This will be unique for each user.
            var userGuid = Guid.NewGuid();

            // Hash the password together with our unique userGuid.
            var hashedPassword = HashSHA1(password + userGuid);

            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                var users = new List<User> {new User {Name = name, Password = hashedPassword, UserGuid = userGuid}};
                connection.Execute($"dbo.AddUser @UserID, @Name, @Password, @UserGuid", users);
            }
        }

        public List<User> GetUsers()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                var output = connection.Query<User>($"dbo.Get_Users").ToList();
                return output;
            }
        }

        public List<User> CheckLogin(string name)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                var output = connection.Query<User>($"dbo.Check_User_Login @Name", new { Name = name }).ToList();
                return output;
            }
        }

        public void DeleteUser(int userID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                connection.Execute($"dbo.Delete_User @UserID", new { UserID = userID });
            }

        }

        #endregion
    }
}
