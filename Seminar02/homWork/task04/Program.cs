// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
string tmp = Console.ReadLine();
int day;
var isValid = int.TryParse(tmp, out day);

if(!isValid){
    Console.WriteLine("Допускаются только числовые значения!");
    return;
}

if(day < 1 || day > 7){
    Console.WriteLine("День " + day + " не существует");
    return;
}
if(day > 5) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}