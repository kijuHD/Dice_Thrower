using System;
using System.Linq;
using System.Collections.Generic;
using Zenject;
using System.Diagnostics;

namespace DiceThrower.UI
{
    public class MenuSystem
    {
        private List<IMenu> _availableMenus = new List<IMenu>();

        private IMenu _currentMenu;

        public void Show(MenuType type)
        {
            var menu = _availableMenus.FirstOrDefault(m => m.GetMenuType() == type);
            if (menu == null)
            {
                throw new Exception($"There is no Menu with Type: {type}");
            }

            _currentMenu.Hide();
            _currentMenu = menu;
            _currentMenu.Show();
        }
        public void RegisterMenu(IMenu menu)
        {
            if(_availableMenus.Any(n => n.GetMenuType() == menu.GetMenuType()))
            {
                throw new Exception($"There is already Menu with Type: {menu.GetMenuType()}");
            }

            if (menu.GetMenuType() != MenuType.MainMenu)
                menu.Hide();
            else
                _currentMenu = menu;

            _availableMenus.Add(menu);
        }
    }
}