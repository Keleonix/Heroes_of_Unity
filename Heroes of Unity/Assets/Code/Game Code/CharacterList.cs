using System;
using System.Collections.Generic;
using System.Text;

namespace Test_HoU
{
    public class Keleonix : Character
    {
        public Keleonix() : base()
        {
            name = "Keleonix";
            id = 0;
            weaponType = "Breath";
            movementType = "Armored";
            color = "Red";
            range = 1;
            maxMovement = 1;
            //----------------------------//
            attack = 61;
            defense = 43;
            health = 46;
            resistance = 35;
            speed = 16;
            //----------------------------//
            X = 0;
            Y = 0;
            Movement = 0;
            FightHealth = health;
            //----------------------------//
            buffs = new List<Buff>();
            buffs.Add(new EpicAbsoluteNullify(Id));
            buffs.Add(new RareDefenseResistanceBuff(Id));
            buffs.Add(new LegendaryKeepMovingForward(Id));
            //----------------------------//
            ulti = new Zenith(Id);
            //----------------------------//
            support = new CommonSupportCrossThrough(Id);
            //----------------------------//
            tmpBuffs = new List<TemporaryBuff>();
            //----------------------------//
        }

    }

    public class Haankhes : Character
    {
        public Haankhes() : base()
        {
            name = "Haankhes";
            id = 1;
            weaponType = "Archer";
            movementType = "Infantry";
            color = "Grey";
            range = 2;
            maxMovement = 2;
            //----------------------------//
            attack = 36;
            defense = 16;
            health = 41;
            resistance = 21;
            speed = 42;
            //----------------------------//
            X = 0;
            Y = 0;
            Movement = 0;
            FightHealth = health;
            //----------------------------//
            buffs = new List<Buff>();
            buffs.Add(new EpicPerfectCondition(id));
            buffs.Add(new EpicAggressivityBuff(id));
            buffs.Add(new RareAttackSpeedBuff(Id));
            //----------------------------//
            ulti = new PiercingBlow(Id);
            //----------------------------//
            support = new CommonSupportSwitch(Id);
            //----------------------------//
            tmpBuffs = new List<TemporaryBuff>();
            //----------------------------//
        }
    }

    public class Vesperz : Character
    {
        public Vesperz() : base()
        {
            name = "Vesperz";
            id = 2;
            weaponType = "Tome";
            movementType = "Infantry";
            color = "Grey";
            range = 2;
            maxMovement = 2;
            //----------------------------//
            attack = 30;
            defense = 25;
            health = 47;
            resistance = 30;
            speed = 34;
            //----------------------------//
            X = 0;
            Y = 0;
            Movement = 0;
            FightHealth = health;
            //----------------------------//
            buffs = new List<Buff>();
            buffs.Add(new LegendaryJokersGamble(id));
            buffs.Add(new LegendaryJokersCopy(id));
            //----------------------------//
            ulti = new Glimmer(Id);
            //----------------------------//
            support = new CommonSupportSwitch(Id);
            //----------------------------//
            tmpBuffs = new List<TemporaryBuff>();
            //----------------------------//
        }
    }

}
