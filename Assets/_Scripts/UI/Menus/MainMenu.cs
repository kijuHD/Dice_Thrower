using Zenject;
using UnityEngine;
using UnityEngine.UI;
using DiceThrower.Dice;

namespace DiceThrower.UI
{
    public class MainMenu : Menu
    {
        public override MenuType GetMenuType()
        {
            return MenuType.MainMenu;
        }

        [SerializeField]
        private Button _quickStartButton;


        [Inject]
        private DiceSpawnerManager _spawnerManager;
        [Inject]
        private DiceSetManager _setManager;


        protected override void ResolveReferences(MenuSystem menuSystem)
        {
            base.ResolveReferences(menuSystem);
        }

        protected override void AddListeners()
        {
            base.AddListeners();
            _quickStartButton.onClick.AddListener(OnQuickStartButtonClicked);

        }
        protected override void RemoveListeners()
        {
            base.RemoveListeners();
            _quickStartButton.onClick.RemoveAllListeners();
        }
        private void OnQuickStartButtonClicked()
        {
            _menuSystem.HideOverlay();
            _setManager.SelectQuickStartSet();
            _spawnerManager.SpawnDices();
        }
    }
}
