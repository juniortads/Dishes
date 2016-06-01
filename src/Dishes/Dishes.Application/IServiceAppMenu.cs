using Dishes.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes.Application
{
    public interface IServiceAppMenu
    {
        List<MenuFood> SearchMenuTimeOfDayByMorning(int[] dishType);
        List<MenuFood> SearchMenuTimeOfDayByNight(int[] dishType);
    }
}
