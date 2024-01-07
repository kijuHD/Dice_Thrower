using UnityEngine;
using UnityEngine.UI;

namespace DiceThrower.UI
{
    public class DiceSetsMenu : Menu
    {
        [SerializeField]
        private Button _CreateButton;
        [SerializeField]
        private Button _EditButton;
        [SerializeField]
        private Button _BackButton;

        public override MenuType GetMenuType()
        {
            return MenuType.DiceSets;
        }
        protected override void AddListeners()
        {
            _CreateButton.onClick.AddListener(OnCreateButtonClicked);
            _EditButton.onClick.AddListener(OnEditButtonClicked);
            _BackButton.onClick.AddListener(OnBackButtonClicked);
        }
        protected override void RemoveListeners()
        {
            _CreateButton.onClick.RemoveAllListeners();
            _EditButton.onClick.RemoveAllListeners();
            _BackButton.onClick.RemoveAllListeners();
        }

        private void OnCreateButtonClicked()
        {
            _menuSystem.Show(MenuType.CreateDiceSet);
        }
        private void OnEditButtonClicked() 
        {
            _menuSystem.Show(MenuType.EditDiceSet);
        }
        private void OnBackButtonClicked()
        {
            _menuSystem.Show(MenuType.MainMenu);
        }
    }
}
