using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballMatch.Umasou.Model
{
    public class Game
    {
        ///
        ///本类用来记录赛事中的比赛的基本信息
        ///
        //声明实例
        private int _uniqueID;  //记录比赛的唯一标识号
        private int _matchID;  //记录比赛所属的赛事的标识号
        private int _matchGameNum;  //记录某一比赛在赛事中所属的比赛场次，具有唯一标志性
        private string _gameName;  //比赛的名字，在一场赛事中也具有唯一标识性
        private string _homeTeam;  //比赛中主队的名字
        private string _guestTeam;  //比赛中客队的名字
        private string _gameWinner;  //比赛中的获胜的球队，当名字为空时，说明是平局
        private string _gameResult;  //比赛的结果
        private string _gameAddress; //比赛所在的位置
        private DateTime _gameDate; //比赛日期
        //构造函数
        public Game()
        {
        }
        public Game(int uniqueID)
        {
            this._uniqueID = uniqueID;
        }
        public Game(int uniqueID, int matchID, int matchGameNum, string gameName)
        {
            this._uniqueID = uniqueID;
            this._matchID = matchID;
            this._matchGameNum = matchGameNum;
            this._gameName = gameName;
        }
        public Game(int uniqueID,int matchID,int matchGameNum,string gameName,string homeTeam,string guestTeam,string gameWiner,string gameResult,string gameAddress,DateTime gameDate)
        {
            this._uniqueID = uniqueID;
            this._matchID = matchID;
            this._matchGameNum = matchGameNum;
            this._gameName = gameName;
            this._homeTeam = homeTeam;
            this._guestTeam = guestTeam;
            this._gameWinner = gameWiner;
            this._gameResult = gameResult;
            this._gameAddress = gameAddress;
            this._gameDate = gameDate;
        }
        //取值方法
        public int getUniqueID()
        {
            return this._uniqueID;
        }
        public int getMatchID()
        {
            return this._matchID;
        }
        public int getMatchGameNum()
        {
            return this._matchGameNum;
        }
        public string getGameName()
        {
            return this._gameName;
        }
        public string getHomeTeam()
        {
            return this._homeTeam;
        }
        public string getGuestTeam()
        {
            return this._guestTeam;
        }
        public string getGameWinner()
        {
            return this._gameWinner;
        }
        public string getGameResult()
        {
            return this._gameResult;
        }
        public string getGameAddress()
        {
            return this._gameAddress;
        }
        public DateTime getGameDate()
        {
            return this._gameDate;
        }
        //赋值方法
        public void setUniqueID(int uniqueID)
        {
            this._uniqueID = uniqueID;
            
        }
        public void setMatchID(int matchID)
        {
            this._matchID = matchID;
        }
        public void setMatchGameNum(int matchGameNum)
        {
            this._matchGameNum = matchGameNum;
        }
        public void setGameName(string gameName)
        {
            this._gameName = gameName;
        }
        public void setHomeTeam(string homeTeam)
        {
            this._homeTeam = homeTeam;
        }
        public void setGuestTeam(string guestTeam)
        {
            this._guestTeam = guestTeam;
        }
        public void setGameWinner(string gameWiner)
        {
            this._gameWinner = gameWiner;
        }
        public void setGameResult(string gameResult)
        {
            this._gameResult = gameResult;
        }
        public void setGameAddress(string gameAddress)
        {
            this._gameAddress = gameAddress;
        }
        public void setGameDate(DateTime gameDate)
        {
            this._gameDate = gameDate;
        }
    }
}
