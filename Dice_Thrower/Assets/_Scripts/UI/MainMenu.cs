using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DiceThrower.UI
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField]
        private Button _StartButton;
        [SerializeField]
        private Button _QuickStartButton;
        [SerializeField]
        private Button _DiceSetsButton;

        void Start()
        {
            AddListeners();
        }
        private void OnDestroy()
        {
            RemoveListeners();
        }

        private void OnStartButtonClicked()
        {

        }
        private void OnQuickStartButtonClicked()
        {

        }
        private void OnDiceSetsButtonClicked()
        {

        }

        private void AddListeners()
        {
            _StartButton.onClick.AddListener(OnStartButtonClicked);
            _QuickStartButton.onClick.AddListener(OnQuickStartButtonClicked);
            _DiceSetsButton.onClick.AddListener(OnDiceSetsButtonClicked);

        }
        private void RemoveListeners()
        {
            _StartButton.onClick.RemoveAllListeners();
            _QuickStartButton.onClick.RemoveAllListeners();
            _DiceSetsButton.onClick.RemoveAllListeners();
        }
    }
}
