using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceCoalitieSimulator.Objects
{
    public class Party
    {
        
        public string Name { get; set; }
        public int Votes { get; set; }
        public int Seats { get; set; }
        public string  PartyLeader { get; set; }

        public Party(string name, int votes, string partyleader)
        {
            PartyLeader = partyleader;
            Name = name;
            Votes = votes;
        }
    }
}
