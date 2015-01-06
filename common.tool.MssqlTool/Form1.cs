using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace common.tool.MssqlTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetConnection();
        }

        public bool GetConnection()
        {
            bool flag = false;
            //SELECT COLUMN_NAME,DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'AdminInfo';
            string _sql = "SELECT COLUMN_NAME,DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'AdminInfo'";
            ConnDB conn = new ConnDB();
            DataSet ds = conn.ReturnDataSet(_sql);
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    richTextBox1.AppendText("columns: " + dr[0].ToString() + "          type: " + dr[1].ToString() +"\n");
                }
            }

            ds.Tables[0].Columns[0].ToString();
            return flag;
        }
    }
}
