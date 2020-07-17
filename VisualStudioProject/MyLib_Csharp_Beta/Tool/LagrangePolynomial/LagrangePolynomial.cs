using MyLib_Csharp_Beta.CommonMethod;
using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.Tool
{
    public partial class LagrangePolynomial
    {
        public (double x, double y)[] points;

		public LagrangePolynomial(params (double x, double y)[] points)
		{
			this.points = points;
		}


		// Generate //
		public string Generate() =>
			points.JoinSum((pointT, t) =>
				points.JoinProduct((pointI, i) =>
					t == i ? $"({pointI.y})" : $"((x-{pointI.x})/({pointT.x - pointI.x}))"));
		public static string Generate(params (double x, double y)[] points) =>
			new LagrangePolynomial(points).Generate();


		// Print //
		public string Print() => Generate().Print();
        public static string Print(params (double x, double y)[] points) => Generate(points).Print();


		//public double Invoke(int x) =>
		//	SumOf(0, points.Length - 1,
		//		(j, _) => points[j].y *
		//		ProductOf(0, points.Length - 1,
		//			m => (x - points[m].x) / (points[j].x - points[m].x),
		//			m => m != j));

		//public double Invoke(int x, params (double x, double y)[] points) =>
		//	new LagrangePolynomial(points).Invoke(x);


	}
}
