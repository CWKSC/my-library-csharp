using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.MyType
{
    public partial class Matrix<T>
    {
        public T[,] matrix;

        public Matrix(T[,] arr2d) => matrix = arr2d;


        public static implicit operator Matrix<T>(T[,] arr2d) => new Matrix<T>(arr2d);

    }
}
