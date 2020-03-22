# MyLib_Csharp
My Csharp Library

MyMath

```C#
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

MyMath.Atan2(System.Collections.Generic.List<double>);
MyMath.Atan2(System.Numerics.Vector2);
MyMath.CartesianToPolar_Degrees(double, double);
MyMath.CartesianToPolar_Degrees(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_Degrees(System.Numerics.Vector2);
MyMath.CartesianToPolar_Gradians(double, double);
MyMath.CartesianToPolar_Gradians(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_Gradians(System.Numerics.Vector2);
MyMath.CartesianToPolar_PI(double, double);
MyMath.CartesianToPolar_PI(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_PI(System.Numerics.Vector2);
MyMath.CartesianToPolar_Radians(double, double);
MyMath.CartesianToPolar_Radians(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_Radians(System.Numerics.Vector2);
MyMath.CartesianToPolar_startAtDown_Degrees(double, double);
MyMath.CartesianToPolar_startAtDown_Degrees(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_startAtDown_Degrees(System.Numerics.Vector2);
MyMath.CartesianToPolar_startAtDown_Gradians(double, double);
MyMath.CartesianToPolar_startAtDown_Gradians(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_startAtDown_Gradians(System.Numerics.Vector2);
MyMath.CartesianToPolar_startAtDown_PI(double, double);
MyMath.CartesianToPolar_startAtDown_PI(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_startAtDown_PI(System.Numerics.Vector2);
MyMath.CartesianToPolar_startAtDown_Radians(double, double);
MyMath.CartesianToPolar_startAtDown_Radians(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_startAtDown_Radians(System.Numerics.Vector2);
MyMath.CartesianToPolar_startAtDown_Turns(double, double);
MyMath.CartesianToPolar_startAtDown_Turns(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_startAtDown_Turns(System.Numerics.Vector2);
MyMath.CartesianToPolar_startAtLeft_Degrees(double, double);
MyMath.CartesianToPolar_startAtLeft_Degrees(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_startAtLeft_Degrees(System.Numerics.Vector2);
MyMath.CartesianToPolar_startAtLeft_Gradians(double, double);
MyMath.CartesianToPolar_startAtLeft_Gradians(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_startAtLeft_Gradians(System.Numerics.Vector2);
MyMath.CartesianToPolar_startAtLeft_PI(double, double);
MyMath.CartesianToPolar_startAtLeft_PI(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_startAtLeft_PI(System.Numerics.Vector2);
MyMath.CartesianToPolar_startAtLeft_Radians(double, double);
MyMath.CartesianToPolar_startAtLeft_Radians(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_startAtLeft_Radians(System.Numerics.Vector2);
MyMath.CartesianToPolar_startAtLeft_Turns(double, double);
MyMath.CartesianToPolar_startAtLeft_Turns(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_startAtLeft_Turns(System.Numerics.Vector2);
MyMath.CartesianToPolar_startAtUp_Degrees(double, double);
MyMath.CartesianToPolar_startAtUp_Degrees(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_startAtUp_Degrees(System.Numerics.Vector2);
MyMath.CartesianToPolar_startAtUp_Gradians(double, double);
MyMath.CartesianToPolar_startAtUp_Gradians(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_startAtUp_Gradians(System.Numerics.Vector2);
MyMath.CartesianToPolar_startAtUp_PI(double, double);
MyMath.CartesianToPolar_startAtUp_PI(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_startAtUp_PI(System.Numerics.Vector2);
MyMath.CartesianToPolar_startAtUp_Radians(double, double);
MyMath.CartesianToPolar_startAtUp_Radians(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_startAtUp_Radians(System.Numerics.Vector2);
MyMath.CartesianToPolar_startAtUp_Turns(double, double);
MyMath.CartesianToPolar_startAtUp_Turns(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_startAtUp_Turns(System.Numerics.Vector2);
MyMath.CartesianToPolar_Turns(double, double);
MyMath.CartesianToPolar_Turns(System.Collections.Generic.List<double>);
MyMath.CartesianToPolar_Turns(System.Numerics.Vector2);
MyMath.Cos(double);
MyMath.DegreesToAngle(double);
MyMath.DegreesToGradians(double);
MyMath.DegreesToList(double);
MyMath.DegreesToPI(double);
MyMath.DegreesToRadians(double);
MyMath.DegreesToTurns(double);
MyMath.DegreesToUnitList(double);
MyMath.DegreesToUnitVector2(double);
MyMath.DegreesToVector2(double);
MyMath.GradiansToAngle(double);
MyMath.GradiansToDegrees(double);
MyMath.GradiansToList(double);
MyMath.GradiansToPI(double);
MyMath.GradiansToRadians(double);
MyMath.GradiansToTurns(double);
MyMath.GradiansToUnitList(double);
MyMath.GradiansToUnitVector2(double);
MyMath.GradiansToVector2(double);
MyMath.Integral(System.Func<double, double>, double, double, double);
MyMath.ListToAngle(System.Collections.Generic.List<double>);
MyMath.ListToDegrees(System.Collections.Generic.List<double>);
MyMath.ListToGradians(System.Collections.Generic.List<double>);
MyMath.ListToPI(System.Collections.Generic.List<double>);
MyMath.ListToRadians(System.Collections.Generic.List<double>);
MyMath.ListToTurns(System.Collections.Generic.List<double>);
MyMath.ListToUnitList(System.Collections.Generic.List<double>);
MyMath.ListToUnitVector2(System.Collections.Generic.List<double>);
MyMath.ListToVector2(System.Collections.Generic.List<double>);
MyMath.NormalizeAngle_0_fullTurn(MyLib_Csharp.DataStructure.Angle);
MyMath.NormalizeDegrees_0_360(double);
MyMath.NormalizeDegrees_neg180_180(double);
MyMath.NormalizeGradians_0_400(double);
MyMath.NormalizeList(System.Collections.Generic.List<double>);
MyMath.NormalizeRadians_0_TwoPI(double);
MyMath.NormalizeTurn_0_1(double);
MyMath.PIToAngle(double);
MyMath.PIToDegrees(double);
MyMath.PIToGradians(double);
MyMath.PIToList(double);
MyMath.PIToRadians(double);
MyMath.PIToTurns(double);
MyMath.PIToUnitList(double);
MyMath.PIToUnitVector2(double);
MyMath.PIToVector2(double);
MyMath.RadiansToAngle(double);
MyMath.RadiansToDegrees(double);
MyMath.RadiansToGradians(double);
MyMath.RadiansToList(double);
MyMath.RadiansToPI(double);
MyMath.RadiansToTurns(double);
MyMath.RadiansToUnitList(double);
MyMath.RadiansToUnitVector2(double);
MyMath.RadiansToVector2(double);
MyMath.Sin(double);
MyMath.Tan(double);
MyMath.Test();
MyMath.TurnsToAngle(double);
MyMath.TurnsToDegrees(double);
MyMath.TurnsToGradians(double);
MyMath.TurnsToList(double);
MyMath.TurnsToPI(double);
MyMath.TurnsToRadians(double);
MyMath.TurnsToUnitList(double);
MyMath.TurnsToUnitVector2(double);
MyMath.TurnsToVector2(double);
MyMath.UnitListToAngle(System.Collections.Generic.List<double>);
MyMath.UnitListToDegrees(System.Collections.Generic.List<double>);
MyMath.UnitListToGradians(System.Collections.Generic.List<double>);
MyMath.UnitListToList(System.Collections.Generic.List<double>);
MyMath.UnitListToPI(System.Collections.Generic.List<double>);
MyMath.UnitListToRadians(System.Collections.Generic.List<double>);
MyMath.UnitListToTurns(System.Collections.Generic.List<double>);
MyMath.UnitListToUnitVector2(System.Collections.Generic.List<double>);
MyMath.UnitListToVector2(System.Collections.Generic.List<double>);
MyMath.UnitVector2ToAngle(System.Numerics.Vector2);
MyMath.UnitVector2ToDegrees(System.Numerics.Vector2);
MyMath.UnitVector2ToGradians(System.Numerics.Vector2);
MyMath.UnitVector2ToList(System.Numerics.Vector2);
MyMath.UnitVector2ToPI(System.Numerics.Vector2);
MyMath.UnitVector2ToRadians(System.Numerics.Vector2);
MyMath.UnitVector2ToTurns(System.Numerics.Vector2);
MyMath.UnitVector2ToUnitList(System.Numerics.Vector2);
MyMath.UnitVector2ToVector2(System.Numerics.Vector2);
MyMath.Vector2ToAngle(System.Numerics.Vector2);
MyMath.Vector2ToDegrees(System.Numerics.Vector2);
MyMath.Vector2ToGradians(System.Numerics.Vector2);
MyMath.Vector2ToList(System.Numerics.Vector2);
MyMath.Vector2ToPI(System.Numerics.Vector2);
MyMath.Vector2ToRadians(System.Numerics.Vector2);
MyMath.Vector2ToTurns(System.Numerics.Vector2);
MyMath.Vector2ToUnitList(System.Numerics.Vector2);
MyMath.Vector2ToUnitVector2(System.Numerics.Vector2);
```

___

MyArray

```C#
public static int[] GenerateRandIntArray(int n);
public static int[,] GenerateRandInt2dArray(int n, int m);
public static void Print<T>(T[] array);
public static void Print<T>(T[,] array);
public static void Println<T>(T[] array);
```

