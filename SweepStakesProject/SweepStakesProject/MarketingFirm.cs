using System;
namespace SweepStakesProject
{
    public class MarketingFirm
    {
        ISweepstakesManager manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;

            SweepStakes sweep = new SweepStakes("Maserati");
            sweep.RegisterContestant(new Contestant());
            sweep.RunSweepStakes();
            sweep.PickWinner();



            //This is the Run Game class
            //As a developer, I want to implement dependency injection in my
            //MarketingFirm class so that I can utilize a sweepstakes manager.
        }
    }
}
