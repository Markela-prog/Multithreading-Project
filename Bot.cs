using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingProject
{
    internal class Bot
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        
        public Bot(int x, int y, char[,] map)
        {
            X = x;
            Y = y;
            
        }

        public void Move(char[,] map)
        {
            while (true)
            {
                int[] direction = GetRandomDirection();

                int nextPositionX = X + direction[0];
                int nextPositionY = Y + direction[1];

                char nextPosition = map[nextPositionX, nextPositionY];

                if (nextPosition == ' ' || nextPosition == 'X' || nextPosition == 'o')
                {
                    X = nextPositionX;
                    Y = nextPositionY;
                }
                Thread.Sleep(500);
            }
        }

        private int[] GetRandomDirection()
        {
            Random random = new Random();
            int[] direction = { 0, 0 };
            int rand = random.Next(1, 5);
            if (rand == 1)
            {
                direction[0] = -1;
            }
            else if (rand == 2)
            {
                direction[0] = 1;
            }
            else if (rand == 3)
            {
                direction[1] = -1;
            }
            else if (rand == 4)
            {
                direction[1] = 1;
            }

            return direction;

        }
    }
}
