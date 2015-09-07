using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using MySql.Data.MySqlClient;
using FootballMatch.Umasou.Model;

namespace FootballMatch.Umasou.DBA
{
    class SuspendedRecordDAO
    {
        ///
        ///<Summary> 用来处理球员停赛信息的数据库操作</Summary>
        ///

        //检查某一场比赛中，某一个球员是否已经有停赛记录
        public static bool checkPlayerSuspended(int playerID,int matchID,int gameNum)
        {
            bool flag = false;
            DBUtility dbutility = new DBUtility();
            string sql = "select * from suspendedrecord where matchID=" + matchID + " and gameNum=" + gameNum;
            sql = sql + " and playerID=" + playerID;
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
                Console.Write(ex.ToString());
            }
            finally
            {
                dbutility.Close();
            }
            return flag;
        }
        //获取某一球员在某一赛事中所有的停赛记录
        public static List<SuspendedRecord> getPlayerSuspendedRecord(int matchID,int playerID)
        {
            List<SuspendedRecord> list = new List<SuspendedRecord>();
            DBUtility dbutility = new DBUtility();
            string sql = "select uniqueID,matchID,playerID,gameNum,Date from suspendedrecord where matchID=" + matchID;
            sql = sql + " and playerID=" + playerID;
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    //添加记录信息
                    list.Add(new SuspendedRecord(Convert.ToInt32(rd[0]),Convert.ToInt32(rd[1]),Convert.ToInt32(rd[2]),Convert.ToInt32(rd[3]),Convert.ToDateTime(rd[4])));
                }
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                dbutility.Close();
            }
            return list;
        }
        //获取某一球员在某一赛事中所有的停赛记录,在指定的比赛之前的停赛记录
        public static List<SuspendedRecord> getPlayerSuspendedRecord_BeforeGame(int matchID, int playerID,int gameNum)
        {
            List<SuspendedRecord> list = new List<SuspendedRecord>();
            DBUtility dbutility = new DBUtility();
            string sql = "select uniqueID,matchID,playerID,gameNum,Date from suspendedrecord where matchID=" + matchID;
            sql = sql + " and playerID=" + playerID+" and gameNum<"+gameNum;
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    //添加记录信息
                    list.Add(new SuspendedRecord(Convert.ToInt32(rd[0]), Convert.ToInt32(rd[1]), Convert.ToInt32(rd[2]), Convert.ToInt32(rd[3]), Convert.ToDateTime(rd[4])));
                }
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                dbutility.Close();
            }
            return list;
        }
        //获取某一球员在某一赛事中所有停赛记录的总和
        public static int getPlayerSuspendedQuantity(int matchID, int playerID)
        {
            int quantity = 0;
            DBUtility dbutility = new DBUtility();
            //查询某个球员所有停赛记录，同一场球赛不能被停赛两次或两次以上
            string sql = "select COUNT(DISTINCT gameNum) from suspendedrecord where matchID=" + matchID;
            sql = sql + " and playerID=" + playerID;
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    quantity = Convert.ToInt32(rd[0]);
                }
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                dbutility.Close();
            }
            return quantity;
        }
        //添加停赛记录信息
        public static void addNewSuspendedRecord(int matchID,int gameNum,int playerID,DateTime date)
        {
            DBUtility dbutility = new DBUtility();
            //查询某个球员所有停赛记录，同一场球赛不能被停赛两次或两次以上
            string sql = "INSERT INTO suspendedrecord(matchID,playerID,gameNum,Date) VALUES(" + matchID + ",";
            sql = sql + playerID + "," + gameNum + ",'" + date + "')";
            try
            {
                dbutility.openConnection();
                dbutility.ExecuteUpdate(sql);
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                dbutility.Close();
            }
        }
    }
}
