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
            if (comboBox_matchName.SelectedItem != null)
            { if(textBox_numOfSeason.Text!=""){

                if (checkSwitchResult.checkStringSwitchInteger(textBox_numOfSeason.Text)) {

                    int numOfseason = Convert.ToInt32(textBox_numOfSeason.Text);
                    string seasonMatchName = comboBox_matchName.Text.Trim();
                    string description = textBox_seasonDescInfo.Text;
                    SeasonOfMatch newSeason = new SeasonOfMatch(seasonMatchName,numOfseason);
                    newSeason.setSeasonDescription(description);
                    SeasonInfoDAO.getMaxId();
                    newSeason.setId(SeasonInfoDAO.getMaxId()+1);
                   
               
                    SeasonInfoDAO.addNewSeasonInfo(newSeason);
                    //弹出对话框，提示是否继续添加
                    if (MessageBox.Show("添加赛季信息成功，！", "添加新赛季成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        //清空其他
                        comboBox_matchName.Text = "";
                        textBox_numOfSeason.Text="";
                        textBox_seasonDescInfo.Text = "";
                    }
                    else
                    {
                        this.Close();
                    }




                }

              }
            else { MessageBox.Show("没有填写当前赛季届数"); }

            }
            else { MessageBox.Show("没有选择相应赛事！","赛事不为空",MessageBoxButtons.OKCancel,MessageBoxIcon.Information); }


        }

        #region
        //窗体加载
        private void createNewSeason_Load(object sender, EventArgs e)
        {
            this.loadBaseInfo();
        }
        #endregion

        //加载下拉列表信息
        private void loadBaseInfo() {

            SeasonMatch match;
            //取出所有的赛事信息
            List<SeasonMatch> list=MatchInfoDAO.getMatchInfo();
            //清空下拉列表的数据信息
            comboBox_matchName.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {//取出赛事信息
                match = list[i];
                //添加到下拉列表
                comboBox_matchName.Items.Add(match.getName());
            }




        } 



    }
}
