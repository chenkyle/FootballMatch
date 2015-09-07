using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballMatch.Umasou.DBA;
using FootballMatch.Umasou.Model;
using MySql.Data.MySqlClient;

namespace FootballMatch.Umasou.DBA
{
    class TeamInfoDAO
    {
        ///
        ///本类主要用于处理球队信息的数据库的操作
        ///
        //依据球队编号，返回球队的信息
        public static Team getTeamInfo(int teamID)
        {
            Team team = new Team();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID,teamName,teamLeader,teamManager,teamCoach from team where ID=" + teamID;
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    team.setID(Convert.ToInt32(rd[0]));
                    team.setName(Convert.ToString(rd[1]));
                    team.setLeader(Convert.ToString(rd[2]));
                    team.setManager(Convert.ToString(rd[3]));
                    team.setCoach(Convert.ToString(rd[4]));
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
            return team;
        }


        public static Team getTeamInfo(string teamName)
        {
            Team team = new Team();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID,teamName,teamLeader,teamManager,teamCoach from team where teamName='" + teamName + "'";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    team.setID(Convert.ToInt32(rd[0]));
                    team.setName(Convert.ToString(rd[1]));
                    team.setLeader(Convert.ToString(rd[2]));
                    team.setManager(Convert.ToString(rd[3]));
                    team.setCoach(Convert.ToString(rd[4]));
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
            return team;
        }
        //检查赛事名称是否存在
        public static bool checkTeamNameExist(string name)
        {
            bool flag = false;
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID from team where teamName='" + name + "'";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    flag = true;
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
            return flag;
        }
        //查询球队信息
        public static List<Team> getTeamInfo()
        {
            //声明实例
            List<Team> list = new List<Team>();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
           // string SQL = "select ID,teamName,teamLeader,teamManager,teamCoach from team order by ID";
            string SQL = "select * from team order by ID";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {   
                    Team team = new Team(Convert.ToInt32(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]),
                              Convert.ToString(rd[3]), Convert.ToString(rd[4]), Convert.ToString(rd[5]),
                              Convert.ToString(rd[6]),Convert.ToString(rd[7]), Convert.ToString(rd[8]),
                              Convert.ToString(rd[9]));

                    list.Add(team);
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
        //删除球队信息
        public static void deleteTeamInfo(int teamID)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "delete from team where ID=" + teamID;
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
        //删除球队信息
        public static void deleteTeamInfo(List<int> list)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "";
            try
            {
                dbutility.openConnection();
                for (int i = 0; i < list.Count; i++)
                {
                    sql = "delete from team where ID=" + list[i];
                    dbutility.ExecuteUpdate(sql);
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
        }
        //删除球队信息
        public static void deleteTeamInfo(List<Team> list)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "";
            try
            {
                dbutility.openConnection();
                for (int i = 0; i < list.Count; i++)
                {
                    sql = "delete from team where ID=" + list[i].getID();
                    dbutility.ExecuteUpdate(sql);
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
        }
        /*
        * 更新某一个球队的信息
        */
        public static bool updateTeamInfo(Team team)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "update team set teamName='" + team.getName() + "' ,teamLeader='" + team.getLeader();
            sql = sql + "' ,teamManager='" + team.getManager() + "' ,teamCoach='" + team.getCoach();
            sql = sql + "' where ID=" + team.getID();
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
        //往数据库中添加球队，返回是否添加成功的信息
        public static bool addNewTeam(Team team)
        {
            DBUtility dbutility = new DBUtility();
            string SQL = "insert into team(teamName,teamLeader,teamManager,teamCoach,teamFullName,birthDate,matchName,location,introduction) values('";
            SQL = SQL + team.getName() + "','" + team.getLeader() + "','" + team.getManager() + "','" + team.getCoach() + "','" + team.getTeamFullName() +
                      "','" + team.getBirthDate() + "','" + team.getMatchName() + "','" + team.getLocation()+ "','" + team.getIntroduction() + "')";
            try
            {
                dbutility.openConnection();
                dbutility.ExecuteUpdate(SQL);
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
