﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //Uses Stack Data as Underlying structure

        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();

        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
    }
}
