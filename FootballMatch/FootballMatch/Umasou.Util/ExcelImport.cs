using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballMatch.Umasou.Util
{
    class ExcelImport
    {
        /// Excel数据导入方法
        public static void excelToDataGridView(string filePath, DataGridView dgv)
        {
              
            //根据路径打开一个Excel文件并将数据填充到DataSet中

            /*****
            //2003（Microsoft.Jet.Oledb.4.0）
            string strConn = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'", excelFilePath);
            //2010（Microsoft.ACE.OLEDB.12.0）
            string strConn = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'", excelFilePath);
            
            *******/
            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + filePath + ";Extended Properties ='Excel 8.0;HDR=Yes;IMEX=1'";//HDR=YES 有两个值:YES/NO,表示第一行是否字段名,默认是YES,第一行是字段名
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string strExcel = "";
            OleDbDataAdapter myCommand = null;  //建立数据适配器
            DataSet ds = null;
            strExcel = "select  * from [sheet1$]";  //表名的写法也应注意不同，对应的excel表为sheet1，在这里要在其后加美元符号$，并用中括号
            myCommand = new OleDbDataAdapter(strExcel, strConn);
            ds = new DataSet();
            myCommand.Fill(ds, "table1");  ////把数据适配器中的数据读到数据集中的一个表中（此处表名为table1，可以任取表名）

            /***********
            //根据DataGridView的列构造一个新的DataTable
            DataTable tb = new DataTable();
            foreach (DataGridViewColumn dgvc in dgv.Columns)
            {
                if (dgvc.Visible && dgvc.CellType != typeof(DataGridViewCheckBoxCell))
                {
                    DataColumn dc = new DataColumn();
                    dc.ColumnName = dgvc.DataPropertyName;
                    //dc.DataType = dgvc.ValueType;//若需要限制导入时的数据类型则取消注释，前提是DataGridView必须先绑定一个数据源那怕是空的DataTable
                    tb.Columns.Add(dc);
                }
            }
            //根据Excel的行逐一对上面构造的DataTable的列进行赋值
            foreach (DataRow excelRow in ds.Tables[0].Rows)
            {
                int i = 0;
                DataRow dr = tb.NewRow();
                foreach (DataColumn dc in tb.Columns)
                {
                    dr[dc] = excelRow[i];
                    i++;
                }
                tb.Rows.Add(dr);
            }
             * ********/
            //在DataGridView中显示导入的数据
            dgv.DataSource = ds.Tables[0];


        }





    }
}
