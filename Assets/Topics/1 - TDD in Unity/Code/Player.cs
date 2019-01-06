using UnityEngine;

namespace TestDrivenDev
{
    public class Player : MonoBehaviour
    {
        private readonly int _maxHealth = 100;
        private int _health;

        private void Awake()
        {
            _health = _maxHealth;
        }

        public int Health
        {
            get
            {
                return _health + Armor;
            }

            private set
            {
                _health = value;

                if (_health > _maxHealth)
                {
                    _health = _maxHealth;
                }
            }
        }

        public int Armor { get; private set; }
    }
}