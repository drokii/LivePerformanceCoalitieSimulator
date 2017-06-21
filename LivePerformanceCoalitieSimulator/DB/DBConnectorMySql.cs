using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformanceCoalitieSimulator.Objects;
using MySql.Data.MySqlClient;

namespace LivePerformanceCoalitieSimulator.DB
{
    class DBConnectorMySql : IDBConnector
    {
        private MySqlConnection _connection;
        private string _server;
        private string _database;
        private string _uid;
        private string _password;
        string _connectionString;

        public DBConnectorMySql()
        {
            Initialize();
        }

        private void Initialize()
        {
            _server = "studmysql01.fhict.local;";
            _database = "dbi369519";
            _uid = "dbi369519";
            _password = "unityhost";
            _connectionString = "SERVER=" + _server + ";" + "DATABASE=" +
                                _database + ";" + "UID=" + _uid + ";" + "PASSWORD=" + _password + ";";
            _connection = new MySqlConnection(_connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        throw new ArgumentException(ex.Message);
                    case 1045:
                        throw new ArgumentException(ex.Message);

                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public MySqlDataAdapter FillTable(string query)
        {
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, _connection);

            return mySqlDataAdapter;
        }


        public List<string>[] GetParties()
        {
            string query = "SELECT * FROM Party";

            //Create a list to store the result

            List<string>[] listOfLists = new List<string>[3];
            listOfLists[0] = new List<string>();
            listOfLists[1] = new List<string>();



            if (OpenConnection())
            {
                try
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, _connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    ;
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        listOfLists[0].Add(dataReader["Name"] + "");
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    CloseConnection();

                    //return list to be displayed
                    return listOfLists;
                }
                catch (MySqlException e)
                {

                    throw new Exception(e.Message);

                }
            }
            else
            {
                return null;
            }
        }


        public void ExecuteQuery(string query)
        {
            //open connection
            if (OpenConnection())
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, _connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

    }
}
