using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FootballMatch.Umasou.Model;
using FootballMatch.Umasou.DBA;
using System.Collections;
using FootballMatch.Umasou.Util;

namespace FootballMatch.Umasou.CardRecord
{
    public partial class CardRecordManage : Form
    {
        public CardRecordManage(MainForm mainform)
        {
            InitializeComponent();
            this.MdiParent = mainform;
        }

        #region[窗体事件]
        //窗体显示
        private void CardRecordManage_Shown(object sender, EventArgs e)
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
        //显示表格中的数据信息
        private void showDataInfo(SeasonMatch match)
        {
            //清空表格
            if (dataGridView_gameInfo.Rows.Count > 0)
            {
                dataGridView_gameInfo.Rows.Clear();
            }
            //声明一个变量
            PlayerCardRecord cardRecord;
            //获取某一赛事中的所有罚牌记录信息
            List<PlayerCardRecord> list = MatchCardRecordDAO.getMatchPlayerCardRecord(match.getID());
            for (int i = 0; i < list.Count; i++)
            {
                cardRecord = list[i];
                dataGridView_gameInfo.Rows.Add(cardRecord.getUniqueID().ToString(),cardRecord.getMatchID().ToString(),
                    cardRecord.getMatchName(),cardRecord.getPlayerID().ToString(),cardRecord.getPlayerName(),
                    cardRecord.getYellowCardNum().ToString(),cardRecord.getRedCardNum().ToString(),
                    cardRecord.getSerialNum().ToString(),cardRecord.getDateTime().ToLongDateString());
            }
        }
        #endregion
    }
}
