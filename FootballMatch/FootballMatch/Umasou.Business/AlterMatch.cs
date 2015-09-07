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
    public partial class AlterMatch : Form
    {
        public AlterMatch(SeasonMatch match)
        {
            InitializeComponent();
            _match = match;
        }

        #region[实例变量]
        private SeasonMatch _match;   //记录被传入的赛事信息
        #endregion

        #region[窗体事件]
        //显示数据
        private void AlterMatch_Shown(object sender, EventArgs e)
        {
            this.showData(_match);
        } 
        #endregion

        #region[按钮事件]
        //确定按钮
        private void OK_Click(object sender, EventArgs e)
        {
            if (this.alterMatchInfo(_match))
            {
                SystemParam.getMatchManageForm().showMatchData();
                if (MessageBox.Show("修改成功", "更新提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("更新失败", "更新提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        //取消按钮
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region[显示数据]
        //显示数据方法
        private void showData(SeasonMatch match)
        {
            textBox_name.Text = match.getName();
            textBox_switchNum.Text = match.getSwitchNum().ToString();
            textBox_serialNum.Text = match.getSerialNum().ToString();
            richTextBox_description.Text = match.getDescription();
        }
        #endregion

        #region[修改判断]
        private bool alterMatchInfo(SeasonMatch match)
        {
            if (textBox_switchNum.Text == "" || textBox_serialNum.Text == "")
            {
                MessageBox.Show("转换数量或轮次数量不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                //检查数量是否正确
                if (!checkSwitchResult.checkStringSwitchInteger(textBox_switchNum.Text))
                {
                    MessageBox.Show("转换次数必须是数字", "非数字", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return false;
                }
                if (!checkSwitchResult.checkStringSwitchInteger(textBox_serialNum.Text))
                {
                    MessageBox.Show("赛事轮次必须是数字", "非数字", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return false;
                }
                int switchNum = Convert.ToInt32(textBox_switchNum.Text);
                int serialNum = Convert.ToInt32(textBox_serialNum.Text);
                match.setName(textBox_name.Text);
                match.setDescription(richTextBox_description.Text);
                match.setSwitchNum(switchNum);
                match.setSerialNum(serialNum);
                //更新数据库操作
                MatchInfoDAO.updateMatchInfo(match);
                //关闭本页面
                return true;   
            }
        }
        #endregion
    }
}
