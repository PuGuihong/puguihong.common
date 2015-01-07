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
                    StringPlus(dr[0].ToString(), dr[1].ToString());
                    richTextBox1.AppendText("columns: " + dr[0].ToString() + "          type: " + dr[1].ToString() +"\n");
                }
            }

            ds.Tables[0].Columns[0].ToString();
            return flag;
        }

        public void StringPlus(string _col_name,string _type)
        {
            if (_type == "bigint" || _type == "int" || _type == "money")
            {
                _type = "int";
            }
            else if (_type == "")
            {
                _type = "string";
            }
            else
            {
                _type = "string";
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("[Description('')] \n");
            sb.Append("[DataCloumn('" + _col_name + "')] \n");
            sb.Append("[LogProp(LogPropType.Must) \n]");
            sb.Append("public "+_type+" "+_col_name + "{ get; set; }");

            FileHelper _file = new FileHelper(sb.ToString());
        }
    }
}
