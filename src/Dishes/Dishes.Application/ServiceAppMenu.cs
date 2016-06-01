using Dishes.Domain;
using Dishes.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes.Application
{
    public class ServiceAppMenu : IServiceAppMenu
    {
        private IServiceMenu _serviceMenu;

        public ServiceAppMenu(IServiceMenu serviceMenu)
        {
            _serviceMenu = serviceMenu;
        }

        public List<MenuFood> SearchMenuTimeOfDayByMorning(int[] dishType)
        {
            return _serviceMenu.FilterMenuTimeOfDayByMorning(dishType);
        }

        public List<MenuFood> SearchMenuTimeOfDayByNight(int[] dishType)
        {
            return _serviceMenu.FilterMenuTimeOfDayByNight(dishType);
        }
    }
}
