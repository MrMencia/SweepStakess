using System;
namespace SweepStakesProject
{
    public class Factory
    {
        public Factory()
        {

        }
        public class ChooseTypeofSweepStakes
        {
            public ISweepstakesManager ChooseTypeOfSweepStakes()
            {
                Console.WriteLine("Which way would you like to create your sweepstake. Enter 'stack' or 'queue'");
                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "stack":
                        return new SweepstakesStackManager();
                    case "queue":
                        return new SweepstakesQueueManager();
                    default:
                        Console.WriteLine("Invalid Entry. Please enter 'stack' or 'queue' ");
                        break;
                }
                return new SweepstakesQueueManager();
            }
        }
    }
}
