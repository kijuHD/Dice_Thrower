using Zenject;
using UnityEngine;
using System.Collections.Generic;

namespace DiceThrower.UI
{
    public class MenuSystemInstaller : MonoInstaller
    {
        [SerializeField]
        private AvailableMenusSO _availableMenus;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MenuSystem>().AsSingle();
        }
    }
}
