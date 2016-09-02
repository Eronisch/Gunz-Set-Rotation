using System.Collections.Generic;
using Database;
using Database.Repositories;

namespace GunzFactor_Set_Rotation.Managers
{
    public class ItemRotationManager
    {
        private readonly ItemRotationRepository _itemRotationRepository;

        public ItemRotationManager()
        {
            _itemRotationRepository = new ItemRotationRepository();
        }

        public IEnumerable<ItemRotation> GetAllByYearAndMonth(int year, int month)
        {
            return _itemRotationRepository.GetAllByYearAndMonth(year, month);
        }
    }
}
