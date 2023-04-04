using System;
using System.Collections.Generic;
using System.Text;

namespace _03._04._2023
{
    internal class Player
    {
        public int health;
        public int movementSpeed;
        public int damage;


        public void Attack()
        {

        }

        public void TakeDamege(int damage)
        {
            health -= damage;
        }
    }
}
