using System;
using LivePerformanceCoalitieSimulator.Objects;
using MySql.Data.MySqlClient;

namespace LivePerformanceCoalitieSimulator.DB.Context
{
    class ResultContext
    {
        private IDBConnector _db;

        public ResultContext()
        {
            _db = new DBConnectorMySql();
        }

        public MySqlDataAdapter FillTableWithResults(Result result)
        {
            string query = "SELECT Party, Seats, PercentVotes FROM result WHERE Election = " + "'" + result.Name + "'";
            return _db.FillTable(query);
        }

        public void InsertResult(Result result)
        { // delets from same election in case of update, otherwise inserts.
            foreach (var party in result.Participatingparties)
            {
                decimal seatcalc = (decimal) party.Votes / (decimal) result.TotalVotes;
                decimal percentvotescalc = (decimal) party.Votes / (decimal) result.TotalVotes;
                int seats = Convert.ToInt32(result.TotalSeats * seatcalc);
                int percentvotes = Convert.ToInt32(percentvotescalc * 100);
                party.Seats = seats;
                string query ="DELETE FROM result WHERE Election ="+"'"+" result.Name"+"';" +
                    "INSERT INTO `result` (`Election`, `TotalSeats`, `Party`,`Leader`, `Votes`, `Seats`, `PercentVotes`, `DateElection`) VALUES(" +
                    "'" + result.Name + "'" + ", " + 
                    "'" + Convert.ToString(result.TotalSeats) + "'" + "," + 
                    "'" + party.Name + "'" + ", " +
                    "'" + party.PartyLeader + "'" + ", " +
                    "'" + Convert.ToString(party.Votes) + "'" + "," + 
                    "'" + Convert.ToString(party.Seats) + "'" + ", " +
                    "'" + Convert.ToString(percentvotes) + "'" + "," + 
                    "'" + result.Date.ToString("yyyy-MM-dd") +"'" +
                    ");";
                _db.ExecuteQuery(query);
            }
        }
    }
}
