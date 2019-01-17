using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class UserInterface
    {
        //FOR ANY INFO THE APP WOULD NEED TO GET FROM USER

        //member variabes
        
        public int RegistrationNumber = 8888;
        public int totalEntries;


        //member methods
        public void AssignFirstName(Contestant contestant)
        {
            Console.WriteLine("Please enter your First Name");
            contestant.firstName = Console.ReadLine();

        }

        public void AssingLastName(Contestant contestant)
        {
            Console.WriteLine("Please enter your Last Name");
            contestant.lastName = Console.ReadLine();
        }

        public void AssignEmailId(Contestant contestant)
        {
            Console.WriteLine("Please enter your Email Address");
            contestant.emailId = Console.ReadLine();
        }

        public void AssignRegistrationNumber(Contestant contestant)
        {
            RegistrationNumber++;
            contestant.RegNumber = RegistrationNumber;
            totalEntries++;
        }


    }
}
