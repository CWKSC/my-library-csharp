using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.Tool
{
    public class FSMTransition
    {
        public FSMState targetState;
        public Func<bool> transitionCondition;

        public FSMTransition(FSMState targetState, Func<bool> transitionCondition)
        {
            this.targetState = targetState;
            this.transitionCondition = transitionCondition;
        }
    }
}
