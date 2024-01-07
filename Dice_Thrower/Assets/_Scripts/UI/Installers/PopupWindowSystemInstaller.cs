using Zenject;
using UnityEngine;

namespace DiceThrower.UI
{
    public class PopupWindowSystemInstaller : MonoInstaller
    {
        [SerializeField]
        private InfoPopupWindow _InfoPopupWindowPrefab;
        [SerializeField]
        private Transform _MenuParentTransform;

        public override void InstallBindings()
        {
            Container.Bind<PopupWindowSystem>().AsSingle().WithArguments(_InfoPopupWindowPrefab, _MenuParentTransform);
        }
    }
}
