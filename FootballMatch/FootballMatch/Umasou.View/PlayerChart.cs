using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FootballMatch.Umasou.View
{
    public partial class PlayerChart : Form
    {
        public PlayerChart(MainForm mainForm)
        {
            InitializeComponent();
            this.MdiParent = mainForm;
        }

        private void chart_player_Click(object sender, EventArgs e)
        {

        }
    }
}
