// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

System.Console.Write("Введите число A для возведения его в степень: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B - степень, в которую надо возвести число выше: ");
int B = Math.Abs(Convert.ToInt32(Console.ReadLine()));

System.Console.WriteLine("Результат возведения числа A в степень В: " + Math.Pow(A, B));
