using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Manager
    {

        public ISweepstakesManager ManagerSelection()
        {
            Console.WriteLine("Which manager type would you like to hire? Enter 'Stack' or 'Queue'.");
            string response = Console.ReadLine().ToLower();
            switch (response)
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    throw new Exception(string.Format("Not a valid response"));

            }
        }
    }
}
