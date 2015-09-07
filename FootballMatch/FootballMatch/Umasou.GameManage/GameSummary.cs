using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FootballMatch.Umasou.Business;
using FootballMatch.Umasou.DBA;
using FootballMatch.Umasou.Model;
using FootballMatch.Umasou.Util;

namespace FootballMatch.Umasou.GameManage
{
    public partial class GameSummary : Form
    {
        public GameSummary(MainForm mainForm)
        {
            InitializeComponent();
            this.MdiParent = mainForm;
        }

        #region[窗体事件]
        //窗体显示
        private void GameSummary_Shown(object sender, EventArgs e)
        {
            //显示数据
            this.showDataInfo(SystemParam.getMatch());
            //使窗体最大化
            this.WindowState = FormWindowState.Maximized;
        }
        #endregion

        #region[表格事件]
        //画表格行
        private void dataGridView_gameInfo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
             System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView_gameInfo.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView_gameInfo.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView_gameInfo.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        #endregion

        #region[显示数据]
        //显示数据到表格中
        private void showDataInfo(SeasonMatch match)
        {
            Game game;  //用来记录信息
            if (dataGridView_gameInfo.Rows.Count > 0)
            {
                dataGridView_gameInfo.Rows.Clear();  //清空表格
            }
            List<Game> list = GameInfoDAO.getMatchGameInfo(match.getID());
            for (int i = 0; i < list.Count; i++)
            {
                game = list[i];
                //往表格中添加记录
                dataGridView_gameInfo.Rows.Add(game.getUniqueID().ToString(), game.getMatchID().ToString(), game.getGameName(),
                    game.getMatchGameNum().ToString(), game.getHomeTeam(), game.getGuestTeam(), game.getGameWinner(),
                    game.getGameResult(), game.getGameAddress(), game.getGameDate().ToLongDateString());
            }
        }
        #endregion
    }
}
