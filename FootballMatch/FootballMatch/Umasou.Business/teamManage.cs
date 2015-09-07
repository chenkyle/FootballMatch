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
    public partial class teamManage : Form
    {
        public teamManage(MainForm mainForm)
        {
            InitializeComponent();
            this.MdiParent = mainForm;
        }

        #region[声明实例]
        private Team team;  //记录球队信息
        private int rowIndex;  //记录行下标
        #endregion

        #region[窗体事件]

        private void teamManage_Load(object sender, EventArgs e)
        {

        }

        private void teamManage_Shown(object sender, EventArgs e)
        {
            this.showTeamData();
            //设置窗体最大化
            this.WindowState = FormWindowState.Maximized;
        }

        private void teamManage_Resize(object sender, EventArgs e)
        {
            this.setLocation();
        }

        #endregion

        #region[表格事件]
        //画表格行
        private void dataGridView_teamManage_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView_teamManage.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView_teamManage.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView_teamManage.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        //单击表格单元格
        private void dataGridView_teamManage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    rowIndex = e.RowIndex;
                }
            }
            catch
            {
            }
        }
        #endregion

        #region[按钮事件]
        //新建
        private void createNew_Click(object sender, EventArgs e)
        {
            CreateNewTeam form = new CreateNewTeam();
            form.ShowDialog();
        }
        //修改
        private void alter_Click(object sender, EventArgs e)
        {
            this.updateTeamInfo();
        }
        //删除
        private void delete_Click(object sender, EventArgs e)
        {
           // this.deleteTeamRecord();
            this.deleteSelectedTeamRecord_NewEdition();
        }
        //关闭
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region[显示数据]
        //显示赛事的基本信息
        public void showTeamData()
        {
            //先清除DataGridView中的数据
            if (dataGridView_teamManage.Rows.Count > 0)
            {
                dataGridView_teamManage.Rows.Clear();
            }
            //取出数据
            List<Team> list =TeamInfoDAO.getTeamInfo();
            //往dataGridView中添加数据
            for (int i = 0; i < list.Count; i++)
            {
                team = list[i];  //取出线性表中的赛事的信息
                dataGridView_teamManage.Rows.Add(team.getID().ToString(), team.getName(),team.getTeamFullName(),team.getMatchName(), team.getLocation(),team.getBirthDate().ToString(),team.getIntroduction(),team.getLeader(),team.getManager(),team.getCoach());
          
            
            
            }
        }
        #endregion

        #region[控件设置]
        private void setLocation()
        {
            int preTop = ClientRectangle.Top;
            int preLeft = ClientRectangle.Left;
            int preWidth = ClientRectangle.Width;
            int preHeight = ClientRectangle.Height;
            int preBottom = ClientRectangle.Bottom;
            int preRight = ClientRectangle.Right;

            dataGridView_teamManage.Top = preTop + 10;
            dataGridView_teamManage.Left = preLeft + 10;
            dataGridView_teamManage.Width = preWidth - 20;
            dataGridView_teamManage.Height = preHeight - 30 - groupBox_teamManage.Height;

            groupBox_teamManage.Left = preRight - 10 - groupBox_teamManage.Width;
            groupBox_teamManage.Top = preBottom - 10 - groupBox_teamManage.Height;
        }
        #endregion

        #region[删除数据]
        //删除选中的某一行
        private void deleteTeamRecord()
        {
            try
            {
                int teamID = Convert.ToInt32(dataGridView_teamManage.Rows[rowIndex].Cells["team_ID"].Value);
                //删除数据库中的记录
                ContentDAO.deleteTeamInfo(teamID);
                //移除表格中的对应的行
                dataGridView_teamManage.Rows.RemoveAt(rowIndex);
            }
            catch
            {
            }
        }
        //删除选中的多行
        private void deleteSelectedTeamRecord()
        {
            //记录被选中的行数
            int selectedRowCount=dataGridView_teamManage.SelectedRows.Count;
            if (selectedRowCount > 0)
            {
                //用于记录对应的行中球队的编号
                int teamID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<Team> list = new List<Team>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_teamManage.Rows.Count; i++)
                    {
                        if (dataGridView_teamManage.Rows[i].Selected == true)  //当记录到某一行被选中时
                        {
                            //记录被选中的行的球队编号
                            teamID = Convert.ToInt32(dataGridView_teamManage.Rows[i].Cells["team_ID"].Value);
                            //往线性表中添加记录
                            list.Add(TeamInfoDAO.getTeamInfo(teamID));
                            if (--selectedRowCount == 0)  //当所有被选中的行全部被取到时，跳出循环
                            {
                                break;
                            }
                        }
                    }
                    //执行删除球队信息操作
                    TeamInfoDAO.deleteTeamInfo(list);
                    //刷新表格中的数据信息
                    this.showTeamData();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("请至少选中一行再执行删除","选中行数空",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
        }
        //删除选中的多行，新版本
        private void deleteSelectedTeamRecord_NewEdition()
        {
            //记录被选中的行数
            int selectedRowCount = dataGridView_teamManage.SelectedRows.Count;
            if (selectedRowCount > 0)
            {
                //用于记录对应的行中球队的编号
                int teamID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<int> list = new List<int>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_teamManage.Rows.Count; i++)
                    {
                        if (dataGridView_teamManage.Rows[i].Selected == true)  //当记录到某一行被选中时
                        {
                            //记录被选中的行的球队编号
                            teamID = Convert.ToInt32(dataGridView_teamManage.Rows[i].Cells["team_ID"].Value);
                            //往线性表中添加记录
                            list.Add(teamID);
                            if (--selectedRowCount == 0)  //当所有被选中的行全部被取到时，跳出循环
                            {
                                break;
                            }
                        }
                    }
                    //执行删除球队信息操作
                    TeamInfoDAO.deleteTeamInfo(list);
                    //刷新表格中的数据信息
                    this.showTeamData();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("请至少选中一行再执行删除", "选中行数空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region[修改数据]
        //修改数据方法
        private void updateTeamInfo()
        {
            if (rowIndex >= 0)
            {
                try
                {
                    int teamID = Convert.ToInt32(dataGridView_teamManage.Rows[rowIndex].Cells["team_ID"].Value);
                    Team team = TeamInfoDAO.getTeamInfo(teamID);
                    AlterTeam form = new AlterTeam(team);
                    form.ShowDialog();
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        #endregion

    }
}
