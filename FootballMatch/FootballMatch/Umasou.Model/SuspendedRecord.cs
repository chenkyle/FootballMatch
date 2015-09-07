using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballMatch.Umasou.Model
{
    public class SuspendedRecord
    {
        ///
        ///记录停赛信息
        ///
        //声明实例
        private int _uniqueID;  //记录唯一编号
        private int _matchID; //记录比赛编号
        private int _playerID; //记录球员编号
        private DateTime _suspendedDate; //记录停赛日期
        private int _suspendedGameNum;  //记录被停赛的比赛的场次

        //构造函数
        public SuspendedRecord()
        {
        }
        public SuspendedRecord(int uniqueID, int matchID, int playerID, int gameNum, DateTime suspendedDate)
        {
            this._uniqueID = uniqueID;
            this._matchID = matchID;
            this._playerID = playerID;
            this._suspendedDate = suspendedDate;
            this._suspendedGameNum = gameNum;
        }
        public SuspendedRecord(int matchID, int playerID, DateTime suspendedDate, int gameNum)
        {
            this._matchID = matchID;
            this._playerID = playerID;
            this._suspendedDate = suspendedDate;
            this._suspendedGameNum = gameNum;
        }
        //取值函数
        public int getUniqueID()
        {
            return _uniqueID;
        }
        public int getMatchID()
        {
            return _matchID;
        }
        public int getPlayerID()
        {
            return _playerID;
        }
        public DateTime getSuspendedDate()
        {
            return _suspendedDate;
        }
        public int getSuspendedGameNum()
        {
            return _suspendedGameNum;
        }
        //赋值函数
        public void setUniqueID(int uniqueID)
        {
            this._uniqueID = uniqueID;
        }
        public void setMatchID(int matchID)
        {
            this._matchID = matchID;
        }
        public void setPlayerID(int playerID)
        {
            this._playerID = playerID;
        }
        public void setSuspendedDate(DateTime suspendedDate)
        {
            this._suspendedDate = suspendedDate;
        }
        public void setSuspendedSerialNum(int gameNum)
        {
            this._suspendedGameNum = gameNum;
        }
    }
}
