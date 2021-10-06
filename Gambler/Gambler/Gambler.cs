using System;

namespace Gambler
{
    public class Gambler
    {
        public int player;
        public int Everyday = 100;
        public int EachGame = 1;

        public void Startplay()
        {

            Random random = new Random();
            int player = random.Next(0, 2);
            if(player == 0)
            {
                Console.WriteLine("Win");
            }
            else
            {
                Console.WriteLine("Lose");
            }

        }
    }
}
