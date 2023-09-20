// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите 1-ое число");
string numb1String1 = Console.ReadLine();
Console.WriteLine("Введите 2-ое число");
string numb1String2 = Console.ReadLine();

int numb1 = Convert.ToInt32(numb1String1);
int numb2 = Convert.ToInt32(numb1String2);

if (numb1>numb2)
{
    Console.WriteLine($"Большое число {numb1}");
}
else if(numb2>numb1)
{
    Console.WriteLine($"Большое число {numb2}");
}
else
{
    Console.WriteLine("Числа равны");
}
