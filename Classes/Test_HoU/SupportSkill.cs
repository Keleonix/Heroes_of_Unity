using System;
using System.Collections.Generic;
using System.Text;

namespace Test_HoU
{
    class SupportSkill : Buff
    {
        public SupportSkill(int uId) : base(uId)
        { }
    }

    interface MovementSkill
    {
        bool CheckValidMovement(Fight fight, int allyFightId);

        void Move(Fight fight, int allyFightId);
    }

    interface HealingSkill : ValueBuff
    { }

}
