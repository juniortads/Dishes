using Dishes.Domain.Interfaces.Repository;
using Dishes.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes.Domain.Services
{
    public class ServiceMenu : IServiceMenu
    {
        private IRepositoryMenu _repositoryMenu;

        public ServiceMenu(IRepositoryMenu repositoryMenu)
        {
            _repositoryMenu = repositoryMenu;
        }
        public List<MenuFood> FilterMenuTimeOfDayByMorning(int[] dishType)
        {
            return FilterDishType(_repositoryMenu.GetAllByMorning(), dishType, DishType.Drink);
        }
        public List<MenuFood> FilterMenuTimeOfDayByNight(int[] dishType)
        {
            return FilterDishType(_repositoryMenu.GetAllByNight(), dishType, DishType.Side);
        }
        private List<MenuFood> FilterDishType(List<MenuFood> lstFilter, int[] dishTypes, DishType type)
        {
            var newFoods = new List<MenuFood>();
            foreach (var item in dishTypes)
            {
                if (item != (int)type)
                {
                    if (newFoods.Where(w => (int)w.DishType == item).Count() > 0)
                        continue;
                }
                var food = lstFilter.Select(o => o)
                                    .Where(i => (int)i.DishType == item)
                                    .ToList();
                newFoods.AddRange(food);
            }
            return newFoods;
        }
    }
}
