//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). Использовать свои функции, не использовать Math.Pow

bool[] errs = {false, false};

Console.WriteLine("Введите число: ");
string tmp = Console.ReadLine();
errs[0] = int.TryParse(tmp, out int A);
Console.WriteLine("Введите степень: ");
tmp = Console.ReadLine();
errs[1] = int.TryParse(tmp, out int B);

if(errs.Contains(false)){
    Console.WriteLine("В одно или более значений задано не числовое значение");
    return;
}

long MyPow(int a, int b){
    int tmp = a;
    if(b == 0) return 1;
    for(int i = 1; i < b; i++, tmp *= a);
    return tmp;
}

Console.WriteLine("Результат: " + MyPow(A, B).ToString());
