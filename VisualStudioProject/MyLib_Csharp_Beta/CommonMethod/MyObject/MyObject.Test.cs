using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyObject
    {

        public static void Test()
        {
            object intBox = 42;

            intBox.GetType().Println(); // type is System.Int32
            intBox.Println();

            // If you try to use //
            // `string stringValue = (string)intBox;` Or
            // `double doubleValue = (double)intBox;`
            // This will give you an error:
            // System.InvalidCastException: 'Unable to cast object of type 'System.Int32' to type 'System.XXX'.'
            string stringValue = intBox.To<string>();
            double doubleValue = intBox.To<double>();

            stringValue.Println();
            doubleValue.Println();
        }


    }
}
