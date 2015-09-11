using FootballMatch.Umasou.DBA;
using FootballMatch.Umasou.Model;
using FootballMatch.Umasou.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballMatch.Umasou.Business
{
    public partial class ScheduleExcelImport : Form
    {
        public ScheduleExcelImport()
        {
            InitializeComponent();
        }

        private void button_deleteCurrentRow_Click(object sender, EventArgs e)
        {
            //移除表格中的对应的行
            if (this.dataGridView_ExcelImport.SelectedRows.Count != 0) ///如果选中的是行
            {
                if (!this.dataGridView_ExcelImport.SelectedRows[0].IsNewRow)
                    this.dataGridView_ExcelImport.Rows.RemoveAt(this.dataGridView_ExcelImport.SelectedRows[0].Index);
                else
                    MessageBox.Show("当前行不能删除", "删除提示");
            }

            else
            {           /// 如果选中的是单元格 
                if (!this.dataGridView_ExcelImport.CurrentRow.IsNewRow)
                    this.dataGridView_ExcelImport.Rows.RemoveAt(this.dataGridView_ExcelImport.CurrentCell.RowIndex);
                else
                    MessageBox.Show("当前行不能删除", "删除提示");
            }
        }

        private void button_deleteMultiRows_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in this.dataGridView_ExcelImport.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    this.dataGridView_ExcelImport.Rows.Remove(r);
                }
            }
        }

        private void button_saveSchedule_Click(object sender, EventArgs e)
        {
              DialogResult RSS = MessageBox.Show(this, "确定要保存表单赛程吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (RSS)
            {
                case DialogResult.Yes:
                    {
                        int rowNum = this.dataGridView_ExcelImport.Rows.Count - 1;  //得到总列数，其中要除去新行
                        int cellNum = this.dataGridView_ExcelImport.Columns.Count;//得到总列数
                        int flag = 0;//验证表格是否有空值
                        int isTheTeam = 0;//验证表格中特定的两列是否是存在的球队,默认0是
                        int isHomeEqualsGuest = 0;  //验证表格中是否存在主队和客队一样的球队，默认0不等
                        List<Schedule> scheduleList = new List<Schedule>();
                        for (int i = 0; i < rowNum; i++)
                        {

                            for (int j = 0; j < cellNum; j++)
                            {

                                if (this.dataGridView_ExcelImport.Rows[i].Cells[j].Value == null)
                                    flag = 1;

                                }
                                 if(this.dataGridView_ExcelImport.Rows[i].Cells[2].Value.ToString()==this.dataGridView_ExcelImport.Rows[i].Cells[3].Value.ToString()){
                                     isHomeEqualsGuest=1;
                                 }
                                 if (checkIsTheTeam(this.dataGridView_ExcelImport.Rows[i].Cells[2].Value.ToString())||checkIsTheTeam(this.dataGridView_ExcelImport.Rows[i].Cells[3].Value.ToString()))
                                 { isTheTeam = 1; }
                        }
                        if (flag == 1)
                            MessageBox.Show("当前表格有未填写的空格，请确认！");
                        else
                        {
                            if (isTheTeam == 1) { MessageBox.Show("表格中球队存在不是该赛事的球队，请确认！"); }

                            else
                            {
                                if (isHomeEqualsGuest == 1) { MessageBox.Show("表格中球队存在主客队为同一球队，请确认！"); }
                               
                                else
                                  {
                                for (int k = 0; k < rowNum; k++)
                                {

                                    Schedule s = new Schedule();  //实例化一条赛程记录，存放到list中
                                    s.setMatchId(8);
                                    s.setSeasonId(1);
                                    for (int l = 0; l < cellNum; l++)
                                    {
                                        switch (l)
                                        {
                                            case 0:
                                                s.setTurn(Convert.ToInt32(this.dataGridView_ExcelImport.Rows[k].Cells[l].Value.ToString()));
                                                break;
                                            case 1:
                                                s.setGameDate(this.dataGridView_ExcelImport.Rows[k].Cells[l].Value.ToString());
                                                break;
                                            case 2:
                                                s.setHomeTeam(this.dataGridView_ExcelImport.Rows[k].Cells[l].Value.ToString());
                                                break;
                                            case 3:
                                                s.setGuestTeam(this.dataGridView_ExcelImport.Rows[k].Cells[l].Value.ToString());
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    scheduleList.Add(s);
                                }

                                ScheduleDAO.addSchedule(scheduleList);
                                MessageBox.Show("插入数据成功！");
                                //清除已经提交的数据，如果设定的是数据源则源设置为空，不是用clear（）方法清除
                                if (this.dataGridView_ExcelImport.DataSource != null)
                                {
                                    this.dataGridView_ExcelImport.DataSource = null;
                                    this.textBox_fileName.Text = "";
                                }
                                else
                                {
                                    this.dataGridView_ExcelImport.Rows.Clear();
                                    this.textBox_fileName.Text = "";
                                }
                               
                            } //表格中球队存在主客队为同一球队
                            }//球队存在不是该赛事的球队
                        }//else表格不为空的
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        
            
        }


        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    //文件导入
        private void button_openFile_Click(object sender, EventArgs e)
        {
            //打开一个文件选择框
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Excel文件";
            ofd.FileName = "";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//为了获取特定的系统文件夹，可以使用System.Environment类的静态方法GetFolderPath()。该方法接受一个Environment.SpecialFolder枚举，其中可以定义要返回路径的哪个系统目录
            ofd.Filter = "Excel文件(*.xls,*xls)|*.xls;*.xlsx";
            ofd.AutoUpgradeEnabled = true;
            ofd.ValidateNames = true;     //文件有效性验证ValidateNames，验证用户输入是否是一个有效的Windows文件名
            ofd.CheckFileExists = true;  //验证路径有效性
            ofd.CheckPathExists = true; //验证文件有效性

            string strName = string.Empty;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strName = ofd.FileName;
                this.textBox_fileName.Text = ofd.FileName;
                Console.WriteLine(strName);
                MessageBox.Show(strName);
            }
            if (strName == "")
            {
                MessageBox.Show("没有选择Excel文件！无法进行数据导入");
                return;
            }
            //调用导入数据方法
            ExcelImport.excelToDataGridView(strName, this.dataGridView_ExcelImport);

        }

        public bool checkIsTheTeam(string teamName){   //检查导入表格中的数据，球队是否是该赛事球队，不是则返回true,是则返回false

            List<Team> list = new List<Team>();
            list = TeamInfoDAO.getTeamInfoOfCertainMatch(SystemParam.getMatch());
            foreach(Team t in list){
             if(t.getName()==teamName)
                 return false;
            }

             return true;
        }
        //此方法存在问题
        public bool checkOnlyInOneTurn() {
                                           //每一个轮次，每个球队只出现一次，锦标赛的主客场算作两个轮次,
            
            int count = 0;//统计同一轮次内的记录数
            List<string> tList = new List<string>(); //将同一个轮次内的球队排他性存入list中，如果最后list中元素个数不等于2倍(同一轮最后一个row+1)则该轮中存在同一球队出现两次
            int row = this.dataGridView_ExcelImport.Rows.Count;
            for (int i = 0; i < row - 1; i++) //统计所有同一轮次的球队名称到tlist
             {
                 if (Convert.ToInt32(this.dataGridView_ExcelImport.Rows[i].Cells[0].Value) == Convert.ToInt32(this.dataGridView_ExcelImport.Rows[i+1].Cells[0].Value)) //顺序分割每个轮次，如果轮次不一样则执行else
                 { 
                    if(i<row-2){                 
                     Console.WriteLine(i);
                     count++;
                     if (!tList.Contains(this.dataGridView_ExcelImport.Rows[i].Cells[2].Value.ToString()))
                         tList.Add(this.dataGridView_ExcelImport.Rows[i].Cells[2].Value.ToString());
                     if (!tList.Contains(this.dataGridView_ExcelImport.Rows[i].Cells[3].Value.ToString()))
                     { tList.Add(this.dataGridView_ExcelImport.Rows[i].Cells[3].Value.ToString()); }
                     Console.WriteLine(count);
                     Console.WriteLine(tList.Count);}

                     else{
                         Console.WriteLine(i);
                         count++;
                         if (!tList.Contains(this.dataGridView_ExcelImport.Rows[i].Cells[2].Value.ToString()))
                             tList.Add(this.dataGridView_ExcelImport.Rows[i].Cells[2].Value.ToString());
                         if (!tList.Contains(this.dataGridView_ExcelImport.Rows[i].Cells[3].Value.ToString()))
                         { tList.Add(this.dataGridView_ExcelImport.Rows[i].Cells[3].Value.ToString()); }
                         Console.WriteLine(count);
                         Console.WriteLine(tList.Count);
                         if (!tList.Contains(this.dataGridView_ExcelImport.Rows[i+1].Cells[2].Value.ToString()))
                             tList.Add(this.dataGridView_ExcelImport.Rows[i+1].Cells[2].Value.ToString());
                         if (!tList.Contains(this.dataGridView_ExcelImport.Rows[i+1].Cells[3].Value.ToString()))
                         { tList.Add(this.dataGridView_ExcelImport.Rows[i+1].Cells[3].Value.ToString()); }
                         Console.WriteLine(tList.Count);
                         if (count != 0)
                         {
                             if (2 * (count+1) != tList.Count)
                             {
                                 Console.WriteLine(count);
                                 Console.WriteLine(tList.Count);
                                 MessageBox.Show("表格赛事中第" + Convert.ToInt32(this.dataGridView_ExcelImport.Rows[i].Cells[0].Value) + "轮存在不唯一的球队");
                                 return false;
                             }

                              
                         }



                     }
                 }
                 else
                 {
                     if (count != 0)
                     {
                         if (2 * count != tList.Count)
                         {
                             MessageBox.Show("表格赛事中第"+Convert.ToInt32(this.dataGridView_ExcelImport.Rows[i].Cells[0].Value)+"轮存在不唯一的球队");
                             return false;
                         }
                        
                         count = 0; tList.Clear(); 
                     }
                 
                 }
             }//for
            return true; //所有记录检查通过
        } 
   
    }
}
