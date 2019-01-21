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


        public string AssignSweepstakesName()
        {
            Console.WriteLine("Please Enter the Sweepstakes Name");
            string name = Console.ReadLine();
            return name;
        }
            
        public int NumberOfContestants()
        {
            try
            {
                Console.WriteLine("How many contestants you want to enter in the Sweepstakes?");
                int response = Int32.Parse(Console.ReadLine());
                return response;
            }
            catch(FormatException)
            {
                Console.WriteLine("Not a Valid Input");
                return NumberOfContestants();
            }
        }
        public void AssignFirstName(Contestant contestant)
        {
            Console.WriteLine("***********ENTRY NO. {0}**************",contestant.regNumber+1);
            Console.WriteLine("Please enter the First Name of the contestant.");
            contestant.firstName = Console.ReadLine();

        }

        public void AssingLastName(Contestant contestant)
        {
            Console.WriteLine("Please enter the Last Name of the contestant");
            contestant.lastName = Console.ReadLine();
        }

        public void AssignEmailId(Contestant contestant)
        {
            try
            {
                Console.WriteLine("Please enter the Email Address of the contestant");
                contestant.emailId = Console.ReadLine();
                if(!contestant.emailId.EndsWith(".com"))
                {
                    throw new FormatException();
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Not A valid Email Address.");
                AssignEmailId(contestant);
            }
                
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
            Console.ReadLine();
            Console.Clear();
        }
        public void DisplayContestantAdded(Contestant contestant)
        {
            Console.ReadLine();
            Console.WriteLine("{0} {1} HAS BEEN ENTERED TO THE SWEEPSTAKES.", contestant.firstName, contestant.lastName);
            
        }

        public string Reprompt()
        {
            Console.WriteLine("Do you want to run another Sweepstake?, Enter 'yes' or 'no");
            return Console.ReadLine().ToLower().Trim();
            
        }
        //Close Message method
        public void AppCloseMessage()
        {
            Console.WriteLine("THANKYOU! HAVE A NICE DAY.");
        }

        //Helper method for pick winner/need to work
        public void PickWinnerPrompt(ISweepstakesManager manager)
        {
            Type type = manager.GetType();
            if (type.Name == "SweepstakesStackManager")
            {
                //Need to write logic
            }
            else if(type.Name == "SweepstakesQueueManager")
            {
                Console.WriteLine("Do you want to pick a winner for the Sweepstake? Enter 'yes' or 'no'");
                string response = Console.ReadLine().ToLower().Trim();
                switch (response)
                {
                    case "yes":
                        //Write Logic
                    case "no":
                        //Write Logic
                    default:
                        PickWinnerPrompt(manager);
                        break;
                }
            }
        }

        public void PickWinnerDisplay(Contestant contestant)
        {
            Console.WriteLine("Winner for this Sweepstake is: {0} {1}", contestant.firstName, contestant.lastName);
        }
    }
}
