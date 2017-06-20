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

namespace LivePerformanceCoalitieSimulator
{
    public partial class NieuwPartij : Form
    {
        private PartyRepository _repo;
        public NieuwPartij()
        {
            InitializeComponent();
            _repo = new PartyRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _repo.InsertNewParty(textBox1.Text);
            }
            catch
            {
                MessageBox.Show(@"There was an error, try contacting your system admin");
            }
            Close();
        }
    }
}
