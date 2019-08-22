using System;
using System.Collections;
using System.Collections.Generic;

namespace SweepStakesProject
{
    public class SweepstakesStackManager: ISweepstakesManager
    {
        Stack<SweepStakes> SweepStakesManager = new Stack<SweepStakes>();


        public SweepstakesStackManager()
        {
            // this class needs the Stack Data Structure

           




        }

        public SweepStakes GetSweepstakes()
        {
            return SweepStakesManager.Pop();
            
        }

        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            SweepStakesManager.Push(sweepstakes);
        }
    }
}
