using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FootballMatch.Umasou.Business;
using FootballMatch.Umasou.Util;
using FootballMatch.Umasou.Model;
using FootballMatch.Umasou.GameManage;
using FootballMatch.Umasou.CardRecord;
using FootballMatch.Umasou.View;
using FootballMatch.Umasou.DBA;

namespace FootballMatch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region[实例变量]
        private SeasonMatch _match; //记录被选中的赛事
        #endregion

        #region[窗体事件]
        //窗体加载
        //窗体显示
        private void MainForm_Shown(object sender, EventArgs e)
        {
            //设置窗体最大化
            this.WindowState = FormWindowState.Maximized;
            //默认设置数据读取
            DefaultSetDAO.getDefaultSet();
            //显示打开球队
            DefaultPage defaultPage = new DefaultPage(this);
            SystemParam.setDefaultPageForm(defaultPage);
            defaultPage.Show();

            //ReportOfInfo report = new ReportOfInfo(this);
           // report.Show();


            OpenMatch form = new OpenMatch();
            form.ShowDialog();
        }
        //窗体改变大小
        private void MainForm_Resize(object sender, EventArgs e)
        {

        }
        #endregion

        #region[菜单栏事件]

        #region[文件菜单]
        //新建
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMatch createMatch = new CreateMatch();
            createMatch.ShowDialog();
        }
        //打开事件
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMatch openMatch = new OpenMatch();
            openMatch.ShowDialog();
        }
        //退出事件
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  this.Dispose();
            Application.Exit();
        }
        #endregion

        #region[视图菜单]

        #region[罚牌统计]
        //赛事统计
        private void getCardmatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.checkChildFormExist("MatchChart"))
            {
                if (SystemParam.getMatch() != null)
                {
                    SystemParam.setCardMatchChartForm(new MatchChart(SystemParam.getMainForm()));
                    SystemParam.getCardMatchChartForm().Show();
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
        }
        //球队统计
        private void getCardteamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //球员统计
        private void getCardplayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region[停赛统计]
        //赛事统计
        private void suspendedmatchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //球队统计
        private void suspendedteamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //球员统计
        private void suspendedplayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region[获胜统计]
        //赛事统计
        private void winGamematchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //球队统计
        private void winGameteamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion

        #region[罚牌管理]
        //罚牌总览
        private void cardRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.checkChildFormExist("CardRecordManage"))
            {
                if (SystemParam.getMatch() != null)
                {
                    SystemParam.setCardRecordManageForm(new CardRecordManage(SystemParam.getMainForm()));
                    SystemParam.getCardRecordManageForm().Show();
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
        }
        //添加罚牌记录
        private void addCardRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SystemParam.getMatch() != null)
            {
                SystemParam.setAddPlayerCardRecordForm(new addPlayerCardRecordcs());
                SystemParam.getAddPlayerCardRecordsForm().ShowDialog();
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
        #endregion

        #region[比赛管理]
        //比赛总览
        private void gameSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.checkChildFormExist("GameSummary"))
            {
                if (SystemParam.getMatch() != null)
                {
                    SystemParam.setGameSummaryForm(new GameSummary(SystemParam.getMainForm()));
                    SystemParam.getGameSummaryForm().Show();
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
        }
        //添加比赛信息
        private void createMatchGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SystemParam.getMatch() != null)
            {
                //显示新建比赛信息的窗体
                CreateNewGame form = new CreateNewGame();
                form.ShowDialog();
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
        #endregion

        #region[系统管理]
        //赛季管理，管理所有的赛季的基本信息，可以删除，修改，添加等
        private void matchManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.checkChildFormExist("matchManage"))
            {
                SystemParam.setMatchManageForm(new matchManage(SystemParam.getMainForm()));
                SystemParam.getMatchManageForm().Show();
            }
            else {

                SystemParam.getMatchManageForm().Activate();
               // this.openFormWithoutOtherChlidForm(this,SystemParam.getMatchManageForm());
            }

        }
        //球队管理，管理所有的球队基本信息，可以删除，修改，添加等
        private void teamManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.checkChildFormExist("teamManage"))
            {
                SystemParam.setTeamManageForm(new teamManage(SystemParam.getMainForm()));
                SystemParam.getTeamManageForm().Show();
            }

            else
            {
                SystemParam.getTeamManageForm().Activate();
                //this.openFormWithoutOtherChlidForm(this, SystemParam.getTeamManageForm());
            }

        }
        //球员管理,管理所有的球员，设定球员所属的球队，可以删除，修改，添加等
        private void memberManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.checkChildFormExist("playerManage"))
            {
                SystemParam.setPlayerManageForm(new playerManage(SystemParam.getMainForm()));
                SystemParam.getPlayerManageForm().Show();
            }
            else
            {
                SystemParam.getPlayerManageForm().Activate();
               // this.openFormWithoutOtherChlidForm(this, SystemParam.getPlayerManageForm());
            }

        }
        //赛季球队管理，为某一个赛季分配球队，设定某个赛季中有哪些球队参赛，只有设定分配好球队之后，才能为赛季分配球员
        private void matchTeamManage_Click(object sender, EventArgs e)
        {
            if (!this.checkChildFormExist("MatchTeamManage"))
            {
                if (SystemParam.getMatch() != null)
                {
                    SystemParam.setMatchTeamManageForm(new MatchTeamManage(SystemParam.getMainForm()));
                    SystemParam.getMatchTeamManageForm().Show();
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
        }
        //赛季球员管理，为某一个赛季分配参赛的球员，必须在分配好球队之后才能分配球员
        private void matchPlayerManage_Click(object sender, EventArgs e)
        {
            if (!this.checkChildFormExist("MatchPlayerManage"))
            {
                if (SystemParam.getMatch() != null)
                {
                    SystemParam.setMatchPlayerManageForm(new MatchPlayerManage(SystemParam.getMainForm()));
                    SystemParam.getMatchPlayerManageForm().Show();
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
        }
        #endregion

        #endregion

        #region[工具栏事件]

        #region[文件事件]
        //新建
        private void toolStripButton_Create_Click(object sender, EventArgs e)
        {
            CreateMatch createMatch = new CreateMatch();
            createMatch.ShowDialog();
        }
        //打开
        private void toolStripButton_Open_Click(object sender, EventArgs e)
        {
            OpenMatch openMatch = new OpenMatch();
            openMatch.ShowDialog();
        }
        //显示球赛状态
        private void toolStripButton_showRecord_Click(object sender, EventArgs e)
        {
            if (!this.checkChildFormExist("AvaliableInfo"))
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
        }
        //添加罚牌记录
        private void toolStripButton_addRecord_Click(object sender, EventArgs e)
        {
            
        }
        //退出
        private void toolStripButton_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #endregion

        #region[常规方法]
        #region[判断子窗体是否存在]
        //判断某一个子窗体是否已经存在,当已经打开该子窗体时，返回值是真
        public bool checkChildFormExist(string childFormName)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (childFormName == this.MdiChildren[i].Name)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region[打开一个子窗体的同时，关闭其他子窗体]
        //检查要打开的子窗体是否已经打开

        public void openFormWithoutOtherChlidForm(Form MdiForm, Form ChildForm) {

            foreach (Form tempChildForm in MdiForm.MdiChildren)
            {
                if (tempChildForm.Name != ChildForm.Name.ToString()) //用子窗体的Name进行判断是否已实例化，如果存在则将他激活
                {
                   
                    tempChildForm.Close();
                }
            }
             
             
           ChildForm.MdiParent = MdiForm;
           ChildForm.Show();

        }
        #endregion

        #endregion



        //新建一个联赛类型,填充相关联赛信息
        private void newMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMatch createMatch = new CreateMatch();
            createMatch.ShowDialog();
        }

        //浏览所有已有的所有联赛,可执行相应的增删改查
        private void totalMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!this.checkChildFormExist("matchManage"))
            {
                SystemParam.setMatchManageForm(new matchManage(SystemParam.getMainForm()));
                SystemParam.getMatchManageForm().Show();
            }
            else {
                SystemParam.getMatchManageForm().Activate();
                //this.openFormWithoutOtherChlidForm(this,SystemParam.getMatchManageForm());
            }

        }
        //
        private void NewSeasonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewSeason createNewSeason = new CreateNewSeason();
            createNewSeason.ShowDialog();
        }

        //浏览所有库中存在的赛季
        private void TotalSeasonsToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (!this.checkChildFormExist("SeasonManage"))
            {
                SystemParam.setSeasonManageForm(new SeasonManage(SystemParam.getMainForm()));
                SystemParam.getSeasonManageForm().Show();
            }

            else
            {
                SystemParam.getSeasonManageForm().Activate();
               //this.openFormWithoutOtherChlidForm(this, SystemParam.getSeasonManageForm());

            }

        }

        private void ViewMatchTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_backToHomePage_Click(object sender, EventArgs e)
        {

            if (!this.checkChildFormExist("DefaultPage"))
            {
                SystemParam.setDefaultPageForm(new DefaultPage(SystemParam.getMainForm()));
                SystemParam.getDefaultPageForm().Show();
            }

            else
            {
                SystemParam.getDefaultPageForm().Activate();
                //this.openFormWithoutOtherChlidForm(this, SystemParam.getSeasonManageForm());

            }
        }

        private void ScheduleManageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!this.checkChildFormExist("ScheduleManage"))
            {
                SystemParam.setScheduleManageForm(new ScheduleAdd(SystemParam.getMainForm()));
                SystemParam.getScheduleManageForm().Show();
            }

            else
            {
                SystemParam.getScheduleManageForm().Activate();
                //this.openFormWithoutOtherChlidForm(this, SystemParam.getSeasonManageForm());

            }



        }

 

    }
}
