﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class Builder
    {


        public static T Build<T>(Action<T> action) where T : class, new()
        {
            T result = new T();
            action(result);
            return result;
        }


        public static string BuildString(Action<StringBuilder> action)
        {
            StringBuilder stringBuilder = new StringBuilder();
            action(stringBuilder);
            return stringBuilder.ToString();
        }


        public static T[] BuildArray<T>(int size, Action<T[]> action)
        {
            T[] result = new T[size];
            action(result);
            return result;
        }


    }
}
