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
        public List<MenuFood> GetAllByMorning()
        {
            return menuFoods.Value.Select(o => o)
                           .Where(o => o.TimeOfDay.Equals(TimeOfDay.Morning))
                           .ToList();

        }

        public List<MenuFood> GetAllByNight()
        {
            return menuFoods.Value.Select(o => o)
                          .Where(o => o.TimeOfDay.Equals(TimeOfDay.Night))
                          .ToList();
        }

        private static readonly Lazy<List<MenuFood>> menuFoods = new Lazy<List<MenuFood>>(
           () =>
           {
               return new List<MenuFood>
               {
                    new MenuFood() {DishType = DishType.Entrée, TimeOfDay = TimeOfDay.Morning, Food = "Eggs"},
                    new MenuFood() {DishType = DishType.Entrée, TimeOfDay = TimeOfDay.Night, Food = "Steak"},

                    new MenuFood() {DishType = DishType.Side, TimeOfDay = TimeOfDay.Morning, Food = "Toast"},
                    new MenuFood() {DishType = DishType.Side, TimeOfDay = TimeOfDay.Night, Food = "Potato"},

                    new MenuFood() {DishType = DishType.Drink, TimeOfDay = TimeOfDay.Morning, Food = "Coffee"},
                    new MenuFood() {DishType = DishType.Drink, TimeOfDay = TimeOfDay.Night, Food = "Wine"},

                    new MenuFood() {DishType = DishType.Dessert, TimeOfDay = TimeOfDay.Night, Food = "Cake"},
                    new MenuFood() {DishType = DishType.Dessert, TimeOfDay = TimeOfDay.Morning, Food = "Not Applicable"}
               };
           });
    }
}
