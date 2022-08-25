//Задача 10

Console.WriteLine("Пожалуйста, введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

if(99 < number && number < 1000) 
{
   int a2 = number / 10 % 10;
   Console.WriteLine($"Число: {number}, вторая цифра числа: {a2}"); 
}
else
{
    Console.WriteLine($"Число {number} не трёхзначное");
}

