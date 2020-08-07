using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace Useless_Backup_Testing.Math
{
    public static partial class PowerX
    {

        public static void Test()
        {
            ("2^2  = " + Power2(2)).Println();
            ("4^2  = " + Power2(4)).Println();
            ("10^2 = " + Power2(10)).Println();
            ("42^2 = " + Power2(42)).Printlnln();

            ("2^3  = " + Power3(2)).Println();
            ("4^3  = " + Power3(4)).Println();
            ("10^3 = " + Power3(10)).Println();
            ("42^3 = " + Power3(42)).Printlnln();

            ("2^2  = " + Power2_v2(2)).Println();
            ("4^2  = " + Power2_v2(4)).Println();
            ("10^2 = " + Power2_v2(10)).Println();
            ("42^2 = " + Power2_v2(42)).Printlnln();
        }

    }
}
