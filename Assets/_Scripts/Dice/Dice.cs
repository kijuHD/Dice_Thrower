using UnityEngine;
using Zenject;

namespace DiceThrower.Dice
{
    public abstract class Dice : MonoBehaviour, ISelectable, IThrowable
    {
        public int NumberOfSides => _numberOfSides;

        protected int _numberOfSides;

        public void Select()
        {
        }

        public void Throw()
        {
        }
    }
}
