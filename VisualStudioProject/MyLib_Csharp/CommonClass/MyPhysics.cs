using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    class MyPhysics
    {
        public static float Momentum(float mass, float velocity)
        {
            return mass * velocity;
        }

        public static float KineticEnergy(float mass, float velocity)
        {
            return mass * velocity * velocity / 2.0f;
        }

        public static float gravity = 9.81f;

        public static bool CircleCollision(Vector2 a, float r1, Vector2 b, float r2)
        {
            double distance = Vector2.Distance(a, b);
            return distance <= r1 + r2;
        }


        public enum Find
        {
            F, m, a
        }
        public static float F_ma(Find find, float p1, float p2) => find switch
        {
            Find.F => p1 * p2,
            Find.m => p1 / p2,
            Find.a => p1 / p2,
            _ => throw new ArgumentException("Unexpected Find enum value.")
        };


    }
}
