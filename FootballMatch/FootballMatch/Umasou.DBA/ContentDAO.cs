using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using MySql.Data.MySqlClient;
using FootballMatch.Umasou.Model;
using System.Windows.Forms;

namespace FootballMatch.Umasou.DBA
{
    class ContentDAO
    {
        ///
        ///记录一些基本的数据库查询事件
        ///
        /*
         * 查询数据库中的赛事的基本信息，并且返回到一个线性表中
         */
        public static List<SeasonMatch> getMatchInfo()
        {
            //声明实例
            List<SeasonMatch> list = new List<SeasonMatch>();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID,seasonName,description,switchNum,serialNum from matchinfo order by ID";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    list.Add(new SeasonMatch(Convert.ToInt32(rd[0]),Convert.ToString(rd[1]),Convert.ToString(rd[2]),Convert.ToInt32(rd[3]),Convert.ToInt32(rd[4])));
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
        //依据赛事的编号返回赛事信息类
        public static SeasonMatch getMatchInfo(int matchID)
        {
            SeasonMatch match = new SeasonMatch();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID,seasonName,description,switchNum,serialNum from matchinfo where ID=" + matchID;
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    match.setID(matchID);
                    match.setName(Convert.ToString(rd[1]));
                    match.setDescription(Convert.ToString(rd[2]));
                    match.setSwitchNum(Convert.ToInt32(rd[3]));
                    match.setSerialNum(Convert.ToInt32(rd[4]));
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
            return match;
        }
        //依据赛事名称，返回赛事信息
        public static SeasonMatch getMatchInfo(string matchName)
        {
            SeasonMatch match = new SeasonMatch();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID,seasonName,description,switchNum,serialNum from matchinfo where seasonName='" + matchName + "'";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    match.setID(Convert.ToInt32(rd[0]));
                    match.setName(Convert.ToString(rd[1]));
                    match.setDescription(Convert.ToString(rd[2]));
                    match.setSwitchNum(Convert.ToInt32(rd[3]));
                    match.setSerialNum(Convert.ToInt32(rd[4]));
                    
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
            return match;
        }
        //依据球员的编号，返回球员信息
        public static FootballPlayer getPlayerInfo(int playerID)
        {
            FootballPlayer player = new FootballPlayer();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID,playerName,number,postion,teamName from player where ID=" + playerID;
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    player.setPlayerID(playerID);
                    player.setPlayerName(Convert.ToString(rd[1]));
                    player.setPlayNumber(Convert.ToInt32(rd[2]));
                    player.setPostion(Convert.ToString(rd[3]));
                    player.setBelongTeam(Convert.ToString(rd[4]));
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
            return player;
        }
        //依据球员的姓名，返回球员信息
        public static FootballPlayer getPlayerInfo(string playerName)
        {
            FootballPlayer player = new FootballPlayer();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID,playerName,number,postion,teamName from player where playerName='" + playerName+"'";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    player.setPlayerID(Convert.ToInt32(rd[0]));
                    player.setPlayerName(Convert.ToString(rd[1]));
                    player.setPlayNumber(Convert.ToInt32(rd[2]));
                    player.setPostion(Convert.ToString(rd[3]));
                    player.setBelongTeam(Convert.ToString(rd[4]));
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
            return player;
        }
        //依据球队编号，返回球队的信息
        public static Team getTeamInfo(int teamID)
        {
            Team team = new Team();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID,teamName,teamLeader,teamManager,teamCoach from player where ID=" + teamID;
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    team.setID(teamID);
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
        //获取球队信息
        public static Team getTeamInfo(string teamName)
        {
            Team team = new Team();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID,teamName,teamLeader,teamManager,teamCoach from player where teamName='" + teamName+"'";
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
        public static bool checkMatchNameExist(string name)
        {
            bool flag = false;
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID,seasonName,description from matchinfo where seasonName='" + name + "'";
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
        //往数据库中添加赛事，并且返回新被添加的赛事
        public static SeasonMatch addNewMatch(string name,string description,int switchNum,int serialNum)
        {
            SeasonMatch match = new SeasonMatch();
            DBUtility dbutility = new DBUtility();
            int matchID;
            string SQL = "insert into matchinfo(seasonName,description,switchNum,serialNum) values('";
            SQL=SQL+name + "','" + description + "'," + switchNum + "," + serialNum + ")";
            try
            {
                dbutility.openConnection();
                matchID = dbutility.ExecuteQuery_Last_Insert_ID(SQL);
               // dbutility.ExecuteUpdate(SQL);
                match.setID(matchID);
                match.setName(name);
                match.setDescription(description);
                match.setSwitchNum(switchNum);
                match.setSerialNum(serialNum);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                dbutility.Close();
            }
            return match;
        }
        public static void addNewPlayerCardNum(PlayerCardRecord _playerCardNum)
        {
            DBUtility dbutility = new DBUtility();
            string SQL = "insert into playerGetCardRecord(matchID,playerID,serialNum,yellowCardNum,redCardNum,";
            SQL = SQL + "getDate) values(" + _playerCardNum.getMatchID() + "," + _playerCardNum.getPlayerID() + ",";
            SQL = SQL + _playerCardNum.getSerialNum() + "," + _playerCardNum.getYellowCardNum() + ",";
            SQL = SQL + _playerCardNum.getRedCardNum() + ",'" + _playerCardNum.getDateTime()+ "')";
            try
            {
                dbutility.openConnection();
                dbutility.ExecuteUpdate(SQL);
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
        //查询球队信息
        public static List<Team> getTeamInfo()
        {
            //声明实例
            List<Team> list = new List<Team>();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID,teamName,teamLeader,teamManager,teamCoach from team order by ID";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    list.Add(new Team(Convert.ToInt32(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToString(rd[3]), Convert.ToString(rd[4])));
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
        //查询球队信息
        public static List<FootballPlayer> getPlayerInfo()
        {
            //声明实例
            List<FootballPlayer> list = new List<FootballPlayer>();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID,playerName,number,postion,teamName ,playerIDnum from player order by ID";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    list.Add(new FootballPlayer(Convert.ToInt32(rd[0]), Convert.ToString(rd[1]), Convert.ToInt32(rd[2]), Convert.ToString(rd[3]), Convert.ToString(rd[4]), Convert.ToString(rd[5])));
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

       #region[删除记录]
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
        //删除赛事信息
        public static void deleteMatchInfo(int matchID)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "delete from matchinfo where ID=" + matchID;
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
        //删除球员信息
        public static void deletePlayerInfo(int playerID)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "delete from player where ID=" + playerID;
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

    }
}
