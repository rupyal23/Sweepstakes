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
            myFirm.LaunchApp("yes");
            Console.ReadLine();
           // myFirm.LaunchApp(myFirm.sweepstakes.UI.Reprompt());
            


            //SweepstakesStackManager stackManager = new SweepstakesStackManager();
            //SweepstakesQueueManager queueManager = new SweepstakesQueueManager();



        }
    }
}
