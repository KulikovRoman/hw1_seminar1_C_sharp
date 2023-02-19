// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//     2, 3, 7 -> 7    
//     44 5 78 -> 78
//     22 3 9 -> 22

System.Console.WriteLine("Введите первое число > ");
string userNumber1 = Console.ReadLine();
System.Console.WriteLine("Введите второе число > ");
string userNumber2 = Console.ReadLine();
System.Console.WriteLine("Введите третье число > ");
string userNumber3 = Console.ReadLine();

int a = Convert.ToInt32(userNumber1);
int b = Convert.ToInt32(userNumber2);
int c = Convert.ToInt32(userNumber3);

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

System.Console.WriteLine($"Максимальное значение {max}");