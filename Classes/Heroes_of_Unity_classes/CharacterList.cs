using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes_of_Unity_classes
{
    class Keleonix : Character
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
            buffs.Add(new EpicAbsoluteNullify(id));
            buffs.Add(new RareDefenseResistanceBuff(Id));
            //----------------------------//
            support = new SupportSkill();
            //----------------------------//
            tmpBuffs = new List<TemporaryBuff>();
            //----------------------------//
        }

    }

    class Haankhes : Character
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
            health = 40;
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
            buffs.Add(new RareAttackSpeedBuff(Id));
            //----------------------------//
            support = new SupportSkill();
            //----------------------------//
            tmpBuffs = new List<TemporaryBuff>();
            //----------------------------//
        }
    }
}
