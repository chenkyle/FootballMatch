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
using CrystalDecisions.CrystalReports.Engine;
using FootballMatch.Umasou.Util;

namespace FootballMatch.Umasou.Business
{
    public partial class DefaultPage : Form
    {
       

        public DefaultPage(MainForm mainForm)
        {
            InitializeComponent();
            this.MdiParent = mainForm;
            SystemParam.setDefaultPageForm(this);
        }

        private void DefaultPage_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void DefaultPage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
           
            this.loadBaseMatchInfo();
            this.UpdateTreeView(DefaultSet.getDefaultMatch(),10);
        }





        //加载赛事下拉列表信息
        private void loadBaseMatchInfo()
        {

            SeasonMatch match;
            //取出所有的赛事信息
            List<SeasonMatch> list = MatchInfoDAO.getMatchInfo();
            //清空下拉列表的数据信息
            comboBox_matchOfDefaultPage.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {//取出赛事信息
                match = list[i];
                //添加到下拉列表
                comboBox_matchOfDefaultPage.Items.Add(match.getName());

          }
 }
        //加载特定赛事的赛季下拉列表信息
        private void loadCertainMatchSeasonInfo(String matchName)
        {

            SeasonOfMatch season;
            //取出所有的赛事信息
            List<SeasonOfMatch> list = SeasonInfoDAO.getSeasonsOfCertainMatch(matchName);
;
            //清空下拉列表的数据信息
            comboBox_SeasonOfDefaultPage.Items.Clear();
             
            for (int i = 0; i < list.Count; i++)
            {//取出赛事信息
                season = list[i];
                //添加到下拉列表
                comboBox_SeasonOfDefaultPage.Items.Add("第 "+season.getNumOfSeason()+" 赛季");

            }



            this.toolStripStatusLabel_currentMatch.Text = matchName;
            this.toolStripStatusLabel_currentSeason.Text = comboBox_SeasonOfDefaultPage.Text;
        }



        private void comboBox_matchOfDefaultPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBox_matchOfDefaultPage.Text;
            comboBox_SeasonOfDefaultPage.Items.Clear();

             this.loadCertainMatchSeasonInfo(name);
        }

         
        

   #region[动态更新比赛条目树]
        //根节点默认存在，默认名称为赛事名称
        public void  UpdateTreeView(string matchName,int numOfSeason){


            if (!treeView_GameReference.Nodes.ContainsKey(matchName))
            {

                treeView_GameReference.Nodes.Clear();
                TreeNode root = new TreeNode(matchName);
                treeView_GameReference.Nodes.Add(root);
                for (int i = 1; i < numOfSeason; i++)
                {
                    TreeNode node = new TreeNode("第"+i+"个一级节点");
                    node.Name = "节点" + i;
                    root.Nodes.Add(node);
 
                  }

            }

            else MessageBox.Show("已经存在根节点");
        
        }
        
        #endregion








    }
}
