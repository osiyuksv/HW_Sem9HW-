// Вывести с помощью рекурсии функцию Аккермана для двух 
// заданных пользователем чисел M и N, которые больше нуля

Console.WriteLine("Введите число M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numN = Convert.ToInt32(Console.ReadLine());

if ((numM < 0) || (numN < 0))
  Console.WriteLine("Задано отрицательное число");

int AckermanFunctionMN(int number, int argument)
{
  if (number == 0) return argument + 1;

  else if ((number > 0) && (argument == 0))
    return AckermanFunctionMN(number - 1, 1);

  else if ((number > 0) && (argument > 0))
    return (AckermanFunctionMN(number - 1, AckermanFunctionMN(number, argument - 1)));
  return 0;
}

Console.WriteLine($"Функция Аккермана A({numM},{numN}) = " + AckermanFunctionMN(numM, numN));
