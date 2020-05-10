using MyLib_Csharp.CommonClass;
using MyLib_Csharp.DataStructure;
using MyLib_Csharp.Tool;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MyLib_Csharp
{
    class Program
    {



        public static void Main(string[] args)
        {
            MyMath.Integral(0, Math.PI, x => x * Math.Sin(x) / (1 + Math.Pow(Math.Cos(x), 2)), 0.0005).Print();
        }
    }
}
