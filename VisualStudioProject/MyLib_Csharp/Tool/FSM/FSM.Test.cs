using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.Tool
{
    public partial class FSM
    {
        public static void Test()
        {

            FSMState Idle = new FSMState()
            {
                enter = () => Console.WriteLine("Idle Enter"),
                update = () => Console.WriteLine("Idle Update"),
                exit = () => Console.WriteLine("Idle Exit")
            };
            FSMState Attack = new FSMState()
            {
                enter = () => Console.WriteLine("Attack Enter"),
                update = () => Console.WriteLine("Attack Update"),
                exit = () => Console.WriteLine("Attack Exit")
            };
            FSMState Flee = new FSMState()
            {
                enter = () => Console.WriteLine("Flee Enter"),
                update = () => Console.WriteLine("Flee Update"),
                exit = () => Console.WriteLine("Flee Exit")
            };

            float distance = 10;
            float hp = 100;

            FSMTransition ToAttack = new FSMTransition(Attack, () => distance < 5);
            FSMTransition ToFlee = new FSMTransition(Flee, () => hp < 30);
            Idle.AddTransition(ToAttack, ToFlee);
            Attack.AddTransition(ToFlee);

            FSM fsm = new FSM(Idle, Attack, Flee);

            Console.WriteLine("[Update]");
            fsm.Update();
            Console.WriteLine();

            Console.WriteLine("[Update]");
            fsm.Update();
            Console.WriteLine();

            Console.WriteLine("[distance change to 3]");
            distance = 3;

            Console.WriteLine("[Update]");
            fsm.Update();
            Console.WriteLine();

            Console.WriteLine("[Update]");
            fsm.Update();
            Console.WriteLine();

            Console.WriteLine("[hp change to 20]");
            hp = 20;

            Console.WriteLine("[Update]");
            fsm.Update();
            Console.WriteLine();

            Console.WriteLine("[Update]");
            fsm.Update();
            Console.WriteLine();

        }

    }
}
