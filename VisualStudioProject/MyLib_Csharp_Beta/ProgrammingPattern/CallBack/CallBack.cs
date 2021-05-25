using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public partial class CallBack
    {

        public static IEnumerable<T> CallBackToIEnumerable<T>(Action<Action<T>> CallBack)
        {
            List<T> list = new List<T>();
            CallBack(x => { list.Add(x); });
            return list;
        }


    }

}
