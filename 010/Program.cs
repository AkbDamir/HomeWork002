/* Задача 10: Напишите программу,
которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/ 

while (true)
{
    Console.WriteLine("Введите трехзначное число или 'q' для выхода");
    string num = Console.ReadLine();
    if(num == "q")
    {
        break;
    }
    if(num.Length == 3)
    {
        Console.WriteLine("Вторая цифра это " + num[1]);
    }
    else
    {
        Console.WriteLine("Вы ввели не трехзначное число");
    }
}