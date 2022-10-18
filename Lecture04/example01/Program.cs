string[,] table = new string[2, 5];
// индексы меяются от 0 т.е 
//String.Empty
//table[0,0] tabbe[0,1] table[0,2] table[0,4]
//table[1,0] table[1,1] table[1,2] table[1,4]


//table[1, 2] = "слово";   // в кскобках индекс строки и индекс столбца 

//void PrintArray();


//for (int rows = 0; rows < 2; rows++)
{

    //for (int colums = 0; colums < 5; colums++)
    {
      //  Console.WriteLine($"-{table[rows, colums]}-");
    }

}

//Метод который будет отдельно печатать на экран и заполнять матрицу числами 



//void PrintArray(int[,] matr)
{
  //  for (int i = 0; i < matr.GetLength(0); i++)
    {
    //    for (int j = 0; j < matr.GetLength(1); j++)
        {
      //      Console.Write($"{matr[i, j]} ");
        }
        //Console.WriteLine();
    }
}
//int[,] matrix = new int[3, 4];
//PrintArray(matrix);




//Теперь опишем дополнительный метод, который будет заполнять нашу матрицу случайными числами.
//Здесь всё почти так же, как с одномерными массивами. Для i указываем matr.GetLength(0), для J —
//matr.GetLength(1). Затем обращаемся к конкретному элементу на позиции «итый-житый» и пишем
//через использование генератора псевдослучайных чисел. Возьмём полуинтервал от 1 до 10.
//Напоминаю, из-за круглых скобок может показаться, что это интервал (как в математике), но у нас
//получается именно полуинтервал.
//Проверим работоспособность нашего метода. Сначала инициализируемся, убедимся, что у нас нули.
//Затем сделаем FillArray, в качестве аргумента передадим наш массив и снова распечатаем. А чтобы
//отделить нули от чисел, перед финальной распечаткой добавим Console.WriteLine()


void PrintArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 Console.Write($"{matr[i, j]} ");
 }
 Console.WriteLine();
 }
}
void FillArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 matr[i,j] = new Random().Next(1,10);//[1; 10)
 }
 }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
