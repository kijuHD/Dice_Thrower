using Zenject;

namespace DiceThrower.Dice
{
    public class DiceSpawnerManager
    {
        [Inject]
        private DiceSpawner _diceSpawner;
        [Inject]
        private DiceSetManager _diceSetManager;

        public void SpawnDices()
        {
            _diceSpawner.SpawnDices(_diceSetManager.ActiveSet);
        }
    }
}
