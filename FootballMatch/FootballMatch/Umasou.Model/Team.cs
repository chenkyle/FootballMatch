using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballMatch.Umasou.Model
{
    public class Team
    {
        ///
        ///记录球队的基本信息
        ///
        //声明实例
       
        private int _teamID; //球队编号
        private string _teamName;  //球队名称
        private string _teamLeader;  //球队队长
        private string _teamManager; //球队总经理
        private string _teamCoach;  //球队主教练
        private string _teamFullName;  //球队全名
        private string _birthDate;  //球队建队时间
        private string _matchName; //球队所属联赛名称
        private string _location;  //球队所在城市或地点
        private string _introduction;// 球队简介

        //构造函数
        public Team()
        {
        }
        public Team(int teamID)
        {
            this._teamID = teamID;
        }
        public Team(string teamName)
        {
            this._teamName = teamName;
        }
        public Team(int teamID, string teamName, string leader, string manager, string coach)
        {
            this._teamID = teamID;
            this._teamName = teamName;
            this._teamLeader = leader;
            this._teamManager = manager;
            this._teamCoach = coach;
        }

        public Team(int teamID, string teamName, string leader, string manager, string coach, string teamFullName,string birthDate,string matchName,string location,string introduction )
        {
            this._teamID = teamID;
            this._teamName = teamName;
            this._teamLeader = leader;
            this._teamManager = manager;
            this._teamCoach = coach;
            this._teamFullName = teamFullName;
            this._birthDate = birthDate;      
            this._matchName = matchName;
            this._location = location;
            this._introduction = introduction;


        }

        //取值方法
        public int getID()
        {
            return _teamID;
        }
        public string getName()
        {
            return _teamName;
        }
        public string getLeader()
        {
            return _teamLeader;
        }
        public string getManager()
        {
            return _teamManager;
        }
        public string getCoach()
        {
            return _teamCoach;
        }
        public string getTeamFullName() {
            return _teamFullName;
        }

        public string getBirthDate() {
            return _birthDate;
        }
        public string  getMatchName() {
            return _matchName;
        }

        public string getLocation() {
            return _location;

        }
        public string getIntroduction() {
            return _introduction;
        }
        //赋值方法
        public void setID(int ID)
        {
            this._teamID = ID;
        }
        public void setName(string name)
        {
            this._teamName = name;
        }
        public void setLeader(string leader)
        {
            this._teamLeader = leader;
        }
        public void setManager(string manager)
        {
            this._teamManager = manager;
        }
        public void setCoach(string coach)
        {
            this._teamCoach = coach;
        }

        public void setTeamFullName(string fullName) {
            this._teamFullName = fullName;
        }
        public void setBirthDate(string date) {
            this._birthDate = date;
        }
        public void setMatchName(string matchName) {
            this._matchName = matchName;
        }
        public void setLocation(string location) {
            this._location = location;
        }
        public void setIntroduction(string introduction) {
            this._introduction = introduction;
        }
    }
}
