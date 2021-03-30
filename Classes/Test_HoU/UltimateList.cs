using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_HoU
{
    class Zenith : Ultimate, DamageUltimate, ConditionalValueBuff, ValueBuff
    {
        public Zenith(int uId) : base(uId)
        {
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(0);
            Stats.Add("Health");
            Values.Add(0);
            Stats.Add("Attack");
            Cooldown = 5;
            FightCooldown = 5;
            name = "Zenith";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }

        public override int LaunchUltimate(Fight fight, Character opponent)
        {
            FightCooldown = Cooldown + 1;
            Console.WriteLine(name + " restores " + Values[0] + " hp");
            fight.SearchByFightId(unitId).FightHealth += Values[0];
            if (fight.SearchByFightId(unitId).FightHealth > fight.SearchByFightId(unitId).Health + fight.SearchByFightId(unitId).HealthBuff) fight.SearchByFightId(unitId).FightHealth = fight.SearchByFightId(unitId).Health + fight.SearchByFightId(unitId).FightHealth;
            return Values[1];
        }

        public void ActualizeConditionalValues(Fight fight, Character opponent)
        {
            Values[1] = (int) (fight.SearchByFightId(unitId).Attack * 0.3);      // Damage dealt
            Values[0] = (int) ((fight.SearchByFightId(unitId).GetTotalStat(fight, opponent, "Attack") + Values[1] - opponent.GetBlock(fight, fight.SearchByFightId(unitId), fight.SearchByFightId(unitId).WeaponType))*0.5);
        }
    }

    class PiercingBlow : Ultimate, DamageUltimate, ValueBuff
    {
        public PiercingBlow(int uId) : base(uId)
        {
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(0);
            Stats.Add("Attack");
            Cooldown = 1;
            FightCooldown = 1;
            name = "Piercing Blow";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }

        public override int LaunchUltimate(Fight fight, Character opponent)
        {
            FightCooldown = Cooldown + 1;
            Values[0] = ((int)(opponent.GetBlock(fight, fight.SearchByFightId(unitId), fight.SearchByFightId(unitId).WeaponType) * 0.3));
            return Values[0];
        }
    }

    class Glimmer : Ultimate, DamageUltimate, ValueBuff
    {
        public Glimmer(int uId) : base(uId)
        {
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(0);
            Stats.Add("Attack");
            Cooldown = 2;
            FightCooldown = 2;
            name = "Glimmer";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }

        public override int LaunchUltimate(Fight fight, Character opponent)
        {
            FightCooldown = Cooldown + 1;
            Values[0] = ((int)(fight.SearchByFightId(unitId).Attack * 0.3));
            return Values[0];
        }
    }

}
