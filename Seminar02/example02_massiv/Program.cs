// Имеется одномерный массив array из n элементов 
//Требуется найти элемент массива равный find
//1. Установить счётчиу index в позиции 0
//2. Если индекс array [index]=find, алгоритм завершит работу успешно
//3. Увеличить index на 1
//4. Если index < n , то перейти к шагу 2 . В противном случае алгоритм завершит работу безуспешно

int[] array = { 1, 2, 3, 4, 5, 16, 17, 18 };

int n = array.Length; // array.Length Возвращает колличество элементов массива 
int find = 18;

int index = 0; // Счётчик index


while (index < n) // Цикл while
{

    if (array[index] == find)
    {

        Console.WriteLine(index);
    }
    index++;
}