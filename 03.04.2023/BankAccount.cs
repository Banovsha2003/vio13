using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace _03._04._2023
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public int Balance { get; set; } 

       

        public void Add(int addmoney)
        {
           Balance += addmoney;
        }
        public bool Exit(int exitmoney)
        {
            bool pul = true;
            
            if (exitmoney <= Balance)
            {
                Balance -= exitmoney;
            }
            else if (exitmoney > Balance)
            {
               pul = false;
            }
            return pul;
        }

       
    }

}
