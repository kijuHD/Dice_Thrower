using Zenject;
using UnityEngine;

namespace DiceThrower.UI
{
    public class Overlay : MonoBehaviour
    {
        [Inject]
        private void RegisterToMenuSystem(MenuSystem menuSystem)
        {
            menuSystem.RegisterUIOverlay(this);
        }

    }
}
