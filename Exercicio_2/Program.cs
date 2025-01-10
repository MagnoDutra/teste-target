using System.Runtime.CompilerServices;

Console.WriteLine("Digite um número: ");

if (int.TryParse(Console.ReadLine(), out int numero))
{
  if (isFibonacciSequency(numero))
    Console.WriteLine($"O número {numero} pertence à sequência.");
  else
    Console.WriteLine($"O número {numero} não pertence à sequência.");
}

bool isFibonacciSequency(int n)
{
  if (n < 0) return false;

  int a = 0, b = 1;

  while (a <= n)
  {
    if (a == n) return true;
    int temp = a;
    a = b;
    b = temp + b;
  }

  return false;
}