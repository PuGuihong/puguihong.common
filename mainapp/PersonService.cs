using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainapp
{
    public class PersonService
    {
        public string UserName { get; set; }

        public void GoToBed()
        {
            Console.WriteLine("姓名 {0} 睡觉的时间是: {1}", UserName, DateTime.Now);
        }
    }
}
