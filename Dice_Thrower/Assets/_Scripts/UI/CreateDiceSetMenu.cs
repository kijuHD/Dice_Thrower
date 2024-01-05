using UnityEngine;
using UnityEngine.UI;

namespace DiceThrower.UI
{
    public class CreateDiceSetMenu : Menu
    {
        [SerializeField]
        private Button _CreateButton;
        private Button _CancelButton;

        public override MenuType GetMenuType()
        {
            return MenuType.CreateDiceSet;
        }

        protected override void AddListeners()
        {
            _CreateButton.onClick.AddListener(OnCreateButtonClicked);
            _CancelButton.onClick.AddListener(OnCancelButtonClicked);
        }

        protected override void RemoveListeners()
        {
            _CreateButton.onClick.RemoveAllListeners();
            _CancelButton.onClick.RemoveAllListeners();
        }

        private void OnCreateButtonClicked()
        {

        }
        private void OnCancelButtonClicked() 
        {

        }
    }
}
