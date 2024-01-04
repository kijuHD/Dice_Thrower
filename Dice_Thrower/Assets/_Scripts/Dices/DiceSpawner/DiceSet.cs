using UnityEngine;
using System.Collections.Generic;
using System;
using System.Linq;

namespace DiceThrower.Dice
{
    [CreateAssetMenu(fileName = "DiceSet", menuName = "ScriptableObjects/Dice/DiceSet", order = 1)]
    public class DiceSet : ScriptableObject
    {
        /*
         * 
         * TODO: in future look for better solution
         * 
         * serilize dictionary ???
         * 
         */

        public List<DiceType> Types => _types;
        public List<int> Counts => _counts;

        [SerializeField]
        private List<DiceType> _types= new List<DiceType>();
        [SerializeField]
        private List<int>_counts= new List<int>();

        public DiceSet()
        {
            foreach (var type in Enum.GetValues(typeof(DiceType)).Cast<DiceType>())
            {
                _types.Add(type);
                _counts.Add(0);
            }
        }
    }
}
