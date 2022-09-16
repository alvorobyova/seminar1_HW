Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());

if(numberA > numberB)
{
    Console.WriteLine(numberA + " большее число");
}
else if(numberA < numberB)
{
    Console.WriteLine(numberB + " большее число");
}

else if(numberA == numberB)
{
    Console.WriteLine("Числа равны");

}
