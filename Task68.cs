
int fnc(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return fnc(m - 1, 1);
  else return fnc(m - 1, fnc(m, n - 1));
}

Console.Clear();                            
Console.Write("Введите m: ");           
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");           
int n = Convert.ToInt32(Console.ReadLine());

int res = fnc(m, n);
Console.WriteLine($"A({m},{n}) = " + res.ToString());
