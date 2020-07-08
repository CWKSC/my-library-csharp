using MyLib_Csharp.CommonClass;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;


namespace MyLib_Csharp.CommonClass
{

    public partial class MyVoid
    {

        public static readonly MyVoid defalutVoid;

        public R Return<R>(R expression) => expression;

    }

    public static class MyVoidExtension
    {

    }
}
