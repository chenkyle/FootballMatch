using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FootballMatch.Umasou.Business
{
    public partial class MatchPlayerInfo : Form
    {
        public MatchPlayerInfo(MainForm mainForm)
        {
            InitializeComponent();
            this.MdiParent = mainForm;
        }
    }
}
