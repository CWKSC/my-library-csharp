using MyLib_Csharp.CommonClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.Tool
{
    public partial class LagrangeInterpolationGenerator
    {

		public static void Run(params (double x, double y)[] points)
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

		public static void Run2(params (double x, double y)[] points)
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



		public static double Calc(int x, params (double x, double y)[] points) => 
			MyMath.SumOf(
				(j) => points[j].y * LagrangeBasisPolynomials(points, j, x, points.Length),
				0, points.Length);

		public static double LagrangeBasisPolynomials((double x, double y)[] points, int j, int x, int k) => 
			MyMath.ProductOf(LagrangeBasisPolynomials_Func, new object[] { points , x, j},
				0, k, (m) => m != j);

		public static double LagrangeBasisPolynomials_Func(int m, object[] args)
		{
			(double x, double y)[] points = ((double x, double y)[])args[0];
			double x = (double)args[1];
			int j = (int)args[2];
			return (x - points[m].x) / (points[j].x - points[m].x);
		}


	}
}
