using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_HoU
{
    public class CommonSupportSwitch : SupportSkill, MovementSkill
    {
        public CommonSupportSwitch(int uId) : base(uId)
        {
            rarity = 1;
            nameBuff = "Support Switch";
        }

        public bool CheckValidMovement(Fight fight, int allyFightId)
        {
            return (fight.CheckCanAccessTileSupport(unitId, allyFightId, fight.SearchByFightId(allyFightId).X, fight.SearchByFightId(allyFightId).Y) && fight.CheckCanAccessTileSupport(allyFightId, unitId, fight.SearchByFightId(unitId).X, fight.SearchByFightId(unitId).Y)) ;
        }

        public void Move(Fight fight, int allyFightId)
        {
            int tmpX = fight.SearchByFightId(unitId).X;
            int tmpY = fight.SearchByFightId(unitId).Y;

            fight.SearchByFightId(unitId).Move(fight.SearchByFightId(allyFightId).X, fight.SearchByFightId(allyFightId).Y);
            fight.SearchByFightId(fight.SearchByFightId(allyFightId).FightId).Move(tmpX, tmpY);
        }
    }

    public class CommonSupportCrossThrough : SupportSkill, MovementSkill
    {
        public CommonSupportCrossThrough(int uId) : base(uId)
        {
            rarity = 1;
            nameBuff = "Support Cross Through";
        }

        public bool CheckValidMovement(Fight fight, int allyFightId)
        {
            return (fight.CheckCanAccessTile(unitId, (fight.SearchByFightId(allyFightId).X + (fight.SearchByFightId(allyFightId).X- fight.SearchByFightId(unitId).X)), fight.SearchByFightId(allyFightId).Y + (fight.SearchByFightId(allyFightId).Y - fight.SearchByFightId(unitId).Y)));
        }

        public void Move(Fight fight, int allyFightId)
        {
            int tmpX = fight.SearchByFightId(unitId).X;
            int tmpY = fight.SearchByFightId(unitId).Y;

            fight.SearchByFightId(unitId).Move(fight.SearchByFightId(allyFightId).X + (fight.SearchByFightId(allyFightId).X - fight.SearchByFightId(unitId).X), fight.SearchByFightId(allyFightId).Y + (fight.SearchByFightId(allyFightId).Y - fight.SearchByFightId(unitId).Y));
        }
    }

}
