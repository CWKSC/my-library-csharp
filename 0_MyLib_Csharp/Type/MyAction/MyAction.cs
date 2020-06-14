using System;
using System.Collections.Generic;
using System.Text;


namespace MyLib_Csharp.Type
{
    public partial class MyAction<T>
    {
        public Action<T> actionT;
        public Action action;

        public MyAction(Action<T> actionT)
        {
            this.actionT = actionT;
            action = () => actionT(default);
        }
        public MyAction(Action action)
        {
            actionT = _ => action();
            this.action = action;
        }


        public static implicit operator MyAction<T>(Action<T> actionT) => new MyAction<T>(actionT);
        public static implicit operator MyAction<T>(Action action) => new MyAction<T>(action);

    }
}
