// Задача 4. Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.  
//     5 -> 2, 4
//     8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число > ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 0)
{
    userNumber = -userNumber;
}

int count = 1;

while (count <= userNumber)
{
    if (count % 2 == 0)
    System.Console.Write($"{count} ");
    count = count + 1;
}