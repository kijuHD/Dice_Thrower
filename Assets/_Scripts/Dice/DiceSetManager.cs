using System.Linq;

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
            var set = _setsCollection.Sets.FirstOrDefault(s => s.IsQuickStartSet);
            if (set == null)
            {
                throw new System.Exception($"[DICESET] There is no quick start set in collection");
            }
            SelectDiceSet(set);
        }
    }
}
