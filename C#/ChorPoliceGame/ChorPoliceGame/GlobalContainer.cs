using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChorPoliceGame
{
    public class GlobalContainer
    {
        public const int TOTAL_PLAYERS = 4;
        public enum Roles { DAROGA, POLICE, DAKAT, CHOR, HABILDAR, POCKETMAR};
        public struct Player
        {
            public string name;
            public string points;
        }
        public Player[] players;


        public int[,] chitSl = 
            {{0,1,2,3}, {0,1,3,2}, {0,2,1,3}, {0,2,3,1}, {0,3,1,2}, {0,3,2,1},
                        {1,0,2,3}, {1,0,3,2}, {1,2,0,3}, {1,2,3,0}, {1,3,0,2}, {1,3,2,0},
                        {2,0,1,3}, {2,0,3,1}, {2,1,0,3}, {2,1,3,0}, {2,3,0,1}, {2,3,1,0},
                        {3,0,1,2}, {3,0,2,1}, {3,1,0,2}, {3,1,2,0}, {3,2,0,1}, {3,2,1,0}
                         };


        public GlobalContainer() {
            players = new Player[TOTAL_PLAYERS];
        }


    }
}
