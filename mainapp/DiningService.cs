using System;
using Spring.Scheduling.Quartz;
using Quartz;

namespace mainapp
{
    class DiningService : QuartzJobObject
    {
        private string UserName { get; set; }
        protected override void ExecuteInternal(JobExecutionContext context)
        {
            string msg = string.Format("{0} : 回家吃饭时间，姓名 :{1},下次吃饭时间： {2}",
                DateTime.Now,UserName,context.NextFireTimeUtc.Value.ToLocalTime());
            Console.WriteLine(msg);
        }
    }
}
