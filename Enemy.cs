using System;

namespace Ninjas
{
    class Enemy
    {
        public Health health;

        public Enemy()
        {
            this.health = new Health(40,40,40);
        }
    }
}