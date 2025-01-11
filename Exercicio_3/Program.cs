using System.Text.Json;
using Exercicio_3.Data;

string filePath = "Data/dados.json";

string json = File.ReadAllText(filePath);
var faturamentoList = JsonSerializer.Deserialize<List<Faturamento>>(json);

void CalcularFaturamento()
{

  if (faturamentoList == null || faturamentoList.Count == 0)
  {
    Console.WriteLine("Não há dados disponíveis");
    return;
  }

  double menorValor = faturamentoList[0].valor;
  int diaMenorValor = faturamentoList[0].dia;

  double maiorValor = faturamentoList[0].valor;
  int diaMaiorValor = faturamentoList[0].dia;

  double soma = 0;

  foreach (var dia in faturamentoList)
  {
    if (dia.valor < menorValor)
    {
      menorValor = dia.valor;
      diaMenorValor = dia.dia;
    }

    if (dia.valor > maiorValor)
    {
      maiorValor = dia.valor;
      diaMaiorValor = dia.dia;
    }

    soma += dia.valor;
  }

  double media = soma / faturamentoList.Count;

  int diasAcimaMedia = 0;

  foreach (var dia in faturamentoList)
  {
    if (dia.valor > media)
      diasAcimaMedia++;
  }

  Console.WriteLine($"O menor valor de faturamento do mês foi no dia {diaMenorValor} com o valor de R${menorValor:F2}");
  Console.WriteLine($"O maior valor de faturamento do mês foi no dia {diaMaiorValor} com o valor de R${maiorValor:F2}");
  System.Console.WriteLine($"Teve {diasAcimaMedia} dias acima da média.");

}

CalcularFaturamento();