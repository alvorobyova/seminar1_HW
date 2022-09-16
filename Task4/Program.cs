Console.WriteLine("Введите 1-е число");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2-е число");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 3-е число");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if(numberA > max) 
{
    max = numberA;
}
else if(numberB > max)
{
    max = numberB;
}

else if(numberC > max)

{
    max = numberC;
}
Console.WriteLine(max + " наибольшее из 3 чисел");
