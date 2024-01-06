using UnityEngine;
using UnityEngine.UI;

public class PopupWindow : MonoBehaviour
{
    [SerializeField]
    protected Button _OkButton;
    [SerializeField]
    protected Button _CancelButton;


    protected void Start()
    {
        AddListeners();
    }
    protected void OnDestroy()
    {
        RemoveListeners();
    }
    protected void AddListeners()
    {
        _OkButton.onClick.AddListener(OnOKButtonClicked);
        _CancelButton.onClick.AddListener(OnCancelButtonClicked);
    }
    protected void RemoveListeners()
    {
        _OkButton.onClick.RemoveAllListeners();
        _CancelButton.onClick.RemoveAllListeners();
    }

    protected void OnOKButtonClicked()
    {

    }
    protected void OnCancelButtonClicked()
    {

    }
}
