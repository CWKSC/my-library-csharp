using MyLib_Csharp.DataStructure;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    class MyMath
    {

        #region Static constant 

        #region PI
        public const double TwoPI = 2 * Math.PI;
        public const double PIOver2 = Math.PI / 2;
        public const double PIOver4 = Math.PI / 4;
        public const double PIOver6 = Math.PI / 6;
        public const double PIOver8 = Math.PI / 8;
        public const double PIOver16 = Math.PI / 16;
        public const double PIOver32 = Math.PI / 32;
        public const double PIOver64 = Math.PI / 64;
        public const double ThreePIOverTwo = 3 * Math.PI / 2;
        #endregion

        #region Angle convert constant
        public const double DegToRad = Math.PI / 180;
        public const double DegToGrad = 10 / 9;
        public const double DegToTurn = 1 / 360;

        public const double RadToDeg = 180 / Math.PI;
        public const double RadToGrad = 200 / Math.PI;
        public const double RadToTurn = 1 / (2 * Math.PI);

        public const double GradToDeg = 9 / 10;
        public const double GradToRad = Math.PI / 200;
        public const double GradToTurn = 1 / 400;

        public const double TurnToDeg = 360;
        public const double TurnToRad = 2 * Math.PI;
        public const double TurnToGrad = 400;

        public const double RightAngleDeg = TurnToDeg / 4;
        public const double RightAngleRad = TurnToRad / 4;
        public const double RightAngleGrad = TurnToGrad / 4;
        public const double RightAngleTurn = 1 / 4;

        public const double HalfTurnDeg = TurnToDeg / 2;
        public const double HalfTurnRad = TurnToRad / 2;
        public const double HalfTurngGrad = TurnToGrad / 2;
        public const double HalfTurn = 1 / 2;
        #endregion

        #region Square of root
        public const float squareRoot2_float = 1.41421356237309504880168872420969807856967187537694807317667973799073247846210703885038753432764157f;
        public const float squareRoot3_float = 1.7320508075688772935274463415058723669428052538103806280558069794519330169088000370811461867572485756756261414154f;
        public const float squareRoot5_float = 2.23606797749978969640917366873127623544061835961152572427089724541052092563780489941441440837878227f;
        public const float squareRoot6_float = 2.44948974278317809819728407470589139196594748065667f;
        public const float squareRoot7_float = 2.64575131106459059050161575363926042571025918308245f;
        public const float squareRoot8_float = 2.82842712474619009760337744841939615713934375075389f;
        public const float squareRoot10_float = 3.16227766016837933199889354443271853371955513932521f;

        public const double squareRoot2_double = 1.41421356237309504880168872420969807856967187537694807317667973799073247846210703885038753432764157;
        public const double squareRoot3_double = 1.7320508075688772935274463415058723669428052538103806280558069794519330169088000370811461867572485756756261414154;
        public const double squareRoot5_double = 2.23606797749978969640917366873127623544061835961152572427089724541052092563780489941441440837878227;
        public const double squareRoot6_double = 2.44948974278317809819728407470589139196594748065667;
        public const double squareRoot7_double = 2.64575131106459059050161575363926042571025918308245;
        public const double squareRoot8_double = 2.82842712474619009760337744841939615713934375075389;
        public const double squareRoot10_double = 3.16227766016837933199889354443271853371955513932521;

        public const decimal squareRoot2_decimal = 1.41421356237309504880168872420969807856967187537694807317667973799073247846210703885038753432764157M;
        public const decimal squareRoot3_decimal = 1.7320508075688772935274463415058723669428052538103806280558069794519330169088000370811461867572485756756261414154M;
        public const decimal squareRoot5_decimal = 2.23606797749978969640917366873127623544061835961152572427089724541052092563780489941441440837878227M;
        public const decimal squareRoot6_decimal = 2.44948974278317809819728407470589139196594748065667M;
        public const decimal squareRoot7_decimal = 2.64575131106459059050161575363926042571025918308245M;
        public const decimal squareRoot8_decimal = 2.82842712474619009760337744841939615713934375075389M;
        public const decimal squareRoot10_decimal = 3.16227766016837933199889354443271853371955513932521M;
        #endregion

        #endregion

        #region Trigonometric functions
        public static double Sin(double degrees) => Math.Sin(DegreesToRadians(degrees));
        public static double Cos(double degrees) => Math.Cos(DegreesToRadians(degrees));
        public static double Tan(double degrees) => Math.Tan(DegreesToRadians(degrees));
        public static double Atan2(Vector2 point) => Math.Atan2(point.Y, point.X);
        public static double Atan2(List<double> list) => Math.Atan2(list[1], list[0]);
        #endregion

        #region Cartesian to Polar

        #region Cartesian to Polar (default)

        #region CartesianToPolar_Radians
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_Radians(double x, double y)
        {
            double result = Math.Atan2(y, x);
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_Radians(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X);
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_Radians(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]);
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #region CartesianToPolar_Degrees
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_Degrees(double x, double y)
        {
            double result = Math.Atan2(y, x) * RadToDeg;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_Degrees(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X) * RadToDeg;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_Degrees(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]) * RadToDeg;
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #region CartesianToPolar_Gradians
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_Gradians(double x, double y)
        {
            double result = Math.Atan2(y, x) * RadToGrad;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_Gradians(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X) * RadToGrad;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_Gradians(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]) * RadToGrad;
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #region CartesianToPolar_Turns
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_Turns(double x, double y)
        {
            double result = Math.Atan2(y, x);
            return (result < 0 ? result + TwoPI : result) * RadToTurn;
        }
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_Turns(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X);
            return (result < 0 ? result + TwoPI : result) * RadToTurn;
        }
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_Turns(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]);
            return (result < 0 ? result + TwoPI : result) * RadToTurn;
        }
        #endregion

        #endregion

        #region Cartesian to Polar (start at Up)

        #region CartesianToPolar_Radians
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtUp_Radians(double x, double y)
        {
            double result = Math.Atan2(y, x) - RightAngleRad;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtUp_Radians(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X) - RightAngleRad;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtUp_Radians(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]) - RightAngleRad;
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #region CartesianToPolar_Degrees
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtUp_Degrees(double x, double y)
        {
            double result = Math.Atan2(y, x) * RadToDeg - RightAngleDeg;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtUp_Degrees(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X) * RadToDeg - RightAngleDeg;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtUp_Degrees(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]) * RadToDeg - RightAngleDeg;
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #region CartesianToPolar_Gradians
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtUp_Gradians(double x, double y)
        {
            double result = Math.Atan2(y, x) * RadToGrad - RightAngleGrad;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtUp_Gradians(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X) * RadToGrad - RightAngleGrad;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtUp_Gradians(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]) * RadToGrad - RightAngleGrad;
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #region CartesianToPolar_Turns
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtUp_Turns(double x, double y)
        {
            double result = Math.Atan2(y, x) * RadToTurn - RightAngleTurn;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtUp_Turns(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X) * RadToTurn - RightAngleTurn;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtUp_Turns(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]) * RadToTurn - RightAngleTurn;
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #endregion

        #region Cartesian to Polar (start at Left)

        #region CartesianToPolar_Radians
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtLeft_Radians(double x, double y)
        {
            double result = Math.Atan2(y, x) - 2 * RightAngleRad;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtLeft_Radians(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X) - 2 * RightAngleRad;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtLeft_Radians(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]) - 2 * RightAngleRad;
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #region CartesianToPolar_Degrees
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtLeft_Degrees(double x, double y)
        {
            double result = Math.Atan2(y, x) * RadToDeg - 2 * RightAngleDeg;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtLeft_Degrees(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X) * RadToDeg - 2 * RightAngleDeg;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtLeft_Degrees(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]) * RadToDeg - 2 * RightAngleDeg;
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #region CartesianToPolar_Gradians
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtLeft_Gradians(double x, double y)
        {
            double result = Math.Atan2(y, x) * RadToGrad - 2 * RightAngleGrad;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtLeft_Gradians(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X) * RadToGrad - 2 * RightAngleGrad;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtLeft_Gradians(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]) * RadToGrad - 2 * RightAngleGrad;
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #region CartesianToPolar_Turns
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtLeft_Turns(double x, double y)
        {
            double result = Math.Atan2(y, x) * RadToTurn - 2 * RightAngleTurn;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtLeft_Turns(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X) * RadToTurn - 2 * RightAngleTurn;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtLeft_Turns(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]) * RadToTurn - 2 * RightAngleTurn;
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #endregion

        #region Cartesian to Polar (start at Down)

        #region CartesianToPolar_Radians
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtDown_Radians(double x, double y)
        {
            double result = Math.Atan2(y, x) - 3 * RightAngleRad;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtDown_Radians(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X) - 3 * RightAngleRad;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtDown_Radians(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]) - 3 * RightAngleRad;
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #region CartesianToPolar_Degrees
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtDown_Degrees(double x, double y)
        {
            double result = Math.Atan2(y, x) * RadToDeg - 3 * RightAngleDeg;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtDown_Degrees(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X) * RadToDeg - 3 * RightAngleDeg;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtDown_Degrees(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]) * RadToDeg - 3 * RightAngleDeg;
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #region CartesianToPolar_Gradians
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtDown_Gradians(double x, double y)
        {
            double result = Math.Atan2(y, x) * RadToGrad - 3 * RightAngleGrad;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtDown_Gradians(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X) * RadToGrad - 3 * RightAngleGrad;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtDown_Gradians(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]) * RadToGrad - 3 * RightAngleGrad;
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #region CartesianToPolar_Turns
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtDown_Turns(double x, double y)
        {
            double result = Math.Atan2(y, x) * RadToTurn - 3 * RightAngleTurn;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtDown_Turns(Vector2 point)
        {
            double result = Math.Atan2(point.Y, point.X) * RadToTurn - 3 * RightAngleTurn;
            return result < 0 ? result + TwoPI : result;
        }
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtDown_Turns(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]) * RadToTurn - 3 * RightAngleTurn;
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #endregion

        #endregion


        #region Convert

        #region Degrees convert
        public static double DegreesToRadians(double degrees) => degrees * DegToRad;
        public static double DegreesToGradians(double degrees) => degrees * DegToGrad;
        public static double DegreesToTurns(double degrees) => degrees * DegToTurn;
        public static Vector2 DegreesToUnitVector(double degrees) => Vector2.Normalize(new Vector2((float)Math.Cos(DegreesToRadians(degrees)), (float)Math.Sin(DegreesToRadians(degrees))));
        public static List<double> DegreesToList(double degrees) => new List<double>() { Math.Cos(DegreesToRadians(degrees)), Math.Sin(DegreesToRadians(degrees)) };
        /// <summary> return new Angle </summary>
        public static Angle DegreesToAngle(double degrees) => new Angle(AngleType.Degrees, degrees);
        #endregion

        #region Radians convert
        public static double RadiansToDegrees(double radians) => radians * RadToDeg;
        public static double RadiansToGradians(double radians) => radians * RadToGrad;
        public static double RadiansToTurns(double radians) => radians * RadToTurn;
        public static Vector2 RadiansToUnitVector(double radians) => DegreesToUnitVector(RadiansToDegrees(radians));
        public static List<double> RadiansToList(double radians) => DegreesToList(RadiansToDegrees(radians));
        /// <summary> return new Angle </summary>
        public static Angle RadiansToAngle(double radians) => new Angle(radians);
        #endregion

        #region Gradians convert
        public static double GradiansToDegrees(double gradians) => gradians * GradToDeg;
        public static double GradiansToRadians(double gradians) => gradians * GradToRad;
        public static double GradiansToTurns(double gradians) => gradians * GradToTurn;
        public static Vector2 GradiansToUnitVector(double gradians) => DegreesToUnitVector(GradiansToDegrees(gradians));
        public static List<double> GradiansToList(double gradians) => DegreesToList(GradiansToDegrees(gradians));
        /// <summary> return new Angle </summary>
        public static Angle GradiansToAngle(double gradians) => new Angle(AngleType.Gradians, gradians);
        #endregion

        #region Turn convert
        public static double TurnsToDegrees(double turns) => turns * TurnToDeg;
        public static double TurnsToRadians(double turns) => turns * TurnToRad;
        public static double TurnsToGradians(double turns) => turns * TurnToGrad;
        public static Vector2 TurnsToUnitVector(double turns) => DegreesToUnitVector(TurnsToDegrees(turns));
        public static List<double> TurnsToList(double turns) => DegreesToList(TurnsToDegrees(turns));
        public static Angle TurnsToAngle(double turns) => new Angle(AngleType.Turns, turns);
        #endregion

        #region UnitVector convert
        public static double UnitVectorToDegrees(Vector2 unitVector) => CartesianToPolar_Degrees(unitVector);
        public static double UnitVectorToRadians(Vector2 unitVector) => CartesianToPolar_Radians(unitVector);
        public static double UnitVectorToGradians(Vector2 unitVector) => CartesianToPolar_Gradians(unitVector);
        public static double UnitVectorToTurns(Vector2 unitVector) => CartesianToPolar_Turns(unitVector);
        public static List<double> UnitVectorToList(Vector2 unitVector) => new List<double>() { unitVector.X, unitVector.Y };
        /// <summary> return new Angle </summary>
        public static Angle UnitVectorToAngle(Vector2 unitVector) => new Angle(unitVector);

        #endregion

        #region List convert
        public static double ListToDegrees(List<double> list) => CartesianToPolar_Degrees(list);
        public static double ListToRadians(List<double> list) => CartesianToPolar_Radians(list);
        public static double ListToGradians(List<double> list) => CartesianToPolar_Gradians(list);
        public static double ListToTurns(List<double> list) => CartesianToPolar_Turns(list);
        public static Vector2 ListToUnitVector(List<double> list) => Vector2.Normalize(new Vector2((float)list[0], (float)list[1]));
        /// <summary> return new Angle </summary>
        public static Angle ListToAngle(List<double> list) => new Angle(list);
        #endregion

        #endregion

        #region Normalize

        #region NormalizeList
        public static List<double> NormalizeList(List<double> list) => UnitVectorToList(ListToUnitVector(list));
        #endregion

        #region Normalize angle

        #region Normalize angle [0, fullTurn)
        /// <summary> [0, 360) </summary>
        public static double NormalizeDegrees_0_360(double degrees)
        {
            while (degrees >= TurnToDeg) degrees -= TurnToDeg;
            while (degrees < 0) degrees += TurnToDeg;
            return degrees;
        }
        /// <summary> [0, TwoPI) </summary>
        public static double NormalizeRadians_0_TwoPI(double radians)
        {
            while (radians >= TurnToRad) radians -= TurnToRad;
            while (radians < 0) radians += TurnToRad;
            return radians;
        }
        /// <summary> [0, 400) </summary>
        public static double NormalizeGradians_0_400(double gradians)
        {
            while (gradians >= TurnToGrad) gradians -= TurnToGrad;
            while (gradians < 0) gradians += TurnToGrad;
            return gradians;
        }
        /// <summary> [0, 1) </summary>
        public static double NormalizeTurn_0_1(double turns)
        {
            while (turns >= 0) turns -= 1;
            while (turns < 0) turns += 1;
            return turns;
        }
        /// <summary> [0, fullTurn) , return new Angle</summary> 
        public static Angle NormalizeAngle_0_fullTurn(Angle angle) => new Angle(angle).Normalize();
        #endregion

        #region Normalize angle [-halfTurn, halfTurn)
        /// <summary> [-180, 180) </summary>
        public static double NormalizeDegrees_neg180_180(double degrees)
        {
            while (degrees >= HalfTurnDeg) degrees -= TurnToDeg;
            while( degrees < -HalfTurnDeg) degrees += TurnToDeg;
            return degrees;
        }
        #endregion

        #endregion

        #endregion

        #region Test
        public static void Test()
        {

        }
        #endregion
    }
}
