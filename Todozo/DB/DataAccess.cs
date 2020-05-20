﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Todozo.Models;

// https://www.youtube.com/watch?v=Et2khGnrIqc&list=WL&index=2&t=0s

namespace Todozo
{
    public class DataAccess
    {
        // All that there is to talk to our SQLServer. It is done like so.
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
        public void InsertList(string name)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {

                List<List> taskLists = new List<List>();
                taskLists.Add(new List { Name = name });

                connection.Execute("dbo.Insert_List @Name", taskLists);
            }
        }

        //code that retrieves the list in the database 
        //reminder --> when the user is implemented, only retrieve lists that match the userID

        public List<List> GetLists()
        {
            // With these two lines, we can open a connection to SQL, get data out of it and close that connection. Beautiful code.
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                // Don't use raw SQL statements, use stored procedures that you build in SMSS. 
                // var output = connection.Query<Person>($"select * from People where LastName = '{lastName}'").ToList();

                // In the braces with the string, put the stored procedure!

                //make a stored procedure for selecting data from task 
                List<List> output = connection.Query<List>($"select ListID, Name from List").ToList();
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
                List<Task> output = connection.Query<Task>($"select TaskID, Name, Status, Priority, Description, Deadline from Task where ListID = '{ listID }'").ToList();
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

                string sql = $"UPDATE [Task] SET Status = 1 WHERE TaskID = {taskID}";


                //Need to make a stored procedure and insert the values
                connection.Execute(sql);
            }
        }

        #endregion

        #region User

        public void AddUser(string name, string password)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                List<User> users = new List<User>();
                users.Add(new User { Name = name, Password = password });
                connection.Execute("dbo.AddUser @UserID, @Name, @Password", users);
            }
        }

        public List<User> GetUsers()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
            {
                List<User> output = connection.Query<User>($"SELECT Name, Password FROM [User]").ToList();
                return output;
            }
        }

        //public void CheckLogin(string name, string password)
        //{
        //    using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("LokalTodozo")))
        //    {
        //        //List<User> output = connection
        //        //    .Query<User>($"SELECT * FROM [User] WHERE Name = '{name}' AND Password = '{password}'").ToList();
        //        //return output;

        //        var output = connection.Query<User>($"SELECT * FROM [User] WHERE Name = '{name}' AND Password = '{password}'");
        //        if (output.ToList().ToString() == "1")
        //        {
        //            MessageBox.Show("You have logged in!");
        //        }
        //    }
        //}

        #endregion
    }
}
