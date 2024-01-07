using DiceThrower.General;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace DiceThrower.Dice
{
    public class DiceSetManager
    {
        public DiceSet ActiveSet => _activeDiceSet;

        private DiceSet _activeDiceSet;
        private SetsCollection _setsCollection;
        public DiceSetManager(SetsCollection setsCollection)
        {
            _setsCollection = setsCollection;
        }

        public void SelectDiceSet(DiceSet set)
        {
            _activeDiceSet = set;
        }
        public void SelectQuickStartSet()
        {
            var set = _setsCollection.Sets.FirstOrDefault(s => s.GetIsQuickStartSet);
            if (set == null)
            {
                throw new System.Exception($"[DICESET] There is no quick start set in collection");
            }
            SelectDiceSet(set);
        }
        public bool NameDuplicate(string name)
        {
            return _setsCollection.Sets.Any(s=>s.Name.Equals(name));
        }
        public void CreateNewSet(string name, int d6Number, int d12Number)
        {
            DiceSet newSet = ScriptableObject.CreateInstance<DiceSet>();
            newSet.Edit(name,d6Number, d12Number);

            string path = ConstantValues.DiceSetSOPath + "/" + $"{name}.asset";
            AssetDatabase.CreateAsset(newSet,path);
            _setsCollection.Sets.Add(newSet);
        }
    }
}
