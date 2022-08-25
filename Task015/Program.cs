//Задача 15

Console.WriteLine("Пожалуйста, введите цифру, обозначающую день недели: ");
int number = int.Parse(Console.ReadLine());

if(number > 5 && number < 8)
{
    Console.WriteLine("Выходной!");
}
else if(number > 7) 
{
    Console.WriteLine("В неделе только 7 дней!");
}
else
{
    Console.WriteLine("Не выходной :(");
}