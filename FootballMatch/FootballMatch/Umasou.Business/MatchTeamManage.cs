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
    public partial class MatchTeamManage : Form
    {
        public MatchTeamManage(MainForm mainForm)
        {
            InitializeComponent();
            this.MdiParent = mainForm;
        }

        #region[实例变量]
        private int notAssignedRowIndex;  //记录未分配球队表格的行下标
        private int assignedRowIndex;  //记录已分配球队表格的行下标
        #endregion

        #region[窗体事件]
        //窗体加载
        private void MatchTeamManage_Load(object sender, EventArgs e)
        {

        }
        //窗体显示
        private void MatchTeamManage_Shown(object sender, EventArgs e)
        {
            //显示数据
            this.showDataInfo();
            //窗体最大化
            this.WindowState = FormWindowState.Maximized;
        }
        //窗体改变大小
        private void MatchTeamManage_Resize(object sender, EventArgs e)
        {
            this.setComponentLocation();
        }
        #endregion

        #region[按钮事件]
        //添加球队到赛事中
        private void button_Add_Click(object sender, EventArgs e)
        {
            this.addSelectedTeam_NewEdition();
        }
        //添加所有球队到赛事中
        private void button_addAll_Click(object sender, EventArgs e)
        {
            this.addAllTeam_NewEdition();
        }
        //从赛事中移除球队
        private void button_remove_Click(object sender, EventArgs e)
        {
            this.removeSelectedTeam_NewEdition();
        }
        //从赛事中移除所有球队
        private void button_removeAll_Click(object sender, EventArgs e)
        {
            this.removeAllTeam_newEdition();
        }
        //关闭本页面
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region[表格事件]

        #region[未分配球队]
        //单击未分配球队单元格
        private void dataGridView_NotAssiagnedTeam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    notAssignedRowIndex = e.RowIndex;
                  //清除已分配球队信息表中选中的行的数据信息
                    dataGridView_assignedTeam.ClearSelection();
                }
            }
            catch
            {
            }
        }
        //未分配球队画表格行
        private void dataGridView_NotAssiagnedTeam_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView_NotAssiagnedTeam.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView_NotAssiagnedTeam.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView_NotAssiagnedTeam.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        #endregion

        #region[已分配球队]
        //单击已分配球队单元格
        private void dataGridView_assignedTeam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    assignedRowIndex = e.RowIndex;
                    //清除未分配球队信息表中的选中的行信息
                    dataGridView_NotAssiagnedTeam.ClearSelection();
                }
            }
            catch
            {
            }
        }
        //已分配球队画表格行
        private void dataGridView_assignedTeam_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView_assignedTeam.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView_assignedTeam.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView_assignedTeam.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        #endregion

        #endregion

        #region[显示数据]
        //显示窗体中的数据信息
        private void showDataInfo()
        {
            //显示未分配球队信息
            this.showNotAssignedTeam();
            //显示已分配球队信息
            this.showAssignedTeam();
        }
        //显示未分配球队信息
        private void showNotAssignedTeam()
        {
            if (dataGridView_NotAssiagnedTeam.Rows.Count > 0)  //若已经有记录，先清除记录
            {
                dataGridView_NotAssiagnedTeam.Rows.Clear();
            }
            //显示数据操作
            Team team = new Team();
            //查询未被分配的球队信息，并且返回到一个线性表中
            List<Team> list = MatchTeamInfoDAO.getNotAssignedMatchTeamInfo(SystemParam.getMatch().getID());
            for (int i = 0; i < list.Count; i++)
            {
                team = list[i];  //取出球队信息
                dataGridView_NotAssiagnedTeam.Rows.Add(team.getID().ToString(), team.getName(), team.getLeader(), team.getManager(), team.getCoach());
            }
        }
        //显示已分配球队信息
        private void showAssignedTeam()
        {
            if (dataGridView_assignedTeam.Rows.Count > 0)//若已经有记录，先清除记录
            {
                dataGridView_assignedTeam.Rows.Clear();
            }
            //显示数据操作
            Team team = new Team();
            //查询未被分配的球队信息，并且返回到一个线性表中
            List<Team> list = MatchTeamInfoDAO.getAssignedMatchTeamInfo(SystemParam.getMatch().getID());
            for (int i = 0; i < list.Count; i++)
            {
                team = list[i];  //取出球队信息
                dataGridView_assignedTeam.Rows.Add(team.getID().ToString(), team.getName(), team.getLeader(), team.getManager(), team.getCoach());
            }
        }
        #endregion

        #region[加载位置]
        //设置窗体中各个控件的位置
        private void setComponentLocation()
        {
            int preTop = ClientRectangle.Top;
            int preLeft = ClientRectangle.Left;
            int preRight = ClientRectangle.Right;
            int preBottom = ClientRectangle.Bottom;
            int preWidth = ClientRectangle.Width;
            int preHeight = ClientRectangle.Height;
            //设置未分配球队信息表格位置
            groupBox_notAssiagned.Left = preLeft + 10;
            groupBox_notAssiagned.Top = preTop + 10;
            groupBox_notAssiagned.Height = preHeight - 20;
            groupBox_notAssiagned.Width = (preWidth - 40 - groupBox_button.Width) / 2;
            //设置中间按钮的位置
            groupBox_button.Left = groupBox_notAssiagned.Right + 10;
            groupBox_button.Top = preTop + (preHeight - groupBox_button.Height) / 2;
            //设置右边已分配球队信息表格位置
            groupBox_assiagned.Left = groupBox_button.Right + 10;
            groupBox_assiagned.Top = preTop + 10;
            groupBox_assiagned.Height = preHeight - 20;
            groupBox_assiagned.Width = groupBox_notAssiagned.Width;
        }
        #endregion

        #region[添加球队]
        //添加被选中的球队信息
        private void addSelectedTeam()
        {
            //记录被选中的行的个数
            int selectedRowCount=dataGridView_NotAssiagnedTeam.SelectedRows.Count;
            if ( selectedRowCount> 0)  //当且仅当有选中行时，才执行
            {
                //用于记录对应的行中球队的编号
                int teamID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<Team> list = new List<Team>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_NotAssiagnedTeam.Rows.Count; i++)
                    {
                        if (dataGridView_NotAssiagnedTeam.Rows[i].Selected == true)  //当记录到某一行被选中时
                        {
                            //记录被选中的行的球队编号
                            teamID = Convert.ToInt32(dataGridView_NotAssiagnedTeam.Rows[i].Cells["team_ID"].Value);
                            //往线性表中添加记录
                            list.Add(TeamInfoDAO.getTeamInfo(teamID));
                            if (--selectedRowCount == 0)  //当所有被选中的行全部被取到时，跳出循环
                            {
                                break;
                            }
                        }
                    }
                    //执行添加赛事球队操作
                    MatchTeamInfoDAO.addMatchTeamInfo(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("请至少选中一个球队", "未选中球队", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //添加被选中的球队信息，新版本
        private void addSelectedTeam_NewEdition()
        {
            //记录被选中的行的个数
            int selectedRowCount = dataGridView_NotAssiagnedTeam.SelectedRows.Count;
            if (selectedRowCount > 0)  //当且仅当有选中行时，才执行
            {
                //用于记录对应的行中球队的编号
                int teamID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<int> list = new List<int>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_NotAssiagnedTeam.Rows.Count; i++)
                    {
                        if (dataGridView_NotAssiagnedTeam.Rows[i].Selected == true)  //当记录到某一行被选中时
                        {
                            //记录被选中的行的球队编号
                            teamID = Convert.ToInt32(dataGridView_NotAssiagnedTeam.Rows[i].Cells["team_ID"].Value);
                            //往线性表中添加记录
                            list.Add(teamID);
                            if (--selectedRowCount == 0)  //当所有被选中的行全部被取到时，跳出循环
                            {
                                break;
                            }
                        }
                    }
                    //执行添加赛事球队操作
                    MatchTeamInfoDAO.addMatchTeamInfo(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("请至少选中一个球队", "未选中球队", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //添加全部未被选中的球队信息
        private void addAllTeam()
        {
            if (dataGridView_NotAssiagnedTeam.Rows.Count > 0)
            {
                //用于记录对应的行中球队的编号
                int teamID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<Team> list = new List<Team>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_NotAssiagnedTeam.Rows.Count; i++)
                    {
                        //记录被选中的行的球队编号
                        teamID = Convert.ToInt32(dataGridView_NotAssiagnedTeam.Rows[i].Cells["team_ID"].Value);
                        //往线性表中添加记录
                        list.Add(TeamInfoDAO.getTeamInfo(teamID));
                    }
                    //执行添加赛事球队操作
                    MatchTeamInfoDAO.addMatchTeamInfo(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("未分配球队数量为0", "球队数量空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //添加全部未被选中的球队信息，新版本
        private void addAllTeam_NewEdition()
        {
            if (dataGridView_NotAssiagnedTeam.Rows.Count > 0)
            {
                //用于记录对应的行中球队的编号
                int teamID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<int> list = new List<int>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_NotAssiagnedTeam.Rows.Count; i++)
                    {
                        //记录被选中的行的球队编号
                        teamID = Convert.ToInt32(dataGridView_NotAssiagnedTeam.Rows[i].Cells["team_ID"].Value);
                        //往线性表中添加记录
                        list.Add(teamID);
                    }
                    //执行添加赛事球队操作
                    MatchTeamInfoDAO.addMatchTeamInfo(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("未分配球队数量为0", "球队数量空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region[移除球队]
        //移除被选中的球队
        private void removeSelectedTeam()
        {
            //记录被选中的行的个数
            int selectedRowCount = dataGridView_assignedTeam.SelectedRows.Count;
            if (selectedRowCount > 0)  //当且仅当有选中行时，才执行
            {
                //用于记录对应的行中球队的编号
                int teamID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<Team> list = new List<Team>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_assignedTeam.Rows.Count; i++)
                    {
                        if (dataGridView_assignedTeam.Rows[i].Selected == true)  //当记录到某一行被选中时
                        {
                            //记录被选中的行的球队编号
                            teamID = Convert.ToInt32(dataGridView_assignedTeam.Rows[i].Cells["_teamID"].Value);
                            //往线性表中添加记录
                            list.Add(TeamInfoDAO.getTeamInfo(teamID));
                            if (--selectedRowCount == 0)  //当所有被选中的行全部被取到时，跳出循环
                            {
                                break;
                            }
                        }
                    }
                    //执行添加赛事球队操作
                    MatchTeamInfoDAO.deleteMatchTeamInfo(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("请至少选中一个球队", "未选中球队", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //移除被选中的球队，新版本
        private void removeSelectedTeam_NewEdition()
        {
            //记录被选中的行的个数
            int selectedRowCount = dataGridView_assignedTeam.SelectedRows.Count;
            if (selectedRowCount > 0)  //当且仅当有选中行时，才执行
            {
                //用于记录对应的行中球队的编号
                int teamID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<int> list = new List<int>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_assignedTeam.Rows.Count; i++)
                    {
                        if (dataGridView_assignedTeam.Rows[i].Selected == true)  //当记录到某一行被选中时
                        {
                            //记录被选中的行的球队编号
                            teamID = Convert.ToInt32(dataGridView_assignedTeam.Rows[i].Cells["_teamID"].Value);
                            //往线性表中添加记录
                            list.Add(teamID);
                            if (--selectedRowCount == 0)  //当所有被选中的行全部被取到时，跳出循环
                            {
                                break;
                            }
                        }
                    }
                    //执行添加赛事球队操作
                    MatchTeamInfoDAO.deleteMatchTeamInfo(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("请至少选中一个球队", "未选中球队", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //移除全部球队
        private void removeAllTeam()
        {
            if (dataGridView_assignedTeam.Rows.Count > 0)
            {
                //用于记录对应的行中球队的编号
                int teamID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<Team> list = new List<Team>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_assignedTeam.Rows.Count; i++)
                    {
                        //记录被选中的行的球队编号
                        teamID = Convert.ToInt32(dataGridView_assignedTeam.Rows[i].Cells["_teamID"].Value);
                        //往线性表中添加记录
                        list.Add(TeamInfoDAO.getTeamInfo(teamID));
                    }
                    //执行添加赛事球队操作
                    MatchTeamInfoDAO.deleteMatchTeamInfo(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("已分配球队数量为0", "球队数量空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //移除全部球队，新版本
        private void removeAllTeam_newEdition()
        {
            if (dataGridView_assignedTeam.Rows.Count > 0)
            {
                //用于记录对应的行中球队的编号
                int teamID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<int> list = new List<int>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_assignedTeam.Rows.Count; i++)
                    {
                        //记录被选中的行的球队编号
                        teamID = Convert.ToInt32(dataGridView_assignedTeam.Rows[i].Cells["_teamID"].Value);
                        //往线性表中添加记录
                        list.Add(teamID);
                    }
                    //执行添加赛事球队操作
                    MatchTeamInfoDAO.deleteMatchTeamInfo(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("已分配球队数量为0", "球队数量空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}
