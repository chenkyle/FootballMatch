using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballMatch.Umasou.Model
{
    public class SeasonMatch
    {
        ///
        ///  构造赛事信息
        ///
        //声明实例
        private string seasonName;  //赛季名称
        private int seasonID;  //赛季ID值
        private string seasonDescription;  //赛季描述
        private int _switchNum;  //记录黄牌转换为红牌的条件数目
        private int _gameNum;  //记录赛季中的比赛的数目
        //构造函数
        public SeasonMatch()
        {
        }
        public SeasonMatch(int _seasonID,string _seasonName)
        {
            this.seasonID = _seasonID;
            this.seasonName = _seasonName;
        }
        public SeasonMatch(int _seasonID, string _seasonName,string _description)
        {
            this.seasonID = _seasonID;
            this.seasonName = _seasonName;
            this.seasonDescription = _description;
        }
        public SeasonMatch(int _seasonID, string _seasonName, string _description, int switchNum, int gameNum)
        {
            this.seasonID = _seasonID;
            this.seasonName = _seasonName;
            this.seasonDescription = _description;
            this._switchNum = switchNum;
            this._gameNum = gameNum;
        }
        //取值方法
        public int getID()
        {
            return seasonID;
        }
        public string getName()
        {
            return seasonName;
        }
        public string getDescription()
        {
            return seasonDescription;
        }
        public int getSwitchNum()
        {
            return _switchNum;
        }
        public int getSerialNum()
        {
            return _gameNum;
        }
        //赋值方法
        public void setID(int _ID)
        {
            this.seasonID = _ID;
        }
        public void setName(string _Name)
        {
            this.seasonName = _Name;
        }
        public void setDescription(string _Description)
        {
            this.seasonDescription = _Description;
        }
        public void setSwitchNum(int switchNum)
        {
            this._switchNum = switchNum;
        }
        public void setSerialNum(int gameNum)
        {
            this._gameNum = gameNum;
        }
    }
}
