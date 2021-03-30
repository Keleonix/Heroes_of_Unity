using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes_of_Unity_classes
{
    class TemporaryBuff : Buff
    {
        //----------------------------------//
        protected int countdown;
        public int Countdown { get => countdown; set => countdown = value; }
        //----------------------------------//
        TemporaryBuff(int uId) : base(uId)
        { }
    }

    class TemporaryCommonAttackBuff : Buff, SimpleBuff
    {
        public TemporaryCommonAttackBuff(int uId) : base(uId)
        {
            rarity = 1;
            value1 = 5;
            stat1 = "Attack";
        }

        public override string ToString()
        {
            return "Temporary Common Attack Buff";
        }
        public int value1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string stat1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}
