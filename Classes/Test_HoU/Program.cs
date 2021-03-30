using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_HoU
{
    class Program
    {
        static void Main(string[] args)
        {
            Fight fight = new Fight("Castle1");
            fight.Team1.Add(new Vesperz());
            fight.Team1.Add(new Keleonix());
            fight.Team2.Add(new Haankhes());

            fight.InitializeFight();

            fight.Team1[0].X = 2;
            fight.Team1[1].X = 1;
            fight.DebugRefreshPositions();

            Console.WriteLine(fight);

            fight.Team1[1].SupportCharacter(fight, fight.Team1[0]);

            Console.WriteLine(fight);

            Console.ReadLine();
        }
    }

}
