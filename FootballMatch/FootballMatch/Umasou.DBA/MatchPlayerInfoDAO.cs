using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;
using FootballMatch.Umasou.Model;

namespace FootballMatch.Umasou.DBA
{
    public class MatchPlayerInfoDAO
    {
        ///
        ///本类用于完成执行赛事球员信息的数据库处理操作
        ///
        //查询属于某一个赛事的球员信息,并且返回到一个线性表拉米娜
        public static List<FootballPlayer> getAssignedPlayerInfo(int matchID)
        {
            DBUtility dbutility = new DBUtility();
            List<FootballPlayer> _list = new List<FootballPlayer>();
            try
            {
                dbutility.openConnection();
                string sql = "SELECT ID,playerName,number,postion,teamName,playerIDnum FROM player WHERE ID ";
                sql=sql+"IN (SELECT playerID FROM matchplayerinfo WHERE matchID ="+matchID+" )";
               // sql=sql+"GROUP BY teamName";
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    _list.Add(new FootballPlayer(Convert.ToInt32(rd[0]), Convert.ToString(rd[1]), Convert.ToInt32(rd[2]), Convert.ToString(rd[3]), Convert.ToString(rd[4]), Convert.ToString(rd[5])));
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
            return _list;
        }
        /*
         * 查询不属于某一个赛事的球员信息，但是这些球员信息必须是满足其所在球队已经在赛事球队表里面,
         * 最终返回到一个线性表中
         */
        public static List<FootballPlayer> getNotAssignedPlayerInfo(int matchID)
        {
            DBUtility dbutility = new DBUtility();
            List<FootballPlayer> _list = new List<FootballPlayer>();
            try
            {
                dbutility.openConnection();
                string sql = "SELECT ID,playerName,number,postion,teamName,playerIDnum FROM player WHERE ID NOT IN";
                sql=sql+"(SELECT playerID FROM matchplayerinfo WHERE matchID = "+matchID+")";
                sql=sql+" AND teamName IN ( SELECT team.teamName FROM team,matchteaminfo WHERE";
                sql=sql+" matchteaminfo.matchID = "+matchID+" AND team.ID = matchteaminfo.teamID)";
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    _list.Add(new FootballPlayer(Convert.ToInt32(rd[0]), Convert.ToString(rd[1]), Convert.ToInt32(rd[2]), Convert.ToString(rd[3]), Convert.ToString(rd[4]), Convert.ToString(rd[5])));
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
            return _list;
        }
        //联动删除某一个赛事中属于某一球队的球员信息
        public static bool deleteMatchTeamPlayerInfo(int matchID, int teamID)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "DELETE FROM matchplayerinfo WHERE matchID=" + matchID + " AND teamID=" + teamID;
            try
            {
                dbutility.openConnection();
                dbutility.ExecuteUpdate(sql);
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                dbutility.Close();
            }
        }
        //删除赛事球员信息表中某一个球员的信息
        public static bool deletMatchPlayerInfoRecord(int matchID, int playerID)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "DELETE FROM matchplayerinfo WHERE matchID=" + matchID + " AND playerID=" + playerID;
            try
            {
                dbutility.openConnection();
                dbutility.ExecuteUpdate(sql);
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                dbutility.Close();
            }
        }
        //删除一系列的赛事球员信息表中的球员信息
        public static bool deletMatchPlayerInfoRecord(int matchID, List<FootballPlayer> list)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "";
            try
            {
                dbutility.openConnection();
                for (int i = 0; i < list.Count; i++)
                {
                    sql = "DELETE FROM matchplayerinfo WHERE matchID=" + matchID + " AND playerID=" + list[i].getID();
                    dbutility.ExecuteUpdate(sql);
                }
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                dbutility.Close();
            }
        }
        //删除一系列的赛事球员信息表中的球员信息
        public static bool deletMatchPlayerInfoRecord(int matchID, List<int> list)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "";
            try
            {
                dbutility.openConnection();
                for (int i = 0; i < list.Count; i++)
                {
                    sql = "DELETE FROM matchplayerinfo WHERE matchID=" + matchID + " AND playerID=" + list[i];
                    dbutility.ExecuteUpdate(sql);
                }
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                dbutility.Close();
            }
        }
        //添加赛事球员信息到表中
        public static bool addMatchPlayerInfoRecord(int matchID, int playerID)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "INSERT INTO matchplayerinfo(matchID,playerID,teamID) values(" + matchID + "," + playerID + ",";
            sql=sql+"(SELECT team.ID FROM team,player WHERE team.teamName = player.teamName ";
            sql=sql+" AND player.ID = "+playerID+"))";
            try
            {
                dbutility.openConnection();
                dbutility.ExecuteUpdate(sql);
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                dbutility.Close();
            }
        }
        //添加一系列赛事球员信息到表中
        public static bool addMatchPlayerInfoRecord(int matchID, List<FootballPlayer> list)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "";
            try
            {
                dbutility.openConnection();
                for (int i = 0; i < list.Count; i++)
                {
                    sql = "INSERT INTO matchplayerinfo(matchID,playerID,teamID) values(" + matchID + "," + list[i].getID() + ",";
                    sql = sql + "(SELECT ID FROM team WHERE teamName ='"+list[i].getBelongTeam()+"'))";
                    dbutility.ExecuteUpdate(sql);
                }
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                dbutility.Close();
            }
        }
        //添加一系列赛事球员信息到表中
        public static bool addMatchPlayerInfoRecord(int matchID, List<int> list)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "";
            try
            {
                dbutility.openConnection();
                for (int i = 0; i < list.Count; i++)
                {
                    sql = "INSERT INTO matchplayerinfo(matchID,playerID,teamID) values(" + matchID + "," + list[i] + ",";
                    sql = sql + "(SELECT team.ID FROM team,player WHERE team.teamName = player.teamName ";
                    sql = sql + " AND player.ID = " + list[i] + "))";
                    dbutility.ExecuteUpdate(sql);
                }
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                dbutility.Close();
            }
        }
    }
}
