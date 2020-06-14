using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyObject
    {

        public static T Cast<T>(this object value) => (T)Convert.ChangeType(value, typeof(T));


    }
}
