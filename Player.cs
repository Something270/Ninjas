using System;

namespace Ninjas
{


    class Player
    {
        public Health health;

        public Movement movement;

        public int attackDamage = 30;

        public Player()
        {
            this.health = new Health(100, 100, 100);
        }

        public void Move()
        {

        }

        /// <summary>
        /// Attack a target
        /// </summary>
        /// <returns> true if attack was succesful</returns>
        public bool Attack(Health target)
        {
            if (target == null)
            {
                return false;
            }
            if (target.health == 0)
            {
                return false;
            }
            target.TakeDamage(attackDamage);
            return true;
        }
    }
}