using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Assignment3.ClassLib.Connectors
{
    public class MysqlConnector
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

    //Constructor
    public MysqlConnector()
    {
        Initialize();
    }

    //Initialize values
    private void Initialize()
    {
        server = "localhost";
        database = "bookingDB";
        uid = "user";
        password = "P@$$word";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
		database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }

    private bool OpenConnection()
{
    try
    {
        connection.Open();
        return true;
    }
    catch (MySqlException ex)
    {
        //When handling errors, you can your application's response based 
        //on the error number.
        //The two most common error numbers when connecting are as follows:
        //0: Cannot connect to server.
        //1045: Invalid user name and/or password.
        // switch (ex.Number)
        // {
        //     case 0:
        //         MessageBox.Show("Cannot connect to server.  Contact administrator");
        //         break;

        //     case 1045:
        //         MessageBox.Show("Invalid username/password, please try again");
        //         break;
        // }
        return false;
    }
}
    }
}