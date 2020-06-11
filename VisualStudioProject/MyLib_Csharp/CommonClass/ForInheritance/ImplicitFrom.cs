using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public abstract class ImplicitFrom<T>
    {
        public static implicit operator ImplicitFrom<T>(T fromValue) => default;
    }
}
