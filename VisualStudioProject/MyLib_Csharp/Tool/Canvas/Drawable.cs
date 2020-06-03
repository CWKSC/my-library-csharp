using MyLib_Csharp.CommonClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.Tool
{
    public abstract class Drawable : IDrawable
    {
        public (int x, int y) position;
        public abstract void Draw();
        public abstract void Draw<T>(T arg);
    }
}
