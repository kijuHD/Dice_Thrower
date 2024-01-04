using UnityEngine;
using System.Collections.Generic;

namespace DiceThrower.Dice
{
    [CreateAssetMenu(fileName = "SetsCollection", menuName = "ScriptableObjects/Dice/SetsCollection", order = 2)]
    public class SetsCollection : ScriptableObject
    {
        public List<DiceSet> Sets => _sets;

        [SerializeField]
        private List<DiceSet> _sets=new List<DiceSet>();
    }
}
