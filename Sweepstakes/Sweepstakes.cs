using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        //member variables
        public Dictionary<int, string> dictionary;
        public UserInterface UI;
        public string name;
        public Random randomWinner = new Random();
        public string winner;
        public int winnerRegNumber;
        
        

        //constructor
        public Sweepstakes(string name)
        {
            UI = new UserInterface();
            dictionary = new Dictionary<int, string>();
            this.name = name;
        }

        //member methods


        public void RegisterContestant(Contestant contestant)
        {
            UI.AssignFirstName(contestant);
            UI.AssingLastName(contestant);
            UI.AssignEmailId(contestant);
            UI.AssignRegistrationNumber(contestant);
            dictionary.Add(contestant.RegNumber, contestant.firstName);
        }

        public string PickWinner()
        {
            winnerRegNumber = randomWinner.Next(UI.totalEntries);
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }


    }
}
