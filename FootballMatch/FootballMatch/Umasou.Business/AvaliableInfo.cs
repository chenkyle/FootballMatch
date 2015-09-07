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
    public partial class AvaliableInfo : Form
    {
        public AvaliableInfo(MainForm mainForm)
        {
            InitializeComponent();
            this.MdiParent = mainForm;
        }

        #region[窗体事件]
        //窗体加载
        private void AvaliableInfo_Load(object sender, EventArgs e)
        {

        }
        //窗体显示
        private void AvaliableInfo_Shown(object sender, EventArgs e)
        {
            //显示数据
            this.showDataInfo(SystemParam.getMatch());
            //使窗体最大化
            this.WindowState = FormWindowState.Maximized;
        }
        //改变窗体大小
        private void AvaliableInfo_Resize(object sender, EventArgs e)
        {
            //设置控件位置
            this.dynamicComponentLocation();
        }
        #endregion

        #region[表格事件]
        //单击单元格事件
        private void dataGridView_gameInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //取出比赛的唯一标识号
                    int uniqueID = Convert.ToInt32(dataGridView_gameInfo.Rows[e.RowIndex].Cells["game_UniqueID"].Value);
                    Game game = GameInfoDAO.getGameInfo(uniqueID);
                 //   MessageBox.Show(game.getGameName());
                    //刷新可上场成员信息
                    this.showAvaliableDataInfo(SystemParam.getMatch(), game);
                }
            }
            catch
            {
             //   MessageBox.Show("");
            }
        }
        //画表格行数
        private void dataGridView_gameInfo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView_gameInfo.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView_gameInfo.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView_gameInfo.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        //画表格行数
        private void dataGridView_playerManage_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView_playerManage.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView_playerManage.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView_playerManage.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
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
        //显示某一比赛中可上场成员的信息
        private void showAvaliableDataInfo(SeasonMatch match,Game game)
        {
            if (dataGridView_playerManage.Rows.Count > 0)  //清除表格行
            {
                dataGridView_playerManage.Rows.Clear();
            }
            //查询属于该场比赛的所有球员信息``
            if (game.getHomeTeam() == "" || game.getGuestTeam() == "")
            {
                MessageBox.Show("比赛中的主队或客队不能为空", "比赛球队空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                //获取参加该比赛的球员信息
                List<FootballPlayer> list = PlayerInfoDAO.getPlayerInfo(game);
                FootballPlayer player;  //记录球员信息
             //   SuspendedRecord _suspendedRecord;  //记录球员的停赛记录
                PlayerCardRecord _playerCardRecord;  //记录球员的罚牌记录信息
                string label = "";  //记录球员可上场状态
                string leftYellowCardNum = "-";  //记录球员上场之后，可以被罚的黄牌数量
                for (int i = 0; i < list.Count; i++)  //循环查询每一个球员的信息，显示该球员在某一场比赛中是否能够上场
                {
                    player = list[i];
                    label = "";
                    leftYellowCardNum = "-";
                    //取出指定用户的所有停赛记录
                //    List<SuspendedRecord> suspendedList = SuspendedRecordDAO.getPlayerSuspendedRecord(match.getID(), player.getID());
                    //取出指定用户在指定比赛前的所有停赛记录数量
                    List<SuspendedRecord> _suspenedList = SuspendedRecordDAO.getPlayerSuspendedRecord_BeforeGame(match.getID(), player.getID(), game.getMatchGameNum());
                    //判断用户是否在本次比赛中具有停赛信息记录
                    if (SuspendedRecordDAO.checkPlayerSuspended(player.getID(), match.getID(), game.getMatchGameNum()))  //若具有停赛记录
                    {
                        label = "停赛";
                    }
                    else  //若还没有记录到停赛信息时
                    {
                        //取出该球员在这场比赛之前的所有罚牌记录
                        List<PlayerCardRecord> cardRecordList = MatchCardRecordDAO.getPlayerCardRecord_beforeGame(match.getID(), player.getID(), game.getMatchGameNum());
                        //统计该球员的所有黄牌和红牌数量
                        int yellowCardNum = 0;
                        int redCardNum = 0;
                        for (int k = 0; k < cardRecordList.Count; k++)
                        {
                            _playerCardRecord = cardRecordList[k];
                            //统计该球员在该场比赛前所有获得黄牌和红牌的数量
                            yellowCardNum = yellowCardNum + _playerCardRecord.getYellowCardNum();
                            redCardNum = redCardNum + _playerCardRecord.getRedCardNum();
                        }
                        //统计该球员所有黄牌和红牌总和可以得到的停赛次数
                        int attendedSuspendedQuantity = redCardNum + yellowCardNum / match.getSwitchNum();
                        //若应当停赛的次数比实际停赛次数多时，那么应当添加一次停赛，并且设置标签数据为停赛
                        if (attendedSuspendedQuantity > _suspenedList.Count)
                        {
                            //修改参赛标签
                            label = "停赛";
                            //添加一次停赛记录
                            SuspendedRecordDAO.addNewSuspendedRecord(match.getID(), game.getMatchGameNum(), player.getID(), game.getGameDate());
                        }
                        else  //当应当停赛次数没有实际停赛次数多时，比实际停赛次数少或等时，说明该球员在之前已经停赛过了
                        {
                            //设置标签为参赛
                            label = "可参赛";
                            //求得余下可被罚的黄牌数量
                            leftYellowCardNum = (match.getSwitchNum() - yellowCardNum % match.getSwitchNum()).ToString();
                        }
                    }
                    dataGridView_playerManage.Rows.Add(player.getID().ToString(), player.getName(), player.getNumber().ToString(), player.getPostion(), player.getBelongTeam(),label,leftYellowCardNum);
                }
                //设置表格颜色
                this.setDataRowColor();
            }
        }
        //设置参赛球员行的信息，若球员被停赛，该行颜色变为红色
        private void setDataRowColor()
        {
            string label = "";
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            for (int i = 0; i < dataGridView_playerManage.Rows.Count; i++)
            {
                label = dataGridView_playerManage.Rows[i].Cells["player_State"].Value.ToString();
                if (label == "停赛")  //若是停赛，背景色改为红色s
                {
                    style.BackColor = Color.Orange;
                    dataGridView_playerManage.Rows[i].DefaultCellStyle = style;
                }
                else  //可参赛时，背景色是绿色
                {
                 //   style.BackColor = Color.Green;
                 //   dataGridView_playerManage.Rows[i].DefaultCellStyle = style;
                }
            }
        }
        //刷新数据信息
        public void flushDataInfo(SeasonMatch match)
        {
            if (dataGridView_playerManage.Rows.Count > 0)
            {
                dataGridView_playerManage.Rows.Clear();
            }
            //显示比赛信息列表
            this.showDataInfo(match);
        }
        #endregion

        #region[动态位置]
        //动态设置控件位置
        private void dynamicComponentLocation()
        {
            int preHeight = this.ClientRectangle.Height;
            int preWidth = this.ClientRectangle.Width;
            int preTop = this.ClientRectangle.Top;
            int preLeft = this.ClientRectangle.Left;
            //设置显示比赛列表
            groupBox_gameList.Left = preLeft + 10;
            groupBox_gameList.Top = preTop + 10;
            groupBox_gameList.Height = preHeight - 20;
            //设置球员信息列表
            groupBox_avaliableInfo.Left = groupBox_gameList.Right + 10;
            groupBox_avaliableInfo.Top = preTop + 10;
            groupBox_avaliableInfo.Width = preWidth - 30 - groupBox_gameList.Width;
            groupBox_avaliableInfo.Height = preHeight - 20;
        }
        #endregion


    }
}
