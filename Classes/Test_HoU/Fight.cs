using System;
using System.Collections.Generic;
using System.Text;

namespace Test_HoU
{
    class Fight
    {
        //-------------------------------------------------------------------//
        private List<Character> team1;
        public List<Character> Team1 { get => team1; set => team1 = value; }
        private List<Character> team2;
        public List<Character> Team2 { get => team2; set => team2 = value; }
        private int[][] map;
        public int[][] Map { get => map; }                                      // None = 0, Character = [1-997], Obstacle = 998, Wall = 999, Stairs = 1000, Tree = 1001
        private string mapName;
        public string MapName { get => mapName; }
        private int length;
        public int Length { get => length; }
        private int width;
        public int Width { get => width; }
        private bool teamTurn;
        public bool TeamTurn { get => teamTurn; set => teamTurn = value; }
        //-------------------------------------------------------------------//

        public Fight(string mN)
        {
            team1 = new List<Character>();
            team2 = new List<Character>();
            mapName = mN;
            teamTurn = true;
            switch (mN)
            {
                case "Castle1":
                    map = CreateMatrice(8, 12);
                    width = 8;
                    length = 12;
                    break;
                default:
                    map = CreateMatrice(8, 12);
                    width = 8;
                    length = 12;
                    break;
            }
        }

        //-------------------------------------------------------------------//

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
            return null;
        }

        private int[][] CreateMatrice(int w, int l)
        {
            int[][] map = new int[8][];
            for (int i = 0; i < 8; i++)
            {
                map[i] = new int[12];
            }
            return map;
        }

        public int CheckAlliedCharacterNSpace(int FightId, int N)
        {
            int X = SearchByFightId(FightId).X;
            int Y = SearchByFightId(FightId).Y;
            int nbAllies = -1;

            for (int i = X - N; i <= X + N; i++)
            {
                for (int j = Y - N; j <= Y + N; j++)
                {
                    if ((Math.Abs(X - i) + Math.Abs(Y - j) <= N) && i >= 0 && i < width & j >= 0 && j < length) if (map[i][j] >= 1 && map[i][j] <= 997) if (SearchByFightId(map[i][j]).TeamId == SearchByFightId(FightId).TeamId)
                            {
                                nbAllies++;
                            }
                }
            }
            return nbAllies;
        }

        public List<int> GetAlliedCharacterNSpace(int FightId, int N)
        {
            int X = SearchByFightId(FightId).X;
            int Y = SearchByFightId(FightId).Y;
            List<int> Allies = new List<int>();

            for (int i = X - N; i <= X + N; i++)
            {
                for (int j = Y - N; j <= Y + N; j++)
                {
                    if ((Math.Abs(X - i) + Math.Abs(Y - j) <= N) && i >= 0 && i < width & j >= 0 && j < length) if (map[i][j] >= 1 && map[i][j] <= 997) if (SearchByFightId(map[i][j]).TeamId == SearchByFightId(FightId).TeamId)
                            {
                                Allies.Add(map[i][j]);
                            }
                }
            }
            return Allies;
        }

        public bool CheckCanAccessTile(int FightId, int newX, int newY)
        {
            return  CheckMovementTable(FightId, map[newX][newY]);
        }

        public bool CheckCanAccessTileSupport(int FightId, int FightIdAlly, int newX, int newY)
        {
            return CheckMovementTableSupport(FightId, FightIdAlly, map[newX][newY]);
        }

        private bool CheckMovementTable(int FightId, int mapTile)
        {
            switch (SearchByFightId(FightId).MovementType)
            {
                case "Armored":
                case "Infantry":
                case "Flying":
                    return (mapTile == 0 || mapTile == FightId || mapTile == 1000 || mapTile == 1001);
                case "Cavalry":
                    return (mapTile == 0 || mapTile == FightId || mapTile == 1000);
                default:
                    return false;
            }
        }

        private bool CheckMovementTableSupport(int FightId, int FightIdAlly, int mapTile)
        {
            switch (SearchByFightId(FightId).MovementType)
            {
                case "Armored":
                case "Infantry":
                case "Flying":
                    return (mapTile == 0 || mapTile == FightId || mapTile == FightIdAlly || mapTile == 1000 || mapTile == 1001);
                case "Cavalry":
                    return (mapTile == 0 || mapTile == FightId || mapTile == FightIdAlly ||  mapTile == 1000);
                default:
                    return false;
            }
        }

        public bool CheckIsTurn(int FightId)
        {
            int turn;
            if (teamTurn) turn = 1;
            else turn = 2;
            return (SearchByFightId(FightId).TeamId == turn);
        }

        public void AddTemporaryBuff(int FightId, TemporaryBuff buff)
        {
            int i = 0;
            foreach (Character character in team1)
            {
                if (character.FightId == FightId) team1[i].TmpBuffs.Add(buff);
                i++;
            }
            i = 0;
            foreach (Character character in team2)
            {
                if (character.FightId == FightId) team2[i].TmpBuffs.Add(buff);
                i++;
            }
        }

        public void EndOfTurn()
        {
            if (teamTurn) foreach (Character character in team1) character.EndOfTurn();
            else foreach (Character character in team2) character.EndOfTurn();
            teamTurn = !teamTurn;
        }

        public void DebugRefreshPositions()
        {
            foreach (Character character in team1)
            {
                map[character.X][character.Y] = character.FightId;
            }
            foreach (Character character in team2)
            {
                map[character.X][character.Y] = character.FightId;
            }
        }


        //-------------------------------------------------------------------//

        public void InitializeFight()
        {
            AssignFightId();
            AssignTeam();
            InitializeFightStats();
        }

        public void AssignFightId()
        {
            int FightId = 1;
            foreach (Character character in team1)
            {
                Console.WriteLine(character.Name + " has FightID : " + FightId);
                character.FightId = FightId;
                character.SetupFightIdBuffs(FightId);
                FightId++;
            }
            foreach (Character character in team2)
            {
                Console.WriteLine(character.Name + " has FightID : " + FightId);
                character.FightId = FightId;
                character.SetupFightIdBuffs(FightId);
                FightId++;
            }
            Console.WriteLine();
        }

        public void AssignTeam()
        {
            foreach (Character character in team1)
            {
                character.TeamId = 1;
            }
            foreach (Character character in team2)
            {
                character.TeamId = 2;
            }
        }

        public void InitializeFightStats()
        {
            foreach (Character character in team1)
            {
                character.InitializeFightStats(this);
            }
            foreach (Character character in team2)
            {
                character.InitializeFightStats(this);
            }
        }

        //-------------------------------------------------------------------//

        public override string ToString()
        {
            string team1Str = "";
            string team2Str = "";

            foreach (Character character in team1) team1Str += character.ToString() + "\n";
            foreach (Character character in team2) team2Str += character.ToString() + "\n";
            return "//-------------------------------------------------------------------//\n" +
                "Team 1:\n" + 
                team1Str + 
                "//-------------------------------------------------------------------//\n\n" +
                "Team 2:\n" + 
                team2Str + 
                "//-------------------------------------------------------------------//\n";
        }

    }
}
