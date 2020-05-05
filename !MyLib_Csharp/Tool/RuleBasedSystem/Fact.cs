using System;

namespace MyLib_Csharp.Tool
{
    public class Fact
    {
        public string name;
        public Fact(string name) => this.name = name;
        public void Print() => Console.Write(name);
        public override string ToString() => name;
    }

}
