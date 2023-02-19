// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.
//     a = 5; b = 7 -> max = 7, min = 5
//     a = 2 b = 10 -> max = 10, min = 2   
//     a = -9 b = -3 -> max = -3, min = -9

System.Console.Write("Введите первое число > ");
string userNumber1 = Console.ReadLine();
System.Console.Write("Введите второе число > ");
string userNumber2 = Console.ReadLine();

int x = Convert.ToInt32(userNumber1);
int y = Convert.ToInt32(userNumber2);

if (x > y)
{
    System.Console.WriteLine($"Число {userNumber1} больше, а число {userNumber2} меньше");
}
else
{
    System.Console.WriteLine($"Число {userNumber2} больше, а число {userNumber1} меньше");
}