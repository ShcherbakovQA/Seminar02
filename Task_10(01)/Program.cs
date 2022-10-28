// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

void SecondNum(int number)
{
    int[] arraytdn = new int[3];
    for (int i = 2; i >= 0; i--)
    {
        arraytdn[i] = number % 10;
        number /= 10;
    }
    Console.WriteLine("Второе число = " + arraytdn[1]);
}

Console.Write("Введите трехзначное число: ");
SecondNum(int.Parse(Console.ReadLine() ?? "0"));










