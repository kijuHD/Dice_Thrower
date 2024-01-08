
using UnityEngine;
using Zenject;

namespace DiceThrower.Dice
{
    public class ManagersInstaller : MonoInstaller
    {
        [SerializeField]
        private SetsCollection _diceSetsCollection;
        public override void InstallBindings()
        {
            Container.Bind<DiceSetManager>().AsSingle().WithArguments(_diceSetsCollection);
            Container.Bind<DiceSpawnerManager>().AsSingle();
        }
    }
}
