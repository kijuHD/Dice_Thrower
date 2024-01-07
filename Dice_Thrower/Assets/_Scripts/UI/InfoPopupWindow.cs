using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DiceThrower.UI
{
    public class InfoPopupWindow : MonoBehaviour
    {
        [SerializeField]
        private Button _OKButton;
        [SerializeField]
        private TextMeshProUGUI _infoText;

        public void Setup(string info)
        {
            _infoText.text = info;
        }

        private void Start()
        {
            AddListeners();
        }
        private void OnDestroy()
        {
            RemoveListeners();
        }
        private void AddListeners()
        {
            _OKButton.onClick.AddListener(OnOKButtonClicked);
        }
        private void RemoveListeners()
        {
            _OKButton.onClick.RemoveAllListeners();
        }
        private void OnOKButtonClicked()
        {
            gameObject.SetActive(false);
            Destroy(this);
        }
    }
}
