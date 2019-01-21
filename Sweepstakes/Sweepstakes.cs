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
        public Dictionary<int, Contestant> dictionary;
        public UserInterface UI = new UserInterface();
        public Contestant contestant;
        public string name;
        public Random rnd = new Random();
        public string winner;
        public int winnerRegNumber;
        public int totalEntries;
        
        

        //constructor
        public Sweepstakes(string name)
        {
            contestant = new Contestant("john", "doe", "johndoe@gmail.com");
            dictionary = new Dictionary<int, Contestant>();
            this.name = name;
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            dictionary.Add(contestant.regNumber, contestant);
            totalEntries++;
        }

        public string PickWinner()
        {
            winnerRegNumber = rnd.Next(dictionary.Keys.Min(), dictionary.Keys.Max());
            Contestant cWinner;
            cWinner = dictionary[winnerRegNumber];
            winner = cWinner.firstName + cWinner.lastName;
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UI.DisplayContestantInfo(contestant);
        }

    }
}
