using UnityEngine;
using UnityEngine.UI;

namespace DiceThrower.UI
{
    public class DiceSetsMenu : Menu
    {
        [SerializeField]
        private Button _createButton;
        [SerializeField]
        private Button _editButton;

        public override MenuType GetMenuType()
        {
            return MenuType.DiceSets;
        }
        protected override void AddListeners()
        {
            base.AddListeners();
            _createButton.onClick.AddListener(OnCreateButtonClicked);
            _editButton.onClick.AddListener(OnEditButtonClicked);
        }
        protected override void RemoveListeners()
        {
            base.RemoveListeners();
            _createButton.onClick.RemoveAllListeners();
            _editButton.onClick.RemoveAllListeners();
        }

        private void OnCreateButtonClicked()
        {

        }
        private void OnEditButtonClicked()
        {

        }
    }
}
