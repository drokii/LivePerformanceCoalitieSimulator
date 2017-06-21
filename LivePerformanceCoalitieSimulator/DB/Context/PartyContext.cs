using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        try
        {
            list = _dbc.GetParties();
        }
        catch
        {
            MessageBox.Show("De database is niet online. Controleer of u verbonden bent met de VPN.");
        }
        
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

    public void UpdateExistingParty(string partyname, int partyvotes, string partyleader)
    {
        string query = "UPDATE result SET votes =" + "'" + Convert.ToString(partyvotes) + "'" + ", leader =" + "'" +
                       partyleader + "'" + "where Party =" + "'" + partyname + "';";
    }

}
