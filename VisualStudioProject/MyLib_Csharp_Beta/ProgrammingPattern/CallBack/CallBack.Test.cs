using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public partial class CallBack
    {

        private static void Foo_CallBack(Action<int> action)
        {
            action(1);
            action(2);
            action(3);
            action(42);
            action(5678);
            action(10);
        }

        private static IEnumerable<int> Foo_CallBack_iter()
        {
            return CallBackToIEnumerable<int>(Foo_CallBack);
        }


        public static void Test()
        {
            IEnumerable<int> ienumberable = Foo_CallBack_iter();
            foreach(int ele in ienumberable)
            {
                Console.Write(ele + " ");
            }
        }

    }
}
