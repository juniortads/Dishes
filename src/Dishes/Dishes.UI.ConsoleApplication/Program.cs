using Dishes.Application;
using Dishes.Domain;
using Dishes.Infra.IoC;
using Dishes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes.UI.ConsoleApplication
{
    class Program
    {
        //private static IServiceAppMenu _serviceAppMenu = ContainerConfigurationDictionary.Resolve<IServiceAppMenu>();
        private static IServiceAppMenu _serviceAppMenu = ContainerConfigurationUnity.Resolve<IServiceAppMenu>();

        static void Main(string[] args)
        {
            initApp:
            Console.WriteLine("Please inform morning or evening with at least one selection...");
            string[] choice = Console.ReadLine().Split(',');

            string menuTimeOfDay = choice[0];

            choice = choice.Where(w => w != choice[0]).ToArray();
            int[] dishTypes = Array.ConvertAll(choice, s => int.Parse(s));

            switch (menuTimeOfDay.ToUpper())
            {
                case "MORNING":
                    var menusByMorning = _serviceAppMenu.SearchMenuTimeOfDayByMorning(dishTypes);
                    Console.WriteLine("Output: {0}", menusByMorning.ConvertToString(o => o.Food));
                    break;
                case "NIGHT":
                    var menusByNight = _serviceAppMenu.SearchMenuTimeOfDayByNight(dishTypes);
                    Console.WriteLine("Output: {0}", menusByNight.ConvertToString(o => o.Food));
                    break;
                default:
                    break;
            }
            Console.WriteLine(Environment.NewLine);
            goto initApp;
        }
    }
}
