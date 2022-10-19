// Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран. Сделать через функции.

int[] items = new int[8];

void GetRandom(int[] input, out int[] arg){
    arg = input;
    for(int i = 0; i < arg.Length; i++){
        Random tmp = new Random();

        arg[i] = tmp.Next(0,10000);
    }
    return;
}

GetRandom(items, out int[] result);


Console.WriteLine("Вывод: ");
for(int i = 0; i < result.Length; i++){
    Console.WriteLine(result[i]);
}
