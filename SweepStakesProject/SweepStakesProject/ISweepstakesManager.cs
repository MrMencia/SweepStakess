using System;
namespace SweepStakesProject
{
    public interface ISweepstakesManager
    {
        void InsertSweepstakes(SweepStakes sweepstakes);
        SweepStakes GetSweepstakes();

    }
}
