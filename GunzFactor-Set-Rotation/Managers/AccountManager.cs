using System.Collections.Generic;
using Database;
using Database.Repositories;

namespace GunzFactor_Set_Rotation.Managers
{
    public class AccountManager
    {
        private readonly AccountRepository _accountRepository;

        public AccountManager()
        {
            _accountRepository = new AccountRepository();
        }

        public IEnumerable<int> GetAllAccountIds()
        {
            return _accountRepository.GetAllAccountIds();
        }
    }
}
