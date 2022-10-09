using System;
using prc04;
Point dot1 = new(1, 2, 2.5);
Point dot2 = new(2, 5, 7);
Point dot3 = new(0, 1, 10.5);
Console.WriteLine(dot1.Distance_between_two_points(dot1, dot2));
Point dot4 = dot1.VectorMultiplying(dot1, dot2);
Console.WriteLine($"{dot4.X}, {dot4.Y}, {dot4.Z}");
Console.WriteLine(dot1.Distance_from_point_to_start(dot1));
dot1.Equation_of_the_line(dot2, dot3);
dot1.Equation_of_the_flat(dot1, dot2, dot3);
Point dot5 = dot1 + dot2;
Console.WriteLine($"{dot5.X}, {dot5.Y}, {dot5.Z}");
Console.WriteLine(dot1*dot2);

