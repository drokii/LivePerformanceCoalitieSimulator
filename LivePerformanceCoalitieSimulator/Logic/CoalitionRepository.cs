using LivePerformanceCoalitieSimulator.DB;
using LivePerformanceCoalitieSimulator.Objects;
using MySql.Data.MySqlClient;

namespace LivePerformanceCoalitieSimulator.Logic
{
    public class CoalitionRepository
    {
        private CoalitionContext _context;

        public CoalitionRepository()
        {
            _context = new CoalitionContext();

        }

        public void InsertCoalition(Coalition coalition, Result result)
        {
            _context.InsertCoalition(coalition, result);
        }

        public MySqlDataAdapter FillTableWithCoalitions(Result result)
        {
           return  _context.FillTableWithCoalitions(result);
        }
    }
}