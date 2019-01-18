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
        public Sweepstakes mySweep;
        public ISweepstakesManager Manager;

        //Dependency Injection
        public MarketingFirm(ISweepstakesManager Manager)
        {
            this.Manager = Manager;
            //mySweep = new Sweepstakes("Sweepstakes 2019");
        }

        public void CreateContestant()
        {
            for(int i = 0; i < 3; i++)
            {
                mySweep.UI.AssignFirstName(contestant);
                mySweep.UI.AssingLastName(contestant);
                mySweep.UI.AssignEmailId(contestant);
                mySweep.UI.AssignRegistrationNumber(contestant);
                mySweep.RegisterContestant(contestant);
            }
        }
        
    }

}
