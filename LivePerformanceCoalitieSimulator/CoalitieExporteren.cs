using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformanceCoalitieSimulator
{
    public partial class CoalitieExporteren : Form
    {
        public CoalitieExporteren()
        {
            InitializeComponent();
            foreach (var coalition in MainForm.Coalitions)
            {
                comboBox1.Items.Add(coalition.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var coalition in MainForm.Coalitions)
            {
                if (coalition.Name == comboBox1.SelectedItem.ToString())
                {
                    string filePath = null;
                    FolderBrowserDialog fbd = new FolderBrowserDialog();   

                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        filePath = fbd.SelectedPath;
                    }
                    try
                    {
                        coalition.ExportCoalition(filePath);
                        Close();
                    }
                    catch
                    {
                        MessageBox.Show(
                            "De tekstbestand kon niet geexporteerd worden. Contacteer onze klantenservice voor hulp.");
                        
                    }
                    
                }
            }
        }
    }
}
