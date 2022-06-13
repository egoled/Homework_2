// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine (array[1]);
    }
}
Console.WriteLine("Введите трехзначное число: ");
string Num = Console.ReadLine();
int N = int.Parse(Num);

int [] array = new int [3];
array [0] = N / 100;
array [1] = N % 100 /10;
array [2] = N % 10;

Console.WriteLine(array[1]);