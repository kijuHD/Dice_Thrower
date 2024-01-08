using Zenject;

namespace DiceThrower.Dice
{
    public class DiceSpawnerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<DiceSpawner>().AsSingle();
        }
    }
}