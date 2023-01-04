// Вывести через рекурсию числа с интервалом 0,5 по возрастанию в 
// промежутке от M до N включительно, которые запрашиваем у пользователя

Console.WriteLine("Введите число M");
double numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
double numN = Convert.ToInt32(Console.ReadLine());

double start1 = numM;
double end1 = numN;

if(numM > numN) 
  {
    start1 = numN;
    end1 = numM;
  }
  
string PrintSequenceNumbers(double start, double end)
{
  if( Math.Round(start, 1) == end) return start.ToString();
  return(Math.Round(start, 1) + "; " + PrintSequenceNumbers((Math.Round(start, 1) + 0.2), end));
}

Console.WriteLine(PrintSequenceNumbers(start1, end1));

