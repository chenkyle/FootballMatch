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
    public partial class CreateMatch : Form 
    {
        public CreateMatch()
        {
            InitializeComponent();
            SystemParam.setCreatMatchForm(this);
        }

        #region[窗体事件]
        //显示
        private void CreateMatch_Shown(object sender, EventArgs e)
        {
            textBox_switchNum.Text = SystemParam.getSwitchNum().ToString();  //默认从配置文件中读取黄牌转换为红牌的数量
            textBox_serialNum.Text = SystemParam.getDefaultMatchSerialNum().ToString();  //默认从配置文件中读取数量
        }
        #endregion

        #region[按钮事件]

        private void OK_Click(object sender, EventArgs e)
        {
            if (this.addNewMatchRecord())  //若添加新记录成功后，关闭本页面
            {
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region[新建赛事]
        //添加新的赛事信息
        private bool addNewMatchRecord()
        {
            if (textBox_name.Text == "" || textBox_switchNum.Text == "" || textBox_serialNum.Text == "")
            {
                MessageBox.Show("赛事名称，转换数量或轮次数量不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                if (ContentDAO.checkMatchNameExist(textBox_name.Text))
                {
                    MessageBox.Show("赛事名称已经存在，请修改", "名称重复", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
                    //插入并且返回新的赛事信息
                    SeasonMatch match = ContentDAO.addNewMatch(textBox_name.Text, richTextBox_description.Text,switchNum,serialNum);
                    //更新全局静态变量
                    SystemParam.setMatch(match);
                    SystemParam.setMatchID(match.getID());
                    //刷新主页面中显示的信息
                    if (SystemParam.getMatchManageForm() != null)  //若该窗体打开时，刷新该窗体的数据信息
                    {
                        SystemParam.getMatchManageForm().showMatchData();
                    }
                    if(SystemParam.getOpenMatchForm()!=null){
                        SystemParam.getOpenMatchForm().showMatchData();
                        SystemParam.getOpenMatchForm().cleanListBox();
                    }
                    //关闭本页面
                    return true;
                }
            }
        }
        #endregion


    }
}
