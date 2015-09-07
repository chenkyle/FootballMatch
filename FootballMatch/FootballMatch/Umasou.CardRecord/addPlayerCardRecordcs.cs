using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FootballMatch.Umasou.Model;
using FootballMatch.Umasou.Util;
using FootballMatch.Umasou.DBA;

namespace FootballMatch.Umasou.Business
{
    public partial class addPlayerCardRecordcs : Form
    {
        public addPlayerCardRecordcs()
        {
            InitializeComponent();
            _match = SystemParam.getMatch();
        }

        #region[声明实例]
        private static SeasonMatch _match;  //记录被打开的赛事
        private static FootballPlayer _player;  //记录被选中的用户
        #endregion

        #region[窗体事件]
        //窗体显示
        private void addPlayerCardRecordcs_Shown(object sender, EventArgs e)
        {
            this.showData();
        }
        #endregion

        #region[按钮事件]
        //确定按钮
        private void OK_Click(object sender, EventArgs e)
        {
            this.addPlayerRecord();
        }
        //取消按钮
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region[初始化显示]
        //初始化显示数据
        private void showData()
        {
            textBox_matchName.Text = _match.getName();
        }
        #endregion

        #region[公共调用]
        //刷新球员名称
        public  void flushPlayerName(string playerName)
        {
            textBox_playerName.Text = playerName;
        }
        //刷新比赛序号
        public void flushGameNum(int gameNum)
        {
            textBox_matchSerial.Text = gameNum.ToString();
        }
        #endregion

        #region[文本框事件]
        //双击文本框
        private void textBox_playerName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (SystemParam.getMatch() != null)
            {
                SelectPlayerInfo form = new SelectPlayerInfo();
                form.ShowDialog();
            }
            else
            {
                if (MessageBox.Show("请先选择打开一个赛事", "打开赛事提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    OpenMatch openMatch = new OpenMatch();
                    openMatch.ShowDialog();
                }
            }
        }
        //双击选择比赛序号文本框
        private void textBox_matchSerial_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (SystemParam.getMatch() != null)
            {
                SelectGameInfo form = new SelectGameInfo();
                form.ShowDialog();
            }
            else
            {
                if (MessageBox.Show("请先选择打开一个赛事", "打开赛事提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    OpenMatch openMatch = new OpenMatch();
                    openMatch.ShowDialog();
                }
            }
        }
        #endregion

        #region[添加记录]
        private void addPlayerRecord()
        {
            //记录各个变量
            int matchID;  //比赛ID
            int playerID;  //球员ID
            int matchSerial;  //赛事轮次
            int yellowCardNum;  //黄牌数量
            int redCardNum;  //红牌数量
            DateTime dateTime;  //记录添加罚牌记录的日期

            if (textBox_matchName.Text == "" || textBox_playerName.Text == "")  //赛事名称和用户名称不能为空
            {
                MessageBox.Show("赛事名称或球员姓名不能为空","不能为空",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            else
            {
                matchID = _match.getID();  //记录赛事的编号
                //查询并获取球员信息
                _player = ContentDAO.getPlayerInfo(textBox_playerName.Text);
                playerID = _player.getID();
                if (textBox_matchSerial.Text != "")  //当比赛场次不是空时
                {
                    //检查是否是数字
                    if (!checkSwitchResult.checkStringSwitchInteger(textBox_matchSerial.Text))
                    {
                        MessageBox.Show("赛事轮次必须是数字", "非数字", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    else //可以转换时
                    {
                        matchSerial = Convert.ToInt32(textBox_matchSerial.Text);
                    }
                }
                else  //比赛轮次是空时，记录其值为0
                {
                    matchSerial = 0;
                }
                if (textBox_yellowCardNum.Text != "")  //当黄牌数量不是空时
                {
                    //检查是否是数字
                    if (!checkSwitchResult.checkStringSwitchInteger(textBox_yellowCardNum.Text))
                    {
                        MessageBox.Show("黄牌数量必须是数字", "非数字", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    else //可以转换时
                    {
                        yellowCardNum = Convert.ToInt32(textBox_yellowCardNum.Text);
                    }
                }
                else
                {
                    yellowCardNum = 0;
                }
                if (textBox_redCardNum.Text != "")  //红牌数量不是空时
                {
                    //检查是否是数字
                    if (!checkSwitchResult.checkStringSwitchInteger(textBox_redCardNum.Text))
                    {
                        MessageBox.Show("红牌数量必须是数字", "非数字", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    else //可以转换时
                    {
                        redCardNum = Convert.ToInt32(textBox_redCardNum.Text);
                        if (yellowCardNum != 0 && yellowCardNum % SystemParam.getSwitchNum() == 0)
                        {
                            yellowCardNum = 0;
                        }
                    }
                }
                else
                {
                    redCardNum = 0;
                    if (yellowCardNum != 0 && yellowCardNum % SystemParam.getSwitchNum() == 0)  //若添加的黄牌数量可以转换成红牌时，直接将黄牌数变为0
                    {
                        yellowCardNum = 0;
                        redCardNum = 1;
                    }
                }
                //记录日期
                if (dateTimePicker_addCardRecord.Text != "")  //日期文本不是空时
                {
                    dateTime = dateTimePicker_addCardRecord.Value;
                }
                else  //日期文本是空时，直接设定当前日期为默认日期
                {
                    dateTime = DateTime.Today;
                }
                PlayerCardRecord _playerCardRecord = new PlayerCardRecord(matchID,playerID,matchSerial,yellowCardNum,redCardNum,dateTime);
                //往数据库中添加记录
                ContentDAO.addNewPlayerCardNum(_playerCardRecord);
                if (MessageBox.Show("添加罚牌信息成功，是否继续添加？", "添加罚牌成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    textBox_matchSerial.Text = "";
                    textBox_playerName.Text = "";
                    textBox_yellowCardNum.Text = "";
                    textBox_redCardNum.Text = "";
                }
                else
                {
                    this.Close();
                }
            }
        }
        #endregion


    }
}
