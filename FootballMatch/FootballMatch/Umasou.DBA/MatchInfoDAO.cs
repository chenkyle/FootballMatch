using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballMatch.Umasou.Model;
using MySql.Data.MySqlClient;

namespace FootballMatch.Umasou.DBA
{
    class MatchInfoDAO
    {
        ///
        ///本类针对赛事信息的数据库处理
        ///
        /*
         * 更新某一个赛事的信息
         */
        public static void updateMatchInfo(SeasonMatch match)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "update matchinfo set seasonName='"+match.getName()+"' ,description='"+match.getDescription();
            sql = sql + "' ,switchNum=" + match.getSwitchNum() + " ,serialNum=" + match.getSerialNum();
            sql = sql + " where ID=" + match.getID();
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
                    list.Add(new SeasonMatch(Convert.ToInt32(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToInt32(rd[3]), Convert.ToInt32(rd[4])));
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
        public static bool checkUpdateMatchName(string name)
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
        public static SeasonMatch addNewMatch(string name, string description, int switchNum, int serialNum)
        {
            SeasonMatch match = new SeasonMatch();
            DBUtility dbutility = new DBUtility();
            int matchID;
            string SQL = "insert into matchinfo(seasonName,description,switchNum,serialNum) values('";
            SQL = SQL + name + "','" + description + "'," + switchNum + "," + serialNum + ")";
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
        //删除赛事信息
        public static void deleteMatchInfo(List<int> list)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "";
            try
            {
                dbutility.openConnection();
                for (int i = 0; i < list.Count; i++)
                {
                    sql = "delete from matchinfo where ID=" + list[i];
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
        //删除赛事信息
        public static void deleteMatchInfo(List<SeasonMatch> list)
        {
            DBUtility dbutility = new DBUtility();
            string sql = "";
            try
            {
                dbutility.openConnection();
                for (int i = 0; i < list.Count; i++)
                {
                    sql = "delete from matchinfo where ID=" + list[i].getID();
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
        //检查某一个赛事中，比赛数量是否满足条件
        public static bool checkGameNumLegal(int matchID,int gameNum)
        {
            bool flag = false;
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select serialNum from matchinfo where ID=" + matchID + "";
            int _gameNum = -1;
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    _gameNum = Convert.ToInt32(rd[0]);
                }
                //判断某一赛事中比赛的总量是否是大于新添加的比赛的比赛序号
                if (gameNum <= _gameNum)
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
        //获取某一赛事中黄牌转红牌的数量
        public static int getMatchSwitchNum(int matchID)
        {
            int switchNum = 0;
            //执行查询数据库操作
            DBUtility dbutility = new DBUtility();
            string SQL = "select switchNum from matchinfo where ID=" + matchID;
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                while (rd.Read())
                {
                    switchNum = Convert.ToInt32(rd[0]);
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
            return switchNum;
        }
    }
}
