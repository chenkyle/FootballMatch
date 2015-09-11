using FootballMatch.Umasou.Model;
using FootballMatch.Umasou.Util;
using FootballMatch.Umasou.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballMatch.Umasou.DBA;

namespace FootballMatch.Umasou.Business
{
    
    public partial class AddNewGame : Form
    {
        private Schedule gameSchedule;

      
        public AddNewGame()
        {
            InitializeComponent();
            SystemParam.setAddNewGame(this);

        }


        //初始化界面下拉框以及对应标题
        public void initData() {
            //设置标题
            this.label_matchName.Text = SystemParam.getMatch().getName();
            SeasonOfMatch season=SystemParam.getCurrentSelectedSeason();
            this.label_seasonNum.Text = Convert.ToString(season.getNumOfSeason());

            //设置两个表格的某些列不能编辑
            this.dataGridView_homeTeamInfo.ReadOnly = false;
            foreach (DataGridViewColumn c in dataGridView_homeTeamInfo.Columns)
            {
                if (c.Index == 0 || c.Index == 1 || c.Index == 4)
                {   c.ReadOnly = true; 
                    this.dataGridView_homeTeamInfo.Columns[c.Index].DefaultCellStyle.BackColor=Color.LightPink;
                }
            }
            this.dataGridView_guestTeamInfo.ReadOnly = false;
            foreach (DataGridViewColumn c in dataGridView_guestTeamInfo.Columns)
            {
                if (c.Index == 0 || c.Index == 1 || c.Index == 4)
                {
                    c.ReadOnly = true;
                    this.dataGridView_guestTeamInfo.Columns[c.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
            

            //设置下拉框
            for (int i = 1; i <=season.getNumOfTurn();i++ )
            {
                this.comboBox_gameTurn.Items.Add(i);
            }
            
        
        }


        

        private void AddNewGame_Load(object sender, EventArgs e)
        {
            this.initData();
        }

        private void button_chooseGame_Click(object sender, EventArgs e)
        {
            this.cleanDataGridView();
            ChooseGameOfSchedule chooseForm = new ChooseGameOfSchedule();
            chooseForm.Show();



        }


        public void LoadScheduleInfo(Schedule s) {

            this.gameSchedule = s;
        }

        public void setGameInfo() {

            this.textbox_homeTeamName.Text = gameSchedule.getHomeTeam();
            this.textbox_guestTeamName.Text = gameSchedule.getGuestTeam();
            this.textBox_gameTime.Text = gameSchedule.getGameDate();

            this.comboBox_WinTeam.Items.Add(gameSchedule.getHomeTeam());
            this.comboBox_WinTeam.Items.Add(gameSchedule.getGuestTeam());
        
        }
        //文本值变化则，则更新datagridview的球员信息
        private void textbox_homeTeamName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox_home  = (TextBox)sender;

            Console.WriteLine(textBox_home.Text);
            this.loadDataGridViewInfo_Home(textBox_home.Text);
            Team team = TeamInfoDAO.getTeamInfo(textBox_home.Text);

            this.textBox_Address.Text = team.getLocation(); 

        }

        private void textbox_guestTeamName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox_guest = (TextBox)sender;

            Console.WriteLine(textBox_guest.Text);
            this.loadDataGridViewInfo_Guest(textBox_guest.Text);
        }

        public void loadDataGridViewInfo_Home(string teamName) {

            List<FootballPlayer> playerList_h = new List<Model.FootballPlayer>();
            playerList_h = ContentDAO.getPlayerInfoOfCertainTeam(teamName); 
            for (int i = 0; i < playerList_h.Count;i++ ) {

                 //查找每一位球员的上一场统计数据，包括累计的黄牌数量、上一场设置的下一场停赛标志



                this.dataGridView_homeTeamInfo.Rows.Add(playerList_h[i].getName(), playerList_h[i].getNumber());
            }
             
        }
        public void loadDataGridViewInfo_Guest(string teamName)
        { 

            List<FootballPlayer> playerList_g = new List<Model.FootballPlayer>();
            playerList_g = ContentDAO.getPlayerInfoOfCertainTeam(teamName);
            for (int i = 0; i < playerList_g.Count; i++)
            {
                this.dataGridView_guestTeamInfo.Rows.Add(playerList_g[i].getName(), playerList_g[i].getNumber());
            }
        }



        //清空两个dataGridView
        public void cleanDataGridView() {

            this.dataGridView_homeTeamInfo.Rows.Clear();
            this.dataGridView_guestTeamInfo.Rows.Clear();
            this.textbox_homeTeamName.Text = "";
            this.textbox_guestTeamName.Text = "";
        }

        //
        private void button_reset_Click(object sender, EventArgs e)
        {
            this.cleanDataGridView();
            this.textbox_homeTeamName.Text = "";
            this.textbox_guestTeamName.Text = "";
            this.comboBox_WinTeam.Text = "";
            this.textBox_gameResult.Text = "";
            this.textBox_gameTime.Text = "";
            this.textBox_Address.Text = "";
            
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
