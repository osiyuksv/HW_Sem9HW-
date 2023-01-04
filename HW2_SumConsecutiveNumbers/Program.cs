// Вывести через рекурсию сумму последовательных натуральных чисел
// в промежутке от M до N включительно, которые запрашиваем у пользователя

Console.WriteLine("Введите число M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numN = Convert.ToInt32(Console.ReadLine());

int start1 = numM;
int end1 = numN;

if (numM > numN)
{
  start1 = numN;
  end1 = numM;
}

int SumConsecutiveNumbers(int start, int end)
{
  if (start == end) return start;
  return (start + SumConsecutiveNumbers((start + 1), end));
}

Console.WriteLine($"Сумма элементов в интервале {start1}  и {end1} (включительно) равна " + SumConsecutiveNumbers(start1, end1));

