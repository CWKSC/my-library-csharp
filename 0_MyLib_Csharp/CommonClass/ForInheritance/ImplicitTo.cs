using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public abstract class ImplicitTo<T>
    {
        public static implicit operator T(ImplicitTo<T> thisObject) => default;
    }
}
