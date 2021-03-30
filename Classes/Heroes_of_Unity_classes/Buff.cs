using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_of_Unity_classes
{
    public class Buff
    {
        //------------------------------------------------//
        protected int uniteId;
        public int UniteId { get => uniteId; set => uniteId = value; }
        protected int rarity;
        public int Rarity { get => rarity; set => rarity = value; }
        //------------------------------------------------//

        public Buff(int uId)
        {
            this.uniteId = uId;
            rarity = -1;
        }

    }

    interface SimpleBuff
    {
        int value1 { get; set; }
        string stat1 { get; set; }
    }

    interface DoubleBuff : SimpleBuff
    {
        int value2 { get; set; }
        string stat2 { get; set; }
    }

    interface TripleBuff : DoubleBuff
    {
        int value3 { get; set; }
        string stat3 { get; set; }
    }

    interface QuadrupleBuff : TripleBuff
    {
        int value4 { get; set; }
        string stat4 { get; set; }
    }

    interface QuintupleBuff: QuadrupleBuff
    {
        int value5 { get; set; }
        string stat5 { get; set; }
    }

    interface ConditionalSimpleBuff
    {
        int conditionalValue1 { get; set; }
        string conditionalStat1 { get; set; }
        bool CheckConditionalBuff(Fight fight);
    }

    interface ConditionalDoubleBuff : ConditionalSimpleBuff
    {
        int conditionalValue2 { get; set; }
        string conditionalStat2 { get; set; }
    }

    interface DoubleStrike
    {
        bool CheckDoubleStrike(Fight Fight);
    }

    interface NullifyDoubleStrikeOpponent
    {
        bool CheckNullifyDoubleStrikeOpponent(Fight fight);
    }

    interface NullifyDoubleStrikeCharacter
    {
        bool CheckNullifyDoubleStrikeCharacter(Fight fight);
    }
}
