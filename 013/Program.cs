/* Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int a = Math.Abs(num);
string strNum = Convert.ToString(a);

if(strNum.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine("Третья цифра вашего числа это " + strNum[2]);
}
