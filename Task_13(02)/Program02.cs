// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

void DetectTD (int n1)
{
   while (n1 >= 1000)
   {
    n1/=10;
   }
   if (n1 < 100 && n1 > -100)
   {
    Console.WriteLine("Третья цифра отсутствует");
   }
    else 
    {n1 = n1 % 10;
    Console.WriteLine($"Третья цифра: {Math.Abs(n1)}");
    }
}

Console.Write("Введите число: ");
DetectTD(int.Parse(Console.ReadLine() ?? "0"));
