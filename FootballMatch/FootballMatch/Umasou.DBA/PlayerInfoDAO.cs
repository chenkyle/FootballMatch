using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballMatch.Umasou.Model;
using FootballMatch.Umasou.DBA;
using MySql.Data.MySqlClient;

namespace FootballMatch.Umasou.DBA
{
    class PlayerInfoDAO
    {
        ///
        ///本类主要用于记录处理球员信息的数据库操作
        ///
        //依据球员的编号，返回球员信息
        public static FootballPlayer getPlayerInfo(int playerID)
        {
            FootballPlayer player = new FootballPlayer();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID,playerName,number,postion,teamName,playerIDnum from player where ID=" + playerID;
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
                    player.setIDnum(Convert.ToString(rd[5]));
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
            string SQL = "select ID,playerName,number,postion,teamName,playerIDnum from player where playerName='" + playerName + "'";
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
                    player.setIDnum(Convert.ToString(rd[5]));
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
        //检查球员名称是否存在
        public static bool checkPlayerNameExist(string name)
        {
            bool flag = false;
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID,playerName from player where playerName='" + name + "'";
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
        public static List<FootballPlayer> getPlayerInfo()
        {
            //声明实例
            List<FootballPlayer> list = new List<FootballPlayer>();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select ID,playerName,number,postion,teamName,playerIDnum from player order by ID";
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
        //查询参加某个比赛的球员信息列表
        public static List<FootballPlayer> getPlayerInfo(Game game)
        {
            //声明实例
            List<FootballPlayer> list = new List<FootballPlayer>();
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL="";          
            try
            {
                dbutility.openConnection();
                //取出比赛的参与球队，若两个球队相同时，只查询一次球队，然后返回到球员列表中
                if (game.getHomeTeam() == game.getGuestTeam())
                {
                    SQL = "select ID,playerName,number,postion,teamName,playerIDnum from player where teamName='" + game.getHomeTeam();
                    SQL = SQL + "' order by ID";
                    MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                    while (rd.Read())
                    {
                        list.Add(new FootballPlayer(Convert.ToInt32(rd[0]), Convert.ToString(rd[1]), Convert.ToInt32(rd[2]), Convert.ToString(rd[3]), Convert.ToString(rd[4]), Convert.ToString(rd[5])));
                    }
                }
                else  //当参加比赛的两个球队不相同时
                {
                    SQL = "select ID,playerName,number,postion,teamName,playerIDnum from player where teamName='" + game.getHomeTeam();
                    SQL = SQL + "' order by ID";
                    MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                    while (rd.Read())
                    {
                        list.Add(new FootballPlayer(Convert.ToInt32(rd[0]), Convert.ToString(rd[1]), Convert.ToInt32(rd[2]), Convert.ToString(rd[3]), Convert.ToString(rd[4]), Convert.ToString(rd[5])));
                    }
                    //查询客队球员信息
                    SQL = "select ID,playerName,number,postion,teamName,playerIDnum from player where teamName='" + game.getGuestTeam();
                    SQL = SQL + "' order by ID";
                    MySqlDataReader rds = dbutility.ExecuteQuery(SQL);
                    while (rds.Read())
                    {
                        list.Add(new FootballPlayer(Convert.ToInt32(rds[0]), Convert.ToString(rds[1]), Convert.ToInt32(rds[2]), Convert.ToString(rds[3]), Convert.ToString(rds[4]), Convert.ToString(rd[5])));
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
            return list;
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
        //删除球员信息
        public static void deletePlayerInfo(List<int> list)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "";
            try
            {
                dbutility.openConnection();
                for (int i = 0; i < list.Count; i++)
                {
                    sql = "delete from player where ID=" + list[i];
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
        //删除球员信息
        public static void deletePlayerInfo(List<FootballPlayer> list)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "";
            try
            {
                dbutility.openConnection();
                for (int i = 0; i < list.Count; i++)
                {
                    sql = "delete from player where ID=" + list[i].getID();
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
        * 更新某一个赛事的信息
        */
        public static bool updatePlayerInfo(FootballPlayer player)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "update player set playerName='" + player.getName() + "' ,postion='" + player.getPostion();
            sql = sql + "' ,number=" + player.getNumber() +" ,teamName='" + player.getBelongTeam()+",'"+player.getIDnum();
            sql = sql + "' where ID=" + player.getID();
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
        //往数据库中添加球员，返回是否添加成功的信息
        public static bool addNewPlayer(FootballPlayer player)
        {
            DBUtility dbutility = new DBUtility();
            string SQL = "insert into player(playerName,postion,teamName,number,playerIDnum) values('";
            SQL = SQL + player.getName() + "','" + player.getPostion() + "','" + player.getBelongTeam() + "'," + player.getNumber() + ",'" +player.getIDnum() + "')";
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
