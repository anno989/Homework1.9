//Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintNumbers(n, 1));

// string PrintNumbers(int start, int end)
// {
//     if(start == end) return start.ToString();
//     return(start + " " + PrintNumbers(start - 1, end));
// }

//Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Write("Введите число M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {SumRec(m, n)}");

// int SumRec(int m, int n)
// {
//     if (m == n) return n;
//     else return (m + SumRec(m + 1, n));
// }

//Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

static uint Akk(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}

Console.WriteLine(Akk(2, 3)); 
Console.WriteLine(Akk(3, 2)); 

Console.ReadKey();
