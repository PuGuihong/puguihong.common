using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace common.tool.MssqlTool
{
    public class FileHelper
    {
        private string _file = "Entitys.txt";
        private string _data;
        public FileHelper(string _d)
        {
            _data = _d;
            WriteFile();
        }
        public bool WriteFile()
        {
            bool _result = false;
            
            try
            {
                StreamWriter sw = new StreamWriter(_file);
                sw.WriteLine(_data);
                _result = true;
                sw.Close();
                return _result;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        } 

    }
}
