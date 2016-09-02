using System;
using System.Threading.Tasks;

namespace Database.Repositories
{
    public class AccountItemRepository
    {
        private readonly GunzDBEntities _dataModel;

        public AccountItemRepository()
        {
            _dataModel = new GunzDBEntities();
        }

        public void Add(int accountId, int itemId, DateTime startRendDate, int amountRentDaysHours)
        {
            _dataModel.AccountItems.Add(new AccountItem
            {
                AID = accountId,
                ItemID = itemId,
                RentDate = startRendDate,
                RentHourPeriod = (short?) amountRentDaysHours,
                Cnt = 1
            });

            _dataModel.SaveChanges();
        }
    }
}
