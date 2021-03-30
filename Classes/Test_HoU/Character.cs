using System;
using System.Collections.Generic;
using System.Text;

namespace Test_HoU
{
    class Character
    {
        //----------------------------------//
        protected string name;
        public string Name { get => name; }
        protected int id;
        public int Id { get => id; }
        //----------------------------------//
        protected Passive passif;
        public Passive Passif { get => passif; set => passif = value; }
        protected List<Buff> buffs;
        public List<Buff> Buffs { get => buffs; }
        protected List<TemporaryBuff> tmpBuffs;
        public List<TemporaryBuff> TmpBuffs { get => tmpBuffs; }
        protected SupportSkill support;
        public SupportSkill Support { get => support; }
        protected Ultimate ulti;
        public Ultimate Ulti { get => ulti; set => ulti = value; }
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
        protected int attackBuff;
        public int AttackBuff { get => attackBuff; }
        protected int defenseBuff;
        public int DefenseBuff { get => defenseBuff; }
        protected int resistanceBuff;
        public int ResistanceBuff { get => resistanceBuff; }
        protected int healthBuff;
        public int HealthBuff { get => healthBuff; }
        protected int speedBuff;
        public int SpeedBuff { get => speedBuff; }
        protected int maxMovementBuff;
        public int MaxMovementBuff { get => MaxMovementBuff; }
        //----------------------------------//
        public int X;
        public int Y;
        public int Movement;
        public int FightId;
        public int FightHealth;
        public int TeamId;
        //----------------------------------//

        /////////////////////////////
        ////////Constructeurs////////
        /////////////////////////////

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

        ///////////////////////
        ////////Actions////////
        ///////////////////////
        public void AttackCharacter(Fight fight, Character opponent) // Include map for debuffs
        {
            int numberStrikes = 1;
            int numberStrikesOpponent = 1;
            int fightSpeed = GetTotalStat(fight, opponent, "Speed");
            int fightSpeedOpponent = opponent.GetTotalStat(fight, this, "Speed");
            bool priority = true;
            bool counterAttack = false;

            if (opponent.IsDead() || IsDead())
            {
                ApplyEndOfCombatEffects(fight, opponent);
                return;
            }

            if ((CheckDoubleStrike(fight, opponent) || fightSpeed >= fightSpeedOpponent + 5) && !(opponent.CheckNullifyDoubleStrikeOpponent(fight, opponent) || CheckNullifyDoubleStrikeCharacter(fight, opponent))) numberStrikes = 2;
            if ((opponent.CheckDoubleStrike(fight, opponent) || fightSpeed + 5 <= fightSpeedOpponent) && !(CheckNullifyDoubleStrikeOpponent(fight, opponent) || opponent.CheckNullifyDoubleStrikeCharacter(fight, opponent))) numberStrikesOpponent = 2;
            if (fightSpeedOpponent > fightSpeed) priority = false;
            if (opponent.IsReachable(this)) counterAttack = true;

            if (counterAttack)
            {
                // First Strike
                if (priority && numberStrikes >= 1)
                {
                    Console.WriteLine(name + " strikes first!\n");
                    InflictDamage(fight, opponent);
                }
                else if (!priority && numberStrikesOpponent >= 1)
                {
                    Console.WriteLine("Opponent " + opponent.name + " strikes first!\n");
                    opponent.InflictDamage(fight, this);
                }

                if (opponent.IsDead() || IsDead())
                {
                    ApplyEndOfCombatEffects(fight, opponent);
                    opponent.ApplyEndOfCombatEffects(fight, this);
                    return;
                }

                // Second Strike
                if (!priority && numberStrikes >= 1)
                {
                    Console.WriteLine(name + " follows up!\n");
                    InflictDamage(fight, opponent);
                }
                else if (priority && numberStrikesOpponent >= 1)
                {
                    Console.WriteLine("Opponent " + opponent.name + " follows up!\n");
                    opponent.InflictDamage(fight, this);
                }

                if (opponent.IsDead() || IsDead())
                {
                    ApplyEndOfCombatEffects(fight, opponent);
                    opponent.ApplyEndOfCombatEffects(fight, this);
                    return;
                }

                // Third Strike
                if (priority && numberStrikes >= 2)
                {
                    Console.WriteLine(name + " uses his/her second strike!\n");
                    InflictDamage(fight, opponent);
                }
                else if (!priority && numberStrikesOpponent >= 2)
                {
                    Console.WriteLine("Opponent " + opponent.name + " uses his/her second strike!\n");
                    opponent.InflictDamage(fight, this);
                }

                if (opponent.IsDead() || IsDead())
                {
                    ApplyEndOfCombatEffects(fight, opponent);
                    opponent.ApplyEndOfCombatEffects(fight, this);
                    return;
                }

                // Fourth Strike
                if (!priority && numberStrikes >= 2)
                {
                    Console.WriteLine(name + " uses his/her second strike!\n");
                    InflictDamage(fight, opponent);
                }
                else if (priority && numberStrikesOpponent >= 2)
                {
                    Console.WriteLine("Opponent " + opponent.name + " uses his/her second strike!\n");
                    opponent.InflictDamage(fight, this);
                }

                ApplyEndOfCombatEffects(fight, opponent);
                opponent.ApplyEndOfCombatEffects(fight, this);
            }
            else
            {
                // First Strike
                if (numberStrikes >= 1)
                {
                    Console.WriteLine(name + " strikes first!\n");
                    InflictDamage(fight, opponent);
                }

                if (opponent.IsDead() || IsDead())
                {
                    ApplyEndOfCombatEffects(fight, opponent);
                    return;
                }

                // Second Strike
                if (numberStrikes >= 2)
                {
                    Console.WriteLine(name + " uses his/her second strike!\n");
                    InflictDamage(fight, opponent);
                }

                ApplyEndOfCombatEffects(fight, opponent);
            }
        }

        public void AttackObstacle(Obstacle obstacle)   // Done
        {
            Console.WriteLine(name + " attacks an obstacle!\n");
            if (obstacle.Health > 0) obstacle.Health = obstacle.Health-1;
        }

        public void Move(int newX, int newY)
        {
            X = newX;
            Y = newY;
        }

        public void SupportCharacter(Fight fight, Character ally)
        {
            Console.WriteLine(name + " supports " + ally.name + "\n");
            if (support is MovementSkill)
            {
                if ((support as MovementSkill).CheckValidMovement(fight, ally.FightId)) (support as MovementSkill).Move(fight, ally.FightId);
            }
        }

        public void InflictDamage(Fight fight, Character opponent)   // Done
        {
            bool defType;
            double typeAdvantage = 1;
            int damage;
            int block;

            defType = GetBlockType(WeaponType);
            typeAdvantage = GetTypeAdvantage(opponent);

            damage = GetTotalStat(fight, opponent, "Attack") + UltimateBonus(fight, opponent);
            block = opponent.GetBlock(fight, opponent, WeaponType);

            Console.WriteLine(name + ": " + damage + " | " + opponent.Name + ": " + block);

            damage = ((int) ((damage - block) * typeAdvantage));

            Ulti.FightCooldown--;
            
            if (Ulti.FightCooldown < 0) Ulti.FightCooldown = 0;
            if (damage <= 0) damage = 0;

            Console.WriteLine(name + " deals " + damage + " damages to " + opponent.Name + "\n");

            opponent.FightHealth -= damage;
            opponent.Ulti.FightCooldown--;
            if (opponent.Ulti.FightCooldown < 0) opponent.Ulti.FightCooldown = 0;

            if (opponent.FightHealth <= 0) opponent.FightHealth = 0;
        }

        //////////////////////////
        ////////CheckStats////////
        //////////////////////////
        
        public void InitializeFightStats(Fight fight)
        {
            attackBuff = GetBuffs("Attack");
            defenseBuff = GetBuffs("Defense");
            healthBuff = GetBuffs("Health");
            resistanceBuff = GetBuffs("Resistance");
            speedBuff = GetBuffs("Speed");
            maxMovementBuff = GetBuffs("MaxMovement");

            FightHealth = health + healthBuff;
        }

        public int GetBuffs(string buffType)
        {
            int buffValue = 0;
            foreach (Buff buff in Buffs)
            {
                if (buff is ValueBuff && !(buff is ConditionalBuff))
                {
                    for(int i = 0; i < (buff as ValueBuff).Stats.ToArray().Length; i++)
                    {
                        if ((buff as ValueBuff).Stats[i] == buffType)
                        {
                            buffValue += (buff as ValueBuff).Values[i];
                            Console.WriteLine(buff.ToString() + " adds " + (buff as ValueBuff).Values[i] + " " + buffType + " to " + name + "\n");
                        }
                    }
                }
            }
            foreach (Buff buff in TmpBuffs)
            {
                if (buff is ValueBuff)
                {
                    for (int i = 0; i < (buff as ValueBuff).Stats.ToArray().Length; i++)
                    {
                        if ((buff as ValueBuff).Stats[i] == buffType)
                        {
                            buffValue += (buff as ValueBuff).Values[i];
                            Console.WriteLine(buff.ToString() + " adds " + (buff as ValueBuff).Values[i] + " " + buffType + " to " + name + "\n");
                        }
                    }
                }
            }
            return buffValue;
        }

        public int GetConditionnalBuffs(Fight fight, Character opponent, string buffType)
        {
            int buffValue = 0;
            if (Buffs != null)
            {
                foreach (Buff buff in Buffs)
                {
                    if (buff is ValueBuff && buff is ConditionalBuff)
                    {
                        if ((buff as ConditionalBuff).CheckConditionalBuff(fight, opponent))
                        {
                            for (int i = 0; i < (buff as ValueBuff).Stats.ToArray().Length; i++)
                            {
                                if ((buff as ValueBuff).Stats[i] == buffType)
                                {
                                    if (buff is ConditionalValueBuff) (buff as ConditionalValueBuff).ActualizeConditionalValues(fight, opponent);
                                    buffValue += (buff as ValueBuff).Values[i];
                                    Console.WriteLine("Conditions are met for " + buff.ToString() + ", it adds " + (buff as ValueBuff).Values[i] + " " + buffType + " to " + name + "\n");
                                }
                            }
                        }
                    }
                }
            }
            return buffValue;
        }

        public int GetTemporaryBuffs(Fight fight, Character opponent, string buffType)
        {
            int buffValue = 0;
            bool check = true;
            if (TmpBuffs != null)
            {
                foreach (TemporaryBuff buff in TmpBuffs)
                {
                    if (buff is ValueBuff)
                    {
                        for (int i = 0; i < (buff as ValueBuff).Stats.ToArray().Length; i++)
                        {
                            if (buff is ConditionalBuff) check = (buff as ConditionalBuff).CheckConditionalBuff(fight, opponent);
                            if ((buff as ValueBuff).Stats[i] == buffType && check)
                            {
                                if (buff is ConditionalValueBuff) (buff as ConditionalValueBuff).ActualizeConditionalValues(fight, opponent);
                                buffValue += (buff as ValueBuff).Values[i];
                                Console.WriteLine("Conditions are met for " + buff.ToString() + ", it adds " + (buff as ValueBuff).Values[i] + " " + buffType + " to " + name + "\n");
                            }
                        }
                    }
                }
            }
            return buffValue;
        }

        public int GetTotalStat(Fight fight, Character opponent, string buffType)
        {
            switch (buffType)
            {
                case "Attack":
                    return attack + attackBuff + GetConditionnalBuffs(fight, opponent, buffType) + GetTemporaryBuffs(fight, opponent, buffType);
                case "Defense":
                    return defense + defenseBuff + GetConditionnalBuffs(fight, opponent, buffType) + GetTemporaryBuffs(fight, opponent, buffType);
                case "Health":
                    return health + healthBuff + GetTemporaryBuffs(fight, opponent, buffType);
                case "Resistance":
                    return resistance + resistanceBuff + GetConditionnalBuffs(fight, opponent, buffType) + GetTemporaryBuffs(fight, opponent, buffType);
                case "Speed":
                    return speed + speedBuff + GetConditionnalBuffs(fight, opponent, buffType) + GetTemporaryBuffs(fight, opponent, buffType);
                case "MaxMovement":
                    return maxMovement + maxMovementBuff + GetConditionnalBuffs(fight, opponent, buffType) + GetTemporaryBuffs(fight, opponent, buffType);
                default:
                    return 0;
            }
        }

        public int GetBlock(Fight fight, Character opponent, string opponentWeaponType)
        {
            bool defType = GetBlockType(opponentWeaponType);

            if (defType) return defense + defenseBuff + GetConditionnalBuffs(fight, opponent, "Defense");
            else return resistance + resistanceBuff + GetConditionnalBuffs(fight, opponent, "Resistance");
        }

        public bool GetBlockType(string WeaponType)
        {
            switch (WeaponType)
            {
                case "Tome":
                case "Breath":
                case "Rod":
                    return false;
                default:
                    return true;
            }
        }

        public double GetTypeAdvantage(Character opponent)
        {
            switch (Color)
            {
                case "Red":
                    if (opponent.Color == "Blue") return 0.5;
                    else if (opponent.Color == "Green") return 2;
                    break;
                case "Blue":
                    if (opponent.Color == "Green") return 0.5;
                    else if (opponent.Color == "Red") return 2;
                    break;
                case "Green":
                    if (opponent.Color == "Red") return 0.5;
                    else if (opponent.Color == "Blue") return 2;
                    break;
                default:
                    return 1;
            }
            return 1;
        }

        ///////////////////////////
        ////////CheckSkills////////
        ///////////////////////////

        public int UltimateBonus(Fight fight, Character opponent)
        {
            int buffValue = 0;
            if (ulti.FightCooldown <= 0)
            {
                if (ulti is ConditionalValueBuff) (ulti as ConditionalValueBuff).ActualizeConditionalValues(fight, opponent);
                buffValue = ulti.LaunchUltimate(fight, opponent);

                if (ulti is ValueBuff && ulti is ConditionalBuff)
                {
                    Console.WriteLine("Conditions are met for " + ulti.ToString() + ", it adds " + buffValue + " Attack to " + name + "\n");
                }
                else if (ulti is ValueBuff)
                {
                    Console.WriteLine(ulti.ToString() + " adds " + buffValue + " Attack to " + name + "\n");
                }
            }
            return buffValue;
        }

        public bool CheckDoubleStrike(Fight fight, Character opponent)
        {
            bool check = false;
            foreach (Buff buff in Buffs)
            {
                if (buff is DoubleStrike)
                {
                    check = (buff as DoubleStrike).CheckDoubleStrike(fight, opponent);
                    if (check) Console.WriteLine(name + " gains a double strike with " + buff.ToString() + "!\n");
                    return check;
                }
            }
            return check;
        }

        public bool CheckNullifyDoubleStrikeOpponent(Fight fight, Character opponent)
        {
            bool check = false;
            foreach (Buff buff in Buffs)
            {
                if (buff is NullifyDoubleStrikeOpponent)
                {
                    check = (buff as NullifyDoubleStrikeOpponent).CheckNullifyDoubleStrikeOpponent(fight, opponent);
                    if (check) Console.WriteLine(name + " nullifies opponent double strike with " + buff.ToString() + "!\n");
                    return check;
                }
            }
            return check;
        }

        public bool CheckNullifyDoubleStrikeCharacter(Fight fight, Character opponent)
        {
            bool check = false;
            foreach (Buff buff in Buffs)
            {
                if (buff is NullifyDoubleStrikeCharacter)
                {
                    check = (buff as NullifyDoubleStrikeCharacter).CheckNullifyDoubleStrikeCharacter(fight, opponent);
                    if (check) Console.WriteLine(name + " nullifies self double strike with " + buff.ToString() + "!\n");
                    return check;
                }
            }
            return check;
        }

        public void ApplyEndOfCombatEffects(Fight fight, Character opponent)
        {
            foreach (Buff buff in Buffs)
            {
                if (buff is EndOfCombatEffect)
                {
                    (buff as EndOfCombatEffect).ApplyEndOfCombatEffect(fight, opponent);
                    Console.WriteLine(buff.ToString() + " adds " + (buff as EndOfCombatEffect).effectName + " to " + (buff as EndOfCombatEffect).TargetOfEffect + "\n");
                }
            }
        }

        public void EndOfTurn()
        {
            foreach (TemporaryBuff buff in TmpBuffs)
            {
                buff.DecrementCooldown();
                if (buff.CheckEndOfEffect()) TmpBuffs.Remove(buff);
            }
        }

        //////////////////////////
        ////////UnitStatus////////
        //////////////////////////

        public bool IsDead()    // Done
        {
            if (FightHealth < 0) FightHealth = 0;
            if (FightHealth == 0) return true;
            else return false;
        }

        public int Distance(Character character)    // Done
        {
            return (Math.Abs(X - character.X) + Math.Abs(Y - character.Y));
        }

        public bool IsReachable(Character opponent) // Done
        {
            if (Distance(opponent) == range) return true;
            else return false;
        }

        public void StartOfTurnReset()
        {
            // Decrement every TemporaryBuffs
        }

        public void SetupFightIdBuffs(int FightId)
        {
            foreach(Buff buff in buffs)
            {
                buff.UnitId = FightId;
            }
            passif.UnitId = FightId;
            support.UnitId = FightId;
            ulti.UnitId = FightId;
        }

        ////////////////////////
        ////////Override////////
        ////////////////////////

        public override string ToString()
        {
            return name + " | Current HP : " + FightHealth + " | Ultimate Status : " + Ulti.FightCooldown + " | X/Y : " + X + "/" + Y + " | TeamId :" + TeamId +
                "\nAttack:" + attack + "\t| BuffAttack:" + AttackBuff + "\nDefense:" + defense + "\t| BuffDefense:" + DefenseBuff + 
                "\nHealth:" + health + "\t| BuffHealth:" + HealthBuff + "\nRes:" + resistance + "\t\t| BuffRes:" + ResistanceBuff + 
                "\nSpeed:" + speed + "\t| BuffSpeed:" + SpeedBuff + "\n" + "Number of Temporary Buffs : " + tmpBuffs.ToArray().Length + "\n";
        }

        ///////////////////////
        ////////Private////////
        ///////////////////////

    }
}
