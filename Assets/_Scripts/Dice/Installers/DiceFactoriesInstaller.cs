using Zenject;
using UnityEngine;

namespace DiceThrower.Dice
{
    public class DiceFactoriesInstaller : MonoInstaller
    {
        [SerializeField]
        private D6 _D6Prefab;
        [SerializeField]
        private D12 _D12Prefab;

        public override void InstallBindings()
        {
            Container.BindFactory<D6, D6.Factory>().FromComponentInNewPrefab(_D6Prefab);
            Container.BindFactory<D12, D12.Factory>().FromComponentInNewPrefab(_D12Prefab);

            Container.Bind<DiceFactoryManager>().AsSingle();
            Container.BindFactory<Dice, DiceFactory>().FromFactory<CustomDiceFactory>();
        }
    }
}
