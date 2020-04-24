using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.Tool
{
    public class FSMState
    {
        public List<FSMTransition> transitions = new List<FSMTransition>();
        public Action enter = () => { };
        public Action update = () => { };
        public Action exit = () => { };
        public bool firstTimesEnter = true;

        public void Enter()
        {
            if (firstTimesEnter)
            {
                enter();
                firstTimesEnter = false;
            }
        }
        public void Exit()
        {
            exit();
            firstTimesEnter = true;
        }
        public void AddTransition(params FSMTransition[] transition) => transitions.AddRange(transition);
        public (bool, FSMState) CheckTransition()
        {
            foreach (FSMTransition transition in transitions)
            {
                if (transition.transitionCondition()) return (true, transition.targetState);
            }
            return (false, null);
        }
    }

}
