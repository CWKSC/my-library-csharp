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
        public const double DegToRad = Math.PI / 180d;
        public const double DegToPI = 1 / 180d;
        public const double DegToGrad = 10d / 9d;
        public const double DegToTurn = 1d / 360d;

        public const double RadToDeg = 180d / Math.PI;
        public const double RadToPI = 1d / Math.PI;
        public const double RadToGrad = 200d / Math.PI;
        public const double RadToTurn = 1d / (2d * Math.PI);

        public const double PIToDeg = 180d;
        public const double PIToRad = Math.PI;
        public const double PIToGrad = 200d;
        public const double PIToTurn = 1d / 2d;

        public const double GradToDeg = 9d / 10d;
        public const double GradToRad = Math.PI / 200d;
        public const double GradToPI = 1d / 200d;
        public const double GradToTurn = 1d / 400d;

        public const double TurnToDeg = 360d;
        public const double TurnToRad = 2d * Math.PI;
        public const double TurnToPI = 2d;
        public const double TurnToGrad = 400d;

        public const double RightAngleDeg = TurnToDeg / 4d;
        public const double RightAngleRad = TurnToRad / 4d;
        public const double RightAnglePI = TurnToPI / 4d;
        public const double RightAngleGrad = TurnToGrad / 4d;
        public const double RightAngleTurn = 1d / 4d;

        public const double HalfTurnDeg = TurnToDeg / 2d;
        public const double HalfTurnRad = TurnToRad / 2d;
        public const double HalgTurnPI = TurnToPI / 2d;
        public const double HalfTurngGrad = TurnToGrad / 2d;
        public const double HalfTurn = 1d / 2d;
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
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_Radians(List<double> list)
        {
            double result = Math.Atan2(list[1], list[0]);
            return result < 0 ? result + TwoPI : result;
        }
        #endregion

        #region CartesianToPolar_PI
        /// <summary> [0, 2) </summary> 
        public static double CartesianToPolar_PI(double x, double y) => CartesianToPolar_Radians(x, y) * RadToPI;
        /// <summary> [0, 2) </summary> 
        public static double CartesianToPolar_PI(Vector2 point) => CartesianToPolar_Radians(point) * RadToPI;
        /// <summary> [0, 2) </summary> 
        public static double CartesianToPolar_PI(List<double> list) => CartesianToPolar_Radians(list) * RadToPI;
        #endregion

        #region CartesianToPolar_Degrees
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_Degrees(double x, double y) => CartesianToPolar_Radians(x, y) * RadToDeg;
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_Degrees(Vector2 point) => CartesianToPolar_Radians(point) * RadToDeg;
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_Degrees(List<double> list) => CartesianToPolar_Radians(list) * RadToDeg;
        #endregion

        #region CartesianToPolar_Gradians
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_Gradians(double x, double y) => CartesianToPolar_Radians(x, y) * RadToGrad;
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_Gradians(Vector2 point) => CartesianToPolar_Radians(point) * RadToGrad;
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_Gradians(List<double> list) => CartesianToPolar_Radians(list) * RadToGrad;
        #endregion

        #region CartesianToPolar_Turns
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_Turns(double x, double y) => CartesianToPolar_Radians(x, y) * RadToTurn;
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_Turns(Vector2 point) => CartesianToPolar_Radians(point) * RadToTurn;
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_Turns(List<double> list) => CartesianToPolar_Radians(list) * RadToTurn;
        #endregion

        #endregion

        #region Cartesian to Polar (start at Up)

        #region CartesianToPolar_Radians
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtUp_Radians(double x, double y) => CartesianToPolar_Radians(x, y) - RightAngleRad;
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtUp_Radians(Vector2 point) => CartesianToPolar_Radians(point) - RightAngleRad;
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtUp_Radians(List<double> list) => CartesianToPolar_Radians(list) - RightAngleRad;
        #endregion

        #region CartesianToPolar_PI
        /// <summary> [0, 2) </summary> 
        public static double CartesianToPolar_startAtUp_PI(double x, double y) => CartesianToPolar_startAtUp_Radians(x, y) * RadToPI;
        /// <summary> [0, 2) </summary> 
        public static double CartesianToPolar_startAtUp_PI(Vector2 point) => CartesianToPolar_startAtUp_Radians(point) * RadToPI;
        /// <summary> [0, 2) </summary> 
        public static double CartesianToPolar_startAtUp_PI(List<double> list) => CartesianToPolar_startAtUp_Radians(list) * RadToPI;
        #endregion

        #region CartesianToPolar_Degrees
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtUp_Degrees(double x, double y) => CartesianToPolar_startAtUp_Radians(x, y) * RadToDeg;
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtUp_Degrees(Vector2 point) => CartesianToPolar_startAtUp_Radians(point) * RadToDeg;
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtUp_Degrees(List<double> list) => CartesianToPolar_startAtUp_Radians(list) * RadToDeg;
        #endregion

        #region CartesianToPolar_Gradians
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtUp_Gradians(double x, double y) => CartesianToPolar_startAtUp_Radians(x, y) * RadToGrad;
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtUp_Gradians(Vector2 point) => CartesianToPolar_startAtUp_Radians(point) * RadToGrad;
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtUp_Gradians(List<double> list) => CartesianToPolar_startAtUp_Radians(list) * RadToGrad;
        #endregion

        #region CartesianToPolar_Turns
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtUp_Turns(double x, double y) => CartesianToPolar_startAtUp_Radians(x, y) * RadToTurn;
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtUp_Turns(Vector2 point) => CartesianToPolar_startAtUp_Radians(point) * RadToTurn;
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtUp_Turns(List<double> list) => CartesianToPolar_startAtUp_Radians(list) * RadToTurn;
        #endregion

        #endregion

        #region Cartesian to Polar (start at Left)

        #region CartesianToPolar_Radians
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtLeft_Radians(double x, double y) => CartesianToPolar_Radians(x, y) - 2 * RightAngleRad;
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtLeft_Radians(Vector2 point) => CartesianToPolar_Radians(point) - 2 * RightAngleRad;
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtLeft_Radians(List<double> list) => CartesianToPolar_Radians(list) - 2 * RightAngleRad;
        #endregion

        #region CartesianToPolar_PI
        /// <summary> [0, 2) </summary> 
        public static double CartesianToPolar_startAtLeft_PI(double x, double y) => CartesianToPolar_startAtLeft_Radians(x, y) * RadToPI;
        /// <summary> [0, 2) </summary> 
        public static double CartesianToPolar_startAtLeft_PI(Vector2 point) => CartesianToPolar_startAtLeft_Radians(point) * RadToPI;
        /// <summary> [0, 2) </summary> 
        public static double CartesianToPolar_startAtLeft_PI(List<double> list) => CartesianToPolar_startAtLeft_Radians(list) * RadToPI;
        #endregion

        #region CartesianToPolar_Degrees
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtLeft_Degrees(double x, double y) => CartesianToPolar_startAtLeft_Radians(x, y) * RadToDeg;
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtLeft_Degrees(Vector2 point) => CartesianToPolar_startAtLeft_Radians(point) * RadToDeg;
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtLeft_Degrees(List<double> list) => CartesianToPolar_startAtLeft_Radians(list) * RadToDeg;
        #endregion

        #region CartesianToPolar_Gradians
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtLeft_Gradians(double x, double y) => CartesianToPolar_startAtLeft_Radians(x, y) * RadToGrad;
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtLeft_Gradians(Vector2 point) => CartesianToPolar_startAtLeft_Radians(point) * RadToGrad;
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtLeft_Gradians(List<double> list) => CartesianToPolar_startAtLeft_Radians(list) * RadToGrad;
        #endregion

        #region CartesianToPolar_Turns
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtLeft_Turns(double x, double y) => CartesianToPolar_startAtLeft_Radians(x, y) * RadToTurn;
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtLeft_Turns(Vector2 point) => CartesianToPolar_startAtLeft_Radians(point) * RadToTurn;
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtLeft_Turns(List<double> list) => CartesianToPolar_startAtLeft_Radians(list) * RadToTurn;
        #endregion

        #endregion

        #region Cartesian to Polar (start at Down)

        #region CartesianToPolar_Radians
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtDown_Radians(double x, double y) => CartesianToPolar_Radians(x, y) - 3 * RightAngleRad;
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtDown_Radians(Vector2 point) => CartesianToPolar_Radians(point) - 3 * RightAngleRad;
        /// <summary> [0, TwoPI) </summary> 
        public static double CartesianToPolar_startAtDown_Radians(List<double> list) => CartesianToPolar_Radians(list) - 3 * RightAngleRad;
        #endregion

        #region CartesianToPolar_PI
        /// <summary> [0, 2) </summary> 
        public static double CartesianToPolar_startAtDown_PI(double x, double y) => CartesianToPolar_startAtDown_Radians(x, y) * RadToPI;
        /// <summary> [0, 2) </summary> 
        public static double CartesianToPolar_startAtDown_PI(Vector2 point) => CartesianToPolar_startAtDown_Radians(point) * RadToPI;
        /// <summary> [0, 2) </summary> 
        public static double CartesianToPolar_startAtDown_PI(List<double> list) => CartesianToPolar_startAtDown_Radians(list) * RadToPI;
        #endregion

        #region CartesianToPolar_Degrees
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtDown_Degrees(double x, double y) => CartesianToPolar_startAtDown_Radians(x, y) * RadToDeg;
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtDown_Degrees(Vector2 point) => CartesianToPolar_startAtDown_Radians(point) * RadToDeg;
        /// <summary> [0, 360) </summary> 
        public static double CartesianToPolar_startAtDown_Degrees(List<double> list) => CartesianToPolar_startAtDown_Radians(list) * RadToDeg;
        #endregion

        #region CartesianToPolar_Gradians
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtDown_Gradians(double x, double y) => CartesianToPolar_startAtDown_Radians(x, y) * RadToGrad;
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtDown_Gradians(Vector2 point) => CartesianToPolar_startAtDown_Radians(point) * RadToGrad;
        /// <summary> [0, 400) </summary> 
        public static double CartesianToPolar_startAtDown_Gradians(List<double> list) => CartesianToPolar_startAtDown_Radians(list) * RadToGrad;
        #endregion

        #region CartesianToPolar_Turns
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtDown_Turns(double x, double y) => CartesianToPolar_startAtDown_Radians(x, y) * RadToTurn;
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtDown_Turns(Vector2 point) => CartesianToPolar_startAtDown_Radians(point) * RadToTurn;
        /// <summary> [0, 1) </summary> 
        public static double CartesianToPolar_startAtDown_Turns(List<double> list) => CartesianToPolar_startAtDown_Radians(list) * RadToTurn;
        #endregion

        #endregion

        #endregion

        #region s
        public double Integral(Func<double, double> func, double lower, double upper, double step = 0.001)
        {
            double sum = 0;
            for (double i = lower; i <= upper; i += step)
            {
                sum += func(i) * step;
            }
            return sum;
        }
        #endregion

        #region Convert

        #region Degrees convert
        public static double DegreesToRadians(double degrees) => degrees * DegToRad;
        public static double DegreesToPI(double degrees) => degrees * DegToPI;
        public static double DegreesToGradians(double degrees) => degrees * DegToGrad;
        public static double DegreesToTurns(double degrees) => degrees * DegToTurn;
        public static Vector2 DegreesToVector2(double degrees) => RadiansToVector2(DegreesToRadians(degrees));
        public static Vector2 DegreesToUnitVector2(double degrees) => RadiansToUnitVector2(DegreesToRadians(degrees));
        public static List<double> DegreesToList(double degrees) => RadiansToList(DegreesToRadians(degrees));
        public static List<double> DegreesToUnitList(double degrees) => RadiansToUnitList(DegreesToRadians(degrees));
        /// <summary> return new Angle </summary>
        public static Angle DegreesToAngle(double degrees) => new Angle(AngleType.Degrees, degrees);
        #endregion

        #region Radians convert
        public static double RadiansToDegrees(double radians) => radians * RadToDeg;
        public static double RadiansToPI(double radians) => radians * RadToPI;
        public static double RadiansToGradians(double radians) => radians * RadToGrad;
        public static double RadiansToTurns(double radians) => radians * RadToTurn;
        public static Vector2 RadiansToVector2(double radians) => new Vector2((float)Math.Cos(radians), (float)Math.Sin(radians));
        public static Vector2 RadiansToUnitVector2(double radians) => Vector2.Normalize(RadiansToVector2(radians));
        public static List<double> RadiansToList(double radians) => new List<double>() { Math.Cos(radians), Math.Sin(radians) };
        public static List<double> RadiansToUnitList(double radians) => NormalizeList(RadiansToList(radians));
        /// <summary> return new Angle </summary>
        public static Angle RadiansToAngle(double radians) => new Angle(radians);
        #endregion

        #region PI convert
        public static double PIToDegrees(double pi) => pi * PIToDeg;
        public static double PIToRadians(double pi) => pi * PIToRad;
        public static double PIToGradians(double pi) => pi * PIToGrad;
        public static double PIToTurns(double pi) => pi * PIToTurn;
        public static Vector2 PIToVector2(double pi) => RadiansToVector2(PIToRadians(pi));
        public static Vector2 PIToUnitVector2(double pi) => RadiansToUnitVector2(PIToRadians(pi));
        public static List<double> PIToList(double pi) => RadiansToList(PIToRadians(pi));
        public static List<double> PIToUnitList(double pi) => RadiansToUnitList(PIToRadians(pi));
        /// <summary> return new Angle </summary>
        public static Angle PIToAngle(double pi) => new Angle(AngleType.Pi, pi);
        #endregion

        #region Gradians convert
        public static double GradiansToDegrees(double gradians) => gradians * GradToDeg;
        public static double GradiansToRadians(double gradians) => gradians * GradToRad;
        public static double GradiansToPI(double gradians) => gradians * GradToPI;
        public static double GradiansToTurns(double gradians) => gradians * GradToTurn;
        public static Vector2 GradiansToVector2(double gradians) => RadiansToVector2(GradiansToRadians(gradians));
        public static Vector2 GradiansToUnitVector2(double gradians) => RadiansToUnitVector2(GradiansToRadians(gradians));
        public static List<double> GradiansToList(double gradians) => RadiansToList(GradiansToRadians(gradians));
        public static List<double> GradiansToUnitList(double gradians) => RadiansToUnitList(GradiansToRadians(gradians));
        /// <summary> return new Angle </summary>
        public static Angle GradiansToAngle(double gradians) => new Angle(AngleType.Gradians, gradians);
        #endregion

        #region Turn convert
        public static double TurnsToDegrees(double turns) => turns * TurnToDeg;
        public static double TurnsToRadians(double turns) => turns * TurnToRad;
        public static double TurnsToPI(double turns) => turns * TurnToPI;
        public static double TurnsToGradians(double turns) => turns * TurnToGrad;
        public static Vector2 TurnsToVector2(double turns) => RadiansToVector2(TurnsToRadians(turns));
        public static Vector2 TurnsToUnitVector2(double turns) => RadiansToUnitVector2(TurnsToRadians(turns));
        public static List<double> TurnsToList(double turns) => RadiansToList(TurnsToRadians(turns));
        public static List<double> TurnsToUnitList(double turns) => RadiansToUnitList(TurnsToRadians(turns));
        public static Angle TurnsToAngle(double turns) => new Angle(AngleType.Turns, turns);
        #endregion

        #region Vector2 convert
        public static double Vector2ToDegrees(Vector2 vector2) => CartesianToPolar_Degrees(vector2);
        public static double Vector2ToRadians(Vector2 vector2) => CartesianToPolar_Radians(vector2);
        public static double Vector2ToPI(Vector2 vector2) => CartesianToPolar_PI(vector2);
        public static double Vector2ToGradians(Vector2 vector2) => CartesianToPolar_Gradians(vector2);
        public static double Vector2ToTurns(Vector2 vector2) => CartesianToPolar_Turns(vector2);
        public static Vector2 Vector2ToUnitVector2(Vector2 vector2) => Vector2.Normalize(vector2);
        /// <summary> return new List </summary>
        public static List<double> Vector2ToList(Vector2 vector2) => new List<double>() { vector2.X, vector2.Y };
        /// <summary> return new List </summary>
        public static List<double> Vector2ToUnitList(Vector2 vector2) => NormalizeList(Vector2ToList(vector2));
        /// <summary> return new Angle </summary>
        public static Angle Vector2ToAngle(Vector2 vector2) => new Angle(vector2);
        #endregion

        #region UnitVector2 convert
        public static double UnitVector2ToDegrees(Vector2 unitVector2) => CartesianToPolar_Degrees(Vector2.Normalize(unitVector2));
        public static double UnitVector2ToRadians(Vector2 unitVector2) => CartesianToPolar_Radians(Vector2.Normalize(unitVector2));
        public static double UnitVector2ToPI(Vector2 unitVector2) => CartesianToPolar_PI(Vector2.Normalize(unitVector2));
        public static double UnitVector2ToGradians(Vector2 unitVector2) => CartesianToPolar_Gradians(Vector2.Normalize(unitVector2));
        public static double UnitVector2ToTurns(Vector2 unitVector2) => CartesianToPolar_Turns(Vector2.Normalize(unitVector2));
        public static Vector2 UnitVector2ToVector2(Vector2 unitVector2) => Vector2ToUnitVector2(unitVector2);
        public static List<double> UnitVector2ToList(Vector2 unitVector2) => Vector2ToList(Vector2.Normalize(unitVector2));
        public static List<double> UnitVector2ToUnitList(Vector2 unitVector2) => Vector2ToUnitList(unitVector2);
        /// <summary> return new Angle </summary>
        public static Angle UnitVector2ToAngle(Vector2 unitVector2) => new Angle(Vector2.Normalize(unitVector2));
        #endregion

        #region List convert
        public static double ListToDegrees(List<double> list) => CartesianToPolar_Degrees(list);
        public static double ListToRadians(List<double> list) => CartesianToPolar_Radians(list);
        public static double ListToPI(List<double> list) => CartesianToPolar_PI(list);
        public static double ListToGradians(List<double> list) => CartesianToPolar_Gradians(list);
        public static double ListToTurns(List<double> list) => CartesianToPolar_Turns(list);
        public static Vector2 ListToVector2(List<double> list) => new Vector2((float) list[0], (float) list[1]);
        /// <summary> return new Vector2 </summary>
        public static Vector2 ListToUnitVector2(List<double> list) => Vector2.Normalize(new Vector2((float)list[0], (float)list[1]));
        /// <summary> return new List </summary>
        public static List<double> ListToUnitList(List<double> list) => NormalizeList(list);
        /// <summary> return new Angle </summary>
        public static Angle ListToAngle(List<double> list) => new Angle(list);
        #endregion

        #region UnitList convert
        public static double UnitListToDegrees(List<double> unitList) => CartesianToPolar_Degrees(NormalizeList(unitList));
        public static double UnitListToRadians(List<double> unitList) => CartesianToPolar_Radians(NormalizeList(unitList));
        public static double UnitListToPI(List<double> unitList) => CartesianToPolar_PI(NormalizeList(unitList));
        public static double UnitListToGradians(List<double> unitList) => CartesianToPolar_Gradians(NormalizeList(unitList));
        public static double UnitListToTurns(List<double> unitList) => CartesianToPolar_Turns(NormalizeList(unitList));
        public static Vector2 UnitListToVector2(List<double> unitList) => ListToVector2(NormalizeList(unitList));
        /// <summary> return new Vector2 </summary>
        public static Vector2 UnitListToUnitVector2(List<double> unitList) => ListToUnitVector2(NormalizeList(unitList));
        /// <summary> return new List </summary>
        public static List<double> UnitListToList(List<double> unitList) => new List<double>(NormalizeList(unitList));
        /// <summary> return new Angle </summary>
        public static Angle UnitListToAngle(List<double> unitList) => new Angle(NormalizeList(unitList));
        #endregion

        #endregion

        #region Normalize

        #region NormalizeList
        /// <summary> return new List </summary>
        public static List<double> NormalizeList(List<double> list) => UnitVector2ToList(ListToUnitVector2(list));
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
