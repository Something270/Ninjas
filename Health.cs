using System;


namespace Ninjas
{
    class Health
    {
        public int health;
        public int maxHealth;
        public int initialHealth;

        public Health(int health, int maxHealth, int initialHealth)
        {
            this.health = health;
            this.maxHealth = maxHealth;
            this.initialHealth = initialHealth;
        }

        public void TakeDamage(int damage)
        {
            if (damage > this.health)
            {
                this.health = 0;
            }
            else
            {
                this.health = this.health - damage;

            }

        }

        public bool IsAlive()
        {
            if (this.health > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsDead()
        {
            return !this.IsAlive();
        }
    }
}
