using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes.Domain.Interfaces.Repository
{
    public interface IRepositoryMenu
    {
        List<MenuFood> GetAllByMorning();

        List<MenuFood> GetAllByNight();
    }
}
