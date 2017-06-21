using System;
using System.Collections.Generic;
using LivePerformanceCoalitieSimulator.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CoalitieTests
    {
        [TestMethod]
        public void TestPremierKeuze()
        {
            Coalition coalition = new Coalition();
            Party party1 = new Party("party1", 5,"Sir");
            Party party2 = new Party("party2", 10, "M'am");
            List<Party> parties = new List<Party>();
            parties.Add(party1);
            parties.Add(party2);
            coalition.JoinParties(parties);
            coalition.DecidePremier();

            Assert.AreEqual("M'am",coalition.Premier,"Premier is not good");
        }

        [TestMethod]
        public void TestJoinPartiesTooMany()
        {
            Coalition coalition = new Coalition();
            Party party1 = new Party("party1", 5, "Sir");
            Party party2 = new Party("party2", 10, "M'am");
            List<Party> parties = new List<Party>();
            parties.Add(party1);
            parties.Add(party2);
            parties.Add(party1);
            parties.Add(party2);
            parties.Add(party1);
            coalition.JoinParties(parties);
            Assert.AreEqual(4, coalition.getParticipatingParties().Count, "Too many parties");
        }
    }


}
