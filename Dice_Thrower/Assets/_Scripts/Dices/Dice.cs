using UnityEngine;

namespace DiceThrower.Dice
{
    public abstract class Dice : MonoBehaviour, ISelectable, IThrowable
    {
        public int NumberofSides => _numberOfSides;

        protected int _numberOfSides;

        public void Select()
        {
            /*
             * TODO: add select method             
             */
        }

        public void Throw()
        {
            /*
             * TODO: add Throw method
             */
        }
    }
}
