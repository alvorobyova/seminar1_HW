Console.WriteLine("Hello, World!");

Console.WriteLine("В этой программе будем определять четные числа в заданном диапазоне.");
Console.WriteLine("Поехали!");

Console.WriteLine("Введите любое число больше 1");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Отлично! Определим все четные числа от 1 до " + number);
Console.WriteLine("Четные числа в заданном диапазоне:");

for(int start = 1; start <= number; start++)
if(start % 2 == 0) 
{
Console.Write(start + ", ");
}