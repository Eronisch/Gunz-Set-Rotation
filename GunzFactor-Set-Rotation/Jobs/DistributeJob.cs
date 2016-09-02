using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using GunzFactor_Set_Rotation.Managers;
using Quartz;
using Timer = System.Timers.Timer;

namespace GunzFactor_Set_Rotation.Jobs
{
    public class DistributeJob : IJob
    {
        private readonly AccountItemManager _accountItemManager;
        private readonly AccountManager _accountManager;
        private readonly ItemRotationManager _itemRotationManager;
        private readonly Timer _progressTimer;

        private int _amountActions;
        private int _amountFinishedActions;
        private int _amountFailedActions;

        public DistributeJob()
        {
            _accountItemManager = new AccountItemManager();
            _accountManager = new AccountManager();
            _itemRotationManager = new ItemRotationManager();
            _progressTimer = new Timer { Interval = 500 };
        }

        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Rotation fired on: {0}", DateTime.Now);
            Distribute();
        }

        private void Distribute()
        {
            var currentDate = DateTime.Now;
            var currentDateFirst = new DateTime(currentDate.Year, currentDate.Month, 1, 0, 0, 0);
            var rotationItems = _itemRotationManager.GetAllByYearAndMonth(currentDate.Year, currentDate.Month).ToList();
            var accountIds = _accountManager.GetAllAccountIds().ToList();
            var dateNextMonth = DateTime.Now.AddMonths(1);
            var dateNextMonthFirst = new DateTime(dateNextMonth.Year, dateNextMonth.Month, 1, 0, 0, 0);
            var amountRentHours = GetAmountHoursFromMonths(currentDateFirst, dateNextMonthFirst);

            _amountActions = accountIds.Count * rotationItems.Count;

            StartProgressTimer();

            Parallel.ForEach(rotationItems, item =>
            {
                Parallel.ForEach(accountIds, accountId =>
                {
                    SendItem(accountId, item.ItemId, currentDateFirst, amountRentHours);
                });
            });
        }

        private void StartProgressTimer()
        {
            _progressTimer.Elapsed += Timer_Elapsed;
            _progressTimer.Start();
        }

        private void StopProgressTimer()
        {
            _progressTimer.Stop();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            int progress = GetProgress();
            Console.Title = $"Progress: {progress}%";

            if (progress == 100)
            {
                Console.WriteLine("Rotation completed on: {0}, successful: {1}, failed : {2}", DateTime.Now, _amountFinishedActions, _amountFailedActions);
                ConsoleLogManager.Reset();
                StopProgressTimer();
            }
        }

        private int GetAmountHoursFromMonths(DateTime currDate, DateTime nextMonth)
        {
            return (int)Math.Round((nextMonth - currDate).TotalHours);
        }

        private void SendItem(int accountId, int itemId, DateTime startTime, int amountRentHours)
        {
            try
            {
                _accountItemManager.Add(accountId, itemId, startTime, amountRentHours);
                _amountFinishedActions = Interlocked.Increment(ref _amountFinishedActions);
            }
            catch (Exception ex)
            {
                _amountFailedActions = Interlocked.Increment(ref _amountFailedActions);
                Console.WriteLine("Queued item crashed for account: {0}, reason: {1}.", accountId, ex.Message);
            }
        }

        private int GetProgress()
        {
            return (int)Math.Round((100m / _amountActions) * (_amountFinishedActions + _amountFailedActions));
        }
    }
}
