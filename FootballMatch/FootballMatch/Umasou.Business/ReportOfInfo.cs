using FootballMatch.Umasou.DBA;
using FootballMatch.Umasou.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballMatch.Umasou.Business
{
    public partial class ReportOfInfo : Form
    {
        public ReportOfInfo(MainForm mainForm)
        {
            InitializeComponent();
            this.MdiParent = mainForm;
        }

        private void ReportOfInfo_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.showDedaultSet();
        }

        public void showDedaultSet(){

            
            DefaultSetDAO.getDefaultSet();
            label_match.Text = "赛事："+DefaultSet.getDefaultMatch();
            label_season.Text = "第"+DefaultSet.getDefaultSeason()+"赛季";
            label_Turn.Text = "第"+Convert.ToString(DefaultSet.getDefaultTurn())+"轮";
        }
          
    }
}
