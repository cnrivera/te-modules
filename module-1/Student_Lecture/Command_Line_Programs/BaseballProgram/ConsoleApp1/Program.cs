using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //This program will prompt the user for the number of players on the team.
            //For each player we'll need theirname, # of times at bat, and # of hits.
            //Then display player nam and batting average for every player.
            //Then display player with the best batting average.

            Console.WriteLine("How many players are on your team?");
            string strNumPlayers = Console.ReadLine();
            int numPlayers = int.Parse(strNumPlayers);
            while(numPlayers <= 0 || numPlayers > 20)
            {
                Console.WriteLine("Invalid. Please enter number of players between 1 and 20.");
                strNumPlayers = Console.ReadLine();
                numPlayers = int.Parse(strNumPlayers);
            }

            string[] playerNames = new string[numPlayers];
            int[] timesAtBat = new int[numPlayers];
            int[] numHits = new int[numPlayers];
            for (int i = 0; i<numPlayers; i++)
            {
                Console.WriteLine("Enter player name: ");
                playerNames [i] = Console.ReadLine();

                Console.WriteLine("Enter times " + playerNames[i]+ "Has been at bat: ");
                string strTimesAtBat = Console.ReadLine();
                timesAtBat[i] = int.Parse(strTimesAtBat);

                Console.WriteLine("Enter number of hits: ");
                string strNumHits = Console.ReadLine();
                numHits[i] = int.Parse(strNumHits);
            }
            for (int i = 0; i < numPlayers; i++);
            {
                Console.WriteLine(playerNames[i] +" " +(double)numHits[i] / timesAtBat[ i]);
            }
        }
        public static string CalculateBattingAverage(int numHits, int timesAtBat)
        {
            return ".003";
        }

    }
}
