using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.Tool
{
    public static partial class GenerateCode
    {



        public static void Test()
        {
            // string Generate(string template, params string[][] set) //
            string template = "<0> <1> <2>\n";
            string[] set0 = { "12", "34" };
            string[] set1 = { "xx", "yy", "zz" };
            string[] set2 = { "aa", "bb", "cc", "dd" };

            Generate(template, set0, set1, set2).Println();


            // string GenerateByGroup(string template, params string[][][] groups) //
            string template_group = "<0_0> <0_1> <1_0>\n";
            string[] group0_set0 = { "12", "34", "56" };
            string[] group0_set1 = { "xx", "yy", "zz" };
            string[] group1_set0 = { "aa", "bb", "cc", "dd" };
            string[][] group0 = { group0_set0, group0_set1 };
            string[][] group1 = { group1_set0 };

            GenerateByGroup(template_group, group0, group1).Println();

            // Another example of GenerateByGroup //
            Generate_CartesianToPolar();
        }


        public static void Generate_CartesianToPolar()
        {
            string template =
@"public static double CartesianToPolar_<1_0>(<0_0>) {
    double result = Math.Atan2(<0_1>);
    return (result < 0 ? result + TwoPI : result) * <1_1>;
}
";
            // Group0 set //
            string[] group0_set0_parameter_args = {
                "double x, double y",
                "Vector2 point",
                "List<double> list" };
            string[] group0_set1_ATan2_input_parameter = {
                "y, x",
                "point.Y, point.X",
                "list[1], list[0]" };

            // Group1 set //
            string[] group1_set0_type = {
                "Radians",
                "Degrees",
                "Gradians"
            };
            string[] group1_set1_convert = {
                "1",
                "RadToDeg",
                "RadToGrad"
            };

            // Group //
            string[][] group0 = {
                group0_set0_parameter_args,
                group0_set1_ATan2_input_parameter
            };
            string[][] group1 = {
                group1_set0_type,
                group1_set1_convert
            };

            GenerateByGroup(template, group0, group1).Println();
        }


    }
}
