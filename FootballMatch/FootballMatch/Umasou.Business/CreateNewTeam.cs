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
    public partial class CreateNewTeam : Form
    {
        public CreateNewTeam()
        {
            InitializeComponent();
        }


        #region[加载显示combox数据]
        private void CreateNewTeam_Load(object sender, EventArgs e)
        {
            this.loadBaseInfo();
        }
         //加载下拉列表信息
        private void loadBaseInfo()
        {

            SeasonMatch match;
            //取出赛事信息
            match = SystemParam.getMatch();
            textBox_matchNameOfTeam.Text = match.getName();
            
        }
        #endregion

        #region[按钮事件]
        //确定按钮
        private void OK_Click(object sender, EventArgs e)
        {
            this.addNewTeamRecord();
        }
        //取消按钮
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region[判断条件]
        //添加方法
        private void addNewTeamRecord()
        {
            if (textBox_teamName.Text == "")
            {
                MessageBox.Show("球队名字不能是空","球队名字空",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            else
            {
                //检查球队名字是否已经存在
                if (TeamInfoDAO.checkTeamNameExist(textBox_teamName.Text))
                {
                    MessageBox.Show("球队名字已经存在，请修改", "球队名字重复", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    Team _team = new Team();
                    _team.setMatchName(textBox_matchNameOfTeam.Text);      
                    _team.setName(textBox_teamName.Text);
                    _team.setTeamFullName(textBox_teamFullName.Text);
                    _team.setBirthDate(dateTimePicker_birthDate.Text);
                    _team.setLocation(textBox_location.Text);
                    _team.setIntroduction(textBox_location.Text);
                    _team.setLeader(textBox_teamLeader.Text);
                    _team.setManager(textBox_teamManager.Text);
                    _team.setCoach(textBox_teamCoach.Text);
                    //执行更新操作
                    if (TeamInfoDAO.addNewTeam(_team))
                    {
                        if (MessageBox.Show("添加新球队成功，是否继续添加", "继续添加提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            //刷新管理球队界面数据信息
                            SystemParam.getTeamManageForm().showTeamData();
                            //清空文本框
                            this.clearTextBox();
                        }
                        else
                        {
                            //刷新管理球队界面数据信息
                            SystemParam.getTeamManageForm().showTeamData();
                            this.Close();  //添加成功后自动关闭本页面
                        }
                    }
                    else
                    {
                        MessageBox.Show("添加新球队失败", "添加失败", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //清空文本框内容
        private void clearTextBox()
        {
            
            textBox_teamFullName.Text = "";
            textBox_location.Text = "";
            textBox_introduction.Text = "";
            dateTimePicker_birthDate.Text = "";
            textBox_teamName.Text = "";
            textBox_teamLeader.Text = "";
            textBox_teamManager.Text = "";
            textBox_teamCoach.Text = "";
        }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            TeamsExcelImport teamsExcelForm = new TeamsExcelImport();
            teamsExcelForm.Show();

        }

        




    }
}
