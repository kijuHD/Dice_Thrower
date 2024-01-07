using DiceThrower.Dice;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace DiceThrower.UI
{
    public class CreateDiceSetMenu : Menu
    {
        [SerializeField]
        private Button _CreateButton;
        [SerializeField]
        private Button _CancelButton;
        [SerializeField]
        private TMP_InputField _SetNameIF;
        [SerializeField]
        private TMP_InputField _D6NumberIF;
        [SerializeField]
        private TMP_InputField _D12NumberIF;

        [Inject]
        private DiceSetManager _diceSetManager;
        [Inject]
        private PopupWindowSystem _popupWindowSystem;
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
            string newName = _SetNameIF.text;
            int d6Number = int.Parse(_D6NumberIF.text);
            int d12Number = int.Parse(_D12NumberIF.text); 
            if (newName.Length == 0)
            {
                _popupWindowSystem.CreateInfoPopupWindow("Name cannot be empty");
                return;
            }
            if (_diceSetManager.NameDuplicate(newName))
            {
                _popupWindowSystem.CreateInfoPopupWindow("Set with that name already exists");
                return;
            }
            if(d6Number < 0 || d6Number>10 || d12Number<0 || d12Number > 10)
            {
                _popupWindowSystem.CreateInfoPopupWindow("Number of dices must be between 0 and 10");
                return;
            }
            

            _diceSetManager.CreateNewSet(newName,d6Number,d12Number);

            _menuSystem.Show(MenuType.DiceSets);
            
        }
        private void OnCancelButtonClicked() 
        {
            _menuSystem.Show(MenuType.DiceSets);
        }
    }
}
