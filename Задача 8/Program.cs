// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число");
string NString = Console.ReadLine();
int N = Convert.ToInt32(NString);

int count = 1;

if(N<0) Console.WriteLine("Вы ввели отрицательно число");

if(N==0) Console.WriteLine($"Вы ввели {N}");

if(N==1) Console.WriteLine($"Вы ввели {N}");

Console.WriteLine("Ваши чётные числа");
while(count<=N)
{
    if(count%2==0) Console.WriteLine(count);
    count++;
}
