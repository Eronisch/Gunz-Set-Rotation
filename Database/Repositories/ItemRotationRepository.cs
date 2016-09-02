using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories
{
    public class ItemRotationRepository
    {
        private readonly GunzDBEntities _dataModel;

        public ItemRotationRepository()
        {
            _dataModel = new GunzDBEntities();
        }

        public IEnumerable<ItemRotation> GetAllByYearAndMonth(int year, int month)
        {
            return _dataModel.ItemRotations.Where(i => i.Year == year && i.Month == month);
        }
    }
}
