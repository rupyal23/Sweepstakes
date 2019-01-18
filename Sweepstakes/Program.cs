using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {

            ISweepstakesManager manager;
            manager = Manager.ManagerSelection();
            MarketingFirm myFirm = new MarketingFirm(manager);
            myFirm.CreateSweepstakes();
            Console.ReadLine();


            //SweepstakesStackManager stackManager = new SweepstakesStackManager();
            //SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
            //myFirm.CreateContestant();
            //Console.WriteLine($"{myFirm.mySweep.dictionary.Count} people added to sweepstakes");
            //Console.ReadLine();


        }
    }
}
