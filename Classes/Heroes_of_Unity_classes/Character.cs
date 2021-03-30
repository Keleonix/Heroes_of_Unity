using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes_of_Unity_classes
{
    class Character
    {
        //----------------------------------//
        protected string name;
        public string Name { get => name; }
        protected int id;
        public int Id { get => id; }
        //----------------------------------//
        protected List<Buff> buffs;
        public List<Buff> Buffs { get => buffs; }
        protected List<TemporaryBuff> tmpBuffs;
        public List<TemporaryBuff> TmpBuffs { get => tmpBuffs; }
        protected SupportSkill support;
        public SupportSkill Support { get => support; }
        protected string weaponType;
        public string WeaponType { get => weaponType; }
        protected string movementType;
        public string MovementType { get => movementType; }
        protected string color;
        public string Color { get => color; }
        protected int range;
        public int Range { get => range; }
        //----------------------------------//
        protected int attack;
        public int Attack { get => attack; }
        protected int defense;
        public int Defense { get => defense; }
        protected int resistance;
        public int Resistance { get => resistance; }
        protected int health;
        public int Health { get => health; }
        protected int speed;
        public int Speed { get => speed; }
        protected int maxMovement;
        public int MaxMovement { get => MaxMovement; }
        //----------------------------------//
        public int X { get => X; set => X = value; }
        public int Y { get => Y; set => Y = value; }
        public int Movement { get => Movement; set => Movement = value; }
        public int FightId { get; set; }
        public int FightHealth { get; set; }
        //----------------------------------//

        public Character()
        {
            name = "";
            id = -1;
            weaponType = "Melee";
            movementType = "Infantry";
            color = "Grey";
            range = -1;
            attack = 0;
            defense = 0;
            health = 0;
            resistance = 0;
            speed = 0;
            maxMovement = 0;
            X = 0;
            Y = 0;
            Movement = 0;
        }

        //----------------------------------//
        public void AttackCharacter(Character opponent) // Include map for debuffs
        {
            int numberStrikes = 1;
            int numberStrikesOpponent = 1;
            bool priority = true;

            if (speed >= opponent.Speed + 5 || (CheckDoubleStrike() && !opponent.CheckNullifyDoubleStrikeOpponent())) numberStrikes = 2;
            if (speed + 5 <= opponent.Speed || (opponent.CheckDoubleStrike() && !CheckNullifyDoubleStrikeOpponent())) numberStrikesOpponent = 2;

            // First Strike
            if (priority && numberStrikes >= 1) InflictDamage(opponent);
            else if (!priority && numberStrikesOpponent >= 1) opponent.InflictDamage(this);

            if (opponent.IsDead() || IsDead())
            {
                EndOfFightDebuff(opponent);
                opponent.EndOfFightDebuff(this);
                return;
            }

            // Second Strike
            if (!priority && numberStrikes >= 1) InflictDamage(opponent);
            else if (priority && numberStrikesOpponent >= 1) opponent.InflictDamage(this);

            if (opponent.IsDead() || IsDead())
            {
                EndOfFightDebuff(opponent);
                opponent.EndOfFightDebuff(this);
                return;
            }

            // Third Strike
            if (priority && numberStrikes >= 2) InflictDamage(opponent);
            else if (!priority && numberStrikesOpponent >= 2) opponent.InflictDamage(this);

            if (opponent.IsDead() || IsDead())
            {
                EndOfFightDebuff(opponent);
                opponent.EndOfFightDebuff(this);
                return;
            }

            // Fourth Strike
            if (!priority && numberStrikes >= 2) InflictDamage(opponent);
            else if (priority && numberStrikesOpponent >= 2) opponent.InflictDamage(this);

            if (opponent.IsDead() || IsDead())
            {
                EndOfFightDebuff(opponent);
                opponent.EndOfFightDebuff(this);
                return;
            }
        }

        public void AttackObstacle(Obstacle obstacle)   // Done
        {
            if (obstacle.Health > 0) obstacle.Health = obstacle.Health-1;
        }

        public void InflictDamage(Character opponent)   // Done
        {
            bool defType;

            switch (WeaponType)
            {
                case "Tome":
                case "Breath":
                case "Rod":
                    defType = false;
                    break;
                default:
                    defType = true;
                    break;
            }

            opponent.FightHealth -= (GetDamage()-opponent.GetBlock(defType));
            if (opponent.FightHealth <= 0) opponent.FightHealth = 0;
        }

        public bool CheckDoubleStrike()
        {
            bool check = false;
            foreach (Buff buff in Buffs)
            {
                /*if (buff.GetType().IsAssignableFrom(DoubleStrike))
                {
                    check = true;
                    break;
                }*/
            }
            return check;
        }

        public bool CheckNullifyDoubleStrikeOpponent()
        {
            bool check = false;
            foreach (Buff buff in Buffs)
            {
                /*if (buff.GetType().IsAssignableFrom(NullifyDoubleStrikeOpponent))
                {
                    check = true;
                    break;
                }*/
            }
            return check;
        }

        public int GetDamage()
        {
            int damage = attack;
            foreach (Buff buff in Buffs)
            {
                //Check the number off buffs + which value modifies attack and add it
            }
            return damage;
        }

        public int GetBlock(bool defType)
        {
            int block;
            if (defType) block = defense;
            else block = resistance;
            foreach (Buff buff in Buffs)
            {
                //Check the number off buffs + which value modifies def/res and add it
            }
            return block;
        }

        public bool IsDead()    // Done
        {
            if (health <= 0) return true;
            else return false;
        }

        public void EndOfFightDebuff(Character opponent)
        {

        }

        public int Distance(Character character)    // Done
        {
            return (Math.Abs(X-character.X) + Math.Abs(Y-character.Y));
        }

        public bool IsReachable(Character opponent) // Done
        {
            if (Distance(opponent) == range) return true;
            else return false;
        }

        public void StartOfTurnReset()
        {
            Movement = maxMovement - CheckMovementDebuff();
            // Decrement every TemporaryBuffs
        }

        //----------------------------------//

        public override string ToString()
        {
            return name + "\nAttack:" + attack + "\nDefense" + defense + "\nHealth" + health + "\nResistance" + resistance + "\nSpeed" + speed + "\n";
        }

        //----------------------------------//

        private int CheckMovementDebuff()
        {
            int debuff = 0;
            // check every debuff
            return debuff;
        }

    }
}
