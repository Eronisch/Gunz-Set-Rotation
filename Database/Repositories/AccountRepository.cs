using System.Collections.Generic;
using System.Linq;

namespace Database.Repositories
{
    public class AccountRepository
    {
        private readonly GunzDBEntities _dataModel;

        public AccountRepository()
        {
            _dataModel = new GunzDBEntities();
        }

        public IEnumerable<int> GetAllAccountIds()
        {
            return _dataModel.Accounts.Select(a => a.AID);
        }
    }
}
