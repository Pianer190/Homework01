
//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным

int a;                             
            Console.WriteLine("введите число: ");
            a = Convert.ToInt32(Console.ReadLine()); 
 
            if (a % 2 == 0)
            {
                Console.WriteLine("четное число");
           
            }
            else
            {
                Console.WriteLine("нечетное");
            }
 
 
 
            Console.ReadKey();