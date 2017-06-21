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
    public partial class PartijAanpassen : Form
    {
        private List<Party> currentPartylsit;
        PartyRepository _repo = new PartyRepository();
        
        public PartijAanpassen()
        {
            InitializeComponent();
           
            
            currentPartylsit = MainForm.currentResult.Participatingparties;
            
            
            
            foreach (var party in currentPartylsit)
            {
                comboBox1.Items.Add(party.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var party in currentPartylsit)
            {
                if (party.Name == comboBox1.SelectedItem.ToString())
                {
                    textBox1.Text = party.Name;
                    numericUpDown1.Value = party.Votes;
                    textBox3.Text = party.PartyLeader;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           _repo.
        }
    }
}
