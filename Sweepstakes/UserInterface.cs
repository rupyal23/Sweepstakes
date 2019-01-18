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
        
        public int RegistrationNumber;
        Random rnd = new Random();
        


        //member methods
        //Factory Pattern
        public MarketingFirm ManagerSelection()
        {
            Console.WriteLine("Which manager type would you like to hire? Enter 'Stack' or 'Queue'.");
            string response = Console.ReadLine().ToLower();
            switch (response)
            {
                case "stack":
                    return new MarketingFirm(new SweepstakesStackManager());
                case "queue":
                    return new MarketingFirm(new SweepstakesQueueManager());
                default:
                    throw new Exception(string.Format("Not a valid response"));

            }
        }
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
            contestant.regNumber++;
        }

        public void DisplayContestantInfo(Contestant contestant)
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine($"Name: {contestant.firstName} {contestant.lastName}");
            info.AppendLine($"Email Address: {contestant.emailId}");
            info.AppendLine($"Registration Number:{ contestant.regNumber}");
            Console.WriteLine(info);
        }
    }
}
