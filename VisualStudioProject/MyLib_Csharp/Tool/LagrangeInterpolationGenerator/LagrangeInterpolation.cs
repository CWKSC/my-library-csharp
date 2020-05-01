using MyLib_Csharp.CommonClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.Tool
{
    public partial class LagrangeInterpolation
    {
		public (double x, double y)[] points;

		public LagrangeInterpolation(params (double x, double y)[] points)
		{
			this.points = points;
		}


		public static void Generate(params (double x, double y)[] points)
		{
			int num = points.Length;
			if (num < 2) return;
			for (int t = 0; t < num; t++)
			{
				if (t != 0) Console.Write("+");
				(double xt, _) = points[t];
				for (int i = 0; i < num; i++)
				{
					(double x, double y) = points[i];
					if (i != 0) Console.Write("*");
					Console.Write(t == i ? $"({y})" : $"((x-{x})/({xt - x}))");
				}
			}
		}

		public static void Generate2(params (double x, double y)[] points)
		{
			int num = points.Length;
			if (num < 2) return;
			(_, double y0) = points[0];
			foreach ((double xt, double yt) in points)
			{
				if (yt != y0) Console.Write("+");
				foreach ((double x, double y) in points)
				{
					if (y != y0) Console.Write("*");
					Console.Write(yt == y ? $"({y})" : $"((x-{x})/({xt - x}))");
				}
			}
		}


		public static void Generate3(params (double x, double y)[] points)
		{
			int num = points.Length;
			if (num < 2) return;
			MyFunction.JoinFunc(points, (pointT, t) =>
				MyFunction.JoinFunc(points, (pointI, i) => 
					Console.Write(t == i ? $"({pointI.y})" : $"((x-{pointI.x})/({pointT.x - pointI.x}))")
				, () => Console.Write("*"))
			, () => Console.Write("+"));
		}

		public static void Generate4(params (double x, double y)[] points)
		{
			int num = points.Length;
			if (num < 2) return;
			points.JoinPrint((pointT, t) =>
				points.JoinPrint((pointI, i) =>
					t == i ? $"({pointI.y})" : $"((x-{pointI.x})/({pointT.x - pointI.x}))"
			   , "*")
			, "+");
		}

		 

		public static double Calc(int x, params (double x, double y)[] points)
		{
			int k = points.Length - 1;
			return MyMath.SumOf(0, k,
				(j, _) => points[j].y * LagrangeBasisPolynomials(points, j, x, k));
		}

		public static double LagrangeBasisPolynomials((double x, double y)[] points, int j, int x, int k) => 
			MyMath.ProductOf(0, k, 
				LagrangeBasisPolynomials_Func, new object[] { points , x, j }, 
				(m) => m != j);

		public static double LagrangeBasisPolynomials_Func(int m, object[] args)
		{
			(double x, double y)[] points = ((double x, double y)[])args[0];
			int x = (int)args[1];
			int j = (int)args[2];
			return (x - points[m].x) / (points[j].x - points[m].x);
		}


	}
}
