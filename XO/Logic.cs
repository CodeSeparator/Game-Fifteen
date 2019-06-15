using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
{
    class Logic
    {
        int[,] map = new int[3, 3];// 0 - empty, 1 - X, 2 - 0
        public int side { get; private set; }
        bool play;
        int step;
        public string finish;
        public Logic()
        {
            Init();
        }

        public void Init()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    map[x, y] = 0;
                }
            }
            side = 1;
            play = true;
            step = 0;
        }
        public bool Place(int x, int y)
        {
            if (!play) return false;
            if (x < 0 || x > 2 || y < 0 || y > 2)
                return false;
            if (map[x, y] > 0) return false;
            map[x, y] = side;
            step++;
            finish = Finish(x, y);
            side = 3 - side;
            return true;
        }
        private string Finish(int x, int y)
        {
            bool win = false;
            if (map[x, 0] == side && map[x, 1] == side && map[x, 2] == side) win = true;
            if (map[0, y] == side && map[1, y] == side && map[2, y] == side) win = true;
            if (map[0, 0] == side && map[1, 1] == side && map[2, 2] == side) win = true;
            if (map[2, 0] == side && map[1, 1] == side && map[0, 2] == side) win = true;
            if (win)
            {
                if (side == 1)
                {
                    play = false;
                    return "winx";
                }

                else
                {
                    play = false;
                    return "wino";

                }
            }
            else
            {
                if (step == 9)
                    return "draw";
                else return "play";
            }
        }
    }
}
