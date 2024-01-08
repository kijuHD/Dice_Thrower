using UnityEngine;
using UnityEngine.UI;

namespace DiceThrower.UI
{
    public class CreateDiceSetMenu : Menu
    {
        public override MenuType GetMenuType()
        {
            return MenuType.CreateDiceSet;
        }

    }
}
