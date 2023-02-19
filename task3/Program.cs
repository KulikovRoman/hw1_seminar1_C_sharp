// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
//     4 -> да
//     -3 -> нет  
//     7 -> нет

System.Console.WriteLine("Введите число > ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int count = userNumber;

if (count % 2 == 0)
{
   System.Console.WriteLine("Вы ввели четное число");
}
else
{
    System.Console.WriteLine("Вы ввели нечетное число");
}