// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Input first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
Console.WriteLine("Greater number = " + number_1 + ", Smaller number = " + number_2 + " ");
else
Console.WriteLine("Greater number = " + number_2 + ", Smaller number = " + number_1 + " ");

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.Write("Input first number: ");
// int number_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int number_2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input third number: ");
// int number_3 = Convert.ToInt32(Console.ReadLine());

// int max = number_1;

// if (number_1 > max) max = number_1;
// if (number_2 > max) max = number_2;
// if (number_3 > max) max = number_3;
// Console.Write("Max number = ");
// Console.WriteLine(max);

// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.Write("Input a number: ");
// int number_1 = Convert.ToInt32(Console.ReadLine());

// if (number_1 % 2 == 0)
// Console.Write("Even");
// else
// Console.Write("Odd");

// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Console.Write("Input a number: ");
// int number_1 = Convert.ToInt32(Console.ReadLine());

// int max = number_1;
// int count = 1;

// for (count = 1; count<=max; count=count+1)
//     if (count%2==0)
//     Console.WriteLine(count);