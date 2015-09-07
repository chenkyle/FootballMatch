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
        public static List<Team> getTeamInfo(string matchName)
        {
            //声明实例
            List<Team> list = new List<Team>();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select teamName from team where matchName='"+matchName+"' order by ID";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {

                    //list.Add(new SeasonMatch(Convert.ToInt32(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToInt32(rd[3]), Convert.ToInt32(rd[4])));
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
