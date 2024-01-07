using TMPro;
using Zenject;
using UnityEngine;
using DiceThrower.Dice;

namespace DiceThrower.UI
{
    public class CreateSetPopupWindow : ConfirmationPopupWindow
    {
        [SerializeField]
        private TextMeshProUGUI _SetNameInput;

        [Inject]
        private DiceSetManager _diceSetManager;

        protected override void OnOKButtonClicked()
        {

        }


    }
}
