using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FootballMatch.Umasou.Business;
using FootballMatch.Umasou.Model;
using FootballMatch.Umasou.GameManage;
using FootballMatch.Umasou.CardRecord;
using FootballMatch.Umasou.View;

namespace FootballMatch.Umasou.Util
{
    public class SystemParam
    {
        ///
        /// 用来记录系统的全局静态变量，诸如获取配置文件中几张黄牌累计成红牌，选中的赛季编号等
        ///
        //声明实例
        private static int _yellowCardSwitchRed;  //记录几张黄牌转换为红牌
        private static int _defaultMatchSerialNum;  //记录赛季中默认的轮次数目
        private static int _matchID;  //记录赛季的编号

        private static string _currentSelectedMatchName;// 当前选定的赛事名称
        private static SeasonOfMatch  _currentSelectedSeason; //当前选定的赛季
        private static int _currentTurn; // 当前轮次

        private static ScheduleAdd _scheduleManage; 
        private static DefaultPage _defaultPage; //软件默认显示首页
        private static CreateNewSeason _createNewSeason;  //记录被打开的赛事新建界面
        private static SeasonManage _seasonManage; //记录被打开的赛季管理界面
        private static string _matchName;  //记录赛季的名称
        private static MainForm _mainForm;  //记录主窗体
        private static SeasonMatch _match;  //记录被打开的赛事
        private static teamManage _teamManage;  //记录被打开的球队管理界面
        private static matchManage _matchManage; //记录被打开的管理赛事的界面
        private static playerManage _playerManage;  //记录被打开的球员管理界面
        private static MatchTeamManage _matchTeamManage;  //记录被打开的赛事球队管理界面
        private static MatchPlayerManage _matchPlayerManage;  //记录被打开的赛事球员管理界面
        private static addPlayerCardRecordcs _addPlayerCardRecordsForm;  //用来记录添加罚牌记录的界面
        private static MatchPlayerInfo _matchPlayerInfoForm;  //记录赛事中球员信息，包括累计罚牌数量，是否可以上场等
        private static GameSummary _gameSummaryForm;  //记录比赛总览的窗体信息
        private static CardRecordManage _cardRecordManageForm;  //记录罚牌总览界面的窗体信息
        private static AvaliableInfo _avaliableInfoForm;  //记录比赛中可用球员信息列表,反应球员可上场信息
        private static MatchChart _getCardMatchChartForm;  //记录罚牌记录的赛事罚牌窗体
        private static TeamChart _getCardTeamChartForm;  //记录罚牌记录的球队罚牌窗体
        private static PlayerChart _getCardPlayerChartForm;  //记录罚牌记录的球员罚牌窗体
        //构造函数
        public SystemParam()
        {
            //读取配置文件中几张黄牌累计成为红牌
            _yellowCardSwitchRed = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["yellowSwitchRedNum"]);
        }
        //取数据
        public static int getSwitchNum()
        {
            //读取配置文件中几张黄牌累计成为红牌
            _yellowCardSwitchRed = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["yellowSwitchRedNum"]);
            return _yellowCardSwitchRed;
        }
        public static int getDefaultMatchSerialNum()
        {
            _defaultMatchSerialNum = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["defaultMatchSerialNum"]);
            return _defaultMatchSerialNum;
        }

        public static string getCurrentSelectedMatchName() {
            return _currentSelectedMatchName;
        }

        public static SeasonOfMatch getCurrentSelectedSeaon() {
            return _currentSelectedSeason;
        }
        public static int getcurrentTurn() {
            return _currentTurn;
        }


        public static DefaultPage getDefaultPageForm() {

            return _defaultPage;
        }


        public static CreateNewSeason getCreateNewSeasonForm() {

            return _createNewSeason;
        }

        public static SeasonManage getSeasonManageForm() {

            return _seasonManage; 
        }

        public static int getMatchID()
        {
            return _matchID;
        }
        public static string getMatchName()
        {
            return _matchName;
        }
        public static MainForm getMainForm()
        {
            return _mainForm;
        }
        public static SeasonMatch getMatch()
        {
            return _match;
        }
        public static teamManage getTeamManageForm()
        {
            return _teamManage;
        }
        public static matchManage getMatchManageForm()
        {
            return _matchManage;
        }
        public static playerManage getPlayerManageForm()
        {
            return _playerManage;
        }
        public static MatchTeamManage getMatchTeamManageForm()
        {
            return _matchTeamManage;
        }
        public static MatchPlayerManage getMatchPlayerManageForm()
        {
            return _matchPlayerManage;
        }
        public static addPlayerCardRecordcs getAddPlayerCardRecordsForm()
        {
            return _addPlayerCardRecordsForm;
        }
        public static MatchPlayerInfo getMatchPlayerInfoForm()
        {
            return _matchPlayerInfoForm;
        }
        public static GameSummary getGameSummaryForm()
        {
            return _gameSummaryForm;
        }
        public static CardRecordManage getCardRecordManageForm()
        {
            return _cardRecordManageForm;
        }
        public static AvaliableInfo getAvaliableInfoForm()
        {
            return _avaliableInfoForm;
        }
        public static MatchChart getCardMatchChartForm()
        {
            return _getCardMatchChartForm;
        }
        public static TeamChart getCardTeamChartForm()
        {
            return _getCardTeamChartForm;
        }
        public static PlayerChart getCardPlayerChartForm()
        {
            return _getCardPlayerChartForm;
        }
        //赋值数据
        public static void setMatchID(int ID)
        {
            _matchID = ID;
        }
        public static void setMatchName(string Name)
        {
            _matchName = Name;
        }
        // 当前选定的赛事名称
        public static void setCurrentSelectedMatchName(string currentSelectedMatchName){
        
            _currentSelectedMatchName=currentSelectedMatchName;
        }
        //当前选定的赛季
        public static void setCurrentSelectedSeason(SeasonOfMatch currentSelecteSeason) {
            _currentSelectedSeason = currentSelecteSeason;
        }
         
        public static void setCurrentTurn(int currentTurn){
            _currentTurn = currentTurn;
    } // 当前轮次
            


        public static void setMainForm(MainForm form)
        {
            _mainForm = form;
        }
        public static void setMatch(SeasonMatch match)
        {
            _match = match;
        }

        public static void  setDefaultPageForm(DefaultPage defaultPage)
        {

             _defaultPage=defaultPage;
        }
        public static void setCreateNewSeasonForm(CreateNewSeason createNewseasonform) {
            _createNewSeason = createNewseasonform;
        }
        public static void setTeamManageForm(teamManage teamManage)
        {
            _teamManage = teamManage;
        }
        public static void setMatchManageForm(matchManage matchManage)
        {
            _matchManage = matchManage;
        }
        public static void setPlayerManageForm(playerManage playerManage)
        {
            _playerManage = playerManage;
        }
        public static void setMatchTeamManageForm(MatchTeamManage matchTeamManage)
        {
            _matchTeamManage = matchTeamManage;
        }
        public static void setMatchPlayerManageForm(MatchPlayerManage matchPlayerManage)
        {
            _matchPlayerManage = matchPlayerManage;
        }
        public static void setAddPlayerCardRecordForm(addPlayerCardRecordcs addPlayerCardRecord)
        {
            _addPlayerCardRecordsForm = addPlayerCardRecord;
        }
        public static void setMatchPlayerInfoForm(MatchPlayerInfo matchPlayerInfo)
        {
            _matchPlayerInfoForm = matchPlayerInfo;
        }
        public static void setGameSummaryForm(GameSummary gameSummary)
        {
            _gameSummaryForm = gameSummary;
        }
        public static void setCardRecordManageForm(CardRecordManage cardRecordManageForm)
        {
            _cardRecordManageForm = cardRecordManageForm;
        }
        public static void setAvaliableInfoForm(AvaliableInfo avaliableInfoForm)
        {
            _avaliableInfoForm = avaliableInfoForm;
        }
        public static void setCardMatchChartForm(MatchChart cardMatchChartForm)
        {
            _getCardMatchChartForm = cardMatchChartForm;
        }
        public static void setCardTeamChartForm(TeamChart cardTeamChartForm)
        {
            _getCardTeamChartForm = cardTeamChartForm;
        }
        public static void setCardPlayerChartForm(PlayerChart cardPlayerChartForm)
        {
            _getCardPlayerChartForm = cardPlayerChartForm;
        }




         public  static void setSeasonManageForm(SeasonManage seasonManage)
        {
            _seasonManage = seasonManage;
        }



         public static void setScheduleManageForm(ScheduleAdd scheduleManage)
         {
             _scheduleManage = scheduleManage;
         }

         public static  ScheduleAdd  getScheduleManageForm()
         {
             return _scheduleManage;
         }
    }
}
