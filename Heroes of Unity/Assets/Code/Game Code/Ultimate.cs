using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_HoU
{
    public class Ultimate
    {
        //------------------------------------------------//
        protected int unitId;
        public int UnitId { get => unitId; set => unitId = value; }
        protected int cooldown;
        public int Cooldown { get => cooldown; set => cooldown = value; }
        protected int fightCooldown;
        public int FightCooldown { get => fightCooldown; set => fightCooldown = value; }
        protected string name;
        public string Name { get => name; set => name = value; }
        //------------------------------------------------//

        public Ultimate(int uId)
        {
            this.unitId = uId;
            cooldown = 0;
        }

        public override string ToString()
        {
            return name;
        }

        virtual public int LaunchUltimate(Fight fight, Character opponent) { return 0; }
    }

    interface HealingUltimate
    { }

    interface DamageUltimate
    {
    }

}
