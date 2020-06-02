using MyLib_Csharp.CommonClass;
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
            Console.Clear();
            foreach (var drawable in drawables)
            {
                drawable.position.SetCursorPosition();
                drawable.Draw();
            }
        }

        public static void Test()
        {

        }


    }
}
