using System;

namespace DesignPatternSample.Factory
{
    partial class Person
    {
        public static class Factory
        {
            public static Person NewCartesianPoint(double x, double y)
            {
                return new Person(x, y);
            }

            public static Person NewPolarPoint(double rho, double theta)
            {
                return new Person(rho, Math.Cos(theta));
            }
        }
    }
}
