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
    public partial class TeamChart : Form
    {
        public TeamChart(MainForm mainForm)
        {
            InitializeComponent();
            this.MdiParent = mainForm;
        }
    }
}
