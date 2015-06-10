using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NR.Clone.Cards

namespace NR.Clone.Players
{
    class Runner : PlayerBase
    {
        public string[] Grip;
        public Stack<Card> CardStack;
        public Stack<Card> CardHeap;
        public RunnerRig Rig;
    }

    public class RunnerRig
    {
        public Card[] ProgramRow;
        public Card[] HardwareRow;
        public Card[] ResourceRow;
    }
}
