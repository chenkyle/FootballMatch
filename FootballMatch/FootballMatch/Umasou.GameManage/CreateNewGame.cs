using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FootballMatch.Umasou.Util;
using FootballMatch.Umasou.Model;
using FootballMatch.Umasou.DBA;
using System.Collections;

namespace FootballMatch.Umasou.Business
{
    public partial class CreateNewGame : Form
    {
        public CreateNewGame()
        {
            InitializeComponent();
        }

        #region[窗体事件]
        //窗体加载
        private void CreateNewGame_Load(object sender, EventArgs e)
        {
            this.loadBaseInfo(SystemParam.getMatch());
        }
        //窗体显示
        private void CreateNewGame_Shown(object sender, EventArgs e)
        {
            this.showDataInfo(SystemParam.getMatch());
        }
        #endregion

        #region[按钮事件]
        //确定按钮
        private void OK_Click(object sender, EventArgs e)
        {
            this.addNewMatchGameInfo(SystemParam.getMatch());
        }
        //关闭按钮
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region[显示数据]
        //初始显示窗体时，调用已经打开的赛事信息
        private void showDataInfo(SeasonMatch match)
        {
            //读取赛事信息，并且在文本框中显示
            textBox_matchName.Text = match.getName();
            textBox_matchGameNum.Text = match.getSerialNum().ToString();
            //获取已经存放的比赛的最大序号
            int _maxGameNum = GameInfoDAO.getMatchMaxGameNum(match.getID());
            textBox_gameNum.Text = (_maxGameNum + 1).ToString();
        }
        #endregion

        #region[初始加载]
        //加载下拉列表信息
        private void loadBaseInfo(SeasonMatch match)
        {
            this.bingComboBox(match.getID());
        }
        //加载下拉列表
        private void bingComboBox(int matchID)
        {
            Team team;
            //取出所有的球队信息，属于某一赛事的球队信息
            List<Team> list = MatchTeamInfoDAO.getAssignedMatchTeamInfo(matchID);
            //清空三个下拉表中的数据信息
            comboBox_homeTeam.Items.Clear();
            comboBox_guestTeam.Items.Clear();
            comboBox_winner.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                //取出球队信息
                team = list[i];
                //往线性表中添加球队信息
                comboBox_homeTeam.Items.Add(team.getName());
                comboBox_guestTeam.Items.Add(team.getName());
            }
        }
        #endregion

        #region[下拉事件]
        //单击下拉框事件
        private void comboBox_winner_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox_winner.Items.Clear(); //先清空，再添加
            //判断其他两个下拉框中是否有值
            if (comboBox_homeTeam.Text != "")
            {
                if (comboBox_guestTeam.Text != "")
                {
                    comboBox_winner.Items.Add(comboBox_homeTeam.Text);
                    comboBox_winner.Items.Add(comboBox_guestTeam.Text);
                }
                else
                {
                    MessageBox.Show("客队名字不能为空","球队空",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("主队名字不能为空","球队空",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
        }
        #endregion

        #region[添加比赛]
        //添加一个比赛的记录，
        private void addNewMatchGameInfo(SeasonMatch match)
        {
            if (textBox_GameName.Text != "") //检查比赛名字
            {
                //检查比赛名称是否合法
                string gameName = textBox_GameName.Text;
                if (GameInfoDAO.checkGameNameExist(match.getID(), gameName))
                {
                    MessageBox.Show("比赛名字已经存在，请修改", "比赛名字重复", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    //检查比赛序号
                    if (textBox_gameNum.Text != "")
                    {
                        if (checkSwitchResult.checkStringSwitchInteger(textBox_gameNum.Text))
                        {
                            int gameNum = Convert.ToInt32(textBox_gameNum.Text);
                            //检查比赛序号是否存在
                            if (GameInfoDAO.checkGameNumExist(match.getID(), gameNum))
                            {
                                MessageBox.Show("比赛序号已经存在，请修改", "比赛序号重复", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            }
                            else
                            {
                                //判断比赛序号是否合法，即是否超过该赛事所限制的比赛次数
                                if (gameNum <= match.getSerialNum())
                                {
                                    if (comboBox_homeTeam.Text != "")
                                    {
                                        if (comboBox_guestTeam.Text != "")
                                        {
                                            Game _game = new Game();  //声明一个比赛类，并且赋值
                                            _game.setMatchID(match.getID());
                                            _game.setGameName(gameName);
                                            _game.setMatchGameNum(gameNum);
                                            _game.setHomeTeam(comboBox_homeTeam.Text);
                                            _game.setGuestTeam(comboBox_guestTeam.Text);
                                            _game.setGameWinner(comboBox_winner.Text);
                                            _game.setGameResult(textBox_gameResult.Text);
                                            _game.setGameAddress(textBox_gameAddress.Text);
                                            _game.setGameDate(Convert.ToDateTime(dateTimePicker_gameDate.Text));
                                            //执行更新操作
                                            GameInfoDAO.addNewGameInfo(_game);
                                            //弹出对话框，提示是否继续添加
                                            if (MessageBox.Show("添加比赛信息成功，是否继续添加？", "添加比赛成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                            {
                                                //清空其他
                                                textBox_GameName.Text = "";
                                                textBox_gameNum.Text = "";
                                                textBox_gameResult.Text = "";
                                                textBox_gameAddress.Text = "";
                                            }
                                            else
                                            {
                                                this.Close();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("客队名字不能为空", "球队空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("主队名字不能为空", "球队空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("比赛序号超过赛事比赛总数", "比赛序号溢出", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("比赛序号必须填数字", "序号非数字", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("比赛序号不能为空", "比赛序号空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("比赛名称不能为空", "比赛名称空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}
