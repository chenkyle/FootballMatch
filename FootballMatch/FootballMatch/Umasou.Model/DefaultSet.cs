using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballMatch.Umasou.Model
{
    class DefaultSet
    {
        private static  string _defaultSeason;   // 软件默认进入赛季
        private static string _defaultMatch;     // 软件默认进入赛事
        private static int _defaultTurn;          //  软件默认进入轮次

      //赋值
        public static void setDefaultSeason(string defaultSeason)
        {
            _defaultSeason = defaultSeason;
        }
        public static void setDedaultMatch(string defaultMatch)
        {
            _defaultMatch = defaultMatch;
        }
        public static void setDefaultTurn(int  defaultTurn) {
            _defaultTurn = defaultTurn;
        }
        //取值
        public static string getDefaultSeason() {
            return _defaultSeason;
        }
        public static string getDefaultMatch() {
            return _defaultMatch;
        }
        public static int getDefaultTurn() {

            return _defaultTurn;
        }


    }
}
