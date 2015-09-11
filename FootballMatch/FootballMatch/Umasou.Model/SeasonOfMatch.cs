using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballMatch.Umasou.Model
{
   public class SeasonOfMatch
    {
        private int id;
        private int matchId;    //赛事ID
        private string matchName;  //赛事名称
        private string seasonDescription;  // 赛季描述
        private int numOfSeason;           //赛季序号或次数
        private int scheduleId;     //赛程安排id
        private int currentGameTurn;  //当前赛事轮次
        private int numOfTurn;        //当前赛季比赛轮次数目

        public SeasonOfMatch() { 

        }
        public SeasonOfMatch(string _matchName, int _NumOfSeason )
        {
            this.matchName = _matchName;
            this.numOfSeason = _NumOfSeason;
        }

        public SeasonOfMatch(int _id, string _matchName, string _seasonDescription, int _numOfSeason,int _numOfTurn)
        {
            // TODO: Complete member initialization
            this.id = _id;
            this.matchName = _matchName;
            this.numOfSeason = _numOfSeason;
            this.seasonDescription = _seasonDescription;
            this.numOfTurn = _numOfTurn;
        }



         //get
        public int getId() { return id; }
        public int getMatchId() { return matchId; }
        public string getmatchName() { return matchName; }
        public string getSeasonDescription() { return seasonDescription; }
        public int getNumOfSeason() { return numOfSeason; }
        public int getScheduleId() { return scheduleId; }
        public int getCurrentGameTurn() { return currentGameTurn; }
        public int getNumOfTurn() { return numOfTurn; }
        //set
        public void setId(int _id) {
            this.id = _id;
        
        }

        public void setMatchId(int _matchId) {
            this.matchId = _matchId;
        }

        public void setMatchName(string _matchName) {
            this.matchName = _matchName;
        }
        public void setSeasonDescription(string _seasonDescription) {
            this.seasonDescription = _seasonDescription;
        }

        public void setNumOfSeason(int _numofSeason) {
            this.numOfSeason = _numofSeason;
        }
        public void setScheduleId(int _scheduleId) {

            this.scheduleId = _scheduleId;
        }
        public void setCurrentGameTurn(int _currentGameTurn) {
            this.currentGameTurn = _currentGameTurn;
        }

        public void setNumOfTurn(int num) {
            this.numOfTurn = num;
        }

    }
}
