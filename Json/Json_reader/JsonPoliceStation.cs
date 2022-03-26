using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Json_reader
{
    public partial class JsonPoliceStation : Form
    {
        public JsonPoliceStation()
        {
            InitializeComponent();
        }

        private void JsonPoliceStation_Load(object sender, EventArgs e)
        {

            Policemen_dataGridView.DataSource = Program.Policemen;
            Prisoners_dataGridView.DataSource = Program.Prisoners;
            Prisonroom_dataGridView.DataSource = Program.Prisonrooms;
        }
    }
}
