using FootballMatch.Umasou.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballMatch.Umasou.DBA
{
   class ScheduleDAO
    {   

        ////////获取当前赛事的球队信息

        /*
        * 查询数据库中的球队的基本信息，并且返回到一个线性表中
        */
        public static List<Schedule> getScheduleInfo(SeasonOfMatch season) 
        {
            //声明实例
            List<Schedule> list = new List<Schedule>();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select seasonId,matchId,turn,gameDate,homeTeamName,guestTeamName from schedule where seasonId= " + season.getNumOfSeason();
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    Schedule s = new Schedule();
                    s.setSeasonId(Convert.ToInt32(rd[0]));
                    s.setMatchId(Convert.ToInt32(rd[1]));
                    s.setTurn(Convert.ToInt32(rd[2]));
                    s.setGameDate(Convert.ToString(rd[3]));
                    s.setHomeTeam(Convert.ToString(rd[4]));
                    s.setGuestTeam(Convert.ToString(rd[5]));
                    list.Add(s);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                dbutility.Close();
            }
            return list;
        }
  
        //插入赛程记录
        public static void addSchedule(List<Schedule> list)  {

            DBUtility dbutility = new DBUtility();

           try
           {
               dbutility.openConnection();
        for (int i = 0; i < list.Count;i++ ) {
            string sql = "insert into schedule(seasonId,matchId,turn,gameDate,homeTeamName,guestTeamName) values("+list[i].getSeasonId()+","+list[i].getMatchId()
                + ","+list[i].getTurn()+",'"+list[i].getGameDate()+"','"+list[i].getHomeTeam()+"','"+list[i].getGuestTeam()+"')";

            
            dbutility.ExecuteUpdate(sql);
        }
	}
           catch (MySqlException ex)
	{

        Console.WriteLine(ex.ToString());
	}
           finally { dbutility.Close(); }
        
        
        }







    }
}
