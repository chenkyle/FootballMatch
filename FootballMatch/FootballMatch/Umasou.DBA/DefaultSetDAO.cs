using FootballMatch.Umasou.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballMatch.Umasou.DBA
{
    class DefaultSetDAO
    {
         
        public static void setDefaultSet() {


            DBUtility dbutility = new DBUtility();
            string sql="update defaultset set defaultSeason='"+DefaultSet.getDefaultSeason()+"',defaultMatch='"+DefaultSet.getDefaultMatch()+"',defaultTurn='"+DefaultSet.getDefaultTurn()+"';";
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

        public static void getDefaultSet() {

            DBUtility dbutility = new DBUtility();
            string sql = "select * from defaultset;";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(sql);
                while (rd.Read())
                {
                    DefaultSet.setDefaultSeason(Convert.ToString(rd[0]));
                    DefaultSet.setDedaultMatch(Convert.ToString(rd[1]));
                    DefaultSet.setDefaultTurn(Convert.ToInt32(rd[2]));
                }
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

    }
}
