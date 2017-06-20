﻿using System;
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
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query , _connection);

            return mySqlDataAdapter;
        }


        public List<string>[] GetParties()
        {
            string query = "SELECT p.Name, pl.Name AS partyleader FROM Party P LEFT JOIN PartyLeader pl ON pl.Party = p.Name";

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
                        listOfLists[1].Add(dataReader["partyleader"] + "");

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

        public List<string>[] GetCoalitions()
        {
            throw new NotImplementedException();
        }


        public void InsertResult(Result result)
        {
            foreach (var party in result.Participatingparties)
            {
                decimal seatcalc = (decimal)party.Votes / (decimal)result.TotalVotes;
                decimal percentvotescalc = (decimal)party.Votes / (decimal)result.TotalVotes;
                int seats = Convert.ToInt32(result.TotalSeats * seatcalc);
                int percentvotes = Convert.ToInt32(percentvotescalc * 100);

                string query = "INSERT INTO `result` (`Election`, `TotalSeats`, `Party`, `Votes`, `Seats`, `PercentVotes`, `DateElection`) VALUES("+"'"+  result.Name +"'" + ", " + "'" + Convert.ToString(result.TotalSeats) + "'" + "," + "'" +
                                        party.Name + "'" + ", " + "'" + Convert.ToString(party.Votes) + "'" + "," + "'"
                                        + Convert.ToString(seats) + "'" + ", " + "'"
                                        + Convert.ToString(percentvotes) + "'" + "," + "'" + result.Date.ToString("yyyy-MM-dd") + "'" + ");";

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

        public void InsertNewParty(string partyname)
        {
            string query = "INSERT INTO party(name) value(@partyname)";


            //open connection
            if (OpenConnection())
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@partyname", partyname);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

    }
}
