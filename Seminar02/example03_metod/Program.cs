//метод void этот метод нечего не возвращает  при этом методе оператор returne использовать нельзя 
void FillArray(int[] collection)

{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {

        collection[index] = new Random().Next(1, 10);
        index++;

    }

}

void FillArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;

    }

}

int[] array = new int[10];

FillArray(array);
printarray(array);
//int[] array = new int[10]; // new int[10] конструкция , которая означает создай новый массив в котором будет 10 элементов 