using System;

namespace SnakeAndLadderSimulation
{
    class Program
    {
        public const int startPosition = 0;
        static void Main(string[] args)
        {
            /*................................................
             * initialising position of the player
             * ........................................*/
           
            Console.WriteLine("Snake and Ladder Game");
            int position = 0;
            Console.WriteLine("initiallly the player is at " +position+"th position" );
            /*........................................
             * creating a Random method to get the number when die is rolled
             * ......................................*/
            Random random = new Random();
            int roll = random.Next(1, 7);
            Console.WriteLine("Player Throws : "+roll);
            Console.Read();
        }
    }
}
