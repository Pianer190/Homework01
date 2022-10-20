/*
    Напишите программу, которая найдёт точку пересечения двух прямых,
    заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/

double k1, k2, b1, b2;
double[] point1 = new double[2], point2 = new double[2];

double[] GetPoint(double a, double b, double c, double d){
    double x = 0, y1 = 0, y2 = 0, founded = 0;
    for(double i = -100000; i <= 100000; i += 0.001){
        x = i;
        y1 = a * x + b;
        y2 = c * x + d;
        if(y1 == y2){
            founded++;
            break;
        }
    }
    if(founded == 0) return new double[2]{-1000000, -1000000};
    return new double[2]{x, y1};
}

Console.WriteLine("Введите значение K1: ");
if(!double.TryParse(Console.ReadLine(), out k1)) return;
Console.WriteLine("Введите значение K2: ");
if(!double.TryParse(Console.ReadLine(), out k2)) return;
Console.WriteLine("Введите значение B1: ");
if(!double.TryParse(Console.ReadLine(), out b1)) return;
Console.WriteLine("Введите значение B2: ");
if(!double.TryParse(Console.ReadLine(), out b2)) return;

point1 = GetPoint(k1, b1, k2, b2);

Console.WriteLine("("+point1[0]+";"+point1[1]+")");