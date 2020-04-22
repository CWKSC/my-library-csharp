using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.DataStructure
{
    class RGBA
    {
        public int r;
        public int g;
        public int b;
        public int a;

        public void Invert()
        {
            r = 255 - r;
            g = 255 - g;
            b = 255 - b;
        }

    }
}
