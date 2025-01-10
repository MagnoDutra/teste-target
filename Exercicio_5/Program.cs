string ReversedString(string str)
{
  string reversed = "";

  for (int i = str.Length - 1; i >= 0; i--)
  {
    reversed += str[i];
  }

  return reversed;
}

System.Console.WriteLine("Digite um texto: ");

string? input = Console.ReadLine();
string reversedString = ReversedString(input);

System.Console.WriteLine($"String ao contrário: {reversedString}");