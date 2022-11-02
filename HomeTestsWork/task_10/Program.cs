//10. Найти траекторию движения брошенного с башки металлического шара
double a = -1;
double b = 0.2;
double c = 13;
double y = 1;
double x = a * y * y + b * y + c;

Console.WriteLine($"f({y})={x}");

double fi = Math.PI/4;
double x1 = x * Math.Cos(fi) - y * Math.Sin(fi);
double y1 = x * Math.Sin(fi) + y * Math.Cos(fi);
Console.WriteLine($"f({y1:f2})={x1:f2}");