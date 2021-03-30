using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_HoU
{
    class LegendaryAltereonPassive : Passive, DoubleStrike
    {
        public LegendaryAltereonPassive(int uId) : base(uId)
        {
            rarity = 4;
            Values = new List<int>();
            Stats = new List<string>();
            Values.Add(5);
            Stats.Add("Attack");
            name = "Altereon";
        }

        public bool CheckDoubleStrike(Fight fight, Character opponent)
        {
            return fight.CheckIsTurn(unitId);
        }
    }
}
