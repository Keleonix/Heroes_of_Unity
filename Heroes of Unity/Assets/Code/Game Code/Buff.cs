using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_HoU
{
    public class Buff
    {
        //------------------------------------------------//
        protected int unitId;
        public int UnitId { get => unitId; set => unitId =value; }
        protected int rarity;
        public int Rarity { get => rarity; set => rarity = value; }
        protected string nameBuff;
        public string Name { get => nameBuff; set => nameBuff = value; }
        //------------------------------------------------//

        public Buff(int uId)
        {
            unitId = uId;
            nameBuff = "";
            rarity = -1;
        }

        public override string ToString()
        {
            return nameBuff;
        }

    }

    interface ValueBuff
    {
        List<int> Values { get; }
        List<string> Stats { get; }
    }

    interface ConditionalValueBuff
    {
        void ActualizeConditionalValues(Fight fight, Character opponent);
    }

    interface ConditionalBuff
    {
        bool CheckConditionalBuff(Fight fight, Character opponent);
    }

    interface DoubleStrike
    {
        bool CheckDoubleStrike(Fight Fight, Character opponent);
    }

    interface NullifyDoubleStrikeOpponent
    {
        bool CheckNullifyDoubleStrikeOpponent(Fight fight, Character opponent);
    }

    interface NullifyDoubleStrikeCharacter
    {
        bool CheckNullifyDoubleStrikeCharacter(Fight fight, Character opponent);
    }

    interface EndOfCombatEffect
    {
        string effectName { get; }

        string TargetOfEffect { get; }

        void ApplyEndOfCombatEffect(Fight fight, Character opponent);

    }

}
