using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformanceCoalitieSimulator.Objects;
using LivePerformanceCoalitieSimulator.DB;
using MySql.Data.MySqlClient;

class PartyContext
{
    private IDBConnector _dbc = new DBConnectorMySql();

    public List<string> GetPartyNames()
    {
        List<string> partyList = new List<string>();

        List<string>[] list = new List<string>[3];
        list = _dbc.GetParties();
        for (int i = 0; i < list[0].Count; i++)
        {
            partyList.Add(list[0].ElementAt(i));
        }
        return partyList;
    }

    public void InsertNewParty(string partyname)
    {
        string query = "INSERT INTO party(name) value(" + "'" + partyname + "'" + ");";
        _dbc.ExecuteQuery(query);
    }

}
