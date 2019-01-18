using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        //member variables
        public string firstName;
        public string lastName;
        public string emailId;
        public int regNumber;


        //constructor
        public Contestant(string firstName, string lastName, string emailId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailId = emailId;
        }

        //member methods


    }
}
