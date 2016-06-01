using Dishes.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dishes.Domain;

namespace Dishes.Infra.Data.Repository
{
    public class RepositoryMenu : IRepositoryMenu
    {
        private List<MenuFood> _menuFoods;

        public List<MenuFood> GetAllByMorning()
        {
            return LoadMenuFoods.Select(o => o)
                           .Where(o => o.TimeOfDay.Equals(TimeOfDay.Morning))
                           .ToList();
        }

        public List<MenuFood> GetAllByNight()
        {
            return LoadMenuFoods.Select(o => o)
                          .Where(o => o.TimeOfDay.Equals(TimeOfDay.Night))
                          .ToList();
        }

        private static List<MenuFood> LoadMenuFoods
        {
            get
            {
                return new List<MenuFood>
                {
                    new MenuFood() { DishType = DishType.Entrée, TimeOfDay = TimeOfDay.Morning, Food = "Eggs", QuantityDemanded = 0 },
                    new MenuFood() { DishType = DishType.Entrée, TimeOfDay = TimeOfDay.Night, Food = "Steak", QuantityDemanded = 0 },
                    new MenuFood() { DishType = DishType.Side, TimeOfDay = TimeOfDay.Morning, Food = "Toast", QuantityDemanded = 0 },
                    new MenuFood() { DishType = DishType.Side, TimeOfDay = TimeOfDay.Night, Food = "Potato", QuantityDemanded = 0 },
                    new MenuFood() { DishType = DishType.Drink, TimeOfDay = TimeOfDay.Morning, Food = "Coffee", QuantityDemanded = 0 },
                    new MenuFood() { DishType = DishType.Drink, TimeOfDay = TimeOfDay.Night, Food = "Wine", QuantityDemanded = 0 },
                    new MenuFood() { DishType = DishType.Dessert, TimeOfDay = TimeOfDay.Night, Food = "Cake", QuantityDemanded = 0 },
                    new MenuFood() { DishType = DishType.Dessert, TimeOfDay = TimeOfDay.Morning, Food = "Not Applicable", QuantityDemanded = 0 }
                };
            }
        }
    }
}
