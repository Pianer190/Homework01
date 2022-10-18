//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.

string tmp = "";
int number = 0;

Console.WriteLine("Введите число:");
while(tmp.Length < 3){
    tmp = Console.ReadLine();
    if(!int.TryParse(tmp, out number)){
        tmp = "";
        Console.WriteLine("Введите число:");
    }
}


do
{
    number = number / 10;
}
while (number > 1000);

Console.WriteLine("Остаток от деления: " + (number % 10));