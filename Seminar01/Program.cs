//Задача 1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введи 2 числа и узнай какое из них больше");
            int a, b;
            Console.WriteLine("Введи  первое число - ");
            a = Convert.ToInt32(Console.Read());
            Console.WriteLine("Введи  второе число - ");
            b = Convert.ToInt32(Console.Read());
 
            bool Chto0 = a > b;
            bool Chto1 = a == b;
            bool Chto2 = a < b;
 
            if (Chto0)
            {
                Console.WriteLine($"Число {a} больше чем {b}");
            }
            else if (Chto1)
            {
                Console.WriteLine($"Числа {a} и {b} равны");
            }
            else
            {
                Console.WriteLine($"Число {b} больше чем {a}");
            }