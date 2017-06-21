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
    public partial class MainForm : Form
    {
        public static Result currentResult;
        private ResultRepository _repo;

        public MainForm()
        {
            InitializeComponent();
            _repo = new ResultRepository();
        }

        private void NieuwUitslagbtn_Click(object sender, EventArgs e)
        {
            Nieuw_Uitslag form = new Nieuw_Uitslag();
            form.Show();
            
        }

        private void UitslagAanpassenbtn_Click(object sender, EventArgs e)
        {
            Nieuw_Uitslag form = new Nieuw_Uitslag(currentResult);
            form.Show();
        }

        private void NieuwPartijbtn_Click(object sender, EventArgs e)
        {
            NieuwPartij form = new NieuwPartij();
            form.Show();
        }

        private void Refresh()
        {
            try
            {
                DataSet ds = new DataSet();
                _repo.FillTable(currentResult).Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Er is geen actieve uitslag. Maak een nieuwe aan!");
            }
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (currentResult != null)
            {
                PartijAanpassen form = new PartijAanpassen();
                form.Show();
            }
            else
            {
                MessageBox.Show("Er is geen uitslag geladen. Maak een uitslaag eerst aan!");
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (currentResult != null)
            {
                CoalitieAanmaken form = new CoalitieAanmaken();
                form.Show();
            }
            else
            {
                MessageBox.Show("Er is geen uitslag geladen. Maak een uitslaag eerst aan!");
            }
        }

    }
}
