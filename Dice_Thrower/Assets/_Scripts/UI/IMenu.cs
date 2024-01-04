using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DiceThrower.UI
{
    public interface IMenu
    {
        public void Show();
        public void Hide();
        public MenuType GetMenuType();
        public void Register();
    }
}
