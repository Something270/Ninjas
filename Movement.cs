using System;
namespace Ninjas
{
    class Movement
    {

        public float speed;
        public float crouchspeed;
        public float walkSpeed;
        public float runSpeed;
        public void Move()
        {

        }

        public void Run()
        {
            this.speed = this.runSpeed;
        }

        public void StopRunning()
        {
            this.speed = this.walkSpeed;
        }
    }   
}