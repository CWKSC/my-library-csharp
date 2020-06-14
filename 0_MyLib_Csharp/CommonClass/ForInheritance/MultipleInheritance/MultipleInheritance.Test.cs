using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp.CommonClass.MyPrint;

namespace MyLib_Csharp.CommonClass
{
    public partial class MultipleInheritance
    {

        public class ClassA
        {
            public int intValue;
            public void ClassAMethod() { "Call Class A Method".Println(); }
        }
        public class ClassB
        {
            public bool boolValue;
            public void ClassBMethod() { "Call Class B Method".Println(); }
        }
        public class ClassC
        {
            public double doubleValue;
            public void ClassCMethod() { "Call Class C Method".Println(); }
        }

        public class Foo : 
            MultipleInheritance<ClassA, ClassB> { }

        public class Boo : 
            MultipleInheritance<ClassA, ClassB, ClassC> { }

        public static void Test()
        {
            Foo foo = new Foo();

            // Usage #1 //
            ClassA classA = foo;
            classA.ClassAMethod();

            // Usage #2
            ((ClassB)foo).ClassBMethod();

            ln();

            Boo boo = new Boo();

            ((ClassA)boo).ClassAMethod();
            ((ClassB)boo).ClassBMethod();
            ((ClassC)boo).ClassCMethod();

        }

    }
}
