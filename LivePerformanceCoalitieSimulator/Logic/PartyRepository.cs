﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformanceCoalitieSimulator.Objects;

namespace LivePerformanceCoalitieSimulator.Logic
{
    class PartyRepository
    {
        private PartyContext _partycontext;

        public PartyRepository()
        {
            _partycontext = new PartyContext();
        }

        public void InsertNewParty(string partyname)
        {
            _partycontext.InsertNewParty(partyname);
        }

        public void UpdateExistingParty(string partyname, int partyvotes, string partyleader)
        {
            
        }
    }
}
