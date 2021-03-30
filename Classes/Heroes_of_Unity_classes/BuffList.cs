using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes_of_Unity_classes
{

    ////////////////////
    ////Common Buffs////
    ////////////////////

    class CommonAttackBuff : Buff, SimpleBuff
    {
        public CommonAttackBuff(int uId) : base(uId)
        {
            rarity = 1;
            value1 = 5;
            stat1 = "Attack";
        }

        public override string ToString()
        {
            return "Common Attack Buff";
        }

        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class CommonDefenseBuff : Buff, SimpleBuff
    {
        public CommonDefenseBuff(int uId) : base(uId)
        {
            rarity = 1;
            value1 = 5;
            stat1 = "Defense";
        }

        public override string ToString()
        {
            return "Common Defense Buff";
        }

        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class CommonHealthBuff : Buff, SimpleBuff
    {
        public CommonHealthBuff(int uId) : base(uId)
        {
            rarity = 1;
            value1 = 5;
            stat1 = "Health";
        }

        public override string ToString()
        {
            return "Common Health Buff";
        }

        public int value1 { get; set; }
        public string stat1 { get; set; }
    }
    
    class CommonResistanceBuff : Buff, SimpleBuff
    {
        public CommonResistanceBuff(int uId) : base(uId)
        {
            rarity = 1;
            value1 = 5;
            stat1 = "Resistance";
        }

        public override string ToString()
        {
            return "Common Resistance Buff";
        }

        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class CommonSpeedBuff : Buff, SimpleBuff
    {
        public CommonSpeedBuff(int uId) : base(uId)
        {
            rarity = 1;
            value1 = 5;
            stat1 = "Speed";
        }

        public override string ToString()
        {
            return "Common Speed Buff";
        }

        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class CommonAttackSpeedBuff : Buff, DoubleBuff
    {
        public CommonAttackSpeedBuff(int uId) : base(uId)
        {
            rarity = 1;
            value1 = 3;
            stat1 = "Attack";
            value2 = 3;
            stat2 = "Speed";
        }

        public override string ToString()
        {
            return "Common Attack/Speed Buff";
        }

        public int value2 { get; set; }
        public string stat2 { get; set; }
        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class CommonAttackDefenseBuff : Buff, DoubleBuff
    {
        public CommonAttackDefenseBuff(int uId) : base(uId)
        {
            rarity = 1;
            value1 = 3;
            stat1 = "Attack";
            value2 = 3;
            stat2 = "Defense";
        }

        public override string ToString()
        {
            return "Common Attack/Defense Buff";
        }

        public int value2 { get; set; }
        public string stat2 { get; set; }
        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class CommonAttackResistanceBuff : Buff, DoubleBuff
    {
        public CommonAttackResistanceBuff(int uId) : base(uId)
        {
            rarity = 1;
            value1 = 3;
            stat1 = "Attack";
            value2 = 3;
            stat2 = "Resistance";
        }

        public override string ToString()
        {
            return "Common Attack/Resistance Buff";
        }

        public int value2 { get; set; }
        public string stat2 { get; set; }
        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class CommonDefenseResistanceBuff : Buff, DoubleBuff
    {
        public CommonDefenseResistanceBuff(int uId) : base(uId)
        {
            rarity = 1;
            value1 = 3;
            stat1 = "Defense";
            value2 = 3;
            stat2 = "Resistance";
        }

        public override string ToString()
        {
            return "Common Defense/Resistance Buff";
        }

        public int value2 { get; set; }
        public string stat2 { get; set; }
        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class CommonDefenseHealthBuff : Buff, DoubleBuff
    {
        public CommonDefenseHealthBuff(int uId) : base(uId)
        {
            rarity = 1;
            value1 = 3;
            stat1 = "Defense";
            value2 = 3;
            stat2 = "Health";
        }

        public override string ToString()
        {
            return "Common Defense/Health Buff";
        }

        public int value2 { get; set; }
        public string stat2 { get; set; }
        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class CommonResistanceHealthBuff : Buff, DoubleBuff
    {
        public CommonResistanceHealthBuff(int uId) : base(uId)
        {
            rarity = 1;
            value1 = 3;
            stat1 = "Health";
            value2 = 3;
            stat2 = "Resistance";
        }

        public override string ToString()
        {
            return "Common Health/Resistance Buff";
        }

        public int value2 { get; set; }
        public string stat2 { get; set; }
        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    //////////////////
    ////Rare Buffs////              //WIP//
    //////////////////

    class RareAttackBuff : Buff, SimpleBuff
    {
        public RareAttackBuff(int uId) : base(uId)
        {
            rarity = 2;
            value1 = 8;
            stat1 = "Attack";
        }

        public override string ToString()
        {
            return "Rare Attack Buff";
        }

        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class RareDefenseBuff : Buff, SimpleBuff
    {
        public RareDefenseBuff(int uId) : base(uId)
        {
            rarity = 2;
            value1 = 8;
            stat1 = "Defense";
        }

        public override string ToString()
        {
            return "Rare Defense Buff";
        }

        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class RareHealthBuff : Buff, SimpleBuff
    {
        public RareHealthBuff(int uId) : base(uId)
        {
            rarity = 2;
            value1 = 8;
            stat1 = "Health";
        }

        public override string ToString()
        {
            return "Rare Health Buff";
        }

        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class RareResistanceBuff : Buff, SimpleBuff
    {
        public RareResistanceBuff(int uId) : base(uId)
        {
            rarity = 2;
            value1 = 8;
            stat1 = "Resistance";
        }

        public override string ToString()
        {
            return "Rare Resistance Buff";
        }

        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class RareSpeedBuff : Buff, SimpleBuff
    {
        public RareSpeedBuff(int uId) : base(uId)
        {
            rarity = 2;
            value1 = 8;
            stat1 = "Speed";
        }

        public override string ToString()
        {
            return "Rare Speed Buff";
        }

        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class RareAttackSpeedBuff : Buff, DoubleBuff
    {
        public RareAttackSpeedBuff(int uId) : base(uId)
        {
            rarity = 2;
            value1 = 4;
            stat1 = "Attack";
            value2 = 4;
            stat2 = "Speed";
        }

        public override string ToString()
        {
            return "Rare Attack/Speed Buff";
        }

        public int value2 { get; set; }
        public string stat2 { get; set; }
        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class RareAttackDefenseBuff : Buff, DoubleBuff
    {
        public RareAttackDefenseBuff(int uId) : base(uId)
        {
            rarity = 2;
            value1 = 4;
            stat1 = "Attack";
            value2 = 4;
            stat2 = "Defense";
        }

        public override string ToString()
        {
            return "Rare Attack/Defense Buff";
        }

        public int value2 { get; set; }
        public string stat2 { get; set; }
        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class RareAttackResistanceBuff : Buff, DoubleBuff
    {
        public RareAttackResistanceBuff(int uId) : base(uId)
        {
            rarity = 2;
            value1 = 4;
            stat1 = "Attack";
            value2 = 4;
            stat2 = "Resistance";
        }

        public override string ToString()
        {
            return "Rare Attack/Resistance Buff";
        }

        public int value2 { get; set; }
        public string stat2 { get; set; }
        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class RareDefenseResistanceBuff : Buff, DoubleBuff
    {
        public RareDefenseResistanceBuff(int uId) : base(uId)
        {
            rarity = 2;
            value1 = 4;
            stat1 = "Defense";
            value2 = 4;
            stat2 = "Resistance";
        }

        public override string ToString()
        {
            return "Rare Defense/Resistance Buff";
        }

        public int value2 { get; set; }
        public string stat2 { get; set; }
        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class RareDefenseHealthBuff : Buff, DoubleBuff
    {
        public RareDefenseHealthBuff(int uId) : base(uId)
        {
            rarity = 2;
            value1 = 4;
            stat1 = "Defense";
            value2 = 4;
            stat2 = "Health";
        }

        public override string ToString()
        {
            return "Rare Defense/Health Buff";
        }

        public int value2 { get; set; }
        public string stat2 { get; set; }
        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class RareResistanceHealthBuff : Buff, DoubleBuff
    {
        public RareResistanceHealthBuff(int uId) : base(uId)
        {
            rarity = 2;
            value1 = 4;
            stat1 = "Health";
            value2 = 4;
            stat2 = "Resistance";
        }

        public override string ToString()
        {
            return "Rare Health/Resistance Buff";
        }

        public int value2 { get; set; }
        public string stat2 { get; set; }
        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    //////////////////
    ////Epic Buffs////              //WIP//
    //////////////////
    
    class EpicAllBuff : Buff, QuintupleBuff
    {
        public EpicAllBuff(int uId) : base(uId)
        {
            rarity = 3;
            value1 = 3;
            stat1 = "Attack";
            value2 = 3;
            stat2 = "Defense";
            value3 = 3;
            stat3 = "Health";
            value4 = 3;
            stat4 = "Resistance";
            value5 = 3;
            stat5 = "Speed";
        }

        public override string ToString()
        {
            return "The Quintuple Force";
        }

        public int value5 { get; set; }
        public string stat5 { get; set; }
        public int value4 { get; set; }
        public string stat4 { get; set; }
        public int value3 { get; set; }
        public string stat3 { get; set; }
        public int value2 { get; set; }
        public string stat2 { get; set; }
        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class EpicAggressivityBuff : Buff, DoubleBuff
    {
        public EpicAggressivityBuff(int uId) : base(uId)
        {
            rarity = 3;
            value1 = 10;
            stat1 = "Attack";
            value2 = -3;
            stat2 = "Health";
        }

        public override string ToString()
        {
            return "Aggressivity";
        }

        public int value2 { get; set; }
        public string stat2 { get; set; }
        public int value1 { get; set; }
        public string stat1 { get; set; }
    }

    class EpicAbsoluteNullify : Buff, NullifyDoubleStrikeCharacter, NullifyDoubleStrikeOpponent
    {
        public EpicAbsoluteNullify(int uId) : base(uId)
        {
            rarity = 3;
        }

        public bool CheckNullifyDoubleStrikeCharacter(Fight fight)
        {
            return true;
        }

        public bool CheckNullifyDoubleStrikeOpponent(Fight fight)
        {
            return true;
        }

        public override string ToString()
        {
            return "Absolute Nullify";
        }
    }

    class EpicBerserk : Buff, DoubleStrike, ConditionalSimpleBuff
    {
        public EpicBerserk(int uId) : base(uId)
        {
            rarity = 3;
            conditionalValue1 = 5;
            conditionalStat1 = "Attack";
        }

        public int conditionalValue1 { get; set; }
        public string conditionalStat1 { get; set; }

        public bool CheckConditionalBuff(Fight fight)
        {
            Character character = fight.SearchByFightId(uniteId);
            if (character.FightHealth <= character.Health / 4) return true;
            else return false;
        }

        public bool CheckDoubleStrike(Fight fight)
        {
            Character character = fight.SearchByFightId(uniteId);
            if (character.FightHealth <= character.Health / 4) return true;
            else return false;
        }

        public override string ToString()
        {
            return "Berserk";
        }
    }

    class EpicPerfectCondition : Buff, DoubleStrike, ConditionalDoubleBuff
    {
        public EpicPerfectCondition(int uId) : base(uId)
        {
            rarity = 3;
            conditionalValue1 = 3;
            conditionalStat1 = "Attack";
            conditionalValue2 = 3;
            conditionalStat2 = "Speed";
        }

        public int conditionalValue1 { get; set; }
        public string conditionalStat1 { get; set; }
        public int conditionalValue2 { get; set; }
        public string conditionalStat2 { get; set; }

        public bool CheckConditionalBuff(Fight fight)
        {
            Character character = fight.SearchByFightId(uniteId);
            if (character.FightHealth == character.Health) return true;
            else return false;
        }

        public bool CheckDoubleStrike(Fight fight)
        {
            Character character = fight.SearchByFightId(uniteId);
            if (character.FightHealth == character.Health) return true;
            else return false;
        }

        public override string ToString()
        {
            return "Perfect Condition";
        }
    }


}
