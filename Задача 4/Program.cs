// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите 1-ое число");
string numb1String1 = Console.ReadLine();

Console.WriteLine("Введите 2-ое число");
string numb1String2 = Console.ReadLine();

Console.WriteLine("Введите 2-ое число");
string numb1String3 = Console.ReadLine();

int numb1 = Convert.ToInt32(numb1String1);
int numb2 = Convert.ToInt32(numb1String2);
int numb3 = Convert.ToInt32(numb1String3);

int max = numb1;

if (numb2>max)
{
    max = numb2;
}
if(numb3>max)
{
    max = numb3;
}
Console.WriteLine($"Большое число {max}");
