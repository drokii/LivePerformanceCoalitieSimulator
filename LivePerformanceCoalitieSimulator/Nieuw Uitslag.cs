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
    public partial class Nieuw_Uitslag : Form
    {
        private ResultRepository _repo;

        private readonly List<Party> partyList;
        public Nieuw_Uitslag()
        {
            InitializeComponent();
            partyList = new List<Party>();
            _repo = new ResultRepository();
            foreach (var partyname in _repo.FillPartyNames())
            {
                PartijnaamCb.Items.Add(partyname);
            }
        }

        public Nieuw_Uitslag(Result result)
        {
            InitializeComponent();
            //Constructor from result to edit parties

            NaamVerkiezingTb.Text = result.Name;
            DatumDtp.Value = result.Date;
            partyList = result.Participatingparties;
            foreach (var party in result.Participatingparties)
            {
                GeselecteerdePartijenListbox.Items.Add(party.Name);
            }
        }
        private void InvoerenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var party in partyList)
                {
                    if (party.Name == PartijnaamCb.SelectedItem.ToString())
                    {
                        partyList.RemoveAt(partyList.IndexOf(party));
                    }

                }

                Party newparty = new Party(PartijnaamCb.Text, decimal.ToInt32(AantalStemmenNum.Value),
                    LijsttrekkerTb.Text);

                GeselecteerdePartijenListbox.Items.Add(newparty.Name);
                
                partyList.Add(newparty);
            }
            catch
            {
                MessageBox.Show(@"Deze partij bestaat al in uw uitslag.");
            }

        }

        private void KlaarBtn_Click(object sender, EventArgs e)
        {
            Result result = new Result(NaamVerkiezingTb.Text, DatumDtp.Value,
                                       decimal.ToInt32(AantalZetelsNumPicker.Value), partyList);
            _repo.InsertResult(result);
            MainForm.currentResult = result;

            foreach (var party in partyList)
            {
                party.CalculateSeats(MainForm.currentResult);

            }
            Close();

        }

        private void GeselecteerdePartijenListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var party in partyList)
            {
                if (party.Name == GeselecteerdePartijenListbox.SelectedItem.ToString())
                {
                    LijsttrekkerTb.Text = party.PartyLeader;
                    AantalStemmenNum.Value = party.Votes;

                }
            }
        }
    }
}
