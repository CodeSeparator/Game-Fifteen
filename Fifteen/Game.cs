using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class Game
    {
        int size;
        int[,] map;
        int spacex, spacey;
        static Random rnd = new Random();

        public Game(int size)
        {
            if(size < 2) size = 2;
            if (size > 9) size = 9;
            this.size = size;
            map = new int[size, size];
        }

        public void Start()
        {
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    map[x, y] = CoordsToPos(x, y);
                }
            }
            spacex = size - 1;
            spacey = size - 1;
            map[spacex, spacey] = -1;
        }

        public void Shift(int position)
        {
            int x, y;
            PositionToCoords(position, out x, out y);
            
            if (Math.Abs(spacex - x) + Math.Abs(spacey - y) != 1)
            {
                return;
            }
            
            map[spacex, spacey] = map[x, y];
            map[x, y] = -1;
            spacex = x;
            spacey = y;
        }

        public bool checkNums()
        {
            if (!(spacex == size - 1 && spacey == size - 1)) return false;
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if (!(x == size - 1 && y == size - 1))
                        if (map[x, y] != CoordsToPos(x, y))
                            return false;
                }
            }
            return true;
        }
        public int GetNumber(int position)
        {
            int x, y;
            PositionToCoords(position, out x, out y);
            if (x < 0 || x >= size) return 0;
            if (y < 0 || y >= size) return 0;
            return map[x, y];
        }

        private int CoordsToPos(int x, int y)
        {
            if (x < 0) x = 0;
            if (x > size - 1) x = size - 1;
            if (y < 0) y = 0;
            if (y > size - 1) y = size - 1;
            return y * size + x;
        }

        private void PositionToCoords(int position, out int x, out int y)
        {
            if (position < 0) position = 0;
            if (position > size * size - 1) position = size * size - 1;
            x = position % size;
            y = position / size;
        }

        internal void shiftRand()
        {
            //Shift(rnd.Next(0, size * size));
            int a = rnd.Next(0, 4);
            int x = spacex;
            int y = spacey;
            switch (a)
            {
                case 0: x--; break;
                case 1: x++; break;
                case 3: y--; break;
                case 4: y++; break;
            }
            Shift(CoordsToPos(x, y));
        }
    }
}
