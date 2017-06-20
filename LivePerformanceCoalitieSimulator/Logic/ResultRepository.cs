using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformanceCoalitieSimulator.DB;
using LivePerformanceCoalitieSimulator.DB.Context;
using LivePerformanceCoalitieSimulator.Objects;
using MySql.Data.MySqlClient;

namespace LivePerformanceCoalitieSimulator.Logic
{
    public class ResultRepository
    {
        private PartyContext _partycontext;
        private ResultContext _resultcontext;

        public ResultRepository()
        {
            _partycontext = new PartyContext();
            _resultcontext = new ResultContext();
        }

        public List<string> FillPartyNames()
        {

            return _partycontext.GetPartyNames();
        }

        public void InsertResult(Result result)
        {
            _resultcontext.InsertResult(result);
        }

        public MySqlDataAdapter FillTable(Result result)
        {
           return _resultcontext.FillTableWithResults(result);
        }
    }

}
