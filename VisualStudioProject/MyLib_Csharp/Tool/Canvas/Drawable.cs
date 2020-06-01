using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.Tool.Canvas
{
    public abstract class Drawable : IDrawable
    {
        public (int x, int y) position;
        public abstract void Draw();

    }
}
