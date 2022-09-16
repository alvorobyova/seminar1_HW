Console.WriteLine("В этой программе будем определять четность/ нечетность чисел.");
Console.WriteLine("Поехали!");

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Введенное вами число является четным");

}

else 
{
    Console.WriteLine("Вы ввели нечетное число");
}
