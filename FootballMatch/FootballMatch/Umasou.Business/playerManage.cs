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
    public partial class playerManage : Form
    {
        private List<Team> teamList;
        private string selectedTeamName="";

        public playerManage(MainForm mainForm)
        {
            InitializeComponent();
            this.MdiParent = mainForm;
        }

        #region[声明实例]
        private FootballPlayer player;  //记录球员信息
        private int rowIndex;  //记录行下标
        #endregion

        #region[窗体事件]

        private void playerManage_Load(object sender, EventArgs e)
        {

        }

        private void playerManage_Shown(object sender, EventArgs e)
        {
            //显示数据
            this.showCertainTeamPlayerData();
            //设置窗体最大化
            this.WindowState = FormWindowState.Maximized;
        }

        private void playerManage_Resize(object sender, EventArgs e)
        {
            //设置控件位置
            this.setLocation();
        }

        #endregion

        #region[表格事件]
        //画表格行数
        private void dataGridView_teamManage_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView_playerManage.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView_playerManage.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView_playerManage.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        //单击单元格事件
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
            CreateNewPlayer form = new CreateNewPlayer();
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
            //this.deletePlayerRecord();
            this.deleteSelectedPlayerRecord_NewEdition();
        }
        //关闭
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region[显示数据]
        //显示赛事的基本信息
        public void showCertainTeamPlayerData()
        {   
           //给队伍列表添加数据源
            teamList = TeamInfoDAO.getTeamInfoOfCertainMatch(SystemParam.getMatch());
            ////如果当前赛事任何球队，则弹窗要求创建一些球队
            if (teamList.Count != 0)  //存在相应的赛季
            {
                listBox_TeamList.Items.Clear();
                foreach (Team t in teamList)
                {
                    listBox_TeamList.Items.Add(t.getName());
                }

                this.loadDataOfDatagridView();

            }
            else {
                MessageBox.Show("此赛事当前没有球队，请您创建球队！");
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

            dataGridView_playerManage.Top = preTop + 10;
            dataGridView_playerManage.Left = preLeft + 10;
            dataGridView_playerManage.Width = preWidth - 20;
            dataGridView_playerManage.Height = preHeight - 30 - groupBox_playerManage.Height;

            groupBox_playerManage.Left = preRight - 10 - groupBox_playerManage.Width;
            groupBox_playerManage.Top = preBottom - 10 - groupBox_playerManage.Height;
        }
        #endregion

        #region[删除数据]
        //删除某一行指定的数据
        private void deletePlayerRecord()
        {
            try
            {
                int playerID = Convert.ToInt32(dataGridView_playerManage.Rows[rowIndex].Cells["Player_ID"].Value);
                //删除数据库中的记录
                ContentDAO.deletePlayerInfo(playerID);
                //移除表格中的对应的行
                dataGridView_playerManage.Rows.RemoveAt(rowIndex);
            }
            catch
            {
            }
        }
        //删除选中的多行
        private void deleteSelectedPlayerRecord()
        {
            //记录被选中的行数
            int selectedRowCount = dataGridView_playerManage.SelectedRows.Count;
            if (selectedRowCount > 0)
            {
                //用于记录对应的行中球队的编号
                int playerID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<FootballPlayer> list = new List<FootballPlayer>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_playerManage.Rows.Count; i++)
                    {
                        if (dataGridView_playerManage.Rows[i].Selected == true)  //当记录到某一行被选中时
                        {
                            //记录被选中的行的球队编号
                            playerID = Convert.ToInt32(dataGridView_playerManage.Rows[i].Cells["Player_ID"].Value);
                            //往线性表中添加记录
                            list.Add(PlayerInfoDAO.getPlayerInfo(playerID));
                            if (--selectedRowCount == 0)  //当所有被选中的行全部被取到时，跳出循环
                            {
                                break;
                            }
                        }
                    }
                    //执行删除球队信息操作
                    PlayerInfoDAO.deletePlayerInfo(list);
                    //刷新表格中的数据信息
                    this.showCertainTeamPlayerData();
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
        //删除选中的多行，新版本
        private void deleteSelectedPlayerRecord_NewEdition()
        {
            //记录被选中的行数
            int selectedRowCount = dataGridView_playerManage.SelectedRows.Count;
            if (selectedRowCount > 0)
            {
                //用于记录对应的行中球队的编号
                int playerID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<int> list = new List<int>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_playerManage.Rows.Count; i++)
                    {
                        if (dataGridView_playerManage.Rows[i].Selected == true)  //当记录到某一行被选中时
                        {
                            //记录被选中的行的球队编号
                            playerID = Convert.ToInt32(dataGridView_playerManage.Rows[i].Cells["Player_ID"].Value);
                            //往线性表中添加记录
                            list.Add(playerID);
                            if (--selectedRowCount == 0)  //当所有被选中的行全部被取到时，跳出循环
                            {
                                break;
                            }
                        }
                    }
                    //执行删除球队信息操作
                    PlayerInfoDAO.deletePlayerInfo(list);
                    //刷新表格中的数据信息
                    this.showCertainTeamPlayerData(); 
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
                {   if(this.dataGridView_playerManage.Rows.Count>0){

                    int playerID = Convert.ToInt32(dataGridView_playerManage.Rows[rowIndex].Cells["Player_ID"].Value);
                    FootballPlayer player = PlayerInfoDAO.getPlayerInfo(playerID);
                    AlterPlayer form = new AlterPlayer(player);
                    form.ShowDialog();}
                else{
                    MessageBox.Show("当前球队无球员!");
                }
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        #endregion

        //增加事件重画ListBox
        private void listBox_TeamList_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            StringFormat strFmt = new System.Drawing.StringFormat();
           // strFmt.Alignment = StringAlignment.Center; //文本垂直居中
            //strFmt.LineAlignment = StringAlignment.Center; //文本水平居中
            e.Graphics.DrawString(listBox_TeamList.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, strFmt);
        }
        
        
        
        //选定值改变，则右侧的datagridview重新获取相应球队的球员信息
        private void listBox_TeamList_SelectedIndexChanged(object sender, EventArgs e)
        {
             selectedTeamName =listBox_TeamList.SelectedItem.ToString().Trim();
             label_teamName.Text = selectedTeamName;
            this.loadDataOfDatagridView();
                
            

        }

        public void loadDataOfDatagridView()
        {

            //先清除dataGridView中的数据
            if (this.dataGridView_playerManage.Rows.Count > 0)
            {
                dataGridView_playerManage.Rows.Clear();
            }
            //取出数据
            List<FootballPlayer> list = ContentDAO.getPlayerInfoOfCertainTeam(selectedTeamName); 
            for (int i = 0; i < list.Count;i++ )
            {
                player = list[i];
                dataGridView_playerManage.Rows.Add(player.getID(),player.getName(),player.getNumber(),player.getNumber().ToString(),player.getPostion(),player.getBelongTeam(),player.getIDnum());
            }
        }

        private void linkLabel_PlayerExcelImport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

             PlayerExcelImport playerExcel = new PlayerExcelImport();
             playerExcel.Show();


        }


    }
}
