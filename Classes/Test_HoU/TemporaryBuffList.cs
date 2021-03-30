using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_HoU
{
    class TemporaryCommonAttackDebuff : TemporaryBuff, ValueBuff
    {
        public TemporaryCommonAttackDebuff(int uId) : base(uId)
        {
            rarity = 1;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(-5);
            Stats.Add("Attack");
            countdown = 1;
            name = "Temporary Common Attack Debuff";
        }

        public List<int> Values { get; }
        public List<string> Stats { get; }
    }

}
