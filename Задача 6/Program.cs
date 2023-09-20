// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число");
string numb1String = Console.ReadLine();

int numb = Convert.ToInt32(numb1String);

int result= numb%2;

if(result==0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число не чётное");
}
