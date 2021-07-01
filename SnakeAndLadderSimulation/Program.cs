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
            int finalPos = 100;
            int rollCount = 1;
            int playerOne = 0;
            int playerTwo = 0;

            Console.WriteLine("Snake and Ladder Game");
            int position = 0;
            Console.WriteLine("initiallly the player is at " + position + "th position");
            /*........................................
             * creating a Random method to get the number when die is rolled
             * ......................................*/
            Random random = new Random();

            while (playerOne < finalPos && playerTwo < finalPos)
            {
                /* int roll = random.Next(1, 7);
                 // Console.WriteLine("Player Throws : "+roll);
                 // playerPos += position;

                 int options = random.Next(1, 4);
                 rollCount++;
                 switch (options)
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
                         playerPos = (playerPos - roll) < 0 ? 0 : (playerPos - roll);
                         break;
                     default:
                         break;

                 }
                 if (playerPos > finalPos)
                 {
                     playerPos = playerPos - roll;
                 }
                 Console.WriteLine("Player Position :" +playerPos);*/
                playerOne = Game(playerOne);
               
                playerTwo = Game(playerTwo);

                rollCount++;
            }
            /*.....................................................................
             * On reaching final position players wins the game 
             * .................................................*/
            if (playerOne == 100)
            {
                Console.WriteLine("Congratulations!!!!! player One won");
            }
            else
            {

                Console.WriteLine("Congratulations!!!!! Player Two Won .......");
            }
            Console.WriteLine("Total num of die rolls = " + rollCount);
            Console.Read();
        }

        public static int Game(int playerPos)
        {
            Random random = new Random();
            int roll = random.Next(1, 7);
            // Console.WriteLine("Player Throws : "+roll);
            // playerPos += position;

            int options = random.Next(1, 4);

            switch (options)
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
                    playerPos = (playerPos - roll) < 0 ? 0 : (playerPos - roll);
                    break;
                default:
                    break;

            }
            if (playerPos > 100)
            {
                playerPos = playerPos - roll;
            }
            return playerPos;
        }
    }
}
