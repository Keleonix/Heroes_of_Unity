using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Test_HoU
{

    public class Program : ScriptableObject
    {
        public void Main()
        {
            Fight fight = new Fight("Forest1");
            fight.Team1.Add(new Vesperz());
            fight.Team1.Add(new Keleonix());
            fight.Team2.Add(new Haankhes());

            fight.InitializeFight();

            fight.Team1[0].X = 2;
            fight.Team1[1].X = 1;
            fight.DebugRefreshPositions();

            Debug.Log(fight);

            fight.Team1[1].SupportCharacter(fight, fight.Team1[0]);

            Debug.Log(fight);

        }

        public void Awake()
        {
            Debug.Log("Awake");
        }

        public void OnDestroy()
        {
            Debug.Log("OnDestroy");
        }
    }

}
