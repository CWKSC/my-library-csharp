using MyLib_Csharp.CommonClass;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MyLib_Csharp.DataStructure
{
    enum AngleType
    {
        Degrees, Radians, Pi, Gradians, Turns
    }

    class Angle
    {
        private double degrees;
        private double radians;
        private double pi;
        private double gradians;
        private double turns;
        private Vector2 vector;
        private Vector2 unitVector;
        private List<double> list;
        private List<double> unitList;

        #region Constructor
        public Angle(double radians) => UpdateByRadians(radians);
        public Angle(AngleType angleType, double value) {
            switch (angleType)
            {
                case AngleType.Degrees: UpdateByDegrees(value); break;
                case AngleType.Radians: UpdateByRadians(value); break;
                case AngleType.Pi: break;
                case AngleType.Gradians: UpdateByGradians(value); break;
                case AngleType.Turns: UpdateByTurns(value); break;
            }
        }
        public Angle(Vector2 unitVector) => UpdateByUnitVector(Vector2.Normalize(unitVector));
        public Angle(List<double> list) => UpdateByList(MyMath.NormalizeList(list));
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

        #region Properties
        public double Degrees { get => degrees; set => UpdateByDegrees(value); }
        public double Radians { get => radians; set => UpdateByRadians(value); }
        public double Gradians { get => gradians; set => UpdateByGradians(value); }
        public double Turns { get => turns; set => UpdateByTurns(value); }
        public Vector2 UnitVector { get => unitVector; set => UpdateByUnitVector(value); }
        public List<double> List { get => list; set => UpdateByList(value); }
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
            UpdateByDegrees();
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
            UpdateByRadians();
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
            UpdateByGradians();
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
            UpdateByTurns();
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
            UpdateByUnitVector();
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
            UpdateByList();
        }
        #endregion

        #endregion


        #region Normalize
        public Angle Normalize()
        {
            Degrees = MyMath.NormalizeDegrees_0_360(degrees);
            return this;
        }
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
            // Constructor //
            Angle a = new Angle(Math.PI);
            Angle b = new Angle(AngleType.Degrees, 30);
            Angle c = new Angle(AngleType.Radians, MyMath.ThreePIOverTwo); // same to Angle a
            Angle d = new Angle(AngleType.Gradians, 400);
            Angle e = new Angle(AngleType.Turns, 0.5);
            Angle f = new Angle(new Vector2(1, 1));
            Angle g = new Angle(new List<double>() {-1, -1});

            // Print //
            Console.WriteLine("[a = new Angle(Math.PI);]\n" + a + "\n");
            Console.WriteLine("[b = MyMath.ThreePIOverTwo]\n" + b + "\n");
            Console.WriteLine("[c = new Angle(AngleType.Radians, MyMath.ThreePIOverTwo);]\n" + c + "\n");
            Console.WriteLine("[d = new Angle(AngleType.Gradians, 400);]\n" + d + "\n");
            Console.WriteLine("[e = new Angle(AngleType.Turns, 0.5);]\n" + e + "\n");
            Console.WriteLine("[f = new Angle(new Vector2(1, 1));]\n" + f + "\n");
            Console.WriteLine("[g = new Angle(new List<double>() {-1, -1});]\n" + g + "\n");

            // Operation //
            Console.WriteLine("[a + b]\n" + (a + b) + "\n");
            Console.WriteLine("[a - b]\n" + (a - b) + "\n");
            Console.WriteLine("[a * b]\n" + (a * b) + "\n");
            Console.WriteLine("[a / b]\n" + (a / b) + "\n");


        }
        #endregion

    }
}
