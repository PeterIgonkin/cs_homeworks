using System;
namespace prc04
{
    class Point
    {
        protected double x;
        protected double y;
        protected double z;
        public Point()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public double X
        {
            get => x;
            set => x = value;
        }
        public double Y 
        {
            get => y;
            set => y = value;
        }
        public double Z
        {
            get => z;
            set => z = value;
        }
        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public double Distance_between_two_points(in Point frst, in Point scnd)
        {
            return Math.Sqrt(Math.Pow(frst.X - scnd.X, 2) + Math.Pow(frst.Y - scnd.Y, 2) + Math.Pow(frst.Z - scnd.Z, 2));
        }
        public double Distance_from_point_to_start(in Point frst)
        {
            return Math.Sqrt(Math.Pow(frst.X, 2) + Math.Pow(frst.Y, 2) + Math.Pow(frst.Z, 2));
        }
        public void Equation_of_the_line(in Point frst, in Point scnd)
        {
            Console.WriteLine($"x = {frst.X} + {scnd.X - frst.X} * t");
            Console.WriteLine($"y = {frst.Y} + {scnd.Y - frst.Y} * t");
            Console.WriteLine($"x = {frst.Z} + {scnd.Z - frst.Z} * t");
        }
        public void Equation_of_the_flat(in Point pt1, in Point pt2, in Point pt3)
        {
            Point vec1 = new(pt1.X - pt2.X, pt1.Y - pt2.Y, pt1.Z - pt2.Z);
            Point vec2 = new(pt1.X - pt3.X, pt1.Y - pt3.Y, pt1.Z - pt3.Z);
            Point vec3 = VectorMultiplying(vec1, vec2);
            Console.WriteLine($"{vec3.X}*X + {vec3.Y}*Y + {vec3.Z}*Z + {-(vec3.X)*pt2.X - (vec3.Y)*pt2.Y - (vec3.Z)*pt2.Z} = 0");
        }
        public static Point operator+(in Point frst, in Point scnd)
        {
            return new (frst.X + scnd.X, frst.Y + scnd.Y, frst.Z + scnd.Z);
        }
        public static double operator*(in Point frst, in Point scnd)
        {
            return frst.X * scnd.X + frst.Y * scnd.Y + frst.Z * scnd.Z;
        }
        public Point VectorMultiplying(in Point vec1, in Point vec2)
        {
            return new(vec1.Y * vec2.Z - vec1.Z * vec2.Y, -(vec1.X * vec2.Z - vec1.Z * vec2.X), vec1.X * vec2.Y - vec1.Y * vec2.X);
        }
    }
}
