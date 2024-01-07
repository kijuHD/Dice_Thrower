using UnityEngine;

namespace DiceThrower.UI
{
    public class PopupWindowSystem
    {
        private InfoPopupWindow _infoPopupWindowPrefab;
        private Transform _menuParentTransform;
        
        public PopupWindowSystem (InfoPopupWindow infoPopupWindowPrefab, Transform menuParentTransform)
        {
            _infoPopupWindowPrefab= infoPopupWindowPrefab;
            _menuParentTransform= menuParentTransform;
        }

        public void CreateInfoPopupWindow(string info)
        {
            var window =GameObject.Instantiate(_infoPopupWindowPrefab, _menuParentTransform);
            window.Setup(info);
        }       
        
    }
}
