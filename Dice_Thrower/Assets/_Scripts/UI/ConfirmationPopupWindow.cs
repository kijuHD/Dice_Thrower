using UnityEngine;
using UnityEngine.UI;

public class ConfirmationPopupWindow : MonoBehaviour
{
    [SerializeField]
    protected Button _ConfirmButton;
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
    protected virtual void AddListeners()
    {
        _ConfirmButton.onClick.AddListener(OnOKButtonClicked);
        _CancelButton.onClick.AddListener(OnCancelButtonClicked);
    }
    protected virtual void RemoveListeners()
    {
        _ConfirmButton.onClick.RemoveAllListeners();
        _CancelButton.onClick.RemoveAllListeners();
    }

    protected virtual void OnOKButtonClicked()
    {
        Destroy(this);
    }
    protected virtual void OnCancelButtonClicked()
    {
        Destroy(this);
    }
}
