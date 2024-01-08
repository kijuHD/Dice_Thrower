using Zenject;

namespace DiceThrower.Dice
{
    public class D6 : Dice
    {
        public D6()
        {
            _numberOfSides = 6;
        }
        public class Factory : PlaceholderFactory<D6> { }
    }
}
