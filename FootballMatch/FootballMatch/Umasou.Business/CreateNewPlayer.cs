using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FootballMatch.Umasou.Util;
using FootballMatch.Umasou.DBA;
using FootballMatch.Umasou.Model;

namespace FootballMatch.Umasou.Business
{
    public partial class CreateNewPlayer : Form
    {
        public CreateNewPlayer()
        {
            InitializeComponent();
        }

        #region[窗体事件]
        //加载
        private void CreateNewPlayer_Load(object sender, EventArgs e)
        {
            this.bindComboData();
        }
        #endregion

        #region[按钮事件]
        //确定
        private void OK_Click(object sender, EventArgs e)
        {
            this.addNewPlayerRecord();
        }
        //取消
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

        #region[添加方法]
        //判断添加条件
        private void addNewPlayerRecord()
        {
            if (textBox_teamName.Text == "")
            {
                MessageBox.Show("球员姓名不能是空", "球员姓名空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                //检查球队名字是否已经存在
                if (PlayerInfoDAO.checkPlayerNameExist(textBox_teamName.Text))
                {
                    MessageBox.Show("球员姓名已经存在，请修改", "球员姓名重复", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    if (comboBox_teamName.Text == "")
                    {
                        MessageBox.Show("球队名称不能是空", "球队名称空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (textBox_IDnum.Text == "") { MessageBox.Show("身份证号不能是空", "身份证号码为空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); }
                        else {

                        if (checkSwitchResult.checkStringSwitchInteger(textBox_teamLeader.Text))  //球员号码是数字
                        {
                            FootballPlayer _player = new FootballPlayer();
                            _player.setPlayerName(textBox_teamName.Text);
                            _player.setPlayNumber(Convert.ToInt32(textBox_teamLeader.Text));
                            _player.setPostion(textBox_teamManager.Text);
                            _player.setBelongTeam(comboBox_teamName.Text);
                            _player.setIDnum(textBox_IDnum.Text);

                            //执行更新操作
                            if (PlayerInfoDAO.addNewPlayer(_player))
                            {
                                if (MessageBox.Show("添加新球员成功，是否继续添加", "继续添加提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    //刷新管理球队界面数据信息
                                    SystemParam.getPlayerManageForm().showCertainTeamPlayerData();
                                    
                                    //清空文本框
                                    this.clearTextBox();
                                }
                                else
                                {
                                    //刷新管理球队界面数据信息
                                    SystemParam.getPlayerManageForm().showCertainTeamPlayerData();
                                    this.Close();  //添加成功后自动关闭本页面
                                }
                            }
                            else
                            {
                                MessageBox.Show("添加新球员失败", "添加失败", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("球员号码必须是数字", "号码错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    } }                    
                }
            }
        }
        //清空文本框内容
        private void clearTextBox()
        {
            textBox_teamName.Text = "";
            textBox_teamLeader.Text = "";
            textBox_teamManager.Text = "";
            comboBox_teamName.Text = "";
            textBox_IDnum.Text = "";
        }
        #endregion

    }
}
