using Zenject;

namespace DiceThrower.Dice
{
    public class D12 : Dice
    {
        public D12()
        {
            _numberOfSides = 12;
        }

        public class Factory : PlaceholderFactory<D12> { }
    }
}