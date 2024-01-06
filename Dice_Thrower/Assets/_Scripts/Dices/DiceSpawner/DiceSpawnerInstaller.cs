using Zenject;
using UnityEngine;

namespace DiceThrower.Dice
{
    public class DiceSpawnerInstaller : MonoInstaller
    {
        [SerializeField]
        private D6 _D6Prefab;
        [SerializeField]
        private D12 _D12Prefab;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<DiceSpawner>().AsSingle();
            Container.BindFactory<D6, D6.Factory>().FromComponentInNewPrefab(_D6Prefab);
            Container.BindFactory<D12,D12.Factory>().FromComponentInNewPrefab(_D12Prefab);
        }
    }
}