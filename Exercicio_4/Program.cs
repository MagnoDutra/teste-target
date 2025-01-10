// Faturamento por estado usando dicionário
var faturamento = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

// Cálculo do faturamento total
double totalFaturamento = 0;
foreach (var valor in faturamento.Values)
{
  totalFaturamento += valor;
}

// Exibição dos resultados
Console.WriteLine($"Faturamento Total: R${totalFaturamento:F2}");

foreach (var estado in faturamento)
{
  double percentual = (estado.Value / totalFaturamento) * 100;
  Console.WriteLine($"Percentual de {estado.Key}: {percentual:F2}%");
}