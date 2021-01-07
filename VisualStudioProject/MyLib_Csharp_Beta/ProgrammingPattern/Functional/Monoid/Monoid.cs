using System;
using System.Collections.Generic;
using System.Linq;

#pragma warning disable IDE1006 // 命名樣式
#pragma warning disable IDE0060 // 移除未使用的參數

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{


    // public interface Unital { }
    public interface Unital<T> { public T Identity(); }
    public interface BinaryOperation<T> { public T BinaryOperation(T a, T b); }
    public interface Semigroup<T> : BinaryOperation<T> { }
    public interface Monoid<T> : Unital<T>, Semigroup<T> { }


    public static partial class Monoid_ExtensionMethod
    {
        public static T Appends<T>(this Monoid<T> monoid, IEnumerable<T> x) =>
            x.Aggregate(monoid.Identity(), monoid.BinaryOperation);
        public static T Appends<T>(this Monoid<T> monoid, params T[] x) =>
            monoid.Appends((IEnumerable<T>)x);

        public static T When<T>(this Monoid<T> monoid, bool c, T then) =>
            c ? then : monoid.Identity();
        public static T Cond<T>(this Monoid<T> monoid, bool c, T then, T els) =>
            c ? then : els;
    }



    public class OptionalM<T> : Monoid<T?> where T : struct
    {
        public T? Identity() => null;
        public T? BinaryOperation(T? a, T? b) => a ?? b;
    }


    public class OrderingM : Monoid<int>
    {
        public int Identity() => 0;
        public int BinaryOperation(int a, int b) => a == 0 ? b : a;
    }

    public class Student : IComparable<Student>
    {
        public string name;
        public string sex;
        public DateTime birthday;
        public string from;
        // Normal define: //
        //public int CompareTo(Student s) =>
        //    name.CompareTo(s.name) != 0 ? name.CompareTo(s.name) : 
        //    sex.CompareTo(s.sex) != 0 ? sex.CompareTo(s.sex) :
        //    birthday.CompareTo(s.birthday) != 0 ? birthday.CompareTo(s.birthday) :
        //    from.CompareTo(s.from) != 0 ? from.CompareTo(s.from) : 0;
        //}
        public int CompareTo(Student student) =>
            new OrderingM().Appends(
                name.CompareTo(student.name),
                sex.CompareTo(student.sex),
                birthday.CompareTo(student.birthday),
                from.CompareTo(student.from)
            );
    }


    public class Todo : Monoid<Action>
    {
        public Action Identity() => () => { };
        public Action BinaryOperation(Action a, Action b) =>
            () => { a(); b(); };
    }

}

#pragma warning restore IDE0060 // 移除未使用的參數
#pragma warning restore IDE1006 // 命名樣式