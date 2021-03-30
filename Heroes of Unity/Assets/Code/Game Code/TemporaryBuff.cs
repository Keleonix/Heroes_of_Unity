using System;
using System.Collections.Generic;
using System.Text;

namespace Test_HoU
{
    public class TemporaryBuff : Buff
    {
        //----------------------------------//
        protected int countdown;
        public int Countdown { get => countdown; set => countdown = value; }
        //----------------------------------//
        public TemporaryBuff(int uId) : base(uId)
        { }

        public void DecrementCooldown()
        {
            countdown--;
        }

        public void IncrementCooldown()
        {
            countdown++;
        }

        public bool CheckEndOfEffect()
        {
            if (countdown <= 0) return true;
            else return false;
        }
    }

}
