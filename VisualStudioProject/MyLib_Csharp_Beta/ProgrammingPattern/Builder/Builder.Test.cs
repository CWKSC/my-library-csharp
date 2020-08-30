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
            string OneToTen = BuildString(builder =>
            {
                builder.Append("123");
                builder.Append("456");
                builder.Append("789");
            });

            OneToTen.Println();

        }



    }
}
