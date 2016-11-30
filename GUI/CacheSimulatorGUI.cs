using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CacheSimulatorGUI : Form
    {
        public CacheSimulatorGUI()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CacheSimulatorGUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cacheDatabaseDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter1.Fill(this.cacheDatabaseDataSet1.Table);
            // TODO: This line of code loads data into the 'cacheDatabaseData.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.cacheDatabaseData.Table);

        }
    }
}
