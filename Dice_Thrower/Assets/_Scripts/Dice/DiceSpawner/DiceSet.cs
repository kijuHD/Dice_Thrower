using System;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

namespace DiceThrower.Dice
{
    [CreateAssetMenu(fileName = "DiceSet", menuName = "ScriptableObjects/Dice/DiceSet", order = 1)]
    public class DiceSet : ScriptableObject
    {
        public List<DiceType> Types => _types;
        public List<int> Counts => _counts;
        public string Name => _name;
        public bool GetIsQuickStartSet => IsQuickStartSet;


        /*
         * 
         * After create and edit set will be complited
         * switch to dictionary
         * 
         */

        [SerializeField]
        private List<DiceType> _types= new List<DiceType>();
        [SerializeField]
        private List<int>_counts= new List<int>();
        [SerializeField]
        private string _name;
        [SerializeField]
        private bool IsQuickStartSet;

        public DiceSet()
        {
            foreach (var type in Enum.GetValues(typeof(DiceType)).Cast<DiceType>())
            {
                _types.Add(type);
                _counts.Add(0);
            }
        }
        public void Edit(string name, int d6Number, int d12Number)
        {
            _name= name;
            _counts[0] = d6Number;
            _counts[1] = d12Number;
        }

    }
}
