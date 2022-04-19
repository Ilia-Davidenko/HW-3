using System;
using static System.Console;

double x1 = Convert.ToDouble(ReadLine());
double y1 = Convert.ToDouble(ReadLine());
double z1 = Convert.ToDouble(ReadLine());
double x2 = Convert.ToDouble(ReadLine());
double y2 = Convert.ToDouble(ReadLine());
double z2 = Convert.ToDouble(ReadLine());

double c = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
WriteLine(c);