using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballMatch.Umasou.Model;
using System.Collections;
using MySql.Data.MySqlClient;

namespace FootballMatch.Umasou.DBA
{
    public class MatchTeamInfoDAO
    {
        ///
        /// 本类用来完成对于赛事球队信息管理的数据库操作
        /// 
        //取出属于某一个赛事的所有球队信息，并且返回到一个线性表中
        public static List<Team> getAssignedMatchTeamInfo(int matchID)
        {
            DBUtility dbutility = new DBUtility();
            List<Team> _teamList = new List<Team>();
            string sql = "SELECT ID,teamName,teamLeader,teamManager,teamCoach FROM team WHERE ID ";
            sql=sql+"IN (SELECT teamID FROM matchteaminfo WHERE matchID = "+matchID+")";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    _teamList.Add(new Team(Convert.ToInt32(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToString(rd[3]), Convert.ToString(rd[4])));
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
            return _teamList;
        }
        //取出不属于某一个赛事的所有球队信息，并且返回到一个线性表中
        public static List<Team> getNotAssignedMatchTeamInfo(int matchID)
        {
            DBUtility dbutility = new DBUtility();
            List<Team> _teamList = new List<Team>();
            string sql = "SELECT ID,teamName,teamLeader,teamManager,teamCoach FROM team WHERE ID ";
            sql = sql + "NOT IN (SELECT teamID FROM matchteaminfo WHERE matchID = " + matchID + ")";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    _teamList.Add(new Team(Convert.ToInt32(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToString(rd[3]), Convert.ToString(rd[4])));
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
            return _teamList;
        }
        //往某个赛事中添加球队信息
        public static bool addMatchTeamInfo(int matchID,int teamID)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "INSERT INTO matchteaminfo(matchID,teamID) values(" + matchID + "," + teamID + ")";
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
        //往某个赛事中添加球队信息，添加一系列球队信息到赛事球队表中
        public static bool addMatchTeamInfo(int matchID, List<Team> list)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "";
            try
            {
                dbutility.openConnection();
                for (int i = 0; i < list.Count; i++)
                {
                    sql = "INSERT INTO matchteaminfo(matchID,teamID) values(" + matchID + "," + list[i].getID() + ")";
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
        //往某个赛事中添加球队信息，添加一系列球队信息到赛事球队表中
        public static bool addMatchTeamInfo(int matchID, List<int> list)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "";
            try
            {
                dbutility.openConnection();
                for (int i = 0; i < list.Count; i++)
                {
                    sql = "INSERT INTO matchteaminfo(matchID,teamID) values(" + matchID + "," + list[i] + ")";
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
        //从某个赛事中移除球队信息
        public static bool deleteMatchTeamInfo(int matchID, int teamID)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "DELETE FROM matchteaminfo WHERE matchID=" + matchID + " AND teamID=" + teamID;
            try
            {
                dbutility.openConnection();
                dbutility.ExecuteUpdate(sql);
                //移除属于某个赛事的某个球队的球员信息
                if (MatchPlayerInfoDAO.deleteMatchTeamPlayerInfo(matchID, teamID))
                {
                    return true;
                }
                else  //当没有全部移除时
                {
                    return false;
                }
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
        //从某个赛事中移除球队信息
        public static bool deleteMatchTeamInfo(int matchID, List<Team> list)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "";
            try
            {
                dbutility.openConnection();
                for (int i = 0; i < list.Count; i++)
                {
                    sql = "DELETE FROM matchteaminfo WHERE matchID=" + matchID + " AND teamID=" + list[i].getID();
                    dbutility.ExecuteUpdate(sql);
                    //移除属于某个赛事的某个球队的球员信息
                    MatchPlayerInfoDAO.deleteMatchTeamPlayerInfo(matchID, list[i].getID());
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
        //从某个赛事中移除球队信息
        public static bool deleteMatchTeamInfo(int matchID, List<int> list)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "";
            try
            {
                dbutility.openConnection();
                for (int i = 0; i < list.Count; i++)
                {
                    sql = "DELETE FROM matchteaminfo WHERE matchID=" + matchID + " AND teamID=" + list[i];
                    dbutility.ExecuteUpdate(sql);
                    //移除属于某个赛事的某个球队的球员信息
                    MatchPlayerInfoDAO.deleteMatchTeamPlayerInfo(matchID, list[i]);
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
