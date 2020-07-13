using MyLib_Csharp_Alpha.CommonClass;
using MyLib_Csharp_Alpha.Tool;
using System;

using static MyLib_Csharp_Alpha.CommonClass.ProgrammaticProgram;

namespace MyLib_Csharp_Alpha
{
    class Program
    {

        public delegate MyVoid FuncR<R>(out R returnValue);

        public R GetReturnValueOfFuncR<R>(FuncR<R> actionR) => 
            actionR(out R returnValue).Return(returnValue);


        public ReturnValue<MyVoid> Foo() => Return();


        public void Bar(Func<int, int> func)
        {

        }


        public static void Main(string[] args)
        {
            //int[] dataSet = {1, 2, 3};
            //dataSet.Map(x => x*3).Print();

            //((Func<int, int>)(i => dataSet[i])).Map(x => x * 3);
            LagrangeInterpolationPolynomial.Test();
            //MultipleInheritance.Test();
        }


    }

}




