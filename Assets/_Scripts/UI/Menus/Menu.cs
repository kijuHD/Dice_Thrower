using Zenject;
using UnityEngine;
using System.Collections.Generic;

namespace DiceThrower.UI
{
    public abstract class Menu : MonoBehaviour, IMenu
    {
        protected MenuSystem _menuSystem;

        [SerializeField]
        private List<MenuButton> _menuButtons = new List<MenuButton>();

        [Inject]
        protected virtual void ResolveReferences(MenuSystem menuSystem)
        {
            _menuSystem = menuSystem;
            Register();
        }

        protected void Start()
        {
            AddListeners();
        }
        protected void OnDestroy()
        {
            RemoveListeners();
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
            Debug.Log($"Register invoked with menu {GetMenuType()}");
            _menuSystem.RegisterMenu(this);

        }
        protected virtual void AddListeners()
        {
            foreach (MenuButton button in _menuButtons)
            {
                button.Button.onClick.AddListener(() => _menuSystem.Show(button.MenuType));
            }
        }
        protected virtual void RemoveListeners()
        {
            foreach (MenuButton button in _menuButtons)
            {
                button.Button.onClick.RemoveAllListeners();
            }
        }

    }
}
