using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using LivePerformanceCoalitieSimulator.DB;
using LivePerformanceCoalitieSimulator.Objects;
using MySql.Data.MySqlClient;

namespace LivePerformanceCoalitieSimulator.DB
{
    class CoalitionContext
    {
        private IDBConnector _db;

        public CoalitionContext()
        {
            _db = new DBConnectorMySql();
        }

        public void InsertCoalition(Coalition coalition, Result result)
        {
            bool hasmajority = coalition.TotalSeats > result.TotalSeats / 2;
            coalition.HasMajority = hasmajority;
            
            StringBuilder builder = new StringBuilder();
            foreach (var party in coalition.getParticipatingParties())
            {
                builder.Append("'" + party.Name + "',");
            }
            if (coalition.getParticipatingParties().Count < 4)
            {
                for (int i = 0; i < 4 - coalition.getParticipatingParties().Count; i++)
                {
                    builder.Append("NULL,");
                }
                
            }
            // stringbuilder edits the string so that it only inserts the parties of the coalition correctly
            var partynames = builder.ToString();
            string query =
                "INSERT INTO `Coalition` (`Name`,`Premier`,`TotalSeats`, `Party1`, `Party2`,`Party3`, `Party4`, `HasMajority`, `Election`) VALUES(" +
                "'" + coalition.Name + "'" + ", " +
                "'" + coalition.Premier + "'" + ", " +
                "'" + Convert.ToString(coalition.TotalSeats) + 
                "'," + partynames +
                "'" + hasmajority + "'" + "," +
                "'" + result.Name + "'" +
                ");";
            _db.ExecuteQuery(query);


        }

        public MySqlDataAdapter FillTableWithCoalitions(Result result)
        {
            string query = "SELECT Name, Premier, TotalSeats, Party1,Party2,Party3,Party4, HasMajority FROM Coalition WHERE Election = " + "'" + result.Name + "' ORDER BY TotalSeats";
            return _db.FillTable(query);
        }
    }
}
