using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballMatch.Umasou.Model
{
      public class Schedule
    {
        private int _seasonId;    
        private int _matchId;   
        private int _turn;
        private string _gameDate;
        private string _homeTeam; 
        private string _guestTeam;
  // 赋值
        public void setSeasonId(int seasonId) 
        {   _seasonId=seasonId; }
        public void setMatchId(int matchId)
        {
            _matchId = matchId;
        }
        public void setTurn(int turn) {
            _turn = turn;
        }
        public void setGameDate(string gameDate) {

            _gameDate = gameDate;
        }
        public void setHomeTeam(string homeTeam){

            _homeTeam = homeTeam;
        }
        public void setGuestTeam(string guestTeam) {
            _guestTeam = guestTeam;
        }

        // 取值
        public int getSeasonId()
        { return _seasonId; }
        public int getMatchId( )
        {
            return _matchId ;
        }
        public int  getTurn( )
        {
            return _turn  ;
        }
        public string  getGameDate( )
        {

            return _gameDate   ;
        }
        public string  getHomeTeam( )
        {

            return _homeTeam   ;
        }
        public  string getGuestTeam( )
        {
            return _guestTeam;
        }








    }
}
