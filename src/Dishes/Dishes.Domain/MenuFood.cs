using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes.Domain
{
    public class MenuFood
    {
        public DishType DishType { get; set; }
        public TimeOfDay TimeOfDay { get; set; }
        public string Food { get; set; }
    }
}
