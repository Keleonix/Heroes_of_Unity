using System;
using System.Collections.Generic;
using System.Text;

namespace Test_HoU
{

    ////////////////////
    ////Common Buffs////
    ////////////////////

    class CommonAttackBuff : Buff, ValueBuff
    {
        public CommonAttackBuff(int uId) : base(uId)
        {
            rarity = 1;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(5);
            Stats.Add("Attack");
            name = "Common Attack Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class CommonDefenseBuff : Buff, ValueBuff
    {
        public CommonDefenseBuff(int uId) : base(uId)
        {
            rarity = 1;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(5);
            Stats.Add("Defense");
            name = "Common Defense Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class CommonHealthBuff : Buff, ValueBuff
    {
        public CommonHealthBuff(int uId) : base(uId)
        {
            rarity = 1;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(5);
            Stats.Add("Health");
            name = "Common Health Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }
    
    class CommonResistanceBuff : Buff, ValueBuff
    {
        public CommonResistanceBuff(int uId) : base(uId)
        {
            rarity = 1;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(5);
            Stats.Add("Resistance");
            name = "Common Resistance Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class CommonSpeedBuff : Buff, ValueBuff
    {
        public CommonSpeedBuff(int uId) : base(uId)
        {
            rarity = 1;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(5);
            Stats.Add("Speed");
            name = "Common Speed Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class CommonAttackSpeedBuff : Buff, ValueBuff
    {
        public CommonAttackSpeedBuff(int uId) : base(uId)
        {
            rarity = 1;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(3);
            Stats.Add("Attack");
            Values.Add(3);
            Stats.Add("Speed");
            name = "Common Attack/Speed Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class CommonAttackDefenseBuff : Buff, ValueBuff
    {
        public CommonAttackDefenseBuff(int uId) : base(uId)
        {
            rarity = 1;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(3);
            Stats.Add("Attack");
            Values.Add(3);
            Stats.Add("Defense");
            name = "Common Attack/Defense Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class CommonAttackResistanceBuff : Buff, ValueBuff
    {
        public CommonAttackResistanceBuff(int uId) : base(uId)
        {
            rarity = 1;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(3);
            Stats.Add("Attack");
            Values.Add(3);
            Stats.Add("Resistance");
            name = "Common Attack/Resistance Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class CommonDefenseResistanceBuff : Buff, ValueBuff
    {
        public CommonDefenseResistanceBuff(int uId) : base(uId)
        {
            rarity = 1;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(3);
            Stats.Add("Defense");
            Values.Add(3);
            Stats.Add("Resistance");
            name = "Common Defense/Resistance Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class CommonDefenseHealthBuff : Buff, ValueBuff
    {
        public CommonDefenseHealthBuff(int uId) : base(uId)
        {
            rarity = 1;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(3);
            Stats.Add("Defense");
            Values.Add(3);
            Stats.Add("Health");
            name = "Common Defense/Health Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class CommonResistanceHealthBuff : Buff, ValueBuff
    {
        public CommonResistanceHealthBuff(int uId) : base(uId)
        {
            rarity = 1;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(3);
            Stats.Add("Health");
            Values.Add(3);
            Stats.Add("Resistance");
            name = "Common Health/Resistance Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    //////////////////
    ////Rare Buffs////
    //////////////////

    class RareAttackBuff : Buff, ValueBuff
    {
        public RareAttackBuff(int uId) : base(uId)
        {
            rarity = 2;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(8);
            Stats.Add("Attack");
            name = "Rare Attack Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class RareDefenseBuff : Buff, ValueBuff
    {
        public RareDefenseBuff(int uId) : base(uId)
        {
            rarity = 2;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(8);
            Stats.Add("Defense");
            name = "Rare Defense Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class RareHealthBuff : Buff, ValueBuff
    {
        public RareHealthBuff(int uId) : base(uId)
        {
            rarity = 2;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(8);
            Stats.Add("Health");
            name = "Rare Health Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class RareResistanceBuff : Buff, ValueBuff
    {
        public RareResistanceBuff(int uId) : base(uId)
        {
            rarity = 2;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(8);
            Stats.Add("Resistance");
            name = "Rare Resistance Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class RareSpeedBuff : Buff, ValueBuff
    {
        public RareSpeedBuff(int uId) : base(uId)
        {
            rarity = 2;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(8);
            Stats.Add("Speed");
            name = "Rare Speed Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class RareAttackSpeedBuff : Buff, ValueBuff
    {
        public RareAttackSpeedBuff(int uId) : base(uId)
        {
            rarity = 2;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(4);
            Stats.Add("Attack");
            Values.Add(4);
            Stats.Add("Speed");
            name = "Rare Attack/Speed Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class RareAttackDefenseBuff : Buff, ValueBuff
    {
        public RareAttackDefenseBuff(int uId) : base(uId)
        {
            rarity = 2;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(4);
            Stats.Add("Attack");
            Values.Add(4);
            Stats.Add("Defense");
            name = "Rare Attack/Defense Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class RareAttackResistanceBuff : Buff, ValueBuff
    {
        public RareAttackResistanceBuff(int uId) : base(uId)
        {
            rarity = 2;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(4);
            Stats.Add("Attack");
            Values.Add(4);
            Stats.Add("Resistance");
            name = "Rare Attack/Resistance Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class RareDefenseResistanceBuff : Buff, ValueBuff
    {
        public RareDefenseResistanceBuff(int uId) : base(uId)
        {
            rarity = 2;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(4);
            Stats.Add("Defense");
            Values.Add(4);
            Stats.Add("Resistance");
            name = "Rare Defense/Resistance Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class RareDefenseHealthBuff : Buff, ValueBuff
    {
        public RareDefenseHealthBuff(int uId) : base(uId)
        {
            rarity = 2;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(4);
            Stats.Add("Defense");
            Values.Add(4);
            Stats.Add("Health");
            name = "Rare Defense/Health Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class RareResistanceHealthBuff : Buff, ValueBuff
    {
        public RareResistanceHealthBuff(int uId) : base(uId)
        {
            rarity = 2;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(4);
            Stats.Add("Health");
            Values.Add(4);
            Stats.Add("Resistance");
            name = "Rare Health/Resistance Buff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class RareFearfullStrike : Buff, EndOfCombatEffect
    {
        public RareFearfullStrike(int uId) : base(uId)
        {
            rarity = 2;
            effectName = "Temporary Common Attack Debuff";
            TargetOfEffect = "Opponent";
            name = "Fearfull Strike";
        }

        public string effectName { get; }

        public string TargetOfEffect { get; }

        public void ApplyEndOfCombatEffect(Fight fight, Character opponent)
        {
            fight.AddTemporaryBuff(opponent.FightId, new TemporaryCommonAttackDebuff(opponent.FightId));
        }
    }

    //////////////////
    ////Epic Buffs////
    //////////////////
    
    class EpicAllBuff : Buff, ValueBuff
    {
        public EpicAllBuff(int uId) : base(uId)
        {
            rarity = 3;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(2);
            Stats.Add("Attack");
            Values.Add(2);
            Stats.Add("Defense");
            Values.Add(2);
            Stats.Add("Health");
            Values.Add(2);
            Stats.Add("Resistance");
            Values.Add(2);
            Stats.Add("Speed");
            name = "The Quintuple Force";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class EpicAggressivityBuff : Buff, ValueBuff
    {
        public EpicAggressivityBuff(int uId) : base(uId)
        {
            rarity = 3;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(10);
            Stats.Add("Attack");
            Values.Add(-3);
            Stats.Add("Health");
            name = "Aggressivity";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

    class EpicAbsoluteNullify : Buff, NullifyDoubleStrikeCharacter, NullifyDoubleStrikeOpponent
    {
        public EpicAbsoluteNullify(int uId) : base(uId)
        {
            rarity = 3;
            name = "Absolute Nullify";
        }

        public bool CheckNullifyDoubleStrikeCharacter(Fight fight, Character opponent)
        {
            return true;
        }

        public bool CheckNullifyDoubleStrikeOpponent(Fight fight, Character opponent)
        {
            return true;
        }
    }

    class EpicBerserk : Buff, DoubleStrike, ConditionalBuff, ValueBuff
    {
        public EpicBerserk(int uId) : base(uId)
        {
            rarity = 3;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(7);
            Stats.Add("Attack");
            name = "Berserk";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }

        public bool CheckConditionalBuff(Fight fight, Character opponent)
        {
            if (fight.SearchByFightId(unitId).FightHealth <= fight.SearchByFightId(unitId).GetTotalStat(fight, opponent, "Health")/4) return true;
            else return false;
        }

        public bool CheckDoubleStrike(Fight fight, Character opponent)
        {
            if (fight.SearchByFightId(unitId).FightHealth <= fight.SearchByFightId(unitId).GetTotalStat(fight, opponent, "Health")/4) return true;
            else return false;
        }
    }

    class EpicPerfectCondition : Buff, DoubleStrike, ConditionalBuff, ValueBuff
    {
        public EpicPerfectCondition(int uId) : base(uId)
        {
            rarity = 3;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(5);
            Stats.Add("Attack");
            Values.Add(5);
            Stats.Add("Speed");
            name = "Perfect Condition";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }

        public bool CheckConditionalBuff(Fight fight, Character opponent)
        {
            return (fight.SearchByFightId(unitId).FightHealth == fight.SearchByFightId(unitId).GetTotalStat(fight, fight.SearchByFightId(unitId), "Health"));
        }

        public bool CheckDoubleStrike(Fight fight, Character opponent)
        {
            return (fight.SearchByFightId(unitId).FightHealth == fight.SearchByFightId(unitId).GetTotalStat(fight, fight.SearchByFightId(unitId), "Health"));
        }
    }

    ///////////////////////
    ////Legendary Buffs////
    ///////////////////////

    class LegendaryKeepMovingForward : Buff, ConditionalBuff, ValueBuff
    {
        public LegendaryKeepMovingForward(int uId) : base(uId)
        {
            rarity = 4;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(1);
            Stats.Add("MaxMovement");
            name = "Keep Moving Forward";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }

        public bool CheckConditionalBuff(Fight fight, Character opponent)
        {
            if (fight.SearchByFightId(unitId).FightHealth >= fight.SearchByFightId(unitId).GetTotalStat(fight, opponent, "Health")/4) return true;
            else return false;
        }
    }

    class LegendaryJokersGamble : Buff, ConditionalBuff, ValueBuff
    {
        public LegendaryJokersGamble(int uId) : base(uId)
        {
            rarity = 4;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(4);
            Stats.Add("Attack");
            Values.Add(4);
            Stats.Add("Defense");
            Values.Add(4);
            Stats.Add("Resistance");
            Values.Add(4);
            Stats.Add("Speed");
            name = "Joker's Gamble";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }

        public bool CheckConditionalBuff(Fight fight, Character opponent)
        {
            return (fight.CheckAlliedCharacterNSpace(unitId, 2) >= 1);
        }
    }

    class LegendaryJokersCopy : Buff, ValueBuff, ConditionalValueBuff, ConditionalBuff
    {
        public LegendaryJokersCopy(int uId) : base(uId)
        {
            rarity = 4;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(0);
            Stats.Add("Attack");
            Values.Add(0);
            Stats.Add("Defense");
            Values.Add(0);
            Stats.Add("Resistance");
            Values.Add(0);
            Stats.Add("Speed");
            name = "Joker's Copy";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }

        public void ActualizeConditionalValues(Fight fight, Character opponent)
        {
            Values[0] = 0;
            Values[1] = 0;
            Values[2] = 0;
            Values[3] = 0;
            List<int> Allies = fight.GetAlliedCharacterNSpace(unitId, 2);
            if (Allies.ToArray().Length > 0)
            {
                foreach(int fightId in Allies)
                {
                    if (fight.SearchByFightId(fightId).Attack > (fight.SearchByFightId(unitId).Attack + Values[0]))           Values[0] = fight.SearchByFightId(fightId).Attack - fight.SearchByFightId(unitId).Attack;
                    if (fight.SearchByFightId(fightId).Defense > (fight.SearchByFightId(unitId).Defense + Values[1]))         Values[1] = fight.SearchByFightId(fightId).Defense - fight.SearchByFightId(unitId).Defense;
                    if (fight.SearchByFightId(fightId).Resistance > (fight.SearchByFightId(unitId).Resistance + Values[2]))   Values[2] = fight.SearchByFightId(fightId).Resistance - fight.SearchByFightId(unitId).Resistance;
                    if (fight.SearchByFightId(fightId).Speed > (fight.SearchByFightId(unitId).Speed + Values[3]) )            Values[3] = fight.SearchByFightId(fightId).Speed - fight.SearchByFightId(unitId).Speed;
                }
            }
        }
        public bool CheckConditionalBuff(Fight fight, Character opponent)
        {
            return (fight.CheckAlliedCharacterNSpace(unitId, 2) >= 1);
        }
    }

}
