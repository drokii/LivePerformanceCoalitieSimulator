using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceCoalitieSimulator.Objects
{
    class Coalition
    {
        private List<Party> participatingParties;
        public int TotalVotes { get; set; }
        private PartyLeader Premier;

        public Coalition()
        {
            participatingParties = new Party[4];
        }

        public void JoinParty(Party[] Parties)
        {
            foreach (var party in Parties)
            {
                if (participatingParties.Count <= 4)
                {
                    participatingParties.Add(party);
                }
                
            }
        }

        public void SlaSpelOp(string path)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    
                    foreach (Party party in participatingParties)
                    {
                        streamWriter.WriteLine(party.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
