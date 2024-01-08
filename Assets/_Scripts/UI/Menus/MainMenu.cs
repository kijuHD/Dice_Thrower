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
        private Button _StartButton;
        [SerializeField]
        private Button _QuickStartButton;
        [SerializeField]
        private Button _DiceSetsButton;

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
            _StartButton.onClick.AddListener(OnStartButtonClicked);
            _QuickStartButton.onClick.AddListener(OnQuickStartButtonClicked);
            _DiceSetsButton.onClick.AddListener(OnDiceSetsButtonClicked);

        }
        protected override void RemoveListeners()
        {
            _StartButton.onClick.RemoveAllListeners();
            _QuickStartButton.onClick.RemoveAllListeners();
            _DiceSetsButton.onClick.RemoveAllListeners();
        }
        private void OnStartButtonClicked()
        {
        }
        private void OnQuickStartButtonClicked()
        {
            _menuSystem.HideOverlay();
            _setManager.SelectQuickStartSet();
            _spawnerManager.SpawnDices();
        }
        private void OnDiceSetsButtonClicked()
        {
            _menuSystem.Show(MenuType.DiceSets);
        }        
    }
}
