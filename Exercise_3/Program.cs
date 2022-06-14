// Напишите программу, которая выводит третью
//цифру заданного числа или сообщает, что третьей цифры
//нет.

int prompt(string message)
{
    System.Console.WriteLine(message);
    string Strnum = Console.ReadLine();
    int num = int.Parse(Strnum);
    return num;
}
int num = prompt("Введите число: ");
if (num < 100)
{
    System.Console.WriteLine("Третьей цифры нет!");
}
else
{
while (num > 999)
{
    num = num/10;
}
num = num % 10;
Console.WriteLine ("Треться цифра числа: " + num);
}
