using UnityEngine;

namespace DiceThrower.Dice
{
    public class DiceSpawner
    {
        readonly D6.Factory _d6Factory;
        readonly D12.Factory _d12Factory;

        public DiceSpawner(D6.Factory d6Factory, D12.Factory d12Factory)
        {
            _d6Factory = d6Factory;
            _d12Factory = d12Factory;
        }

        private void CreateDice(DiceType type, int count)
        {
            switch (type)
            {
                case DiceType.D6:
                    CreateD6(count);
                    break;
                case DiceType.D12:
                    CreateD12(count);
                    break;
            }
        }
        private void CreateD6(int number)
        {
            for(int i=0;i< number;i++)
            {
                _d6Factory.Create();
                Debug.Log("[DICE] D6 created");
            }            
        }
        private void CreateD12(int number)
        {
            for (int i = 0; i < number; i++)
            {
                _d12Factory.Create();
                Debug.Log("[DICE] D12 created");
            }
        }

        public void SpawnDicesBasedOnDiceSet(DiceSet diceSet)
        {
            if(diceSet.Types.Count!=diceSet.Counts.Count)
            {
                throw new System.Exception("[DICESPAWNER] Count of Types and Counts in Dice Set isn't equal");
            }

            for(int i=0;i<diceSet.Types.Count;i++)
            {
                CreateDice(diceSet.Types[i], diceSet.Counts[i]);
            }
        }
    }
}
