using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes_of_Unity_classes
{
    class Fight
    {
        //-------------------------------------------------------------------//
        private List<Character> team1;
        public List<Character> Team1 { get => team1; set => team1 = value; }
        private List<Character> team2;
        public List<Character> Team2 { get => team2; set => team2 = value; }
        //-------------------------------------------------------------------//

        public void AssignFightId()
        {
            int FightId = 0;
            foreach (Character character in team1)
            {
                character.FightId = FightId++;
            }
            foreach (Character character in team2)
            {
                character.FightId = FightId++;
            }
        }

        public Character SearchByFightId(int FightId)
        {
            foreach (Character character in team1)
            {
                if(character.FightId == FightId) return character;
            }
            foreach (Character character in team2)
            {
                if (character.FightId == FightId) return character;
            }
            return new Character();
        }

    }
}
