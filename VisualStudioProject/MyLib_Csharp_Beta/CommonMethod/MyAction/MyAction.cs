using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyAction
    {

        public static Action Nothing = () => { };

        public delegate void ParamsAction(params object[] args);
        public delegate void ParamsAction<IN>(params IN[] args);
        public delegate void RefAction<IN>(ref IN arg);
        public delegate void OutAction<IN>(out IN arg);
        public delegate void InAction<IN>(in IN arg);

    }
}
