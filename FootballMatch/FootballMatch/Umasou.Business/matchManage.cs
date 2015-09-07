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
    public partial class matchManage : Form
    {
        public matchManage(MainForm mainForm)
        {
            InitializeComponent();
            this.MdiParent = mainForm;
        }

        #region[实例变量]
        private int rowIndex;  //记录表格的行号
        private SeasonMatch match;  //记录赛事的信息的变量
        #endregion

        #region[窗体事件]

        private void matchManage_Load(object sender, EventArgs e)
        {

        }

        private void matchManage_Shown(object sender, EventArgs e)
        {
            //显示数据
            this.showMatchData();
            //设置窗体最大化
            this.WindowState = FormWindowState.Maximized;
        }

        private void matchManage_Resize(object sender, EventArgs e)
        {
            this.setLocation();
        }

        #endregion

        #region[表格事件]
        //画表格行数
        private void dataGridView_match_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView_match.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView_match.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView_match.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        //单击单元格事件
        private void dataGridView_match_CellClick(object sender, DataGridViewCellEventArgs e)
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
            CreateMatch form = new CreateMatch();
            form.ShowDialog();
            //刷新页面
          //  this.showMatchData();
        }
        //修改
        private void alter_Click(object sender, EventArgs e)
        {
            try
            {
                int matchID = Convert.ToInt32(dataGridView_match.Rows[rowIndex].Cells["match_ID"].Value);
                match = ContentDAO.getMatchInfo(matchID);
                //打开修改窗体
                AlterMatch form = new AlterMatch(match);
                form.ShowDialog();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        //删除
        private void delete_Click(object sender, EventArgs e)
        {
            //this.deleteMatchRecord();
            this.deleteSelectedMatchRecord_NewEdition();
        }
        //关闭
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region[显示数据]
        //显示赛事的基本信息
        public void showMatchData()
        {
            //先清除DataGridView中的数据
            if (dataGridView_match.Rows.Count > 0)
            {
                dataGridView_match.Rows.Clear();
            }
            //取出数据
            List<SeasonMatch> list = ContentDAO.getMatchInfo();
            //往dataGridView中添加数据
            for (int i = 0; i < list.Count; i++)
            {
                match = list[i];  //取出线性表中的赛事的信息
                dataGridView_match.Rows.Add(match.getID().ToString(), match.getName(), match.getDescription(), match.getSwitchNum().ToString(), match.getSerialNum().ToString());
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

            dataGridView_match.Top = preTop + 10;
            dataGridView_match.Left = preLeft + 10;
            dataGridView_match.Width = preWidth - 20;
            dataGridView_match.Height = preHeight - 30 - groupBox_teamManage.Height;

            groupBox_teamManage.Left = preRight - 10 - groupBox_teamManage.Width;
            groupBox_teamManage.Top = preBottom - 10 - groupBox_teamManage.Height;
        }
        #endregion

        #region[删除数据]
        //删除选中的单行
        private void deleteMatchRecord()
        {
            try
            {
                int matchID = Convert.ToInt32(dataGridView_match.Rows[rowIndex].Cells["match_ID"].Value);
                //删除数据库中的记录
                ContentDAO.deleteMatchInfo(matchID);
                //移除表格中的对应的行
                dataGridView_match.Rows.RemoveAt(rowIndex);
            }
            catch
            {
            }
        }
        //删除选中的多行
        private void deleteSelectedMatchRecord()
        {
            //记录被选中的行数
            int selectedRowCount = dataGridView_match.SelectedRows.Count;
            if (selectedRowCount > 0)
            {
                //用于记录对应的行中球队的编号
                int matchID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<SeasonMatch> list = new List<SeasonMatch>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_match.Rows.Count; i++)
                    {
                        if (dataGridView_match.Rows[i].Selected == true)  //当记录到某一行被选中时
                        {
                            //记录被选中的行的球队编号
                            matchID = Convert.ToInt32(dataGridView_match.Rows[i].Cells["match_ID"].Value);
                            //往线性表中添加记录
                            list.Add(MatchInfoDAO.getMatchInfo(matchID));
                            if (--selectedRowCount == 0)  //当所有被选中的行全部被取到时，跳出循环
                            {
                                break;
                            }
                        }
                    }
                    //执行删除球队信息操作
                    MatchInfoDAO.deleteMatchInfo(list);
                    //刷新表格中的数据信息
                    this.showMatchData();
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
        private void deleteSelectedMatchRecord_NewEdition()
        {
            //记录被选中的行数
            int selectedRowCount = dataGridView_match.SelectedRows.Count;
            if (selectedRowCount > 0)
            {
                //用于记录对应的行中球队的编号
                int matchID = -1;
                //声明一个线性表，用于记录获得的球队信息
                List<int> list = new List<int>();
                try
                {
                    //取出全部被选中的行的球队信息，并且添加到线性表中
                    for (int i = 0; i < dataGridView_match.Rows.Count; i++)
                    {
                        if (dataGridView_match.Rows[i].Selected == true)  //当记录到某一行被选中时
                        {
                            //记录被选中的行的球队编号
                            matchID = Convert.ToInt32(dataGridView_match.Rows[i].Cells["match_ID"].Value);
                            //往线性表中添加记录
                            list.Add(matchID);
                            if (--selectedRowCount == 0)  //当所有被选中的行全部被取到时，跳出循环
                            {
                                break;
                            }
                        }
                    }
                    //执行删除球队信息操作
                    MatchInfoDAO.deleteMatchInfo(list);
                    //刷新表格中的数据信息
                    this.showMatchData();
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
    }
}
