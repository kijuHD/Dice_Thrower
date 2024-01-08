using UnityEngine;

namespace DiceThrower.Dice
{
    public class DiceSpawner
    {
        private readonly DiceFactory _diceFactory;
        private readonly DiceFactoryManager _diceFactoryManager;

        public DiceSpawner(DiceFactory diceFactory, DiceFactoryManager diceFactoryManager)
        {
            _diceFactory= diceFactory;
            _diceFactoryManager= diceFactoryManager;
        }
        public void SpawnDices(DiceSet diceSet)
        {
            if (diceSet == null)
            {
                throw new System.Exception("[DICESPAWNER] Dice Set is null");
            }
            if (diceSet.Types.Count != diceSet.Counts.Count)
            {
                throw new System.Exception("[DICESPAWNER] Count of Types and Counts in Dice Set isn't equal");
            }

            for (int i = 0; i < diceSet.Types.Count; i++)
            {
                _diceFactoryManager.DiceTypeToSpawn = diceSet.Types[i];

                for (int j = 0; j < diceSet.Counts.Count; j++)
                {
                    _diceFactory.Create();
                }
            }
        }
    }
}
