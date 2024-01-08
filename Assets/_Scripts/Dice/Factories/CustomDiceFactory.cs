using Zenject;

namespace DiceThrower.Dice
{
    public class CustomDiceFactory : IFactory<Dice>
    {
        private readonly D6.Factory _D6Factory;
        private readonly D12.Factory _D12Factory;

        private readonly DiceFactoryManager _diceFactoryManager;

        public CustomDiceFactory(DiceFactoryManager diceFactoryManager, D6.Factory D6Factory, D12.Factory D12Factory)
        {
            _D6Factory = D6Factory;
            _D12Factory = D12Factory;
            _diceFactoryManager = diceFactoryManager;
        }

        public Dice Create()
        {
            switch (_diceFactoryManager.DiceTypeToSpawn)
            {
                case DiceType.D6:
                    return _D6Factory.Create();
                case DiceType.D12:
                    return _D12Factory.Create();
                default:
                    return null;
            }
        }
    }
}
