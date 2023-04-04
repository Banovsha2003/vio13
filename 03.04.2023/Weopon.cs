using System;
using System.Collections.Generic;
using System.Text;

namespace _03._04._2023
{
    abstract class Weopon
    {
        public string name;
        public int damage;
        
        public void Name()
        {

        }
        public abstract void Damage();
        

        //Task:5
        abstract class Sword : Weopon
        {

        }


    }
}
