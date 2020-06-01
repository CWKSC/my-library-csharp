using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyConsole
    {

        public static void SetCursorPosition(this (int x, int y) position) => 
            Console.SetCursorPosition(position.x, position.y);

        public static void MoveCursorRelative(int x, int y) => 
            Console.SetCursorPosition(Console.CursorLeft + x, Console.CursorTop + y);

        public static void MoveCursorUp() => MoveCursorRelative(0, -1);
        public static void MoveCursorDown() => MoveCursorRelative(0, 1);
        public static void MoveCursorLeft() => MoveCursorRelative(-1, 0);
        public static void MoveCursorRight() => MoveCursorRelative(1, 0);


        public static void Test()
        {

        }


    }
}
