using System;
using System.Collections.Generic;

namespace SweepStakesProject
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<SweepStakes> manager = new Queue<SweepStakes>();
        public SweepstakesQueueManager()
        {
            // This class uses the Queue data structure as an underlying structure.





        }

        public SweepStakes GetSweepstakes()
        {
            return manager.Dequeue();
        }

        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            manager.Enqueue(sweepstakes);
        }
    }
}
