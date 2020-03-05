using MyLib_Csharp.CommonClass;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MyLib_Csharp.DataStructure
{
    enum AngleType
    {
        Degrees, Radians, Gradians, Turns, UnitVector, List
    }

    class Angle
    {
        public double degrees;
        public double radians;
        public double gradians;
        public double turns;
        public Vector2 unitVector = new Vector2();
        public List<double> list = new List<double>(2);

        #region Constructor
        public Angle(double radians) => UpdateByRadians(radians);
        public Angle(AngleType angleType, double value) {
            switch (angleType)
            {
                case AngleType.Degrees: UpdateByDegrees(value); break;
                case AngleType.Radians: UpdateByRadians(value); break;
                case AngleType.Gradians: UpdateByGradians(value); break;
                case AngleType.Turns: UpdateByTurns(value); break;
            }
        }
        public Angle(Vector2 unitVector) => UpdateByUnitVector(Vector2.Normalize(unitVector));
        public Angle(List<double> list) => UpdateByList(list);
        public Angle(Angle angle)
        {
            degrees = angle.degrees;
            radians = angle.radians;
            gradians = angle.gradians;
            turns = angle.turns;
            unitVector = angle.unitVector;
            list = angle.list;
        }
        #endregion

        #region Update by somethings (Degrees, Radians, Gradians, Turns,  UnitVector, List)

        #region UpdateByDegrees
        public void UpdateByDegrees()
        {
            radians = MyMath.DegreesToRadians(degrees);
            gradians = MyMath.DegreesToGradians(degrees);
            turns = MyMath.DegreesToTurns(degrees);
            unitVector = MyMath.DegreesToUnitVector(degrees);
            list = MyMath.DegreesToList(degrees);
        }
        public void UpdateByDegrees(double degrees)
        {
            this.degrees = degrees;
            radians = MyMath.DegreesToRadians(degrees);
            gradians = MyMath.DegreesToGradians(degrees);
            turns = MyMath.DegreesToTurns(degrees);
            unitVector = MyMath.DegreesToUnitVector(degrees);
            list = MyMath.DegreesToList(degrees);
        }
        #endregion

        #region UpdateByRadians
        public void UpdateByRadians()
        {
            degrees = MyMath.RadiansToDegrees(radians);
            gradians = MyMath.RadiansToGradians(radians);
            turns = MyMath.RadiansToTurns(radians);
            unitVector = MyMath.RadiansToUnitVector(radians);
            list = MyMath.RadiansToList(radians);
        }
        public void UpdateByRadians(double radians)
        {
            this.radians = radians;
            degrees = MyMath.RadiansToDegrees(radians);
            gradians = MyMath.RadiansToGradians(radians);
            turns = MyMath.RadiansToTurns(radians);
            unitVector = MyMath.RadiansToUnitVector(radians);
            list = MyMath.RadiansToList(radians);
        }
        #endregion

        #region UpdateByGradians
        public void UpdateByGradians()
        {
            degrees = MyMath.GradiansToDegrees(gradians);
            radians = MyMath.GradiansToRadians(gradians);
            turns = MyMath.GradiansToTurns(gradians);
            unitVector = MyMath.GradiansToUnitVector(gradians);
            list = MyMath.GradiansToList(gradians);
        }
        public void UpdateByGradians(double gradians)
        {
            this.gradians = gradians;
            degrees = MyMath.GradiansToDegrees(gradians);
            radians = MyMath.GradiansToRadians(gradians);
            turns = MyMath.GradiansToTurns(gradians);
            unitVector = MyMath.GradiansToUnitVector(gradians);
            list = MyMath.GradiansToList(gradians);
        }
        #endregion

        #region UpdateByTurns
        public void UpdateByTurns()
        {
            degrees = MyMath.TurnsToDegrees(turns);
            radians = MyMath.TurnsToRadians(turns);
            gradians = MyMath.TurnsToGradians(turns);
            unitVector = MyMath.TurnsToUnitVector(turns);
            list = MyMath.TurnsToList(turns);
        }
        public void UpdateByTurns(double turns)
        {
            this.turns = turns;
            degrees = MyMath.TurnsToDegrees(turns);
            radians = MyMath.TurnsToRadians(turns);
            gradians = MyMath.TurnsToGradians(turns);
            unitVector = MyMath.TurnsToUnitVector(turns);
            list = MyMath.TurnsToList(turns);
        }
        #endregion

        #region UpdateByUnitVector
        public void UpdateByUnitVector()
        {
            degrees = MyMath.UnitVectorToDegrees(unitVector);
            radians = MyMath.UnitVectorToRadians(unitVector);
            gradians = MyMath.UnitVectorToGradians(unitVector);
            turns = MyMath.UnitVectorToTurns(unitVector);
            list = MyMath.UnitVectorToList(unitVector);
        }
        public void UpdateByUnitVector(Vector2 unitVector)
        {
            this.unitVector = unitVector;
            degrees = MyMath.UnitVectorToDegrees(unitVector);
            radians = MyMath.UnitVectorToRadians(unitVector);
            gradians = MyMath.UnitVectorToGradians(unitVector);
            turns = MyMath.UnitVectorToTurns(unitVector);
            list = MyMath.UnitVectorToList(unitVector);
        }
        #endregion

        #region UpdateByList
        public void UpdateByList()
        {
            degrees = MyMath.ListToDegrees(list);
            radians = MyMath.ListToRadians(list);
            gradians = MyMath.ListToGradians(list);
            turns = MyMath.ListToTurns(list);
            unitVector = MyMath.ListToUnitVector(list);
        }
        public void UpdateByList(List<double> list)
        {
            this.list = list;
            degrees = MyMath.ListToDegrees(list);
            radians = MyMath.ListToRadians(list);
            gradians = MyMath.ListToGradians(list);
            turns = MyMath.ListToTurns(list);
            unitVector = MyMath.ListToUnitVector(list);
        }
        #endregion

        #endregion


        #region Operation (Add, Sub, Mult, Div)
        public static Angle Add(Angle lhs, Angle rhs)
        {
            Angle newAngle = new Angle(lhs);
            newAngle.degrees += rhs.degrees;
            newAngle.radians += rhs.radians;
            newAngle.gradians += rhs.gradians;
            newAngle.turns += rhs.turns;
            newAngle.unitVector += rhs.unitVector;
            newAngle.list[0] += rhs.list[0];
            newAngle.list[1] += rhs.list[1];
            return newAngle;
        }
        public static Angle Sub(Angle lhs, Angle rhs)
        {
            Angle newAngle = new Angle(lhs);
            newAngle.degrees -= rhs.degrees;
            newAngle.radians -= rhs.radians;
            newAngle.gradians -= rhs.gradians;
            newAngle.turns -= rhs.turns;
            newAngle.unitVector -= rhs.unitVector;
            newAngle.list[0] -= rhs.list[0];
            newAngle.list[1] -= rhs.list[1];
            return newAngle;
        }
        public static Angle Mult(Angle lhs, Angle rhs)
        {
            Angle newAngle = new Angle(lhs);
            newAngle.degrees *= rhs.degrees;
            newAngle.radians *= rhs.radians;
            newAngle.gradians *= rhs.gradians;
            newAngle.turns *= rhs.turns;
            newAngle.unitVector *= rhs.unitVector;
            newAngle.list[0] *= rhs.list[0];
            newAngle.list[1] *= rhs.list[1];
            return newAngle;
        }
        public static Angle Div(Angle lhs, Angle rhs)
        {
            Angle newAngle = new Angle(lhs);
            newAngle.degrees /= rhs.degrees;
            newAngle.radians /= rhs.radians;
            newAngle.gradians /= rhs.gradians;
            newAngle.turns /= rhs.turns;
            newAngle.unitVector /= rhs.unitVector;
            newAngle.list[0] /= rhs.list[0];
            newAngle.list[1] /= rhs.list[1];
            return newAngle;
        }
        #endregion

        #region Operator overloading
        public static Angle operator +(Angle lhs, Angle rhs) => Add(lhs, rhs);
        public static Angle operator -(Angle lhs, Angle rhs) => Sub(lhs, rhs);
        public static Angle operator *(Angle lhs, Angle rhs) => Mult(lhs, rhs);
        public static Angle operator /(Angle lhs, Angle rhs) => Div(lhs, rhs);
        #endregion

        #region Override ToString()
        public override string ToString()
        {
            return "Degrees : " + degrees + "\n" + 
                "Radians : " + radians + "\n" + 
                "Gradians : " + gradians + "\n" + 
                "Turns : " + turns + "\n" + 
                "UnitVector : " + unitVector + "\n" + 
                "List : [" + list[0] + ", " + list[1] + "]";
        }
        #endregion

        #region Test
        public static void Test()
        {
            Angle a = new Angle(Math.PI);
            Console.WriteLine("[a = Math.PI]\n" + a + "\n");

            Angle b = new Angle(MyMath.ThreePIOverTwo);
            Console.WriteLine("[b = MyMath.ThreePIOverTwo]\n" + b + "\n");

            Console.WriteLine("[a + b]\n" + (a + b) + "\n");
            Console.WriteLine("[a - b]\n" + (a - b) + "\n");
            Console.WriteLine("[a * b]\n" + (a * b) + "\n");
            Console.WriteLine("[a / b]\n" + (a / b) + "\n");
        }
        #endregion

    }
}
