using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using MySql.Data.MySqlClient;
using FootballMatch.Umasou.Model;


namespace FootballMatch.Umasou.DBA
{
    class GameInfoDAO
    {
        ///
        /// 本类用来处理比赛信息的数据库信息
        /// 
        //取出某一赛事中的比赛信息
        public static List<Game> getMatchGameInfo(int matchID)
        {
            DBUtility dbutility = new DBUtility();
            List<Game> list = new List<Game>();
            string sql = "select uniqueID,matchID,matchGameNum,gameName,homeTeam,guestTeam,gameWinner,";
            sql = sql + "gameResult,gameAddress,gameDate from gameInfo where matchID=" + matchID + " ORDER BY matchGameNum";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    list.Add(new Game(Convert.ToInt32(rd[0]), Convert.ToInt32(rd[1]), Convert.ToInt32(rd[2]),
                        Convert.ToString(rd[3]), Convert.ToString(rd[4]), Convert.ToString(rd[5]), Convert.ToString(rd[6]),
                        Convert.ToString(rd[7]), Convert.ToString(rd[8]), Convert.ToDateTime(rd[9])));
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
        //取出所有比赛信息
        public static List<Game> getAllGameInfo()
        {
            DBUtility dbutility = new DBUtility();
            List<Game> list = new List<Game>();
            string sql = "select uniqueID,matchID,matchGameNum,gameName,homeTeam,guestTeam,gameWinner,";
            sql = sql + "gameResult,gameAddress,gameDate from gameInfo ORDER BY uniqueID";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    list.Add(new Game(Convert.ToInt32(rd[0]), Convert.ToInt32(rd[1]), Convert.ToInt32(rd[2]),
                        Convert.ToString(rd[3]), Convert.ToString(rd[4]), Convert.ToString(rd[5]), Convert.ToString(rd[6]),
                        Convert.ToString(rd[7]), Convert.ToString(rd[8]), Convert.ToDateTime(rd[9])));
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
        //查询某一场比赛的信息
        public static Game getGameInfo(int uniqueID)
        {
            DBUtility dbutility = new DBUtility();
            Game game = new Game();
            string sql = "select uniqueID,matchID,matchGameNum,gameName,homeTeam,guestTeam,gameWinner,";
            sql = sql + "gameResult,gameAddress,gameDate from gameInfo where uniqueID="+uniqueID;
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    game=new Game(Convert.ToInt32(rd[0]), Convert.ToInt32(rd[1]), Convert.ToInt32(rd[2]),
                        Convert.ToString(rd[3]), Convert.ToString(rd[4]), Convert.ToString(rd[5]), Convert.ToString(rd[6]),
                        Convert.ToString(rd[7]), Convert.ToString(rd[8]), Convert.ToDateTime(rd[9]));
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
            return game;
        }
        //查询某一场比赛的信息
        public static Game getGameInfo(int matchID,string gameName)
        {
            DBUtility dbutility = new DBUtility();
            Game game = new Game();
            string sql = "select uniqueID,matchID,matchGameNum,gameName,homeTeam,guestTeam,gameWinner,";
            sql = sql + "gameResult,gameAddress,gameDate from gameInfo where gameName='" + gameName+"'";
            sql = sql + " and matchID=" + matchID;
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    game = new Game(Convert.ToInt32(rd[0]), Convert.ToInt32(rd[1]), Convert.ToInt32(rd[2]),
                        Convert.ToString(rd[3]), Convert.ToString(rd[4]), Convert.ToString(rd[5]), Convert.ToString(rd[6]),
                        Convert.ToString(rd[7]), Convert.ToString(rd[8]), Convert.ToDateTime(rd[9]));
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
            return game;
        }
        //检查某一个比赛的名称是否存在,某一赛事中比赛的名称必须是唯一的
        public static bool checkGameNameExist(int matchID,string gameName)
        {
            bool flag = false;
            DBUtility dbutility = new DBUtility();
            string sql = "select uniqueID,matchID,matchGameNum,gameName,homeTeam,guestTeam,gameWinner,";
            sql = sql + "gameResult,gameAddress,gameDate from gameInfo where gameName='" + gameName + "'";
            sql = sql + " and matchID=" + matchID;
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
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
        //检查某一赛事中某一比赛序号是否存在
        public static bool checkGameNumExist(int matchID, int gameNum)
        {
            bool flag = false;
            DBUtility dbutility = new DBUtility();
            string sql = "select uniqueID,matchID,matchGameNum,gameName,homeTeam,guestTeam,gameWinner,";
            sql = sql + "gameResult,gameAddress,gameDate from gameInfo where matchGameNum=" + gameNum + "";
            sql = sql + " and matchID=" + matchID;
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
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
        //添加比赛信息
        public static void addNewGameInfo(Game game)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "insert into gameInfo(matchID,matchGameNum,gameName,homeTeam,guestTeam,gameWinner,";
            sql = sql + "gameResult,gameAddress,gameDate) values(" + game.getMatchID() + "," + game.getMatchGameNum() + ",'";
            sql=sql+game.getGameName() + "','"+game.getHomeTeam()+"','"+game.getGuestTeam()+"','"+game.getGameWinner()+"','";
            sql = sql + game.getGameResult() + "','" + game.getGameAddress() + "','" + game.getGameDate() + "')";
            try
            {
                dbutility.openConnection();
                dbutility.ExecuteUpdate(sql);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
              //  MessageBox.Show(ex.ToString());
            }
            finally
            {
                dbutility.Close();
            }
        }
        //获取某一赛事中其最大的比赛序号的记录
        public static int getMatchMaxGameNum(int matchID)
        {
            int _maxGameNum = 0;  //记录最大的比赛序号
            DBUtility dbutility = new DBUtility();
            string sql = "select max(matchGameNum) from gameInfo where matchID=" + matchID;
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    if (Convert.ToString(rd[0]) != "")
                    {
                        _maxGameNum = Convert.ToInt32(rd[0]);
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
            return _maxGameNum;
        }
    }
}
