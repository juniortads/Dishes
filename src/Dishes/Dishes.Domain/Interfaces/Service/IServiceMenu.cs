using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes.Domain.Interfaces.Service
{
    public interface IServiceMenu
    {
        List<MenuFood> FilterMenuTimeOfDayByMorning(int[] dishType);
        List<MenuFood> FilterMenuTimeOfDayByNight(int[] dishType);
    }
}
