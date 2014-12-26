using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace common.main.common_10
{
    class MyRegex
    {
        /// <summary>
        /// 正则匹配
        /// 
        /// 在指定的输入字符串中搜索正则表达式的所有匹配项。
        /// 
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="expre"></param>
        public void ShowMatch(string str1,string expre)
        {
            Console.WriteLine("输入的正则表达式是：\n{0}", expre);
            MatchCollection mc = Regex.Matches(str1, expre);
            foreach(Match ma in mc)
            {
                Console.WriteLine("匹配结果:{0}",ma);
            }
        }
        /// <summary>
        ///  正则替换
        ///  
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <returns></returns>
        public string ReplaceMatch(string input,string pattern,string replacement)
        {
            string result;
            Regex regex = new Regex(pattern);
            result = regex.Replace(input, replacement);
            return result;
        }
    }
}
