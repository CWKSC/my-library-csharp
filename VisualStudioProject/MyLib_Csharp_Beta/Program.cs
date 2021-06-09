using MyLib_Csharp_Beta.ProgrammingPattern;
using System;

using static MyLib_Csharp_Beta.ProgrammingPattern.ProgramStructure;
using static MyLib_Csharp_Beta.CommonMethod.Printing;
using MyLib_Csharp_Beta.CommonType;
using MyLib_Csharp_Beta.MyMath;
using MyLib_Csharp_Beta.Tool;
using static MyLib_Csharp_Beta.MyMath.SumOf_ProductOf;
using MyLib_Csharp_Beta.CommonMethod;
using System.Runtime.InteropServices.ComTypes;
using System.Reflection;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using static MyLib_Csharp_Beta.CommonMethod.MyString;
using static MyLib_Csharp_Beta.Tool.TemplateGenerator;
using MyLib_Csharp_Beta.ProgrammingPattern.Functional;
using MyLib_Csharp_Beta.Algorithm;
using System.Text;
using System.Text.RegularExpressions;
using MyLib_Csharp_Beta.DataStructure;
using System.Collections;

namespace MyLib_Csharp_Beta
{

    public static class Program
    {

        public static List<T> BackTracking<T>(T init, Func<T, (int n, T[] addState)> f,
             Func<T, T> whenStep = null, Func<T, T> whenPrev = null, Func<T, T> whenEnd = null)
        {
            List<T> states = new() { init };
            while (true)
            {
                if (states.Count == 0) return new (){ };
                (int n, T[] addState) = f(states[^1]);
                if (n > 0)
                {
                    states.AddRange(addState);
                }
                else if (n < 0)
                {
                    states.RemoveRange(states.Count - n - 1, n);
                }
                else if (n == 0)
                {
                    return states;
                }
            }
        }


        public static void Main(string[] args)
        {
            NQueen.Test();
            return;

            BackTracking(1
            ,
            state =>
            {
                if (state < 5)
                {
                    return (1, new[] { state + 1 });
                }
                return (0, null);
            }).Println();
            // AdvancedLooping.Test();
        }
        

    }

}
