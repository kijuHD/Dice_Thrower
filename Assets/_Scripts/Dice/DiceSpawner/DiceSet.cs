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
        public bool IsQuickStartSet => _isQuickStartSet;

        [SerializeField]
        private List<DiceType> _types = new List<DiceType>();
        [SerializeField]
        private List<int> _counts = new List<int>();
        [SerializeField]
        private string _name;
        [SerializeField]
        private bool _isQuickStartSet;

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
