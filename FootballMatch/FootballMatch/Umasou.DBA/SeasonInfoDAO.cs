using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballMatch.Umasou.Model;
using MySql.Data.MySqlClient;

namespace FootballMatch.Umasou.DBA
{
    class SeasonInfoDAO
    {     /*****
           * 本类是针对不同赛事的不同赛季的数据库操作
           * *****/

       #region[新增一个赛季信息]  
        /****
          *** 新增某一个赛季的信息
         ****/
        public static void addNewSeasonInfo(SeasonOfMatch season)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "insert into gameseason(id,matchname,numofseason,seasondescription) values('" + season.getId()
              +"','" + season.getmatchName() + "','" + season.getNumOfSeason() + "','" + season.getSeasonDescription() + "')";

             
            try
            {
                dbutility.openConnection();
                dbutility.ExecuteUpdate(sql);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                dbutility.Close();
            }
        }

#endregion

        #region[获取最大id]
        //获取当前库中id值最大的一项，返回其id
        public  static int getMaxId(){
            int maxId = 0;
            DBUtility dbutility = new DBUtility();
            string sql = "select max(id) from gameseason;";


            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);

                while (rd.Read())
                {
                    if (Convert.ToString(rd[0]) != "")
                    {
                        maxId = Convert.ToInt32(rd[0]);
                    }
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

            return maxId;
        }

        #endregion


        #region[返回所有赛季信息]

        public static List<SeasonOfMatch> AllSeasons() {

            List<SeasonOfMatch> list = new List<SeasonOfMatch>();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select id,matchname,seasondescription,numofseason from gameseason order by id";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    list.Add(new SeasonOfMatch(Convert.ToInt32(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToInt32(rd[3])));
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
        #endregion

        #region[返回特定赛事所有赛季信息]

        public static List<SeasonOfMatch> getSeasonsOfCertainMatch(string matchName)
        {

            List<SeasonOfMatch> list = new List<SeasonOfMatch>();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select id,matchname,seasondescription,numofseason from gameseason where matchname = '"+matchName+"' order by id";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    list.Add(new SeasonOfMatch(Convert.ToInt32(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToInt32(rd[3])));
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
        #endregion

    }
}
