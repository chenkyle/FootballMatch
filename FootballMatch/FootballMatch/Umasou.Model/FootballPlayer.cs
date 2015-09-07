using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballMatch.Umasou.Model
{
    public class FootballPlayer
    {
        ///
        /// 本类是用来构造记录球员对象的基本信息
        ///
        //声明实例
        private string  playerName;  //球员名称
        private int playerID;   //球员唯一ID号
        private int playNumber;  //球衣号
        private string playPostion;  //在场上的位置，后卫，中场，前锋..
        private string belongTeam;  //所属球队名称
        private string IDnum;
        /**
         *构造函数
         */
        public FootballPlayer()
        {
        }
        /*
         * 新的构造函数
         */
        public FootballPlayer(string _playName,int _playID)
        {
            this.playerName = _playName;
            this.playerID = _playID;
        }
        public FootballPlayer(int _playID)
        {
            this.playerID = _playID;
        }
        public FootballPlayer(int _playID, string _playName, int _playNumber, string _postion, string _belongTeam,string playerIDnum)
        {
            this.playerName = _playName;
            this.playerID = _playID;
            this.playNumber = _playNumber;
            this.playPostion = _postion;
            this.belongTeam = _belongTeam;
            this.IDnum = playerIDnum;
        }
        //取出值

        public string getIDnum() {
            return IDnum;
        }
        public string getName()
        {
            return playerName;
        }
        public int getID()
        {
            return playerID;
        }
        public int getNumber()
        {
            return playNumber;
        }
        public string getPostion()
        {
            return playPostion;
        }
        public string getBelongTeam()
        {
            return belongTeam;
        }
        //赋值
        public void setIDnum(string _IDnum) {
            this.IDnum = _IDnum;
        }
        public void setPlayerName(string _playName)
        {
            this.playerName = _playName;
        }
        public void setPlayerID(int _playID)
        {
            this.playerID = _playID;
        }
        public void setPlayNumber(int _playNumber)
        {
            this.playNumber = _playNumber;
        }
        public void setPostion(string _postion)
        {
            this.playPostion = _postion;
        }
        public void setBelongTeam(string _belongTeam)
        {
            this.belongTeam = _belongTeam;
        }
    }
}
