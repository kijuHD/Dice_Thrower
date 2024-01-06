using UnityEngine;
using Zenject;

namespace DiceThrower.Dice
{
    public abstract class Dice : MonoBehaviour, ISelectable, IThrowable
    {
        public int NumberofSides => _numberOfSides;

        protected int _numberOfSides;

        public Dice()
        {
        }

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
