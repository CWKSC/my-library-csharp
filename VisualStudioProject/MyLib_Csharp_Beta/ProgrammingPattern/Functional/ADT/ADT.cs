using System.Collections.Generic;

#pragma warning disable IDE1006 // 命名樣式

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static partial class ADT
    {

        public interface ISchoolPerson { }
        public sealed class Student : ISchoolPerson
        {
            public string name;
            public int id;
        }
        public sealed class Teacher : ISchoolPerson
        {
            public string name;
            public string office;
        }


        public interface Bool { }
        public sealed class True : Bool { }
        public sealed class False : Bool { }

        public enum EBool
        {
            True,
            False
        }


        public interface Nat { }

        public sealed class Z : Nat { }
        public sealed class S : Nat
        {
            public Nat value;
            public S(Nat v) => value = v;
        }


        public interface List<T> { }
        public sealed class Nil<T> : List<T> { }
        public sealed class Cons<T> : List<T> {
            public T value;
            public List<T> next;
            public Cons(T v, List<T> n) {
                value = v;
                next = n;
            }
        }

        public interface JsonValue { }
        public sealed class JsonBool : JsonValue
        {
            public bool value;
        }
        public sealed class JsonInt : JsonValue
        {
            public int value;
        }
        public sealed class JsonString : JsonValue
        {
            public string value;
        }
        public sealed class JsonArray : JsonValue
        {
            public List<JsonValue> value;
        }
        public sealed class JsonMap : JsonValue
        {
            public Dictionary<string, JsonValue> value;
        }

    }
}

#pragma warning restore IDE1006 // 命名樣式
