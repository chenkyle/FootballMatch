using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FootballMatch.Umasou.DBA;
using FootballMatch.Umasou.Util;
using FootballMatch.Umasou.Model;
using System.Collections;

namespace FootballMatch.Umasou.View
{
    public partial class MatchChart : Form
    {
        public MatchChart(MainForm mainForm)
        {
            InitializeComponent();
            this.MdiParent = mainForm;
        }

        #region[窗体事件]
        //窗体加载
        private void MatchChart_Load(object sender, EventArgs e)
        {

        }
        //窗体显示
        private void MatchChart_Shown(object sender, EventArgs e)
        {
            //显示数据
            this.showMatchChart(SystemParam.getMatch());
            //使窗体最大化
            this.WindowState = FormWindowState.Maximized;
        }
        #endregion

        #region[加载数据]
        //获取dataTable
        private DataTable getDataMatchChart(SeasonMatch match)
        {
            //新建一个datatable
            DataTable dataTable = new DataTable();
            //为datatable添加列
            dataTable.Columns.Add("gameName");
            dataTable.Columns.Add("yellowCardNum");
            dataTable.Columns.Add("redCardNum");
            //声明变量
            DataRow dataRow;
            PlayerCardRecord playerCardRecord;
            //取出比赛的所有罚牌记录
            List<PlayerCardRecord> list = MatchCardRecordDAO.getMatchCardRecord(match.getID());
            for (int i = 0; i < list.Count; i++)
            {
                playerCardRecord = list[i];
                dataRow = dataTable.NewRow();
                //设置数据内容
                dataRow["gameName"] = playerCardRecord.getGameName();
                dataRow["yellowCardNum"] = playerCardRecord.getYellowCardNum();
                dataRow["redCardNum"] = playerCardRecord.getRedCardNum();
                //添加数据行
                dataTable.Rows.Add(dataRow);
            }
                //为dataTable添加数据内容
                return dataTable;
        }
        //显示并且绑定chart中的数据源
        private void showMatchChart(SeasonMatch match)
        {
            //获取数据
            DataTable dataTable =default(DataTable);
            dataTable = this.getDataMatchChart(match);
            //绑定数据源
            chart_match.DataSource = dataTable;
            //设置Y轴显示的信息的数据值
            chart_match.Series[0].YValueMembers = "yellowCardNum";
         //   chart_match.Series[1].YValueMembers = "redCardNum";
            //设置chartX轴对应的项目
            chart_match.Series[0].XValueMember = "gameName";
            //绑定数据
            chart_match.DataBind();
        }
        #endregion

        private void chart_match_Click(object sender, EventArgs e)
        {

        }
    }
}
