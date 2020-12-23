using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static partial class MyMonoid
    {

#pragma warning disable IDE1006 // 命名樣式
        // public interface Unital { }
        public interface Unital<T> { public Func<T> Identity { set; get; } }
        public interface BinaryOperation<T> { public Func<T, T, T> BinaryOperation { get; set; } }
        public interface Semigroup<T> : BinaryOperation<T> { }
        public class Monoid<T> : Unital<T>, Semigroup<T> {
            public Monoid(Func<T> Identity, Func<T, T, T> BinaryOperation)
            {
                this.Identity = Identity;
                this.BinaryOperation = BinaryOperation;
            }
            public Func<T> Identity { get; set; }
            public Func<T, T, T> BinaryOperation { get; set; }
        }

        public static T Appends<T>(this Monoid<T> monoid, IEnumerable<T> x) => 
            x.Aggregate(monoid.Identity(), monoid.BinaryOperation);
        public static T Appends<T>(this Monoid<T> monoid, params T[] x) =>
            monoid.Appends((IEnumerable<T>)x);



        public static Monoid<T?> OptionalM<T>() where T : struct => 
            new Monoid<T?>(() => null, (a, b) => a ?? b);

        public static Monoid<int> OrderingM() =>
            new Monoid<int>(() => 0, (a, b) => a == 0 ? b : a);



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
                OrderingM().Appends(
                    name.CompareTo(student.name),
                    sex.CompareTo(student.sex),
                    birthday.CompareTo(student.birthday),
                    from.CompareTo(student.from)
                );
        }

    }
}


#pragma warning restore IDE1006 // 命名樣式