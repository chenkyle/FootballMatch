using FootballMatch.Umasou.DBA;
using FootballMatch.Umasou.Model;
using FootballMatch.Umasou.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballMatch.Umasou.Business
{
    public partial class ChooseGameOfSchedule : Form
    {
        private string matchName_schedule;
        private int seasonNum_schedule;
        public ChooseGameOfSchedule()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
     
        private void ChooseGameOfSchedule_Load(object sender, EventArgs e)
        {
            this.loadData();

        }

        //初始化表格
        public void loadData()
        {

            matchName_schedule = SystemParam.getMatch().getName();

            List<Schedule> sList = new List<Schedule>();
            sList = ScheduleDAO.getScheduleInfo(SystemParam.getCurrentSelectedSeason());

            //先清除DataGridView中的数据
            if (this.dataGridView_schedule.Rows.Count > 0)
            {
                this.dataGridView_schedule.Rows.Clear();
            }
            //往dataGridView中添加数据
            for (int i = 0; i < sList.Count; i++)
            {
                Schedule s = sList[i];  //取出线性表中的赛事的信息
                seasonNum_schedule = s.getSeasonId();
                dataGridView_schedule.Rows.Add(s.getHomeTeam(), s.getGuestTeam(), s.getTurn(), s.getGameDate(), seasonNum_schedule, matchName_schedule);
           
            
            }
        }
        //选择比赛球队
        private void button_choose_Click(object sender, EventArgs e)
        {
            Schedule gs = new Schedule();
            gs.setHomeTeam(textBox_homeTeam.Text);
            gs.setGuestTeam(textBox_guestTeam.Text);
            gs.setGameDate(label_gameDate.Text);
            SystemParam.getAddNewGameForm().LoadScheduleInfo(gs);
            SystemParam.getAddNewGameForm().setGameInfo();

            this.Dispose();
        }

        private void dataGridView_schedule_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView_schedule.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView_schedule.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView_schedule.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);

        }

        private void dataGridView_schedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                        label_MatchName.Text = Convert.ToString(this.dataGridView_schedule.Rows[e.RowIndex].Cells["matchName"].Value);
                        label_seasonNum.Text = Convert.ToString(this.dataGridView_schedule.Rows[e.RowIndex].Cells["seasonNum"].Value);
                        label_turn.Text = Convert.ToString(this.dataGridView_schedule.Rows[e.RowIndex].Cells["numOfTurn"].Value);
                        textBox_homeTeam.Text = Convert.ToString(this.dataGridView_schedule.Rows[e.RowIndex].Cells["homeTeam"].Value);
                        textBox_guestTeam.Text = Convert.ToString(this.dataGridView_schedule.Rows[e.RowIndex].Cells["guestTeam"].Value);
                        label_gameDate.Text = Convert.ToString(this.dataGridView_schedule.Rows[e.RowIndex].Cells["gameDate"].Value);
                }           
                 else
                    {
                            MessageBox.Show("您当前选中的赛事没有设置赛季，请至少添加一个赛季！", "无赛季信息");
                            
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
}
