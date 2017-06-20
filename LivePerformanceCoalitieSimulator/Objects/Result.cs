using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceCoalitieSimulator.Objects
{
    public class Result
    {
        private List<Coalition> ParticipatingCoalitions;
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<Party> Participatingparties { get; }
        public int TotalSeats { get; set; }
        public int TotalVotes { get; set; }

        public Result(string name, DateTime date, int totalseats, List<Party> participatingparties)
        {
            Name = name;
            Date = date;
            TotalSeats = totalseats;
            Participatingparties = participatingparties;
            foreach (var party in participatingparties)
            {
                TotalVotes += party.Votes;
            }
        }
        

    }
}
