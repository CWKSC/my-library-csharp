using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class Builder
    {

        public static void Test()
        {
            string zeroToNine = BuildString(builder =>
            {
                for(int i = 0; i < 10; i++)
                {
                    builder.Append(i);
                }
            });

            zeroToNine.Printlnln();

            int[] prime = BuildArray<int>(5, x =>
            {
                x[0] = 2;
                x[1] = 3;
                x[2] = 5;
                x[3] = 7;
                x[4] = 11;
            });

            prime.Printlnln();


        }



    }
}
