using UnityEngine;
using Zenject;

namespace DiceThrower.UI
{
    public abstract class Menu : MonoBehaviour, IMenu
    {
        protected MenuSystem _menuSystem;

        [Inject]
        protected virtual void ResolveReferences(MenuSystem menuSystem)
        {
            _menuSystem = menuSystem;
            Register();
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }
        public void Hide()
        {
            gameObject.SetActive(false);
        }
        public abstract MenuType GetMenuType();
        public virtual void Register()
        {
            _menuSystem.RegisterMenu(this);
        }

    }
}
