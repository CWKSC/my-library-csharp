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
        private Vector2 vector2;
        private Vector2 unitVector2;
        private List<double> list;
        private List<double> unitList;

        #region Constructor
        public Angle(double radians) => UpdateByRadians(radians);
        public Angle(AngleType angleType, double value) {
            switch (angleType)
            {
                case AngleType.Degrees: UpdateByDegrees(value); break;
                case AngleType.Radians: UpdateByRadians(value); break;
                case AngleType.Pi: UpdateByPI(value); break;
                case AngleType.Gradians: UpdateByGradians(value); break;
                case AngleType.Turns: UpdateByTurns(value); break;
            }
        }
        public Angle(Vector2 vector) => UpdateByVector2(vector);
        public Angle(List<double> list) => UpdateByList(list);
        /// <summary> new Angle by Angle (A new internal member class will also be created)</summary>
        public Angle(Angle angle)
        {
            degrees = angle.degrees;
            radians = angle.radians;
            pi = angle.pi;
            gradians = angle.gradians;
            turns = angle.turns;
            vector2 = new Vector2(angle.vector2.X, angle.vector2.Y);
            unitVector2 = new Vector2(angle.unitVector2.X, angle.unitVector2.Y);
            list = new List<double>(angle.list);
            unitList = new List<double>(angle.unitList);
        }
        #endregion

        #region Properties
        public double Degrees { get => degrees; set => UpdateByDegrees(value); }
        public double Radians { get => radians; set => UpdateByRadians(value); }
        public double PI { get => pi; set => UpdateByPI(value); }
        public double Gradians { get => gradians; set => UpdateByGradians(value); }
        public double Turns { get => turns; set => UpdateByTurns(value); }
        public Vector2 Vector2 { get => vector2; set => UpdateByVector2(value); }
        public Vector2 UnitVector { get => unitVector2; set => UpdateByUnitVector(value); }
        public List<double> List { get => list; set => UpdateByList(value); }
        public List<double> UnitList { get => unitList; set => UpdateByUnitList(value); }
        #endregion


        #region Update by somethings (Degrees, Radians, Gradians, Turns,  UnitVector, List)

        #region UpdateByDegrees
        public void UpdateByDegrees()
        {
            radians = MyMath.DegreesToRadians(degrees);
            pi = MyMath.DegreesToPI(degrees);
            gradians = MyMath.DegreesToGradians(degrees);
            turns = MyMath.DegreesToTurns(degrees);
            vector2 = MyMath.DegreesToVector2(degrees);
            unitVector2 = MyMath.DegreesToUnitVector2(degrees);
            list = MyMath.DegreesToList(degrees);
            unitList = MyMath.DegreesToUnitList(degrees);
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
            pi = MyMath.RadiansToPI(radians);
            gradians = MyMath.RadiansToGradians(radians);
            turns = MyMath.RadiansToTurns(radians);
            vector2 = MyMath.RadiansToVector2(radians);
            unitVector2 = MyMath.RadiansToUnitVector2(radians);
            list = MyMath.RadiansToList(radians);
            unitList = MyMath.RadiansToUnitList(radians);
        }
        public void UpdateByRadians(double radians)
        {
            this.radians = radians;
            UpdateByRadians();
        }
        #endregion

        #region UpdateByPI
        public void UpdateByPI()
        {
            degrees = MyMath.PIToDegrees(radians);
            radians = MyMath.PIToRadians(radians);
            gradians = MyMath.PIToGradians(radians);
            turns = MyMath.PIToTurns(radians);
            vector2 = MyMath.PIToVector2(radians);
            unitVector2 = MyMath.PIToUnitVector2(radians);
            list = MyMath.PIToList(radians);
            unitList = MyMath.PIToUnitList(radians);
        }
        public void UpdateByPI(double pi)
        {
            this.pi = pi;
            UpdateByPI();
        }
        #endregion

        #region UpdateByGradians
        public void UpdateByGradians()
        {
            degrees = MyMath.GradiansToDegrees(gradians);
            radians = MyMath.GradiansToRadians(gradians);
            pi = MyMath.GradiansToPI(gradians);
            turns = MyMath.GradiansToTurns(gradians);
            vector2 = MyMath.GradiansToVector2(gradians);
            unitVector2 = MyMath.GradiansToUnitVector2(gradians);
            list = MyMath.GradiansToList(gradians);
            unitList = MyMath.GradiansToUnitList(gradians);
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
            pi = MyMath.TurnsToPI(turns);
            gradians = MyMath.TurnsToGradians(turns);
            vector2 = MyMath.TurnsToVector2(turns);
            unitVector2 = MyMath.TurnsToUnitVector2(turns);
            list = MyMath.TurnsToList(turns);
            unitList = MyMath.TurnsToUnitList(turns);
        }
        public void UpdateByTurns(double turns)
        {
            this.turns = turns;
            UpdateByTurns();
        }
        #endregion

        #region UpdateByVector
        public void UpdateByVector2()
        {
            degrees = MyMath.Vector2ToDegrees(vector2);
            radians = MyMath.Vector2ToRadians(vector2);
            pi = MyMath.Vector2ToPI(vector2);
            gradians = MyMath.Vector2ToGradians(vector2);
            turns = MyMath.Vector2ToTurns(vector2);
            unitVector2 = Vector2.Normalize(vector2);
            list = MyMath.Vector2ToList(vector2);
            unitList = MyMath.Vector2ToUnitList(vector2);
        }
        public void UpdateByVector2(Vector2 vector2)
        {
            this.vector2 = vector2;
            UpdateByVector2();
        }
        #endregion

        #region UpdateByUnitVector
        public void UpdateByUnitVector()
        {
            degrees = MyMath.UnitVector2ToDegrees(unitVector2);
            radians = MyMath.UnitVector2ToRadians(unitVector2);
            pi = MyMath.UnitVector2ToPI(unitVector2);
            gradians = MyMath.UnitVector2ToGradians(unitVector2);
            turns = MyMath.UnitVector2ToTurns(unitVector2);
            vector2 = MyMath.UnitVector2ToVector2(unitVector2);
            list = MyMath.UnitVector2ToList(unitVector2);
            unitList = MyMath.UnitVector2ToUnitList(unitVector2);
        }
        public void UpdateByUnitVector(Vector2 unitVector2)
        {
            this.unitVector2 = Vector2.Normalize(unitVector2);
            UpdateByUnitVector();
        }
        #endregion

        #region UpdateByList
        public void UpdateByList()
        {
            degrees = MyMath.ListToDegrees(list);
            radians = MyMath.ListToRadians(list);
            pi = MyMath.ListToPI(list);
            gradians = MyMath.ListToGradians(list);
            turns = MyMath.ListToTurns(list);
            vector2 = MyMath.ListToVector2(list);
            unitVector2 = MyMath.ListToUnitVector2(list);
            unitList = MyMath.ListToUnitList(list);
        }
        public void UpdateByList(List<double> list)
        {
            this.list = list;
            UpdateByList();
        }
        #endregion

        #region UpdateByUnitList
        public void UpdateByUnitList()
        {
            degrees = MyMath.UnitListToDegrees(list);
            radians = MyMath.UnitListToRadians(list);
            pi = MyMath.UnitListToPI(list);
            gradians = MyMath.UnitListToGradians(list);
            turns = MyMath.UnitListToTurns(list);
            vector2 = MyMath.UnitListToVector2(list);
            unitVector2 = MyMath.UnitListToUnitVector2(list);
            list = MyMath.UnitListToList(list);
        }
        public void UpdateByUnitList(List<double> list)
        {
            this.list = list;
            UpdateByUnitList();
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
            newAngle.unitVector2 += rhs.unitVector2;
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
            newAngle.unitVector2 -= rhs.unitVector2;
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
            newAngle.unitVector2 *= rhs.unitVector2;
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
            newAngle.unitVector2 /= rhs.unitVector2;
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
                "Radians : " + radians + " Pi : " + pi + "\n" + 
                "Gradians : " + gradians + "\n" + 
                "Turns : " + turns + "\n" + 
                "Vector : " + vector2 + " UnitVector : " + unitVector2 + "\n" +
                "List : [" + list[0] + ", " + list[1] + "]" + " UnitList : [" + unitList[0] + ", " + unitList[1] + "]";
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
