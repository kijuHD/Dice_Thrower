namespace DiceThrower.Dice
{
    public class DiceFactoryManager
    {
        public DiceType DiceTypeToSpawn
        {
            get { return _diceTypeToSpawn; }
            set { _diceTypeToSpawn = value; }
        }

        private DiceType _diceTypeToSpawn;
    }
}
