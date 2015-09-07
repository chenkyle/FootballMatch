using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FootballMatch.Umasou.DBA;
using FootballMatch.Umasou.Model;
using FootballMatch.Umasou.Util;

namespace FootballMatch.Umasou.Business
{
    public partial class SelectPlayerInfo : Form
    {
        public SelectPlayerInfo()
        {
            InitializeComponent();
        }

        #region[声明实例]
        private FootballPlayer player;  //记录球员信息
        #endregion

        #region[窗体事件]
        //显示
        private void SelectPlayerInfo_Shown(object sender, EventArgs e)
        {
            //显示数据
            this.showPlayerData(SystemParam.getMatch());
        }
        #endregion

        #region[表格事件]
        //双击表格行
        private void dataGridView_playerManage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    try
                    {
                        int playerID = Convert.ToInt32(dataGridView_playerManage.Rows[e.RowIndex].Cells["Player_ID"].Value);
                        player = ContentDAO.getPlayerInfo(playerID);
                        if (SystemParam.getAddPlayerCardRecordsForm() != null)  //当该窗体已经打开时
                        {
                            //刷新添加球员罚牌记录页面
                            SystemParam.getAddPlayerCardRecordsForm().flushPlayerName(player.getName());
                        }
                        //关闭本页面
                        this.Close();
                    }
                    catch (NullReferenceException ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            catch
            {
            }
        }
        //显示表格行数
        private void dataGridView_playerManage_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView_playerManage.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView_playerManage.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView_playerManage.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        #endregion

        #region[显示数据]
        //显示赛事的基本信息
        private void showPlayerData(SeasonMatch match)
        {
            //先清除DataGridView中的数据
            if (dataGridView_playerManage.Rows.Count > 0)
            {
                dataGridView_playerManage.Rows.Clear();
            }
            //取出数据
            List<FootballPlayer> list = MatchPlayerInfoDAO.getAssignedPlayerInfo(match.getID());
            //往dataGridView中添加数据
            for (int i = 0; i < list.Count; i++)
            {
                player = list[i];  //取出线性表中的赛事的信息
                dataGridView_playerManage.Rows.Add(player.getID().ToString(), player.getName(), player.getNumber().ToString(), player.getPostion(), player.getBelongTeam());
            }
        }
        #endregion

    }
}
