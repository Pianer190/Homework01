// 01 здача Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для

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


do
{
    number = number / 10;
    if(number < 100)
    {
        do
        {
            number = number - 10;
            if (number < 10)
            {
                Console.WriteLine("Вторая (с начала) цифра : {0}", number);
            }
        }
        while (number > 10);
    }
}
while (number > 100);