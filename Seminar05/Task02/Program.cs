// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
namespace Console
{
    class Program
    {
        static void Main()
        {
            int[] B = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
 
    
 
            //Сумма нечетных элементов массва
            var oddNums = B.Where(t => t%2 != 0);
            Console.WriteLine(oddNums.Sum());
        }
    }
}