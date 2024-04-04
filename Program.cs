Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int NaturalNumber(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{NaturalNumber(n, m - 1)}, ");
  return m;
}

int n = Prompt("N: ");
if (n < 1)
{
  Console.WriteLine("Введите положительное число");
  return;
}

int m = Prompt("M: ");
if (m < 1)
{
  Console.WriteLine("Введите положительное число");
  return;
}
if (n>m)
Console.WriteLine("Введите N>M");
else Console.WriteLine(NaturalNumber(n, m));
