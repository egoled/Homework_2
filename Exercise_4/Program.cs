// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите число, обозначающее день недели ");
string day = Console.ReadLine();
int num = int.Parse (day);

if(num >= 1 && num <=5)
{
    Console.WriteLine ("Это будний день");
}
if(num > 5 && num <=7)
{
    Console.WriteLine ("Выходной!");
}
if (num < 1 || num > 7)
{
    Console.WriteLine ("Такого дня в неделе нет!");
}

