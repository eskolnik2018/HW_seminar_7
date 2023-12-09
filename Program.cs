// ДЗ к семинару №7

// Задача 1: Задайте значения M и N. Напишите программу, которая
//  выведет все натуральные числа в промежутке от M до N. 
//  Использовать рекурсию, не использовать циклы.

// Задача 2: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Задача 3: Задайте произвольный массив. Выведете его 
// элементы, начиная с конца. Использовать рекурсию, не использовать циклы.



// // Задача 1

// int tmp =0;

// Console.Write("Введите начальное число M: ");
// int initialNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конечное число N: ");
// int finalNumber = Convert.ToInt32(Console.ReadLine());

// if (initialNumber>finalNumber) 
// {
//     tmp = initialNumber;
//     initialNumber = finalNumber;
//     finalNumber = tmp;
// }

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return start + " " + PrintNumbers(start + 1, end);
// }

// Console.WriteLine($"Печать чисел от {initialNumber} до {finalNumber} = {PrintNumbers(initialNumber, finalNumber)}");



// // Задача 2: 
// // Напишите программу вычисления функции 
// // Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


// int CalculatingAckkermanFunction(int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     else
//       if ((n != 0) && (m == 0))
//         return CalculatingAckkermanFunction(n - 1, 1);
//     else
//         return CalculatingAckkermanFunction(n - 1, CalculatingAckkermanFunction(n, m - 1));
// }

// Console.WriteLine(CalculatingAckkermanFunction(1, 2)); 
// Console.WriteLine(CalculatingAckkermanFunction(0, 0)); 
// Console.WriteLine(CalculatingAckkermanFunction(4, 5)); // Переполнение стека



// Задача 3:
// Задайте произвольный массив. Выведете его 
// элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


void printRevers(int[] array, int first = 0)
{
    if (first != array.Length)
    {
        printRevers(array, first + 1);
        Console.Write($"{array[first]} ");
    }
}

int[] array = new int[] { 12, 52, 36, 6, 55 };
printRevers(array);
