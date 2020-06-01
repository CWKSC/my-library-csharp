using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.Tool.Canvas
{
    public partial class Canvas
    {
        public List<Drawable> drawables;

        public void Draw()
        {
            foreach (var drawable in drawables)
            {
                drawable.Draw();
            }
        }
    }
}
