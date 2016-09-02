using System;
using System.Collections.Specialized;
using Quartz;
using Quartz.Impl;

namespace GunzFactor_Set_Rotation.Managers
{
    public class ScheduleService
    {
        public void Run<T>(string identity, string cronjob) where T : IJob
        {
            ISchedulerFactory schedFact = new StdSchedulerFactory();
            
            IScheduler scheduler = schedFact.GetScheduler();
            scheduler.Start();
            
            IJobDetail job = JobBuilder.Create<T>()
                .WithIdentity(identity, "IT")
                .RequestRecovery()
                .Build();
            
            var trigger = (ICronTrigger)TriggerBuilder.Create()
                .WithIdentity(identity, "IT")
                .WithSchedule(CronScheduleBuilder
                .CronSchedule(cronjob)
                .InTimeZone(TimeZoneInfo.Local))
                .StartAt(DateTime.UtcNow)
                .Build();

            scheduler.ScheduleJob(job, trigger);

            Console.WriteLine("Rotation has been scheduled...");
        }
    }
}
