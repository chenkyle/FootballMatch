using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballMatch.Umasou.DBA;
using FootballMatch.Umasou.Model;
using FootballMatch.Umasou.Util;

namespace FootballMatch.Umasou.Business
{
    public partial class CreateNewSeason : Form
    {
        public CreateNewSeason( )
        {
            
            InitializeComponent();
            
        }


         
        private void button_ok_Click(object sender, EventArgs e)
        {
             
            this.addNewSeasonInfo();
             
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
        //添加一个赛事的新赛季记录，
        private void addNewSeasonInfo( )
        {
             
            if(textBox_numOfSeason.Text!=""){

                if (checkSwitchResult.checkStringSwitchInteger(textBox_numOfSeason.Text)) { 
                
  }               if(this.textBox_NumOfTurn.Text!="" ){
   {

                    int numOfseason = Convert.ToInt32(textBox_numOfSeason.Text);
                    string seasonMatchName = textBox_MatchName.Text.Trim();
                    string description = textBox_seasonDescInfo.Text;
                    int numOfTurn = Convert.ToInt32(this.textBox_NumOfTurn.Text);
                    SeasonOfMatch newSeason = new SeasonOfMatch(seasonMatchName,numOfseason);
                    newSeason.setSeasonDescription(description);
                    newSeason.setNumOfTurn(numOfTurn);
                    SeasonInfoDAO.getMaxId();
                    newSeason.setId(SeasonInfoDAO.getMaxId()+1);
                  
               
                    SeasonInfoDAO.addNewSeasonInfo(newSeason);
                    //弹出对话框，提示是否继续添加
                    if (MessageBox.Show("添加赛季信息成功，！", "添加新赛季成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        //清空其他
                        //textBox_MatchName.Text = "";
                        int num=SeasonInfoDAO.getMaxSeasonNumOfMatch(SystemParam.getMatch().getName()) + 1;
                        label_numHelp.Text = "* 最近赛季为第" + (num - 1) + "季";
                        textBox_numOfSeason.Text =Convert.ToString(num);
                        textBox_seasonDescInfo.Text = "";
                    }
                    else
                    {
                        this.Close();
                    }




                }
  
                     }  else{  MessageBox.Show("没有填写赛季的比赛轮次数目！"); }

              }
            else { MessageBox.Show("没有填写当前赛季届数"); }

            
   }

        //窗体加载
        #region
       
        private void createNewSeason_Load(object sender, EventArgs e)
        {
            this.loadBaseInfo();
        }
        #endregion

        //加载初始信息
        private void loadBaseInfo() {

          //  SeasonOfMatch season;
            SeasonMatch match;
            //取出当前设定的赛事赛季信息
           // season = SystemParam.getCurrentSelectedSeaon();
            match = SystemParam.getMatch();
            int seasonNum = 0;  
            //清空下拉列表的数据信息
            textBox_MatchName.Text = match.getName();
            
            //默认新赛季可以为以前赛季数目最大值加1,如果没有赛季则当前为1

            if (SeasonInfoDAO.checkSeasonOfCertainMatchIsNull(match.getName()))
             {  seasonNum = 1; }
            else {  seasonNum = SeasonInfoDAO.getMaxSeasonNumOfMatch(match.getName()) + 1; }

            
            textBox_numOfSeason.Text = Convert.ToString(seasonNum);
            label_numHelp.Text = "* 最近赛季为第" + (seasonNum-1) + "季";
      
        
        }

        private void textBox_numOfSeason_Click(object sender, EventArgs e)
        {
            textBox_numOfSeason.Text = "";
        }

       



    }
}
