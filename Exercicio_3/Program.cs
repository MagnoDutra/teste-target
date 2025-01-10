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
  double maiorValor = faturamentoList[0].valor;
  double soma = 0;

  foreach (var dia in faturamentoList)
  {
    if (dia.valor < menorValor)
      menorValor = dia.valor;

    if (dia.valor > maiorValor)
      maiorValor = dia.valor;

    soma += dia.valor;
  }

  double media = soma / faturamentoList.Count;

  int diasAcimaMedia = 0;

  foreach (var dia in faturamentoList)
  {
    if (dia.valor > media)
      diasAcimaMedia++;
  }

  Console.WriteLine($"O menor valor de faturamento do mês é: {menorValor}");
  Console.WriteLine($"O maior valor de faturamento do mês é: {maiorValor}");
  System.Console.WriteLine($"Teve {diasAcimaMedia} dias acima da média.");

}