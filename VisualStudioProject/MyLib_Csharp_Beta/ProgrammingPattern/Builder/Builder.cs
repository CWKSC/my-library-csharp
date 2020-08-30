using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class Builder
    {



        public static string BuildString(Action<StringBuilder> action)
        {
            StringBuilder stringBuilder = new StringBuilder();
            action(stringBuilder);
            return stringBuilder.ToString();
        }


    }
}
