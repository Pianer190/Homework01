//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.
string tmp = "";
int number = 0;

Console.WriteLine("Введите трехначное число:");
while(tmp.Length != 3){
    tmp = Console.ReadLine();
    if(!int.TryParse(tmp, out number)){
        tmp = "";
        Console.WriteLine("Введите трехначное число:");
    }
}

int num1 = number;
int num2 = number;

// Ищем первую цифру
do
{
    num1 = num1 / 10;
    if(num1 < 10)
    {
        Console.WriteLine("Первая (с начала) цифра : {0}", num1);
    }
}
while (num1 > 10);

// Ищем третью цифру
do
{
    num2 = num2 - 10;
    if(num2 < 10){
        Console.WriteLine("Третья (с начала) цифра : {0}", num2);
    }
}
while (num2 > 10);

Console.WriteLine(number.ToString() + " -> " + ((num1 * 10) + num2));