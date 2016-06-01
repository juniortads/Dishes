using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dishes.Infra.IoC;

namespace Dishes.Application.Test
{
    [TestClass]
    public class UnitTest
    {
        private IServiceAppMenu _serviceAppMenu;

        [TestInitialize]
        public void Initialize()
        {
            _serviceAppMenu = ContainerConfigurationDictionary.Resolve<IServiceAppMenu>();
            //_serviceAppMenu = ContainerConfigurationUnity.Resolve<IServiceAppMenu>();
        }

        [TestMethod]
        public void Menu_By_Morning_Dish_Type_1_2_3()
        {
            int[] dishTypes = new[] { 1, 2, 3 };
            var menus = _serviceAppMenu.SearchMenuTimeOfDayByMorning(dishTypes);
            Assert.AreEqual(dishTypes.Length, menus.Count);
        }

        [TestMethod]
        public void Menu_By_Morning_Dish_Type_2_1_3()
        {
            int[] dishTypes = new[] { 2, 1, 3 };
            var menus = _serviceAppMenu.SearchMenuTimeOfDayByMorning(dishTypes);
            Assert.AreEqual(dishTypes.Length, menus.Count);
        }
    }
}
