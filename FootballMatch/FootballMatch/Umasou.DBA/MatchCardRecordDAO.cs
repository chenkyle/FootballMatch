using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using FootballMatch.Umasou.Model;
using MySql.Data.MySqlClient;

namespace FootballMatch.Umasou.DBA
{
    public class MatchCardRecordDAO
    {
        ///
        ///<summary>本类用来处理罚牌记录的数据库基本操作</summary>
        ///
        //查询某一赛事的所有罚牌记录信息
        public static List<PlayerCardRecord> getMatchPlayerCardRecord(int matchID)
        {
            List<PlayerCardRecord> list = new List<PlayerCardRecord>();
            DBUtility dbutility = new DBUtility();
            string sql = "select playergetcardrecord.uniqueID,playergetcardrecord.matchID,matchinfo.seasonName,";
            sql=sql+"playergetcardrecord.playerID,player.playerName,playergetcardrecord.yellowCardNum,";
            sql=sql+"playergetcardrecord.redCardNum,playergetcardrecord.serialNum,playergetcardrecord.getDate from ";
            sql = sql + "playergetcardrecord,player,matchinfo where playergetcardrecord.matchID=matchinfo.ID and ";
            sql = sql + "playergetcardrecord.playerID=player.ID and playergetcardrecord.matchID=" + matchID;
            sql = sql + " order by playergetcardrecord.serialNum";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    PlayerCardRecord playerCardRecord = new PlayerCardRecord();
                    playerCardRecord.setUniqueID(Convert.ToInt32(rd[0]));
                    playerCardRecord.setMatchID(Convert.ToInt32(rd[1]));
                    playerCardRecord.setMatchName(Convert.ToString(rd[2]));
                    playerCardRecord.setPlayerID(Convert.ToInt32(rd[3]));
                    playerCardRecord.setPlayerName(Convert.ToString(rd[4]));
                    playerCardRecord.setYellowCardNum(Convert.ToInt32(rd[5]));
                    playerCardRecord.setRedCardNum(Convert.ToInt32(rd[6]));
                    playerCardRecord.setSerialNum(Convert.ToInt32(rd[7]));
                    playerCardRecord.setDateTime(Convert.ToDateTime(rd[8]));
                    list.Add(playerCardRecord);
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
        //查询某一赛事的所有罚牌记录信息
        public static List<PlayerCardRecord> getMatchCardRecord(int matchID)
        {
            List<PlayerCardRecord> list = new List<PlayerCardRecord>();
            DBUtility dbutility = new DBUtility();
            string sql = "select playergetcardrecord.uniqueID,playergetcardrecord.matchID,matchinfo.seasonName,";
            sql = sql + "playergetcardrecord.playerID,player.playerName,playergetcardrecord.yellowCardNum,";
            sql = sql + "playergetcardrecord.redCardNum,playergetcardrecord.serialNum,playergetcardrecord.getDate,gameinfo.gameName from ";
            sql = sql + "playergetcardrecord,player,matchinfo,gameinfo where playergetcardrecord.matchID=matchinfo.ID and ";
            sql = sql + "gameinfo.matchID=playergetcardrecord.matchID and playergetcardrecord.serialNum=gameinfo.matchGameNum and ";
            sql = sql + "playergetcardrecord.playerID=player.ID and playergetcardrecord.matchID=" + matchID;
            sql = sql + " order by playergetcardrecord.serialNum";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    PlayerCardRecord playerCardRecord = new PlayerCardRecord();
                    playerCardRecord.setUniqueID(Convert.ToInt32(rd[0]));
                    playerCardRecord.setMatchID(Convert.ToInt32(rd[1]));
                    playerCardRecord.setMatchName(Convert.ToString(rd[2]));
                    playerCardRecord.setPlayerID(Convert.ToInt32(rd[3]));
                    playerCardRecord.setPlayerName(Convert.ToString(rd[4]));
                    playerCardRecord.setYellowCardNum(Convert.ToInt32(rd[5]));
                    playerCardRecord.setRedCardNum(Convert.ToInt32(rd[6]));
                    playerCardRecord.setSerialNum(Convert.ToInt32(rd[7]));
                    playerCardRecord.setDateTime(Convert.ToDateTime(rd[8]));
                    playerCardRecord.setGameName(Convert.ToString(rd[9]));
                    list.Add(playerCardRecord);
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
        //添加球员罚牌记录信息
        public static void addNewPlayerCardNum(PlayerCardRecord _playerCardNum)
        {
            DBUtility dbutility = new DBUtility();
            string SQL = "insert into playerGetCardRecord(matchID,playerID,serialNum,yellowCardNum,redCardNum,";
            SQL = SQL + "getDate) values(" + _playerCardNum.getMatchID() + "," + _playerCardNum.getPlayerID() + ",";
            SQL = SQL + _playerCardNum.getSerialNum() + "," + _playerCardNum.getYellowCardNum() + ",";
            SQL = SQL + _playerCardNum.getRedCardNum() + ",'" + _playerCardNum.getDateTime() + "')";
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
        //取出某球员在某一赛事的所有罚牌记录
        public static List<PlayerCardRecord> getPlayerCardRecord(int matchID,int playerID)
        {
            List<PlayerCardRecord> list = new List<PlayerCardRecord>();
            DBUtility dbutility = new DBUtility();
            string sql = "select playergetcardrecord.uniqueID,playergetcardrecord.matchID,matchinfo.seasonName,";
            sql = sql + "playergetcardrecord.playerID,player.playerName,playergetcardrecord.yellowCardNum,";
            sql = sql + "playergetcardrecord.redCardNum,playergetcardrecord.serialNum,playergetcardrecord.getDate from ";
            sql = sql + "playergetcardrecord,player,matchinfo where playergetcardrecord.matchID=matchinfo.ID and ";
            sql = sql + "playergetcardrecord.playerID=player.ID and playergetcardrecord.matchID=" + matchID;
            sql = sql + " and playergetcardrecord.playerID=" + playerID;
            sql = sql + " order by playergetcardrecord.serialNum";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    PlayerCardRecord playerCardRecord = new PlayerCardRecord();
                    playerCardRecord.setUniqueID(Convert.ToInt32(rd[0]));
                    playerCardRecord.setMatchID(Convert.ToInt32(rd[1]));
                    playerCardRecord.setMatchName(Convert.ToString(rd[2]));
                    playerCardRecord.setPlayerID(Convert.ToInt32(rd[3]));
                    playerCardRecord.setPlayerName(Convert.ToString(rd[4]));
                    playerCardRecord.setYellowCardNum(Convert.ToInt32(rd[5]));
                    playerCardRecord.setRedCardNum(Convert.ToInt32(rd[6]));
                    playerCardRecord.setSerialNum(Convert.ToInt32(rd[7]));
                    playerCardRecord.setDateTime(Convert.ToDateTime(rd[8]));
                    list.Add(playerCardRecord);
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
        //取出某球员在某一赛事的所有罚牌记录,在指定某一场比赛之前的所有罚牌记录
        public static List<PlayerCardRecord> getPlayerCardRecord_beforeGame(int matchID, int playerID,int gameNum)
        {
            List<PlayerCardRecord> list = new List<PlayerCardRecord>();
            DBUtility dbutility = new DBUtility();
            string sql = "select playergetcardrecord.uniqueID,playergetcardrecord.matchID,matchinfo.seasonName,";
            sql = sql + "playergetcardrecord.playerID,player.playerName,playergetcardrecord.yellowCardNum,";
            sql = sql + "playergetcardrecord.redCardNum,playergetcardrecord.serialNum,playergetcardrecord.getDate from ";
            sql = sql + "playergetcardrecord,player,matchinfo where playergetcardrecord.matchID=matchinfo.ID and ";
            sql = sql + "playergetcardrecord.playerID=player.ID and playergetcardrecord.matchID=" + matchID;
            sql = sql + " and playergetcardrecord.playerID=" + playerID + " and playergetcardrecord.serialNum<"+gameNum;
            sql = sql + " order by playergetcardrecord.serialNum";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    PlayerCardRecord playerCardRecord = new PlayerCardRecord();
                    playerCardRecord.setUniqueID(Convert.ToInt32(rd[0]));
                    playerCardRecord.setMatchID(Convert.ToInt32(rd[1]));
                    playerCardRecord.setMatchName(Convert.ToString(rd[2]));
                    playerCardRecord.setPlayerID(Convert.ToInt32(rd[3]));
                    playerCardRecord.setPlayerName(Convert.ToString(rd[4]));
                    playerCardRecord.setYellowCardNum(Convert.ToInt32(rd[5]));
                    playerCardRecord.setRedCardNum(Convert.ToInt32(rd[6]));
                    playerCardRecord.setSerialNum(Convert.ToInt32(rd[7]));
                    playerCardRecord.setDateTime(Convert.ToDateTime(rd[8]));
                    list.Add(playerCardRecord);
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
    }
}
