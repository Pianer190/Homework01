//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)

string input = "";
List<int> numbers = new List<int>();
while (true) {
    Console.Clear();
    Console.WriteLine("Введите число или нажмите Enter чтобы закончить:");
    input = Console.ReadLine();
    if(input.Trim(' ') == "") break;
    if(!int.TryParse(input, out int num)) continue;
    numbers.Add(num);
}

Console.WriteLine("Вывод введенных чисел: " + numbers);
void PrintInt(int a){
    Console.Write(a + " ");
}
numbers.ForEach(PrintInt);

int GetCountPositiveNums(List<int> list){
    int tmp = 0;
    for(int i = 0; i < list.Count; i++){
        if(list[i] > 0) tmp++;
    }
    return tmp;
}

int PositiveNums = GetCountPositiveNums(numbers);
Console.WriteLine();
Console.WriteLine("Введено положительных чисел: " + PositiveNums);