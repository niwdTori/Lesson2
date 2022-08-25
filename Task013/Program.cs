// Задача 13

Console.WriteLine("Пожалуйста, введите число: ");
int number = int.Parse(Console.ReadLine());

if(number > 99) 
{
    while(number > 1000)
    {
        number = number / 10;
    }
    int a3 = number % 10;
    Console.WriteLine($"Третья цифра: {a3}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}