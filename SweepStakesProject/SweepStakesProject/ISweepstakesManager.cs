using System;
namespace SweepStakesProject
{
    public interface ISweepstakesManager
    {
        void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();

    }
}
