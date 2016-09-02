using System;
using Database.Repositories;

namespace GunzFactor_Set_Rotation.Managers
{
    public class AccountItemManager
    {

        public void Add(int accountId, int itemId, DateTime startDate, int amountHours)
        {
            var accountItemRepository = new AccountItemRepository();
            accountItemRepository.Add(accountId, itemId, startDate, amountHours);
        }
    }
}
