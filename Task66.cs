int SumDigits(int n, int m)
{
  if (n == m) return n;
  else return SumDigits(n + 1, m) + n;
}


Console.Clear();                            
Console.Write("Введите число: ");           
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");           
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigits(n, m));

