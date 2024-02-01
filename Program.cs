// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// System.Console.WriteLine("Введите число начало промежутка");
// int M = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число конец промежутка");
// int N = Convert.ToInt32(Console.ReadLine());

// void PrintNumbers(int firstNum, int endNum)
// {
//     if(M > N) 
//     {
//         Console.WriteLine("Первое число долно быть меньше второго!!!");
//         return;
//     }
//     if (firstNum > endNum)
//     {
//         return;
//     }

//     System.Console.Write(firstNum + "\t");

//     PrintNumbers(firstNum + 1, endNum);
// }

// PrintNumbers(M, N);


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Console.WriteLine("Введите значение m:");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите значение n:");
// int n = int.Parse(Console.ReadLine());

// static int Ackermann(int m1, int n1)
// {
//     if (m1 == 0)
//     {
//         return n1 + 1;
//     }
//     else if (m1 > 0 && n1 == 0)
//     {
//         return Ackermann(m1 - 1, 1);
//     }
//     else if (m1 > 0 && n1 > 0)
//     {
//         return Ackermann(m1 - 1, Ackermann(m1, n1 - 1));
//     }
//     else
//     {
//         throw new Exception("Некорректные значения m и n");
//     }
// }

// Console.WriteLine($"A({m}, {n}) = {Ackermann(m, n)}");


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// int[] oldArray = { 1, 2, 5, 0, 10, 34 };
// int OldLength = oldArray.Length - 1;

// void printInvertedArray(int[] array, int current)

// {
//     if (current < 0)
//     {
//         return;
//     }
//     else
//     {
//         Console.Write(array[current] + " ");
//         printInvertedArray(array, current - 1);
//     }
// }

// printInvertedArray(oldArray, OldLength);

