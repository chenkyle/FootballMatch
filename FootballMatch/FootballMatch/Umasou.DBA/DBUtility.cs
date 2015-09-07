using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;   //声明连接mysql的空间
using MySql.Data.MySqlClient;
using System.Configuration;

namespace FootballMatch.Umasou.DBA
{
    class DBUtility
    {
        ///连接数据库的工具类，包括打开，关闭数据库连接等
        ///
        //声明实例
        private string connectString = null;
        private  MySqlConnection connection= null;
        private MySqlCommand command = null;
        //构造函数
        public DBUtility()
        {
            //获取配置文件中连接数据库的代码
            connectString = System.Configuration.ConfigurationManager.AppSettings["MySQLconnection"];
             //  connectString = "Data Source=localhost;UserName=root;password=root;Database=footballmatch;";
        }
        //打开数据库连接
        public bool openConnection()
        {
            bool flag = false;
            try
            {
                connection = new MySqlConnection(connectString);
                connection.Open();
                flag=true;
            }
            catch(MySqlException exception){
                Console.WriteLine(exception.ToString());
                flag=false;
            }
            return flag;
        }
        //执行查询数据库操作
        public MySqlDataReader ExecuteQuery(string SQL)
        {
            command = new MySqlCommand(SQL, connection);
            return command.ExecuteReader();
        }
        //执行数据库更新操作,返回被更新的数据的条数
        public int ExecuteUpdate(string SQL)
        {
            int flag = -1;
            try
            {
                command = new MySqlCommand(SQL, connection);
                flag = command.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return flag;
        }
        //执行更新插入数据库并且返回最新的记录
        public int ExecuteQuery_Last_Insert_ID(string SQL)
        {
            int uniqueID = -1;
            try
            {
                command = new MySqlCommand(SQL, connection);
                command.ExecuteNonQuery();  //先执行更新操作，然后在执行查询操作
                string sql = "select Last_INSERT_ID()";
                MySqlCommand comm = new MySqlCommand(sql, connection);
                MySqlDataReader rd = comm.ExecuteReader();
                while (rd.Read())
                {
                    uniqueID = Convert.ToInt32(rd[0]);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return uniqueID;
        }
        //关闭数据库连接
        public void Close()
        {
            if (command != null)
            {
                command.Dispose();
            }
            if (connection != null)
            {
                connection.Close();
            }
        }
        //获取连接
        public MySqlConnection getConnection()
        {
            return connection;
        }
        //获取执行语句
        public MySqlCommand getCommand()
        {
            return command;
        }
        //关闭数据库连接
        public void Close(MySqlConnection connect)
        {
            connect.Close();
        }
        public void Close(MySqlCommand command)
        {
            command.Dispose();
        }
    }
}
