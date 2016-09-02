using System;
using GunzFactor_Set_Rotation.Jobs;
using GunzFactor_Set_Rotation.Managers;

namespace GunzFactor_Set_Rotation
{
    class Program
    {
        static void Main()
        {
            ConsoleLogManager.Reset();
            
            var scheduleService = new ScheduleService();

            scheduleService.Run<DistributeJob>("Rotation Set", "0 0 0 1 1/1 ? *");
        }
    }
}
