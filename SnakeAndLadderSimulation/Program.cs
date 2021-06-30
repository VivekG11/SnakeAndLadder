using System;

namespace SnakeAndLadderSimulation
{
    class Program
    {
        public const int startPosition = 0;
        public const int noPlay = 1;
        public const int ladder = 2;
        public const int snake = 3;

        static void Main(string[] args)
        {
            /*................................................
             * initialising position of the player
             * ........................................*/
            int playerPos = 0;
           
            Console.WriteLine("Snake and Ladder Game");
            int position = 0;
            Console.WriteLine("initiallly the player is at " +position+"th position" );
            /*........................................
             * creating a Random method to get the number when die is rolled
             * ......................................*/
            Random random = new Random();
            int roll = random.Next(1, 7);
           // Console.WriteLine("Player Throws : "+roll);
           // playerPos += position;

            int options = random.Next(1, 4);
            switch(options)
            {
                case noPlay:
                    Console.WriteLine("PLayer stays in the same position");
                    break;
                case ladder:
                    Console.WriteLine("Moves ahead");
                    playerPos = playerPos + roll;
                    break;
                case snake:
                    Console.WriteLine("Goes Behind");
                    playerPos = (playerPos - roll) <0 ? 0 : (playerPos - roll) ;
                    break;
                default:
                    break;

            }
            Console.WriteLine("The player is at "+playerPos+ " position");
            Console.Read();
        }
    }
}
