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


	}
}
