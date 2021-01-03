using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.Tool
{
    public static partial class GenerateXORTable
    {
        public static string[] XORTable(string ok, string target)
        {
            StringBuilder a_builder = new StringBuilder();
            StringBuilder b_builder = new StringBuilder();
            StringBuilder c_builder = new StringBuilder();
            foreach (var tar in target)
            {
                foreach (var a in ok)
                {
                    foreach (var b in ok)
                    {
                        foreach (var c in ok)
                        {
                            if ((a ^ b ^ c) == tar)
                            {
                                ("target = " + tar + ", a = " + a + ", b = " + b + ", c = " + c).Println();
                                a_builder.Append(a);
                                b_builder.Append(b);
                                c_builder.Append(c);
                                goto exit;
                            }
                        }
                    }
                }
                exit:;
            }
            string a_str = a_builder.ToString().Println();
            string b_str = b_builder.ToString().Println();
            string c_str = c_builder.ToString().Println();
            $"'{a_str}'^'{b_str}'^'{c_str}'".Println();
            return new[] { a_str, b_str, c_str };
        }
    }
}
