using System;

namespace SweepStakesProject
{
    class Program
    {
        static void Main(string[] args)
        { 
            ISweepstakesManager thing;
            string manager = UserInterface.AskManager();
            if(manager == "stack")
            {
                 thing = new SweepstakesStackManager();
            }
            else
            {
                thing = new SweepstakesQueueManager();
            }
            MarketingFirm marketingFirm = new MarketingFirm(thing);
           
        }
    }
}
