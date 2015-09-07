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
    public partial class MatchPlayerManage : Form
    {
        public MatchPlayerManage(MainForm mainForm)
        {
            InitializeComponent();
            this.MdiParent = mainForm;
        }

        #region[窗体事件]
        //加载
        private void MatchPlayerManage_Load(object sender, EventArgs e)
        {

        }
        //显示
        private void MatchPlayerManage_Shown(object sender, EventArgs e)
        {
            //显示数据
            this.showDataInfo();
            //窗体最大化
            this.WindowState = FormWindowState.Maximized;
        }
        //改变大小
        private void MatchPlayerManage_Resize(object sender, EventArgs e)
        {
            this.setComponentLocation();
        }
        #endregion

        #region[表格事件]

        #region[未分配球员]
        //单击单元格
        private void dataGridView_notAssignedPlayer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //清除已分配球队信息表中选中的行的数据信息
                    dataGridView_assignedPlayer.ClearSelection();
                }
            }
            catch
            {
            }
        }
        //画表格行
        private void dataGridView_notAssignedPlayer_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView_notAssignedPlayer.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView_notAssignedPlayer.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView_notAssignedPlayer.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        #endregion

        #region[已分配球员]
        //单击单元格
        private void dataGridView_assignedPlayer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //清除已分配球队信息表中选中的行的数据信息
                    dataGridView_notAssignedPlayer.ClearSelection();
                }
            }
            catch
            {
            }
        }
        //画表格行
        private void dataGridView_assignedPlayer_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView_assignedPlayer.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView_assignedPlayer.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView_assignedPlayer.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        #endregion

        #endregion

        #region[按钮事件]
        //添加选中的人
        private void button_Add_Click(object sender, EventArgs e)
        {
            this.addSelectedPlayer_NewEdition();
        }
        //添加全部人
        private void button_addAll_Click(object sender, EventArgs e)
        {
            this.addAllPlayer_NewEdition();
        }
        //移除选中的人
        private void button_remove_Click(object sender, EventArgs e)
        {
            this.removeSelectedPlayer_NewEdition();
        }
        //移除全部的人
        private void button_removeAll_Click(object sender, EventArgs e)
        {
            this.removeAllPlayer_newEdition();
        }
        //关闭
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region[显示数据]
        //显示窗体中的数据信息
        private void showDataInfo()
        {
            //显示未分配球队信息
            this.showNotAssignedPlayer();
            //显示已分配球队信息
            this.showAssignedPlayer();
        }
        //显示未分配球队信息
        private void showNotAssignedPlayer()
        {
            if (dataGridView_notAssignedPlayer.Rows.Count > 0)  //若已经有记录，先清除记录
            {
                dataGridView_notAssignedPlayer.Rows.Clear();
            }
            //取出数据
            List<FootballPlayer> list = MatchPlayerInfoDAO.getNotAssignedPlayerInfo(SystemParam.getMatch().getID());
            //声明实例
            FootballPlayer player = new FootballPlayer();
            //往dataGridView中添加数据
            for (int i = 0; i < list.Count; i++)
            {
                player = list[i];  //取出线性表中的赛事的信息
                dataGridView_notAssignedPlayer.Rows.Add(player.getID().ToString(), player.getName(), player.getNumber().ToString(), player.getPostion(), player.getBelongTeam());
            }
        }
        //显示已分配球队信息
        private void showAssignedPlayer()
        {
            if (dataGridView_assignedPlayer.Rows.Count > 0)//若已经有记录，先清除记录
            {
                dataGridView_assignedPlayer.Rows.Clear();
            }
            //取出数据
            List<FootballPlayer> list = MatchPlayerInfoDAO.getAssignedPlayerInfo(SystemParam.getMatch().getID());
            //声明实例
            FootballPlayer player = new FootballPlayer();
            //往dataGridView中添加数据
            for (int i = 0; i < list.Count; i++)
            {
                player = list[i];  //取出线性表中的赛事的信息
                dataGridView_assignedPlayer.Rows.Add(player.getID().ToString(), player.getName(), player.getNumber().ToString(), player.getPostion(), player.getBelongTeam());
            }
        }
        #endregion

        #region[添加球员]
        //添加被选中的球队信息
        private void addSelectedPlayer()
        {
            //记录被选中的行的个数
            int selectedRowCount = dataGridView_notAssignedPlayer.SelectedRows.Count;
            if (selectedRowCount > 0)  //当且仅当有选中行时，才执行
            {
                //用于记录对应的行中球队的编号
                int playerID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<FootballPlayer> list = new List<FootballPlayer>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_notAssignedPlayer.Rows.Count; i++)
                    {
                        if (dataGridView_notAssignedPlayer.Rows[i].Selected == true)  //当记录到某一行被选中时
                        {
                            //记录被选中的行的球队编号
                            playerID = Convert.ToInt32(dataGridView_notAssignedPlayer.Rows[i].Cells["Player_ID"].Value);
                            //往线性表中添加记录
                            list.Add(PlayerInfoDAO.getPlayerInfo(playerID));
                            if (--selectedRowCount == 0)  //当所有被选中的行全部被取到时，跳出循环
                            {
                                break;
                            }
                        }
                    }
                    //执行添加赛事球队操作
                    MatchPlayerInfoDAO.addMatchPlayerInfoRecord(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("请至少选中一个球员", "未选中球员", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //添加被选中的球队信息，新版本
        private void addSelectedPlayer_NewEdition()
        {
            //记录被选中的行的个数
            int selectedRowCount = dataGridView_notAssignedPlayer.SelectedRows.Count;
            if (selectedRowCount > 0)  //当且仅当有选中行时，才执行
            {
                //用于记录对应的行中球队的编号
                int playerID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<int> list = new List<int>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_notAssignedPlayer.Rows.Count; i++)
                    {
                        if (dataGridView_notAssignedPlayer.Rows[i].Selected == true)  //当记录到某一行被选中时
                        {
                            //记录被选中的行的球队编号
                            playerID = Convert.ToInt32(dataGridView_notAssignedPlayer.Rows[i].Cells["Player_ID"].Value);
                            //往线性表中添加记录
                            list.Add(playerID);
                            if (--selectedRowCount == 0)  //当所有被选中的行全部被取到时，跳出循环
                            {
                                break;
                            }
                        }
                    }
                    //执行添加赛事球队操作
                    MatchPlayerInfoDAO.addMatchPlayerInfoRecord(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("请至少选中一个球员", "未选中球员", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //添加全部未被选中的球队信息
        private void addAllPlayer()
        {
            if (dataGridView_notAssignedPlayer.Rows.Count > 0)
            {
                //用于记录对应的行中球队的编号
                int playerID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<FootballPlayer> list = new List<FootballPlayer>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_notAssignedPlayer.Rows.Count; i++)
                    {
                        //记录被选中的行的球队编号
                        playerID = Convert.ToInt32(dataGridView_notAssignedPlayer.Rows[i].Cells["Player_ID"].Value);
                        //往线性表中添加记录
                        list.Add(PlayerInfoDAO.getPlayerInfo(playerID));
                    }
                    //执行添加赛事球队操作
                    MatchPlayerInfoDAO.addMatchPlayerInfoRecord(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("未分配球员数量为0", "球员数量空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //添加全部未被选中的球队信息，新版本
        private void addAllPlayer_NewEdition()
        {
            if (dataGridView_notAssignedPlayer.Rows.Count > 0)
            {
                //用于记录对应的行中球队的编号
                int playerID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<int> list = new List<int>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_notAssignedPlayer.Rows.Count; i++)
                    {
                        //记录被选中的行的球队编号
                        playerID = Convert.ToInt32(dataGridView_notAssignedPlayer.Rows[i].Cells["Player_ID"].Value);
                        //往线性表中添加记录
                        list.Add(playerID);
                    }
                    //执行添加赛事球队操作
                    MatchPlayerInfoDAO.addMatchPlayerInfoRecord(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("未分配球员数量为0", "球员数量空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region[移除球员]
        //移除被选中的球队
        private void removeSelectedPlayer()
        {
            //记录被选中的行的个数
            int selectedRowCount = dataGridView_assignedPlayer.SelectedRows.Count;
            if (selectedRowCount > 0)  //当且仅当有选中行时，才执行
            {
                //用于记录对应的行中球队的编号
                int playerID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<FootballPlayer> list = new List<FootballPlayer>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_assignedPlayer.Rows.Count; i++)
                    {
                        if (dataGridView_assignedPlayer.Rows[i].Selected == true)  //当记录到某一行被选中时
                        {
                            //记录被选中的行的球队编号
                            playerID = Convert.ToInt32(dataGridView_assignedPlayer.Rows[i].Cells["_player_ID"].Value);
                            //往线性表中添加记录
                            list.Add(PlayerInfoDAO.getPlayerInfo(playerID));
                            if (--selectedRowCount == 0)  //当所有被选中的行全部被取到时，跳出循环
                            {
                                break;
                            }
                        }
                    }
                    //执行添加赛事球队操作
                    MatchPlayerInfoDAO.deletMatchPlayerInfoRecord(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("请至少选中一个球员", "未选中球员", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //移除被选中的球队，新版本
        private void removeSelectedPlayer_NewEdition()
        {
            //记录被选中的行的个数
            int selectedRowCount = dataGridView_assignedPlayer.SelectedRows.Count;
            if (selectedRowCount > 0)  //当且仅当有选中行时，才执行
            {
                //用于记录对应的行中球队的编号
                int playerID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<int> list = new List<int>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_assignedPlayer.Rows.Count; i++)
                    {
                        if (dataGridView_assignedPlayer.Rows[i].Selected == true)  //当记录到某一行被选中时
                        {
                            //记录被选中的行的球队编号
                            playerID = Convert.ToInt32(dataGridView_assignedPlayer.Rows[i].Cells["_player_ID"].Value);
                            //往线性表中添加记录
                            list.Add(playerID);
                            if (--selectedRowCount == 0)  //当所有被选中的行全部被取到时，跳出循环
                            {
                                break;
                            }
                        }
                    }
                    //执行添加赛事球队操作
                    MatchPlayerInfoDAO.deletMatchPlayerInfoRecord(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("请至少选中一个球员", "未选中球员", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //移除全部球队
        private void removeAllPlayer()
        {
            if (dataGridView_assignedPlayer.Rows.Count > 0)
            {
                //用于记录对应的行中球队的编号
                int playerID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<FootballPlayer> list = new List<FootballPlayer>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_assignedPlayer.Rows.Count; i++)
                    {
                        //记录被选中的行的球队编号
                        playerID = Convert.ToInt32(dataGridView_assignedPlayer.Rows[i].Cells["_player_ID"].Value);
                        //往线性表中添加记录
                        list.Add(PlayerInfoDAO.getPlayerInfo(playerID));
                    }
                    //执行添加赛事球队操作
                    MatchPlayerInfoDAO.deletMatchPlayerInfoRecord(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("已分配球员数量为0", "球员数量空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //移除全部球队，新版本
        private void removeAllPlayer_newEdition()
        {
            if (dataGridView_assignedPlayer.Rows.Count > 0)
            {
                //用于记录对应的行中球队的编号
                int playerID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<int> list = new List<int>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_assignedPlayer.Rows.Count; i++)
                    {
                        //记录被选中的行的球队编号
                        playerID = Convert.ToInt32(dataGridView_assignedPlayer.Rows[i].Cells["_player_ID"].Value);
                        //往线性表中添加记录
                        list.Add(playerID);
                    }
                    //执行添加赛事球队操作
                    MatchPlayerInfoDAO.deletMatchPlayerInfoRecord(SystemParam.getMatch().getID(), list);
                    //刷新表格中的数据信息
                    this.showDataInfo();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("已分配球员数量为0", "球员数量空", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

    }
}
