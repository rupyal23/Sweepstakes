using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        
        public Sweepstakes sweepstakes;
        public string sweepstakesName;
        public ISweepstakesManager manager;
        

        //Dependency Injection
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
            sweepstakes = new Sweepstakes(sweepstakesName);
        }

        public void LaunchApp(string input)
        {
            if(input.ToLower() == "yes")
            {
                RunSweepstakes();
                LaunchApp(sweepstakes.UI.Reprompt());
            }
            else
            {
                sweepstakes.UI.AppCloseMessage();
                return;
            }
        }
        public void RunSweepstakes()
        {
            CreateSweepstakes();
            CreateContestant();

        }

        public void CreateSweepstakes()
        {
            sweepstakesName = sweepstakes.UI.AssignSweepstakesName();
            sweepstakes  = new Sweepstakes(sweepstakesName);
        }
        public void CreateContestant()
        {
            int numberOfContestants = sweepstakes.UI.NumberOfContestants();
            for(int i = 0; i < numberOfContestants; i++)
            {
                sweepstakes.UI.AssignFirstName(sweepstakes.contestant);
                sweepstakes.UI.AssingLastName(sweepstakes.contestant);
                sweepstakes.UI.AssignEmailId(sweepstakes.contestant);
                sweepstakes.UI.AssignRegistrationNumber(sweepstakes.contestant);
                sweepstakes.RegisterContestant(sweepstakes.contestant);
                sweepstakes.UI.DisplayContestantAdded(sweepstakes.contestant);
            }
        }
    }
}
