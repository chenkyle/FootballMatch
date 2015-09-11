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
using FootballMatch.Umasou.Util;

namespace FootballMatch.Umasou.Business
{
    public partial class AlterPlayer : Form
    {
        public AlterPlayer(FootballPlayer player)
        {
            InitializeComponent();
            this._player = player;
        }

        #region[实例变量]
        private FootballPlayer _player;  //用来记录被修改的球员信息
        #endregion

        #region[窗体事件]
        //加载
        private void AlterPlayer_Load(object sender, EventArgs e)
        {
            this.bindComboData();
        }
        //显示
        private void AlterPlayer_Shown(object sender, EventArgs e)
        {
            this.showAlterPlayerInfo(_player);
        }
        #endregion

        #region[按钮事件]
        //确定按钮
        private void OK_Click(object sender, EventArgs e)
        {
            this.alterPlayerInfo();
        }
        //取消按钮
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region[下拉事件]
        //为下拉框绑定数据
        private void bindComboData()
        {
            if (comboBox_teamName.Items.Count > 0)
            {
                comboBox_teamName.Items.Clear();
            }
            else
            {
                List<Team> _teamList = TeamInfoDAO.getTeamInfoOfCertainMatch(SystemParam.getMatch());
                Team _team = new Team();
                comboBox_teamName.Items.Add("");  //添加一个空白字符串
                for (int i = 0; i < _teamList.Count; i++)
                {
                    _team = _teamList[i];
                    comboBox_teamName.Items.Add(_team.getName());
                }
            }
        }
        #endregion

        #region[显示数据]
        private void showAlterPlayerInfo(FootballPlayer player)
        {
            textBox_teamName.Text = player.getName();
            textBox_teamLeader.Text = player.getNumber().ToString();
            textBox_teamManager.Text = player.getPostion();
            comboBox_teamName.Text = player.getBelongTeam();
        }
        #endregion

        #region[修改方法]
        private void alterPlayerInfo()
        {
            if (comboBox_teamName.Text == "")
            {
                MessageBox.Show("球队名称不能是空", "球队名称空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                if (checkSwitchResult.checkStringSwitchInteger(textBox_teamLeader.Text))  //球员号码是数字
                {
                    FootballPlayer player = new FootballPlayer();
                    player = _player;  //先给Player附一个初值
                  //  player.setPlayerName(textBox_teamName.Text);
                    player.setPlayNumber(Convert.ToInt32(textBox_teamLeader.Text));
                    player.setPostion(textBox_teamManager.Text);
                    player.setBelongTeam(comboBox_teamName.Text);
                    //执行更新操作
                    if (PlayerInfoDAO.updatePlayerInfo(player))
                    {
                        MessageBox.Show("修改球员信息成功", "修改成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                         //刷新管理球队界面数据信息
                        SystemParam.getPlayerManageForm().showCertainTeamPlayerData();
                        //关闭本页面
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改球员信息失败", "修改失败", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("球员号码必须是数字", "号码错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
