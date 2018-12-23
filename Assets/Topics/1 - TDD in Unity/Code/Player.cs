using UnityEngine;

namespace TestDrivenDev
{
    public class Player : MonoBehaviour
    {
        private int _health = 100;
        private int _armor = 0;

        public int Health {
            get { return _health + _armor; }
            private set { }
        }

        public int Armor { get; private set; }
    }
}

