using System;
using System.Linq;
using System.Collections.Generic;

namespace DiceThrower.UI
{
    public class MenuSystem
    {
        private List<IMenu> _availableMenus = new List<IMenu>();

        private IMenu _currentMenu;

        private Overlay _uiOverlay;

        public void Show(MenuType type)
        {
            var menu = _availableMenus.FirstOrDefault(m => m.GetMenuType() == type);
            if (menu == null)
            {
                throw new Exception($"[UI] There is no Menu with Type: {type}");
            }

            _currentMenu.Hide();
            _currentMenu = menu;
            _currentMenu.Show();
        }
        public void RegisterMenu(IMenu menu)
        {
            if(_availableMenus.Any(n => n.GetMenuType() == menu.GetMenuType()))
            {
                throw new Exception($"[UI] There is already Menu with Type: {menu.GetMenuType()}");
            }

            if (menu.GetMenuType() != MenuType.MainMenu)
                menu.Hide();
            else
                _currentMenu = menu;

            _availableMenus.Add(menu);
        }
        public void RegisterUIOverlay(Overlay uiOverlay)
        {
            _uiOverlay= uiOverlay;
        }
        public void HideOverlay()
        {
            if (_uiOverlay == null)
            {
                throw new Exception($"[UI] Missing UI Overlay reference");
            }
            _uiOverlay.gameObject.SetActive( false );
        }
        public void ShowOverLay()
        {
            if (_uiOverlay == null)
            {
                throw new Exception($"[UI] Missing UI Overlay reference");
            }
            _uiOverlay.gameObject.SetActive(true);

            if(_currentMenu.GetMenuType()!=MenuType.MainMenu)
                Show(MenuType.MainMenu);
        }
    }
}