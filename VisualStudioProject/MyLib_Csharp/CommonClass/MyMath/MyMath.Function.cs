using System;
using System.Collections.Generic;
using System.Text;

using static System.Math;

namespace MyLib_Csharp.CommonClass
{
    partial class MyMath
    {


        double Gamma(double z) => Integral(
            (t, z) => Pow(t, z - 1) / Exp(t),
            z, 0, 100);


    }
}
