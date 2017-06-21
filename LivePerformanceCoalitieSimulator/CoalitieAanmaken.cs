using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformanceCoalitieSimulator.Logic;
using LivePerformanceCoalitieSimulator.Objects;

namespace LivePerformanceCoalitieSimulator
{
    public partial class CoalitieAanmaken : Form
    {
        private List<Party> participatingParties;
        private List<Party> partiesForCoalition;
        private CoalitionRepository _repo;

        private Coalition currentCoalition;

        public CoalitieAanmaken()
        {
            InitializeComponent();
            participatingParties = MainForm.currentResult.Participatingparties;
            _repo = new CoalitionRepository();
            currentCoalition = new Coalition();
            partiesForCoalition = new List<Party>();
            foreach (var party in participatingParties)
            {
                listBox1.Items.Add(party.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (var party in participatingParties)
            {
                if (party.Name == listBox1.SelectedItem.ToString())
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    currentCoalition.TotalSeats += party.Seats;
                    partiesForCoalition.Add(party);
                    partiesForCoalition.OrderByDescending(p => p.Votes);
                    premierlabel.Text = partiesForCoalition.ElementAt(0).PartyLeader;
                } 

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && listBox2.Items.Count >= 2)
            {
                currentCoalition.Name = textBox1.Text;
                currentCoalition.JoinParties(partiesForCoalition);
                currentCoalition.DecidePremier();
                MainForm.Coalitions.Add(currentCoalition);
                _repo.InsertCoalition(currentCoalition, MainForm.currentResult);
                Close();
            }
            else
            {
                MessageBox.Show("Vul een naam voor uw coalitie in, en tenminste 2 partijen");
            }

        }
    }
}
