using FootballMatch.Umasou.DBA;
using FootballMatch.Umasou.Model;
using FootballMatch.Umasou.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballMatch.Umasou.Business
{
    public partial class PlayerExcelImport : Form
    {
        public PlayerExcelImport()
        {
            InitializeComponent();
        }

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

        private void button_savePlayerInfo_Click(object sender, EventArgs e)
        {
            DialogResult RSS = MessageBox.Show(this, "确定要保存表单球员信息吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (RSS)
            {
                case DialogResult.Yes:
                    {
                        int rowNum = this.dataGridView_ExcelImport.Rows.Count - 1;  //得到总列数，其中要除去新行
                        int cellNum = this.dataGridView_ExcelImport.Columns.Count;//得到总列数
                        int flag = 0;//验证表格是否有空值
                        List<FootballPlayer> playerlList = new List<FootballPlayer>();
                        for (int i = 0; i < rowNum; i++)
                        {

                            for (int j = 0; j < cellNum; j++)
                            {

                                if (this.dataGridView_ExcelImport.Rows[i].Cells[j].Value == null)
                                    flag = 1;
                            }
                        }
                        if (flag == 1)
                            MessageBox.Show("当前表格有未填写的空格，请确认！");
                        else
                        {


                            for (int k = 0; k < rowNum; k++)
                            {

                                FootballPlayer player = new FootballPlayer();  //实例化一条赛程记录，存放到list中
                              
                                for (int l = 0; l < cellNum; l++)
                                {
                                    switch (l)
                                    {
                                        case 0:
                                            player.setPlayerName(this.dataGridView_ExcelImport.Rows[k].Cells[l].Value.ToString());
                                            break;
                                        case 1:
                                            player.setPlayNumber(Convert.ToInt32(this.dataGridView_ExcelImport.Rows[k].Cells[l].Value.ToString()));
                                            break;
                                        case 2:
                                            player.setPostion(this.dataGridView_ExcelImport.Rows[k].Cells[l].Value.ToString());
                                            break;
                                        case 3:
                                            player.setBelongTeam(this.dataGridView_ExcelImport.Rows[k].Cells[l].Value.ToString());
                                            break;
                                        case 4:
                                            player.setIDnum(this.dataGridView_ExcelImport.Rows[k].Cells[l].Value.ToString());
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                playerlList.Add(player);
                            }
                            PlayerInfoDAO.addPlayerList(playerlList);
                            MessageBox.Show("插入数据成功！");
                            SystemParam.getPlayerManageForm().loadDataOfDatagridView();
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
    }
}
