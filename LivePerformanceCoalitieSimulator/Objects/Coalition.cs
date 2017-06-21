using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceCoalitieSimulator.Objects
{
    public class Coalition
    {
        private List<Party> participatingParties;
        public int TotalSeats { get; set; }
        public string Premier { get; private set; }
        public string Name { get; set; }
        public bool HasMajority { get; set; }

        public Coalition()
        {
            participatingParties = new List<Party>();
        }

        public void JoinParties(List<Party> Parties)
        {
            foreach (var party in Parties)
            {
                if (participatingParties.Count < 4)
                {
                    participatingParties.Add(party);
                    TotalSeats += party.Seats;
                }
                
            }
            
        }

        public void DecidePremier()
        {
            participatingParties = participatingParties.OrderByDescending(p => p.Votes).ToList();
            Premier = participatingParties.ElementAt(0).PartyLeader;
        }

        public void ExportCoalition()
        {
            
            try
            {
                
                using (StreamWriter streamWriter = new StreamWriter(@"\"+Name+".txt"))
                {
                    streamWriter.WriteLine("Coalitievoorstel");
                    streamWriter.WriteLine("Partij                    Zetels                   Lijsttrekker");
                    foreach (Party party in participatingParties)
                    {
                        streamWriter.WriteLine(party.ToString());
                    }
                    streamWriter.WriteLine();
                    streamWriter.WriteLine("De Premier van deze coalitie is: " + Premier);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Party> getParticipatingParties()
        {
            return participatingParties;
        }
    }
}
