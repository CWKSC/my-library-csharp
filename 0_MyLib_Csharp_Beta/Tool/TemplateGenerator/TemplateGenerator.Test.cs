using MyLib_Csharp_Beta.CommonMethod;
using MyLib_Csharp_Beta.ProgrammingPattern;

using static MyLib_Csharp_Beta.CommonMethod.MyString;

namespace MyLib_Csharp_Beta.Tool
{
    public static partial class TemplateGenerator
    {



        public static void Test()
        {
            // string[] Generate(string template, params string[][] set) 
            Test_Generate();

            // string[] GenerateByGroup(string template, params string[][][] groups) //
            Test_GenerateByGroup();
            Test_GenerateByGroup_CartesianToPolar(); // Another example of GenerateByGroup 

            // string[] GenerateByName(string template, params (string name, string[] set)[] sets)
            Test_GenerateByName();

            // string[] GenerateByNameAndGroup(string template, params (string name, string[] set)[][] groups) //
            Test_GenerateByNameAndGroup_Generate_Generic_Class(); // Generate generic class
            Test_GenerateByNameAndGroup_Generate_Generic_Method(); // Generat generic method

        }


        public static void Test_Generate()
        {
            // string[] Generate(string template, params string[][] set) //
            string template = "<0> <1> <2>\n";

            string[] set0 = { "12", "34" };
            string[] set1 = { "xx", "yy", "zz" };
            string[] set2 = { "aa", "bb", "cc", "dd" };

            Generate(template, set0, set1, set2).ConcatToOneString().Println();
            #region result
            /*
            12 xx aa
            12 xx bb
            12 xx cc
            12 xx dd
            12 yy aa
            12 yy bb
            12 yy cc
            12 yy dd
            12 zz aa
            12 zz bb
            12 zz cc
            12 zz dd
            34 xx aa
            34 xx bb
            34 xx cc
            34 xx dd
            34 yy aa
            34 yy bb
            34 yy cc
            34 yy dd
            34 zz aa
            34 zz bb
            34 zz cc
            34 zz dd
            */
            #endregion
        }


        public static void Test_GenerateByGroup()
        {
            // string[] GenerateByGroup(string template, params string[][][] groups) //
            string template = "<0_0> <0_1> <1_0>\n";

            string[] group0_set0 = { "12", "34", "56" };
            string[] group0_set1 = { "xx", "yy", "zz" };
            string[] group1_set0 = { "aa", "bb", "cc", "dd" };
            string[][] group0 = { group0_set0, group0_set1 };
            string[][] group1 = { group1_set0 };

            GenerateByGroup(template, group0, group1).ConcatToOneString().Println();
            #region result
            /*
            12 xx aa
            12 xx bb
            12 xx cc
            12 xx dd
            34 yy aa
            34 yy bb
            34 yy cc
            34 yy dd
            56 zz aa
            56 zz bb
            56 zz cc
            56 zz dd
            */
            #endregion
        }


        public static void Test_GenerateByGroup_CartesianToPolar()
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
                "List<double> list"
            };
            string[] group0_set1_ATan2_input_parameter = {
                "y, x",
                "point.Y, point.X",
                "list[1], list[0]"
            };

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

            GenerateByGroup(template, group0, group1).ConcatToOneString().Printlnln();
            #region result
            /*
            public static double CartesianToPolar_Radians(double x, double y) {
                double result = Math.Atan2(y, x);
                return (result < 0 ? result + TwoPI : result) * 1;
            }
            public static double CartesianToPolar_Degrees(double x, double y) {
                double result = Math.Atan2(y, x);
                return (result < 0 ? result + TwoPI : result) * RadToDeg;
            }
            public static double CartesianToPolar_Gradians(double x, double y) {
                double result = Math.Atan2(y, x);
                return (result < 0 ? result + TwoPI : result) * RadToGrad;
            }
            public static double CartesianToPolar_Radians(Vector2 point) {
                double result = Math.Atan2(point.Y, point.X);
                return (result < 0 ? result + TwoPI : result) * 1;
            }
            public static double CartesianToPolar_Degrees(Vector2 point) {
                double result = Math.Atan2(point.Y, point.X);
                return (result < 0 ? result + TwoPI : result) * RadToDeg;
            }
            public static double CartesianToPolar_Gradians(Vector2 point) {
                double result = Math.Atan2(point.Y, point.X);
                return (result < 0 ? result + TwoPI : result) * RadToGrad;
            }
            public static double CartesianToPolar_Radians(List<double> list) {
                double result = Math.Atan2(list[1], list[0]);
                return (result < 0 ? result + TwoPI : result) * 1;
            }
            public static double CartesianToPolar_Degrees(List<double> list) {
                double result = Math.Atan2(list[1], list[0]);
                return (result < 0 ? result + TwoPI : result) * RadToDeg;
            }
            public static double CartesianToPolar_Gradians(List<double> list) {
                double result = Math.Atan2(list[1], list[0]);
                return (result < 0 ? result + TwoPI : result) * RadToGrad;
            }
            */
            #endregion
        }



        public static void Test_GenerateByName()
        {
            // string[] GenerateByName(string template, params (string name, string[] set)[] sets) //
            string template = "<type> <varname><suffix>;\n";

            (string, string[]) typeSet = ("type", new string[] { "int", "string", "bool", "double" });
            (string, string[]) varnameSet = ("varname", new string[] { "x", "y", "z" });
            (string, string[]) suffixSet = ("suffix", new string[] { "1", "2", "3" });

            GenerateByName(template, typeSet, varnameSet, suffixSet).ConcatToOneString().Printlnln();
            #region result
            /*
            int x1;
            int x2;
            int x3;
            int y1;
            int y2;
            int y3;
            int z1;
            int z2;
            int z3;
            string x1;
            string x2;
            string x3;
            string y1;
            string y2;
            string y3;
            string z1;
            string z2;
            string z3;
            bool x1;
            bool x2;
            bool x3;
            bool y1;
            bool y2;
            bool y3;
            bool z1;
            bool z2;
            bool z3;
            double x1;
            double x2;
            double x3;
            double y1;
            double y2;
            double y3;
            double z1;
            double z2;
            double z3;
            */
            #endregion
        }



        public static void Test_GenerateByNameAndGroup_Generate_Generic_Class()
        {
            // string[] GenerateByNameAndGroup(string template, params (string name, string[] set)[][] groups) //
            // Generate generic class //
            string template = "class Box<<generic>> {\n<member>\n}\n";

            (string, string[]) genericSet = ("generic",
                GenericType(5)
                   .ToConcat1dArray_SeparateBy(", "));

            (string, string[]) memberSet = ("member",
                GenericType(5)
                   .AllAdd(" ")
                   .Mix(Xn("t", 5))
                   .AllAdd(";")
                   .AllAddFront("    ")
                   .ToConcat1dArray_SeparateBy("\n"));

            (string, string[])[] group = { genericSet, memberSet };

            GenerateByNameAndGroup(template, group).ConcatToOneString().Printlnln();
            #region result
            /*
            class Box<T0> {
                T0 t0;
            }
            class Box<T0, T1> {
                T0 t0;
                T1 t1;
            }
            class Box<T0, T1, T2> {
                T0 t0;
                T1 t1;
                T2 t2;
            }
            class Box<T0, T1, T2, T3> {
                T0 t0;
                T1 t1;
                T2 t2;
                T3 t3;
            }
            class Box<T0, T1, T2, T3, T4> {
                T0 t0;
                T1 t1;
                T2 t2;
                T3 t3;
                T4 t4;
            }
            */
            #endregion
        }


        public static void Test_GenerateByNameAndGroup_Generate_Generic_Method()
        {
            // string[] GenerateByNameAndGroup(string template, params (string name, string[] set)[][] groups) //
            // Generate generic method //
            string template = "public static T Add<T>(<genericVar>) { return <returnValue>; }\n";

            string[] var = { "a", "b", "c", "d", "e" };

            (string, string[]) genericVarSet = ("genericVar",
                "T ".ToRepeatArray(5)
                    .Mix(var)
                    .ToConcat1dArray_SeparateBy(", "));
            // T a
            // T a, T b
            // T a, T b, T c
            // T a, T b, T c, T d
            // T a, T b, T c, T d, T e

            (string, string[]) returnValueSet = ("returnValue", var.ToConcat1dArray_SeparateBy(" + "));
            // a
            // a + b
            // a + b + c
            // a + b + c + d
            // a + b + c + d + e

            (string, string[])[] group = { genericVarSet, returnValueSet };

            GenerateByNameAndGroup(template, group).ConcatToOneString().Printlnln();
            #region result
            /*
            public static T Add<T>(T a) { return a; }
            public static T Add<T>(T a, T b) { return a + b; }
            public static T Add<T>(T a, T b, T c) { return a + b + c; }
            public static T Add<T>(T a, T b, T c, T d) { return a + b + c + d; }
            public static T Add<T>(T a, T b, T c, T d, T e) { return a + b + c + d + e; }
            */
            #endregion
        }

    }
}
