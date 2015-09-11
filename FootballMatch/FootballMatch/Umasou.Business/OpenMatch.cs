using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using FootballMatch.Umasou.Model;
using FootballMatch.Umasou.DBA;
using FootballMatch.Umasou.Util;

namespace FootballMatch.Umasou.Business
{
    public partial class OpenMatch : Form
    {
        

        public OpenMatch()
        {
            InitializeComponent();
            SystemParam.setOpenMatchForm(this);
        }

        #region[实例变量]
        private int matchID;  //记录被选中的赛季的ID值
        private int rowIndex;  //记录表格的行号
        private SeasonMatch match;  //记录赛事的信息的变量
        private SeasonOfMatch season;  //记录选择赛事的赛季信息
        private List<SeasonOfMatch> seasonList;   //一个赛事所有的赛季信息
        #endregion

        #region[窗体事件]
        //显示数据
        private void OpenMatch_Shown(object sender, EventArgs e)
        {
            this.showMatchData();
        }
        #endregion

        #region[表格事件]
        //单击表格的单元格
        private void dataGridView_match_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    try
                    {
                        matchID = Convert.ToInt32(dataGridView_match.Rows[e.RowIndex].Cells["match_ID"].Value);
                        rowIndex = e.RowIndex;
                        match = ContentDAO.getMatchInfo(matchID);
                        textBox_Name.Text = match.getName();
                        //
                        seasonList= SeasonInfoDAO.getSeasonsOfCertainMatch(match.getName());
                        this.cleanListBox();
                   ////如果当前赛事没有创建赛季，则弹窗要求创建一个赛季
                        if (seasonList.Count != 0)  //存在相应的赛季
                        {
                            listBox_Seasons.Items.Clear();
                            richTextBox_SeasonDescription.Text = "";
                            foreach (SeasonOfMatch s in seasonList)
                            {
                                listBox_Seasons.Items.Add("第" + s.getNumOfSeason() + "赛季");

                            }


                            richTextBox_MatchDescription.Text = match.getDescription();
                        }
                        else {
                            MessageBox.Show("您当前选中的赛事没有设置赛季，请至少添加一个赛季！","无赛季信息");
                            SystemParam.setMatch(match);
                            CreateNewSeason newSeason = new CreateNewSeason();
                            newSeason.Show();
                        
                        }

                    }
                    catch (NullReferenceException ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            catch
            {
            }
        }
        //双击表格的单元格
        /******
        private void dataGridView_match_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)  //当单元格的行数大于等于0时才执行
                {
                    matchID = Convert.ToInt32(dataGridView_match.Rows[e.RowIndex].Cells["match_ID"].Value);
                    rowIndex = e.RowIndex;
                    match = ContentDAO.getMatchInfo(matchID);
                    SystemParam.setMatchID(matchID);
                    SystemParam.setMatch(match);
                    //刷新主窗体中显示的数据信息
                    if (!SystemParam.getMainForm().checkChildFormExist("AvaliableInfo"))
                    {
                        if (SystemParam.getMatch() != null)
                        {
                            SystemParam.setAvaliableInfoForm(new AvaliableInfo(SystemParam.getMainForm()));
                            SystemParam.getAvaliableInfoForm().Show();
                        }
                        else
                        {
                            if (MessageBox.Show("请先选择打开一个赛事", "打开赛事提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                OpenMatch openMatch = new OpenMatch();
                                openMatch.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        SystemParam.getAvaliableInfoForm().flushDataInfo(SystemParam.getMatch());
                    }
                    //关闭本窗体
                    this.Close();
                }
            }
            catch
            {
            }
        }
       * *******/
        //画出表格的行数
        private void dataGridView_match_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView_match.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView_match.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView_match.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        #endregion

        #region[按钮事件]
        //确定按钮
        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                matchID = Convert.ToInt32(dataGridView_match.Rows[rowIndex].Cells["match_ID"].Value);
                match = ContentDAO.getMatchInfo(matchID);
                SystemParam.setMatchID(matchID);
                SystemParam.setMatch(match);
                SystemParam.setCurrentSelectedSeason(season);
               
                //测试
                SystemParam.setCurrentSelectedMatchName(match.getName());
                SystemParam.getDefaultPageForm().UpdateTreeView(season.getmatchName(), 5);

                //刷新主窗体中显示的数据信息
                if (!SystemParam.getMainForm().checkChildFormExist("AvaliableInfo"))
                {
                    if (SystemParam.getMatch() != null)
                    {
                        SystemParam.setAvaliableInfoForm(new AvaliableInfo(SystemParam.getMainForm()));
                        SystemParam.getAvaliableInfoForm().Show();
              
                    }
                    else
                    {
                        if (MessageBox.Show("请先选择打开一个赛事", "打开赛事提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            OpenMatch openMatch = new OpenMatch();
                            openMatch.ShowDialog();
                        }
                    }
                 



                }
                else
                {
                    SystemParam.getAvaliableInfoForm().flushDataInfo(SystemParam.getMatch());

                    try { SystemParam.getTeamManageForm().flushDataInfo(); }

                       catch (Exception ex) { MessageBox.Show("当前赛事没有球队"); }

                }

                 
                
                //关闭本窗体
                this.Close();
            }
            catch
            {
                MessageBox.Show("请选择相应的赛季！","提示");
            }
        }
        //取消按钮
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region[显示数据]
        //显示赛事的基本信息
        public  void showMatchData()
        {
            //先清除DataGridView中的数据
            if (dataGridView_match.Rows.Count > 0)
            {
                dataGridView_match.Rows.Clear();
            }
            //取出数据
            List<SeasonMatch> list = ContentDAO.getMatchInfo();
            Console.WriteLine("test");
            Console.WriteLine(list.Count);
            //往dataGridView中添加数据
            for (int i = 0; i < list.Count; i++)
            {
                match = list[i];  //取出线性表中的赛事的信息
                dataGridView_match.Rows.Add(match.getID().ToString(),match.getName(),match.getDescription(),match.getSwitchNum().ToString(),match.getSerialNum().ToString());
            }
        }
        #endregion
        //选择的值改变，则下边的赛季描述改变
        private void listBox_Seasons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(seasonList.Count>0){ 
            foreach (SeasonOfMatch s in seasonList)
            {
                  
                if (listBox_Seasons.SelectedItem.ToString().Trim() == ("第" + s.getNumOfSeason() + "赛季"))    //此处仍然存在空值问题
                { season = s; //作为选定的赛季
                richTextBox_SeasonDescription.Text = season.getSeasonDescription();
                }
              }
            }
            
             
        }

        private void dataGridView_match_KeyUp(object sender, KeyEventArgs e)
        {
             
            
                
                    try
                    {
                        matchID = Convert.ToInt32(dataGridView_match.SelectedRows[0].Cells["match_ID"].Value);
                        rowIndex = dataGridView_match.SelectedRows[0].Index;
                        match = ContentDAO.getMatchInfo(matchID);
                        textBox_Name.Text = match.getName();
                        //
                        seasonList = SeasonInfoDAO.getSeasonsOfCertainMatch(match.getName());
                        listBox_Seasons.Items.Clear();
                        richTextBox_SeasonDescription.Text = "";
                        foreach (SeasonOfMatch s in seasonList)
                        {
                            listBox_Seasons.Items.Add("第" + s.getNumOfSeason() + "赛季");

                        }


                        richTextBox_MatchDescription.Text = match.getDescription();



                    }
                    catch (NullReferenceException ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
        
        }

        private void dataGridView_match_KeyDown(object sender, KeyEventArgs e)
        {



            try
            {
                matchID = Convert.ToInt32(dataGridView_match.SelectedRows[0].Cells["match_ID"].Value);
                rowIndex = dataGridView_match.SelectedRows[0].Index;
                match = ContentDAO.getMatchInfo(matchID);
                textBox_Name.Text = match.getName();
                //
                seasonList = SeasonInfoDAO.getSeasonsOfCertainMatch(match.getName());
                listBox_Seasons.Items.Clear();
                richTextBox_SeasonDescription.Text = "";
                foreach (SeasonOfMatch s in seasonList)
                {
                    listBox_Seasons.Items.Add("第" + s.getNumOfSeason() + "赛季");

                }


                richTextBox_MatchDescription.Text = match.getDescription();



            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        

        }

        private void linkLabel_newMatch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateMatch newMatch = new CreateMatch();     
            newMatch.Show();
            
        }

        public void cleanListBox() {
            this.listBox_Seasons.Items.Clear();
        
        }

    }

 


}
