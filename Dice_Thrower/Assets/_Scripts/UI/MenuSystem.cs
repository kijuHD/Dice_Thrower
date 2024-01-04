using System;
using System.Linq;
using System.Collections.Generic;
using Zenject;
using System.Diagnostics;

namespace DiceThrower.UI
{
    public class MenuSystem
    {
        /*
         * Add startup hide all and show Main Menu
         * 
         * 
         */


        private List<IMenu> _availableMenus = new List<IMenu>();

        private IMenu _currentMenu;

        public void Show(MenuType type)
        {
            var menu = _availableMenus.FirstOrDefault(m => m.GetMenuType() == type);
            if (menu != null)
            {
                throw new Exception($"There is no Menu with Type: {type}");
            }

            _currentMenu.Hide();
            _currentMenu = menu;
            _currentMenu.Show();
        }
        public void RegisterMenu(IMenu menu)
        {
            // add check if the same menu exists
            // check with main menu and if not hide it
            _availableMenus.Add(menu);
        }
    }
}