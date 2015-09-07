using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballMatch.Umasou.Model
{
    public class PlayerCardRecord
    {
        ///
        ///记录球员新添加的罚牌记录
        ///
        //声明实例
        private int _uniqueID;  //记录罚牌记录唯一标识号
        private int _matchID;  //记录赛事唯一标识号
        private string _matchName; //记录赛事名称
        private int _playerID;  //记录被罚球员唯一标识号
        private string _playerName;  //记录被罚球员姓名
        private int _serialNum;  //记录比赛轮次编号
        private string _gameName;  //记录比赛的名称
        private int _yellowCardNum;  //记录获得的黄牌数量
        private int _redCardNum;  //记录获得红牌数量
        private DateTime _dateTime;  //记录被罚的日期
        //构造函数
        public PlayerCardRecord()
        {
        }
        //带有唯一标识号的重构函数
        public PlayerCardRecord(int uniqueID,int matchID,int playerID,int serialNum,int yellowCardNum,int redCardNum,DateTime dateTime)
        {
            this._uniqueID = uniqueID;
            this._matchID = matchID;
            this._playerID = playerID;
            this._serialNum = serialNum;
            this._yellowCardNum = yellowCardNum;
            this._redCardNum = redCardNum;
            this._dateTime = dateTime;
        }
        //不带唯一标识号的构造函数
        public PlayerCardRecord(int matchID, int playerID, int serialNum, int yellowCardNum, int redCardNum, DateTime dateTime)
        {
            this._matchID = matchID;
            this._playerID = playerID;
            this._serialNum = serialNum;
            this._yellowCardNum = yellowCardNum;
            this._redCardNum = redCardNum;
            this._dateTime = dateTime;
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
        public string getMatchName()
        {
            return _matchName;
        }
        public int getPlayerID()
        {
            return _playerID;
        }
        public string getPlayerName()
        {
            return _playerName;
        }
        public int getSerialNum()
        {
            return _serialNum;
        }
        public int getYellowCardNum()
        {
            return _yellowCardNum;
        }
        public int getRedCardNum()
        {
            return _redCardNum;
        }
        public DateTime getDateTime()
        {
            return _dateTime;
        }
        public string getGameName()
        {
            return _gameName;
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
        public void setMatchName(string matchName)
        {
            this._matchName = matchName;
        }
        public void setPlayerID(int playerID)
        {
            this._playerID = playerID;
        }
        public void setPlayerName(string playerName)
        {
            this._playerName = playerName;
        }
        public void setSerialNum(int serialNum)
        {
            this._serialNum = serialNum;
        }
        public void setYellowCardNum(int yellowCardNum)
        {
            this._yellowCardNum = yellowCardNum;
        }
        public void setRedCardNum(int redCardNum)
        {
            this._redCardNum = redCardNum;
        }
        public void setDateTime(DateTime dateTime)
        {
            this._dateTime = dateTime;
        }
        public void setGameName(string gameName)
        {
            this._gameName = gameName;
        }
    }
}
