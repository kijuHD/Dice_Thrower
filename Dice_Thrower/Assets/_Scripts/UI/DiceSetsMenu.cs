using UnityEngine;
using UnityEngine.UI;

namespace DiceThrower.UI
{
    public class DiceSetsMenu : Menu
    {
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
            throw new System.NotImplementedException();
        }

        [SerializeField]
        private Button _CreateButton;
        [SerializeField]
        private Button _EditButton;
        [SerializeField]
        private Button _BackButton;

        private void OnCreateButtonClicked()
        {

        }
        private void OnEditButtonClicked() 
        { 

        }
        private void OnBackButtonClicked()
        {
            _menuSystem.Show(MenuType.MainMenu);
        }
    }
}
