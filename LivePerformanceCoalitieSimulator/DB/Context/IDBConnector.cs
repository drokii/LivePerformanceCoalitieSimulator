using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformanceCoalitieSimulator.Objects;
using MySql.Data.MySqlClient;

namespace LivePerformanceCoalitieSimulator.DB
{
    interface IDBConnector
    {
        MySqlDataAdapter FillTable(string query);
        List<string>[] GetParties();
        List<string>[] GetCoalitions();
        void InsertResult(Result result);
        void InsertNewParty(string partyname);
    }
}
