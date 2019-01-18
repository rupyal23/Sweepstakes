using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        public Contestant contestant = new Contestant("John", "Doe", "jdoe@gmail.com");
        public Sweepstakes sweepstakes;
        public string sweepstakesName;


        ISweepstakesManager Manager;

        //Dependency Injection
        public MarketingFirm(ISweepstakesManager Manager)
        {
            this.Manager = Manager;
            sweepstakes = new Sweepstakes(sweepstakesName);
        }

        public void CreateSweepstakes()
        {
            sweepstakesName = sweepstakes.UI.AssignSweepstakesName();
            sweepstakes  = new Sweepstakes(sweepstakesName);
        }
        public void CreateContestant()
        {
            for(int i = 0; i < 3; i++)
            {
                sweepstakes.UI.AssignFirstName(contestant);
                sweepstakes.UI.AssingLastName(contestant);
                sweepstakes.UI.AssignEmailId(contestant);
                sweepstakes.UI.AssignRegistrationNumber(contestant);
                sweepstakes.RegisterContestant(contestant);
            }
        }
        
    }

}
