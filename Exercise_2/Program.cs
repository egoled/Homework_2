// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int RandNum = new Random(). Next(100, 999);
Console.WriteLine("Случайное трехзначное число: " + RandNum);
int One = RandNum / 100;
int Two = RandNum % 100 /10;
int Three = RandNum % 10;
Console.WriteLine ("Удаляем вторую цифру: " + One + Three);