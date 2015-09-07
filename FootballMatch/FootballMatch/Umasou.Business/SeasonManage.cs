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

namespace FootballMatch.Umasou.Business
{
    public partial class SeasonManage : Form
    {
        public SeasonManage(MainForm mainForm)
        {
            InitializeComponent();
            this.MdiParent = mainForm;
        }

        #region[实例变量]
        private int rowIndex;  //记录表格的行号
        private SeasonOfMatch  season;//记录赛事的信息的变量
        #endregion


        private void SeasonManage_Shown(object sender, EventArgs e)
        {
            //显示数据
            this.showSeasonData();
            //设置窗体最大化
            this.WindowState = FormWindowState.Maximized;
        }

        

        private void SeasonManage_Resize(object sender, EventArgs e)
        {
            this.setLocation();
        }

        #region[控件设置]
        private void setLocation()
        {
            int preTop = ClientRectangle.Top;
            int preLeft = ClientRectangle.Left;
            int preWidth = ClientRectangle.Width;
            int preHeight = ClientRectangle.Height;
            int preBottom = ClientRectangle.Bottom;
            int preRight = ClientRectangle.Right;

            dataGridView_seasons.Top = preTop + 10;
            dataGridView_seasons.Left = preLeft + 10;
            dataGridView_seasons.Width = preWidth - 20;
            dataGridView_seasons.Height = preHeight - 30 - groupBox_SeasonManage.Height;

            groupBox_SeasonManage.Left = preRight - 10 - groupBox_SeasonManage.Width;
            groupBox_SeasonManage.Top = preBottom - 10 - groupBox_SeasonManage.Height;
        }
        #endregion

        #region[表格事件]
        //画表格行数
        

        private void dataGridView_seasons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    rowIndex = e.RowIndex;
                }
            }
            catch
            {
            }
        }
        //单击单元格事件
        
        #endregion

        #region[显示数据]
        //显示赛事的基本信息
        public void showSeasonData()
        {
            //先清除DataGridView中的数据
            if (dataGridView_seasons.Rows.Count > 0)
            {
                dataGridView_seasons.Rows.Clear();
            }
            //取出数据
            List<SeasonOfMatch> list = SeasonInfoDAO.AllSeasons();
            //往dataGridView中添加数据
            for (int i = 0; i < list.Count; i++)
            {
                season = list[i];  //取出线性表中的赛事的信息
                dataGridView_seasons.Rows.Add(season.getId().ToString(), season.getmatchName(), season.getSeasonDescription(), season.getNumOfSeason().ToString() );
            }
        }
        #endregion

        private void createNew_Click(object sender, EventArgs e)
        {
          CreateNewSeason form = new CreateNewSeason();
            form.ShowDialog();
        }

        private void cancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void alter_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_seasons_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView_seasons.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView_seasons.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView_seasons.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
      
        }

    }
}
