using FootballMatch.Umasou.DBA;
using FootballMatch.Umasou.Model;
using FootballMatch.Umasou.Util;
using MySql.Data.MySqlClient;
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

using Microsoft.Office.Interop;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel; 

namespace FootballMatch.Umasou.Business
{
    public partial class ScheduleAdd : Form
    {
        private bool _CheckChange;
 


        public ScheduleAdd(MainForm mainform)
        {
            InitializeComponent();
           // this.MdiParent = mainform;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                                               e.RowBounds.Location.Y,
                                               this.dataGridView1.RowHeadersWidth - 4,
                                               e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                                    this.dataGridView1.RowHeadersDefaultCellStyle.Font,
                                    rectangle,
                                    this.dataGridView1.RowHeadersDefaultCellStyle.ForeColor,
                                    TextFormatFlags.VerticalCenter | TextFormatFlags.Right);  
        }


     

        private void ScheduleManage_Load(object sender, EventArgs e)
        {    
            
           // this.label_matchName.Text = DefaultSet.getDefaultMatch();
            this.label_matchName.Text = SystemParam.getMatch().getName();
            this.label_seasonNum.Text =  Convert.ToString(SystemParam.getCurrentSelectedSeason().getNumOfSeason());
            this.dateTimePicker_gameDate.Height = this.dataGridView1.Height;

        }


        #region[设置列]
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //设置日期列
            if (this.dataGridView1.Columns[e.ColumnIndex].Name== "gameDate")
            {
            Rectangle r = this.dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                 r = this.dataGridView1.RectangleToScreen(r);
               this.dateTimePicker_gameDate.Location = this.RectangleToClient(r).Location;
               //this.dateTimePicker_gameDate.Left = r.X ;
               this.dateTimePicker_gameDate.Top = this.RectangleToClient(r).Y-3*r.Height-6;
                this.dateTimePicker_gameDate.Size = r.Size;
                this._CheckChange = true; 
                this.dateTimePicker_gameDate.Text = "";  //此处为赋值之后，从新让dataTimePicker恢复空值，避免下一个单元格选择时值没变
                this._CheckChange = false;
                this.dateTimePicker_gameDate.Visible = true;  }

            else   {  
                      
                      this.dateTimePicker_gameDate.Visible = false;
                       }

            
            //设置datagridView的homeTeam下拉框
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "homeTeam") {
                this.InitHomeTeamColumnsSet("homeTeam");
            }
            //设置datagridView的guestTeam下拉框
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "guestTeam")
            {
                this.InitHomeTeamColumnsSet("guestTeam");
            }


        }

        private void dateTimePicker_gameDate_ValueChanged(object sender, EventArgs e)
        {
                if (_CheckChange) return;
              this.dataGridView1.CurrentCell.Value = this.dateTimePicker_gameDate.Text;
              
        }

        #endregion

        #region[datagridView 主队/客队下拉列设置]
        //自定义下拉列表的列表项
        public void InitHomeTeamColumnsSet(string team) {
            
            DataTable teamTable = new DataTable();
            DBUtility dbutility = new DBUtility();
            string SQL = "select teamName from team where matchName='"+SystemParam.getMatch().getName()+"' order by ID";
            try
            {
                dbutility.openConnection();
                MySqlDataReader rd = dbutility.ExecuteQuery(SQL);
                 teamTable.Load(rd);
            }
            catch (MySqlException ex)
            {
              Console.WriteLine(ex.ToString());
            }
            finally
            {
                dbutility.Close();
            }
            

            ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[team]).DataSource =teamTable;
            ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[team]).DataPropertyName = "teamName";
            ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[team]).DisplayMember = "teamName";
             
        }
        #endregion
        
        //删除当前单元格所在的行或者
        private void button_deleteCurrentRow_Click(object sender, EventArgs e)
        {
            //移除表格中的对应的行
            if(this.dataGridView1.SelectedRows.Count!=0 ) ///如果选中的是行
            {
            if (!this.dataGridView1.SelectedRows[0].IsNewRow)
                this.dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            else
                MessageBox.Show("当前行不能删除", "删除提示");}

            else  {           /// 如果选中的是单元格 
                if (!this.dataGridView1.CurrentRow.IsNewRow)
                this.dataGridView1.Rows.RemoveAt(this.dataGridView1.CurrentCell.RowIndex);
                else
                    MessageBox.Show("当前行不能删除", "删除提示");
            }
        }

     
        // 删除当前表格中选中的行
        private void button_deleteMultiRows_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in this.dataGridView1.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    this.dataGridView1.Rows.Remove(r);
                }
            }

        }


        //保存提交的数据到数据库并清空该表
        private void button_saveSchedule_Click(object sender, EventArgs e)
        {
            DialogResult RSS = MessageBox.Show(this, "确定要保存表单赛程吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (RSS)
            {
                case DialogResult.Yes:
                    {
                        int rowNum = this.dataGridView1.Rows.Count-1;  //得到总列数，其中要除去新行
                        int cellNum = this.dataGridView1.Columns.Count;//得到总列数
                        int flag = 0;//验证表格是否有空值
                        List<Schedule> scheduleList = new List<Schedule>(); 
                        for (int i = 0; i < rowNum; i++)
                        {
                            
                            for (int j = 0; j < cellNum; j++) {

                                if (this.dataGridView1.Rows[i].Cells[j].Value==null)
                                    flag = 1;
                            }
                         }
                        if (flag == 1)
                            MessageBox.Show("当前表格有未填写的空格，请确认！");
                        else {
                           

                           for(int k=0;k<rowNum;k++ ){

                               Schedule s = new Schedule();  //实例化一条赛程记录，存放到list中
                               s.setMatchId(SystemParam.getMatch().getID());
                               s.setSeasonId(SystemParam.getCurrentSelectedSeason().getId());
                               for (int l = 0; l < cellNum;l++ ) {
                                   switch (l)
                                   {
                                       case 0:
                                           s.setTurn(Convert.ToInt32(this.dataGridView1.Rows[k].Cells[l].Value.ToString()));  
                                           break;
                                       case 1:
                                           s.setGameDate(this.dataGridView1.Rows[k].Cells[l].Value.ToString());     
                                           break;
                                       case 2:
                                         s.setHomeTeam(this.dataGridView1.Rows[k].Cells[l].Value.ToString()) ;
                                          break;                                     
                                       case 3:
                                            s.setGuestTeam(this.dataGridView1.Rows[k].Cells[l].Value.ToString());                           
                                           break;  
                                       default:
                                           break;
                                   } 
                               }
                             scheduleList.Add(s);
                           }
                            ScheduleDAO.addSchedule(scheduleList);
                           MessageBox.Show("插入数据成功！");
                            //清楚已经提交的数据
                           this.dataGridView1.Rows.Clear(); 

                        }//else表格不为空的
                    }
                    break;
                case DialogResult.No:
                    break;
            }

        }
        // 批量导入excel数据到datagridview1中   
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ScheduleExcelImport importForm = new ScheduleExcelImport();
             importForm.Show();

   }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ScheduleManage schedule = new ScheduleManage(SystemParam.getMainForm());
            schedule.Show();
        }

     
    }

}
