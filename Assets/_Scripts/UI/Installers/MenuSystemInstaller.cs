using Zenject;

namespace DiceThrower.UI
{
    public class MenuSystemInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<MenuSystem>().AsSingle();
        }
    }
}
