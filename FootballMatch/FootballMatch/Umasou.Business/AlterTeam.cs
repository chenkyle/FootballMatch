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
    public partial class AlterTeam : Form
    {
        public AlterTeam(Team team)
        {
            InitializeComponent();
            this._team = team;
        }

        #region[实例变量]
        private Team _team;  //用于内部记录的球队信息
        #endregion

        #region[窗体事件]
        //显示
        private void AlterTeam_Shown(object sender, EventArgs e)
        {
            this.showAlterTeamInfo(_team);
        }
        #endregion

        #region[按钮事件]
        //确定
        private void OK_Click(object sender, EventArgs e)
        {
            Team team = _team;
            team.setLeader(textBox_teamLeader.Text);
            team.setManager(textBox_teamManager.Text);
            team.setCoach(textBox_teamCoach.Text);
            //执行更新操作，并返回一个boolean变量
            if (TeamInfoDAO.updateTeamInfo(team))
            {
                MessageBox.Show("更新球队信息成功", "更新成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //刷新原表格中球队的信息
                SystemParam.getTeamManageForm().showTeamData();
                this.Close();
            }
            else
            {
                MessageBox.Show("更新球队信息失败", "更新失败", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        //取消
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region[显示数据]
        private void showAlterTeamInfo(Team team)
        {
            textBox_teamName.Text = team.getName();
            textBox_teamLeader.Text = team.getLeader();
            textBox_teamManager.Text = team.getManager();
            textBox_teamCoach.Text = team.getCoach();
        }
        #endregion

    }
}
