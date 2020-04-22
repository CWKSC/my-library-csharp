using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    class MyDebug
    {

        [Conditional("MyDebug")] public void Log(string msg) => Console.Write(msg);

        [Conditional("MyDebug")]  public void Logln(string msg) => Console.WriteLine(msg);

    }
}
