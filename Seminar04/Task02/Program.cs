// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр
Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
int sum=0;
while (x > 0){
    sum += x % 10;
    x /= 10;
}

Console.WriteLine("Результат: ");
Console.WriteLine(sum);

