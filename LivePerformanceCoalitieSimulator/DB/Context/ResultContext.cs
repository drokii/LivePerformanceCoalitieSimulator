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

        public void InsertResults(Result result)
        {
            _db.InsertResult(result);
        }

        public MySqlDataAdapter FillTableWithResults(Result result)
        {
            string query = "SELECT Party, Seats, PercentVotes FROM result WHERE Election = " + "'" + result.Name + "'";
            return _db.FillTable(query);
        }
        
    }
}
